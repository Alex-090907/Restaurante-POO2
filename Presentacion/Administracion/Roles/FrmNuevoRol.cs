using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Roles
{
    public partial class FrmNuevoRol : Form
    {
        private readonly RolesServicio _rolesServicio;

        public FrmNuevoRol(RolesServicio rolesServicio)
        {
            InitializeComponent();
            _rolesServicio = rolesServicio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            // Validación del nombre
            if (nombre.Length < 3)
            {
                MostrarAdvertencia("El nombre debe tener al menos 3 caracteres.");
                return;
            }

            try
            {
                if (_rolesServicio.ExisteNombre(nombre))
                {
                    MostrarAdvertencia("Ya existe un rol con ese nombre.");
                    return;
                }

                var rol = new Rol
                {
                    Nombre = nombre,
                    Descripcion = txtDescripcion.Text.Trim(),
                    Activo = chkActivo.Checked
                };

                if (_rolesServicio.Insertar(rol))
                {
                    MessageBox.Show("Rol guardado con éxito.", "Roles",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MostrarError("No se pudo guardar el rol.");
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al guardar: " + ex.Message);
            }
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNombre.Focus();
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}