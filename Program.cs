using Restaurante.Datos;
using Restaurante.Negocio;

namespace Restaurante
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Único lugar donde se crean las dependencias
            Func<RestauranteDbContext> crearContexto = () => new RestauranteDbContext();
            var rolesServicio = new RolesServicio(crearContexto);
            var usuariosServicio = new UsuariosServicio(crearContexto);
            var productosService = new ProductosService(crearContexto);
            var categoriasServicio = new CategoriasServicio(crearContexto);

            Application.Run(new Form1(rolesServicio, usuariosServicio,
                productosService, categoriasServicio));
        }
    }
}