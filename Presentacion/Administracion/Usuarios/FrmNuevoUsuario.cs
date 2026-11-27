using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Usuarios
{
    public partial class FrmNuevoUsuario : Form
    {
        private readonly UsuariosServicio _usuariosServicio;
        private readonly RolesServicio _rolesServicio;

        public FrmNuevoUsuario(UsuariosServicio usuariosServicio,
            RolesServicio rolesServicio)
        {
            InitializeComponent();
            _usuariosServicio = usuariosServicio;
            _rolesServicio = rolesServicio;
        }

        // Carga solo los roles activos
        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                cmbRol.ValueMember = "Id";
                cmbRol.DisplayMember = "Nombre";
                cmbRol.DataSource = _rolesServicio.Todos()
                    .Where(r => r.Activo)
                    .ToList();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudieron cargar los roles: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string nombreCompleto = txtNombre.Text.Trim();

            // Validación de campos
            if (nombreUsuario.Length < 4 || nombreUsuario.Contains(' '))
            {
                Advertir("El usuario debe tener mínimo 4 caracteres y sin espacios.", txtUsuario);
                return;
            }
            if (nombreCompleto.Length < 3)
            {
                Advertir("Ingrese el nombre completo.", txtNombre);
                return;
            }
            if (txtPassword.Text.Length < 6)
            {
                Advertir("La contraseña debe tener mínimo 6 caracteres.", txtPassword);
                return;
            }
            if (txtPassword.Text != txtConfirmar.Text)
            {
                Advertir("Las contraseñas no coinciden.", txtConfirmar);
                return;
            }
            if (cmbRol.SelectedValue == null)
            {
                Advertir("Seleccione un rol.", cmbRol);
                return;
            }

            try
            {
                if (_usuariosServicio.ExisteNombreUsuario(nombreUsuario))
                {
                    Advertir("Ese nombre de usuario ya existe.", txtUsuario);
                    return;
                }

                var usuario = new Usuario
                {
                    NombreUsuario = nombreUsuario,
                    NombreCompleto = nombreCompleto,
                    RolId = (int)cmbRol.SelectedValue,
                    Activo = chkActivo.Checked
                };

                if (_usuariosServicio.Insertar(usuario, txtPassword.Text))
                {
                    MessageBox.Show("Usuario guardado con éxito.", "Usuarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MostrarError("No se pudo guardar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al guardar: " + ex.Message);
            }
        }

        private void Advertir(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
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