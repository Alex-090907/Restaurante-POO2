using Microsoft.EntityFrameworkCore;
using Restaurante.Datos;
using Restaurante.Datos.Entidades;
using System.Security.Cryptography;

namespace Restaurante.Negocio
{
    // Datos que se muestran en la tabla (sin la contraseña)
    public record UsuarioVista(int Id, string NombreUsuario,
        string NombreCompleto, string Rol, bool Activo);

    public class UsuariosServicio
    {
        private readonly Func<RestauranteDbContext> _crearContexto;

        // Recibe la forma de crear el contexto (inyección de dependencias)
        public UsuariosServicio(Func<RestauranteDbContext> crearContexto)
        {
            _crearContexto = crearContexto;
        }

        public List<UsuarioVista> Todos()
        {
            using var db = _crearContexto();
            return db.Usuarios.AsNoTracking()
                .OrderBy(u => u.NombreUsuario)
                .Select(u => new UsuarioVista(u.Id, u.NombreUsuario,
                    u.NombreCompleto, u.Rol!.Nombre, u.Activo))
                .ToList();
        }

        public Usuario? Uno(int id)
        {
            using var db = _crearContexto();
            return db.Usuarios.AsNoTracking().FirstOrDefault(u => u.Id == id);
        }

        public bool ExisteNombreUsuario(string nombreUsuario, int idActual = 0)
        {
            using var db = _crearContexto();
            return db.Usuarios.Any(u => u.NombreUsuario == nombreUsuario
                && u.Id != idActual);
        }

        public bool Insertar(Usuario usuario, string password)
        {
            try
            {
                using var db = _crearContexto();
                usuario.PasswordHash = GenerarHash(password);
                db.Usuarios.Add(usuario);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Si la nueva contraseña está vacía se conserva la anterior
        public bool Editar(Usuario usuario, string nuevaPassword)
        {
            try
            {
                using var db = _crearContexto();
                var existente = db.Usuarios.Find(usuario.Id);
                if (existente == null) return false;

                existente.NombreUsuario = usuario.NombreUsuario;
                existente.NombreCompleto = usuario.NombreCompleto;
                existente.RolId = usuario.RolId;
                existente.Activo = usuario.Activo;

                if (!string.IsNullOrWhiteSpace(nuevaPassword))
                {
                    existente.PasswordHash = GenerarHash(nuevaPassword);
                }

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cifra la contraseña con una sal aleatoria (PBKDF2)
        private static string GenerarHash(string password)
        {
            byte[] sal = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, sal, 600_000,
                HashAlgorithmName.SHA256, 32);

            return Convert.ToBase64String(sal) + "." + Convert.ToBase64String(hash);
        }
    }
}