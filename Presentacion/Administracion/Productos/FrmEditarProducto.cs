using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Productos
{
    public partial class FrmEditarProducto : Form
    {
        private readonly ProductosService _productosService;
        private readonly CategoriasServicio _categoriasServicio;
        private readonly int _id;

        public FrmEditarProducto(ProductosService productosService,
            CategoriasServicio categoriasServicio, int id)
        {
            InitializeComponent();
            _productosService = productosService;
            _categoriasServicio = categoriasServicio;
            _id = id;
        }

        // Carga los datos actuales del producto
        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                var producto = _productosService.Uno(_id);
                if (producto == null)
                {
                    MostrarError("El producto ya no existe.");
                    Close();
                    return;
                }

                cmbCategoria.ValueMember = "id";
                cmbCategoria.DisplayMember = "detalle";
                cmbCategoria.DataSource = _categoriasServicio.Todos();

                txtNombre.Text = producto.Nombre;
                nudPVP.Value = producto.PVP;
                nudPC.Value = producto.Costo_Fabricacion;
                cmbCategoria.SelectedValue = producto.CategoriasId;
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
                Id = _id,
                Nombre = nombre,
                PVP = nudPVP.Value,
                Costo_Fabricacion = nudPC.Value,
                CategoriasId = (int)cmbCategoria.SelectedValue
            };

            if (_productosService.Editar(producto))
            {
                MessageBox.Show("Producto actualizado con éxito.", "Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MostrarError("No se pudo actualizar el producto.");
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