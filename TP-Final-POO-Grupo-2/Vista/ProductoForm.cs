using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = Controlador.ProductoController.obtener_instancia().GetProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductoForm addProductoForm = new AddProductoForm();
            Hide();
            addProductoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Modelo.Producto)productoBindingSource.Current;
            Controlador.ProductoController.obtener_instancia().DeleteProducto(selectedProduct);
            MessageBox.Show("Producto eliminado con exito");
            productoBindingSource.DataSource = Controlador.ProductoController.obtener_instancia().GetProductos();
        }
    }
}
