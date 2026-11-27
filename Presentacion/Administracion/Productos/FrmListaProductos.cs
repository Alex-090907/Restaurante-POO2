using Restaurante.Datos.Entidades;
using Restaurante.Negocio;
using System.ComponentModel;

namespace Restaurante.Presentacion.Administracion.Productos
{
    public partial class FrmListaProductos : Form
    {
        private readonly ProductosService _productos = new ProductosService();

        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            cargalista();
        }

        private void FrmListaProductos_Activated(object sender, EventArgs e)
        {
            cargalista();
        }

        // Llena la lista con los productos de la base
        public void cargalista()
        {
            lstListaproductos.DataSource = null;
            lstListaproductos.DataSource = new BindingList<Producto>(_productos.todos());
            lstListaproductos.ValueMember = "Id";
            lstListaproductos.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmNuevo = new FrmNuevoProducto();
            frmNuevo.ShowDialog();
            cargalista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstListaproductos.SelectedIndex == -1) return;

            var frmEditar = new FrmEditarProducto((int)lstListaproductos.SelectedValue);
            frmEditar.ShowDialog();
            cargalista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstListaproductos.SelectedIndex == -1) return;

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto?",
                "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            if (_productos.eliminar((int)lstListaproductos.SelectedValue))
            {
                MessageBox.Show("Se eliminó con éxito", "Productos");
                cargalista();
            }
            else
            {
                MessageBox.Show("No se eliminó el producto", "Productos");
            }
        }
    }
}