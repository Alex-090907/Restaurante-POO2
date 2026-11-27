using Microsoft.EntityFrameworkCore;
using Restaurante.Datos;
using Restaurante.Datos.Entidades;

namespace Restaurante.Negocio
{
    // Acceso a datos de Categorías
    public class CategoriasServicio
    {
        private readonly Func<RestauranteDbContext> _crearContexto;

        public CategoriasServicio(Func<RestauranteDbContext> crearContexto)
        {
            _crearContexto = crearContexto;
        }

        public List<Categorias> Todos()
        {
            using var db = _crearContexto();
            return db.Categorias.AsNoTracking().OrderBy(c => c.detalle).ToList();
        }
    }
}