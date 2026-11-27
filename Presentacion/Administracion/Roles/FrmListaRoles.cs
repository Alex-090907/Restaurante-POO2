using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Roles
{
    public partial class FrmListaRoles : Form
    {
        private readonly RolesServicio _rolesServicio;

        // El servicio se recibe por el constructor (inyección de dependencias)
        public FrmListaRoles(RolesServicio rolesServicio)
        {
            InitializeComponent();
            _rolesServicio = rolesServicio;
            dgvRoles.AutoGenerateColumns = false;
        }

        private void FrmListaRoles_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        // Obtiene los roles y los enlaza a la tabla
        private void CargarLista()
        {
            try
            {
                dgvRoles.DataSource = _rolesServicio.Todos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los roles: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using var frmNuevo = new FrmNuevoRol(_rolesServicio);
            if (frmNuevo.ShowDialog() == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtiene el rol de la fila seleccionada
            if (dgvRoles.CurrentRow?.DataBoundItem is not Rol rol)
            {
                MessageBox.Show("Seleccione un rol.", "Roles");
                return;
            }

            using var frmEditar = new FrmEditarRol(_rolesServicio, rol.Id);
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