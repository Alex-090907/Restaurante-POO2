using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Usuarios
{
    public partial class FrmListaUsuarios : Form
    {
        private readonly UsuariosServicio _usuariosServicio;
        private readonly RolesServicio _rolesServicio;

        public FrmListaUsuarios(UsuariosServicio usuariosServicio,
            RolesServicio rolesServicio)
        {
            InitializeComponent();
            _usuariosServicio = usuariosServicio;
            _rolesServicio = rolesServicio;
            dgvUsuarios.AutoGenerateColumns = false;
        }

        private void FrmListaUsuarios_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        // Obtiene los usuarios y los enlaza a la tabla
        private void CargarLista()
        {
            try
            {
                dgvUsuarios.DataSource = _usuariosServicio.Todos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los usuarios: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using var frmNuevo = new FrmNuevoUsuario(_usuariosServicio, _rolesServicio);
            if (frmNuevo.ShowDialog() == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtiene el usuario de la fila seleccionada
            if (dgvUsuarios.CurrentRow?.DataBoundItem is not UsuarioVista usuario)
            {
                MessageBox.Show("Seleccione un usuario.", "Usuarios");
                return;
            }

            using var frmEditar = new FrmEditarUsuario(
                _usuariosServicio, _rolesServicio, usuario.Id);
            if (frmEditar.ShowDialog() == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}