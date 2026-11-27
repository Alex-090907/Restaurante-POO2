using Restaurante.Negocio;
using Restaurante.Presentacion.Administracion.Productos;
using Restaurante.Presentacion.Administracion.Roles;
using Restaurante.Presentacion.Administracion.Usuarios;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        private readonly RolesServicio _rolesServicio;
        private readonly UsuariosServicio _usuariosServicio;
        private readonly ProductosService _productosService;
        private readonly CategoriasServicio _categoriasServicio;

        public Form1(RolesServicio rolesServicio, UsuariosServicio usuariosServicio,
            ProductosService productosService, CategoriasServicio categoriasServicio)
        {
            InitializeComponent();
            _rolesServicio = rolesServicio;
            _usuariosServicio = usuariosServicio;
            _productosService = productosService;
            _categoriasServicio = categoriasServicio;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListaProductos(
                _productosService, _categoriasServicio));
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListaRoles(_rolesServicio));
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListaUsuarios(_usuariosServicio, _rolesServicio));
        }

        // Oculta el menú mientras se usa otro formulario
        private void AbrirFormulario(Form formulario)
        {
            using (formulario)
            {
                Hide();
                formulario.ShowDialog();
                Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}