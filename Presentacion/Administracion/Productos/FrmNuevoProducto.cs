using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Productos
{
    public partial class FrmNuevoProducto : Form
    {
        private readonly ProductosService _productosService = new ProductosService();
        private readonly CategoriasServicio _categoriaService = new CategoriasServicio();

        public FrmNuevoProducto()
        {
            InitializeComponent();
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "detalle";
            cmbCategoria.DataSource = _categoriaService.todos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Ingrese el nombre y seleccione una categoría");
                return;
            }

            var producto = new Producto
            {
                Nombre = textBox1.Text.Trim(),
                PVP = nudPVP.Value,
                Costo_Fabricacion = nudPC.Value,
                CategoriasId = (int)cmbCategoria.SelectedValue
            };

            if (_productosService.insertar(producto))
            {
                MessageBox.Show("Se guardó con éxito");
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