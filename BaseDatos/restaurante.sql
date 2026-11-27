IF DB_ID('restaurante') IS NULL CREATE DATABASE restaurante;
GO
USE restaurante;
GO
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126173143_inicial'
)
BEGIN
    CREATE TABLE [Categorias] (
        [id] int NOT NULL IDENTITY,
        [detalle] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Categorias] PRIMARY KEY ([id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126173143_inicial'
)
BEGIN
    CREATE TABLE [Productos] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] nvarchar(150) NOT NULL,
        [PVP] decimal(18,2) NOT NULL,
        [Costo_Fabricacion] decimal(18,2) NOT NULL,
        [CategoriasId] int NOT NULL,
        CONSTRAINT [PK_Productos] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Productos_Categorias_CategoriasId] FOREIGN KEY ([CategoriasId]) REFERENCES [Categorias] ([id]) ON DELETE CASCADE
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126173143_inicial'
)
BEGIN
    CREATE INDEX [IX_Productos_CategoriasId] ON [Productos] ([CategoriasId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126173143_inicial'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20261126173143_inicial', N'10.0.15');
END;

COMMIT;
GO

BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126232533_RolesUsuarios'
)
BEGIN
    CREATE TABLE [Roles] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] nvarchar(50) NOT NULL,
        [Descripcion] nvarchar(200) NULL,
        [Activo] bit NOT NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126232533_RolesUsuarios'
)
BEGIN
    CREATE TABLE [Usuarios] (
        [Id] int NOT NULL IDENTITY,
        [NombreUsuario] nvarchar(50) NOT NULL,
        [NombreCompleto] nvarchar(150) NOT NULL,
        [PasswordHash] nvarchar(200) NOT NULL,
        [Activo] bit NOT NULL,
        [RolId] int NOT NULL,
        CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Usuarios_Roles_RolId] FOREIGN KEY ([RolId]) REFERENCES [Roles] ([Id]) ON DELETE NO ACTION
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126232533_RolesUsuarios'
)
BEGIN
    CREATE UNIQUE INDEX [IX_Roles_Nombre] ON [Roles] ([Nombre]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126232533_RolesUsuarios'
)
BEGIN
    CREATE UNIQUE INDEX [IX_Usuarios_NombreUsuario] ON [Usuarios] ([NombreUsuario]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126232533_RolesUsuarios'
)
BEGIN
    CREATE INDEX [IX_Usuarios_RolId] ON [Usuarios] ([RolId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20261126232533_RolesUsuarios'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20261126232533_RolesUsuarios', N'10.0.15');
END;

COMMIT;
GO

-- ===== DATOS DE EJEMPLO =====

-- Categorías
INSERT INTO Categorias (detalle)
SELECT v.detalle
FROM (VALUES ('Entradas'), ('Platos fuertes'), ('Bebidas'), ('Postres'),
             ('Sopas'), ('Desayunos')) AS v(detalle)
WHERE NOT EXISTS (SELECT 1 FROM Categorias c WHERE c.detalle = v.detalle);

-- Roles
INSERT INTO Roles (Nombre, Descripcion, Activo)
SELECT v.Nombre, v.Descripcion, v.Activo
FROM (VALUES
    ('Administrador', 'Acceso total', 1),
    ('Mesero', 'Toma pedidos', 1),
    ('Cajero', 'Cobra y emite comprobantes', 1),
    ('Chef', 'Prepara los platos', 1),
    ('Bodeguero', 'Controla el inventario', 1),
    ('Repartidor', 'Entrega pedidos a domicilio', 0)
) AS v(Nombre, Descripcion, Activo)
WHERE NOT EXISTS (SELECT 1 FROM Roles r WHERE r.Nombre = v.Nombre);

-- Usuarios (contraseña de ejemplo: demo123)
INSERT INTO Usuarios (NombreUsuario, NombreCompleto, PasswordHash, Activo, RolId)
SELECT v.Usuario, v.Nombre, v.Hash, v.Activo, r.Id
FROM (VALUES
    ('carlos.admin', 'Carlos Mendoza', 'gM5Xiu3Y1HZDfRucLKOi+g==.NjVZ8Q0/U4Kd/zcir8tLmHCpRZ7wwlYlSuciNQ1D3qI=', 1, 'Administrador'),
    ('maria.mesera', 'María Zambrano', '0LRvHXOlwY0scY75ZCVGsg==.xCaZQHYtfISZWIS5nsJlfMb9X9SegFMg6TORDeuQUW0=', 1, 'Mesero'),
    ('jose.mesero', 'José Cedeño', 'M18qomdOSUbjJdQ1Zyn7QA==.wcBJn+EWKQtw+35Sko5Dlc4FjUdvvF4BnQGYytc8qCQ=', 1, 'Mesero'),
    ('lucia.caja', 'Lucía Vera', '/LIYYyeOguqJuAVvbaazdA==.yFvE18hFzBooqgA8vzxY6Vyxup1uBgxWk5uZjkcDsyA=', 1, 'Cajero'),
    ('pedro.chef', 'Pedro Loor', 'YJDOGs9pKPwUsrY7YVKQSw==.b6ZwuH6KUh5wncXG9HoEf9AHQGtDURv6wB5Szz536Vg=', 1, 'Chef'),
    ('ana.mesera', 'Ana Intriago', 'qRoo4Pqag93356KmiiufeQ==.OgkqXby63EZbV+u2eO6gu9Ybd3QRkho5hv2J5aU4yRg=', 0, 'Mesero')
) AS v(Usuario, Nombre, Hash, Activo, Rol)
INNER JOIN Roles r ON r.Nombre = v.Rol
WHERE NOT EXISTS (SELECT 1 FROM Usuarios u WHERE u.NombreUsuario = v.Usuario);

-- Productos
INSERT INTO Productos (Nombre, PVP, Costo_Fabricacion, CategoriasId)
SELECT v.Nombre, v.PVP, v.Costo,
       (SELECT MIN(c.id) FROM Categorias c WHERE c.detalle = v.Categoria)
FROM (VALUES
    ('Empanadas de verde', 2.50, 1.10, 'Entradas'),
    ('Patacones con queso', 3.00, 1.30, 'Entradas'),
    ('Seco de pollo', 4.50, 2.20, 'Platos fuertes'),
    ('Bandera', 6.00, 3.10, 'Platos fuertes'),
    ('Arroz marinero', 7.50, 4.00, 'Platos fuertes'),
    ('Encebollado', 3.50, 1.75, 'Sopas'),
    ('Caldo de gallina', 3.75, 1.80, 'Sopas'),
    ('Jugo natural', 1.50, 0.60, 'Bebidas'),
    ('Cola personal', 1.00, 0.55, 'Bebidas'),
    ('Tres leches', 2.25, 1.00, 'Postres'),
    ('Flan de coco', 1.75, 0.80, 'Postres'),
    ('Tigrillo', 4.00, 1.90, 'Desayunos')
) AS v(Nombre, PVP, Costo, Categoria)
WHERE NOT EXISTS (SELECT 1 FROM Productos p WHERE p.Nombre = v.Nombre);
GO