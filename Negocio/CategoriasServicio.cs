using Restaurante.Datos;
using Restaurante.Datos.Entidades;

namespace Restaurante.Negocio
{
    public class CategoriasServicio
    {
        private readonly RestauranteDbContext _dbContext = new RestauranteDbContext();

        // Devuelve todas las categorías
        public List<Categorias> todos()
        {
            return _dbContext.Categorias.ToList();
        }

        public bool insertar(Categorias categorias)
        {
            try
            {
                _dbContext.Categorias.Add(categorias);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}