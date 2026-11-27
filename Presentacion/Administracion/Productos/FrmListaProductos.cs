using Restaurante.Datos.Entidades;
using Restaurante.Negocio;

namespace Restaurante.Presentacion.Administracion.Productos
{
    public partial class FrmListaProductos : Form
    {
        private readonly ProductosService _productosService;
        private readonly CategoriasServicio _categoriasServicio;

        public FrmListaProductos(ProductosService productosService,
            CategoriasServicio categoriasServicio)
        {
            InitializeComponent();
            _productosService = productosService;
            _categoriasServicio = categoriasServicio;
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        // Llena la lista con los productos de la base
        private void CargarLista()
        {
            try
            {
                lstProductos.DataSource = null;
                lstProductos.DisplayMember = "Nombre";
                lstProductos.DataSource = _productosService.Todos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los productos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using var frmNuevo = new FrmNuevoProducto(
                _productosService, _categoriasServicio);
            if (frmNuevo.ShowDialog() == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItem is not Producto producto)
            {
                MessageBox.Show("Seleccione un producto.", "Productos");
                return;
            }

            using var frmEditar = new FrmEditarProducto(
                _productosService, _categoriasServicio, producto.Id);
            if (frmEditar.ShowDialog() == DialogResult.OK)
            {
                CargarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItem is not Producto producto)
            {
                MessageBox.Show("Seleccione un producto.", "Productos");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar " + producto.Nombre + "?", "Eliminar Producto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            if (_productosService.Eliminar(producto.Id))
            {
                MessageBox.Show("Producto eliminado con éxito.", "Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el producto.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}