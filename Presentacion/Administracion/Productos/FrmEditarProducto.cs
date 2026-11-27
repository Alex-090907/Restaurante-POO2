using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Productos
{
    public partial class FrmEditarProducto : Form
    {
        private readonly int _id;
        private readonly ProductosService _productosService = new ProductosService();
        private readonly CategoriasServicio _categoriaService = new CategoriasServicio();

        public FrmEditarProducto(int id)
        {
            InitializeComponent();
            _id = id;
        }

        // Carga los datos actuales del producto
        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "detalle";
            cmbCategoria.DataSource = _categoriaService.todos();

            var producto = _productosService.uno(_id);
            txtNombre.Text = producto.Nombre;
            nudPVP.Value = producto.PVP;
            nudPC.Value = producto.Costo_Fabricacion;
            cmbCategoria.SelectedValue = producto.CategoriasId;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Ingrese el nombre y seleccione una categoría");
                return;
            }

            var producto = new Producto
            {
                Id = _id,
                Nombre = txtNombre.Text.Trim(),
                PVP = nudPVP.Value,
                Costo_Fabricacion = nudPC.Value,
                CategoriasId = (int)cmbCategoria.SelectedValue
            };

            if (await _productosService.editar(producto))
            {
                MessageBox.Show("Se guardó con éxito");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}