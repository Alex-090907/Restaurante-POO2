using Microsoft.EntityFrameworkCore;
using Restaurante.Datos;
using Restaurante.Datos.Entidades;

namespace Restaurante.Negocio
{
    // Acceso a datos de Roles. LINQ usa parámetros y evita inyección SQL
    public class RolesServicio
    {
        public List<Rol> Todos()
        {
            using var db = new RestauranteDbContext();
            return db.Roles.AsNoTracking().OrderBy(r => r.Nombre).ToList();
        }

        public Rol? Uno(int id)
        {
            using var db = new RestauranteDbContext();
            return db.Roles.AsNoTracking().FirstOrDefault(r => r.Id == id);
        }

        // Verifica que otro rol no tenga el mismo nombre
        public bool ExisteNombre(string nombre, int idActual = 0)
        {
            using var db = new RestauranteDbContext();
            return db.Roles.Any(r => r.Nombre == nombre && r.Id != idActual);
        }

        public bool Insertar(Rol rol)
        {
            try
            {
                using var db = new RestauranteDbContext();
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
                using var db = new RestauranteDbContext();
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