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
    public partial class AddProductoForm : Form
    {
        public AddProductoForm()
        {
            InitializeComponent();
        }

        private void AddProductoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo.Producto producto = new Modelo.Producto();
            producto.Descripcion = productoDesc.Text;
            Controlador.ProductoController.obtener_instancia().AddProducto(producto);
            Hide();
            ProductoForm productoForm = new ProductoForm();
            productoForm.Show();

        }
    }
}
