using Microsoft.EntityFrameworkCore;
using Restaurante.Datos;
using Restaurante.Datos.Entidades;

namespace Restaurante.Negocio
{
    // Acceso a datos de Productos
    public class ProductosService
    {
        private readonly Func<RestauranteDbContext> _crearContexto;

        public ProductosService(Func<RestauranteDbContext> crearContexto)
        {
            _crearContexto = crearContexto;
        }

        public List<Producto> Todos()
        {
            using var db = _crearContexto();
            return db.Productos.AsNoTracking().OrderBy(p => p.Nombre).ToList();
        }

        public Producto? Uno(int id)
        {
            using var db = _crearContexto();
            return db.Productos.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        public bool Insertar(Producto producto)
        {
            try
            {
                using var db = _crearContexto();
                db.Productos.Add(producto);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Editar(Producto producto)
        {
            try
            {
                using var db = _crearContexto();
                var existente = db.Productos.Find(producto.Id);
                if (existente == null) return false;

                db.Entry(existente).CurrentValues.SetValues(producto);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using var db = _crearContexto();
                var existente = db.Productos.Find(id);
                if (existente == null) return false;

                db.Productos.Remove(existente);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}