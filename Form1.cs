using Restaurante.Negocio;
using Restaurante.Presentacion.Administracion.Productos;
using Restaurante.Presentacion.Administracion.Roles;
using Restaurante.Presentacion.Administracion.Usuarios;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var frmProductos = new FrmListaProductos();
            Hide();
            frmProductos.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var frmRoles = new FrmListaRoles(new RolesServicio());
            Hide();
            frmRoles.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using var frmUsuarios = new FrmListaUsuarios(
                new UsuariosServicio(), new RolesServicio());
            Hide();
            frmUsuarios.ShowDialog();
            Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}