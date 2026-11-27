using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Usuarios
{
    public partial class FrmEditarUsuario : Form
    {
        private readonly UsuariosServicio _usuariosServicio;
        private readonly RolesServicio _rolesServicio;
        private readonly int _id;

        public FrmEditarUsuario(UsuariosServicio usuariosServicio,
            RolesServicio rolesServicio, int id)
        {
            InitializeComponent();
            _usuariosServicio = usuariosServicio;
            _rolesServicio = rolesServicio;
            _id = id;
        }

        // Carga los datos actuales del usuario
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                var usuario = _usuariosServicio.Uno(_id);
                if (usuario == null)
                {
                    MostrarError("El usuario ya no existe.");
                    Close();
                    return;
                }

                // Roles activos y el rol que ya tiene el usuario
                cmbRol.ValueMember = "Id";
                cmbRol.DisplayMember = "Nombre";
                cmbRol.DataSource = _rolesServicio.Todos()
                    .Where(r => r.Activo || r.Id == usuario.RolId)
                    .ToList();

                txtUsuario.Text = usuario.NombreUsuario;
                txtNombre.Text = usuario.NombreCompleto;
                cmbRol.SelectedValue = usuario.RolId;
                chkActivo.Checked = usuario.Activo;
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar: " + ex.Message);
                Close();
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
            if (txtPassword.Text.Length > 0 && txtPassword.Text.Length < 6)
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
                if (_usuariosServicio.ExisteNombreUsuario(nombreUsuario, _id))
                {
                    Advertir("Ese nombre de usuario ya existe.", txtUsuario);
                    return;
                }

                var usuario = new Usuario
                {
                    Id = _id,
                    NombreUsuario = nombreUsuario,
                    NombreCompleto = nombreCompleto,
                    RolId = (int)cmbRol.SelectedValue,
                    Activo = chkActivo.Checked
                };

                if (_usuariosServicio.Editar(usuario, txtPassword.Text))
                {
                    MessageBox.Show("Usuario actualizado con éxito.", "Usuarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MostrarError("No se pudo actualizar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al actualizar: " + ex.Message);
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