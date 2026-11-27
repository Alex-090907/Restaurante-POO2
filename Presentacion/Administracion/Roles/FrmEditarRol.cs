using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Roles
{
    public partial class FrmEditarRol : Form
    {
        private readonly RolesServicio _rolesServicio;
        private readonly int _id;

        public FrmEditarRol(RolesServicio rolesServicio, int id)
        {
            InitializeComponent();
            _rolesServicio = rolesServicio;
            _id = id;
        }

        // Carga los datos actuales del rol
        private void FrmEditarRol_Load(object sender, EventArgs e)
        {
            try
            {
                var rol = _rolesServicio.Uno(_id);
                if (rol == null)
                {
                    MostrarError("El rol ya no existe.");
                    Close();
                    return;
                }

                txtNombre.Text = rol.Nombre;
                txtDescripcion.Text = rol.Descripcion;
                chkActivo.Checked = rol.Activo;
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar: " + ex.Message);
                Close();
            }
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
                if (_rolesServicio.ExisteNombre(nombre, _id))
                {
                    MostrarAdvertencia("Ya existe otro rol con ese nombre.");
                    return;
                }

                var rol = new Rol
                {
                    Id = _id,
                    Nombre = nombre,
                    Descripcion = txtDescripcion.Text.Trim(),
                    Activo = chkActivo.Checked
                };

                if (_rolesServicio.Editar(rol))
                {
                    MessageBox.Show("Rol actualizado con éxito.", "Roles",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MostrarError("No se pudo actualizar el rol.");
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al actualizar: " + ex.Message);
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