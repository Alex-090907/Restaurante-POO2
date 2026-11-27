using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Productos
{
    public partial class FrmNuevoProducto : Form
    {
        private readonly ProductosService _productosService;
        private readonly CategoriasServicio _categoriasServicio;

        public FrmNuevoProducto(ProductosService productosService,
            CategoriasServicio categoriasServicio)
        {
            InitializeComponent();
            _productosService = productosService;
            _categoriasServicio = categoriasServicio;
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCategoria.ValueMember = "id";
                cmbCategoria.DisplayMember = "detalle";
                cmbCategoria.DataSource = _categoriasServicio.Todos();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudieron cargar las categorías: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            // Validación de campos
            if (nombre.Length < 3)
            {
                Advertir("El nombre debe tener al menos 3 caracteres.", txtNombre);
                return;
            }
            if (nudPVP.Value <= 0)
            {
                Advertir("El PVP debe ser mayor que cero.", nudPVP);
                return;
            }
            if (nudPC.Value <= 0 || nudPC.Value > nudPVP.Value)
            {
                Advertir("El costo debe ser mayor que cero y no superar el PVP.", nudPC);
                return;
            }
            if (cmbCategoria.SelectedValue == null)
            {
                Advertir("Seleccione una categoría.", cmbCategoria);
                return;
            }

            var producto = new Producto
            {
                Nombre = nombre,
                PVP = nudPVP.Value,
                Costo_Fabricacion = nudPC.Value,
                CategoriasId = (int)cmbCategoria.SelectedValue
            };

            if (_productosService.Insertar(producto))
            {
                MessageBox.Show("Producto guardado con éxito.", "Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MostrarError("No se pudo guardar el producto.");
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