using Microsoft.EntityFrameworkCore;
using Restaurante.Datos;
using Restaurante.Datos.Entidades;

namespace Restaurante.Negocio
{
    // Acceso a datos de Roles. LINQ usa parámetros y evita inyección SQL
    public class RolesServicio
    {
        private readonly Func<RestauranteDbContext> _crearContexto;

        // Recibe la forma de crear el contexto (inyección de dependencias)
        public RolesServicio(Func<RestauranteDbContext> crearContexto)
        {
            _crearContexto = crearContexto;
        }

        public List<Rol> Todos()
        {
            using var db = _crearContexto();
            return db.Roles.AsNoTracking().OrderBy(r => r.Nombre).ToList();
        }

        public Rol? Uno(int id)
        {
            using var db = _crearContexto();
            return db.Roles.AsNoTracking().FirstOrDefault(r => r.Id == id);
        }

        // Verifica que otro rol no tenga el mismo nombre
        public bool ExisteNombre(string nombre, int idActual = 0)
        {
            using var db = _crearContexto();
            return db.Roles.Any(r => r.Nombre == nombre && r.Id != idActual);
        }

        public bool Insertar(Rol rol)
        {
            try
            {
                using var db = _crearContexto();
                db.Roles.Add(rol);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Editar(Rol rol)
        {
            try
            {
                using var db = _crearContexto();
                var existente = db.Roles.Find(rol.Id);
                if (existente == null) return false;

                db.Entry(existente).CurrentValues.SetValues(rol);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}