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
    public partial class EditUserForm : Form
    {
        Modelo.Usuario usuario = new Modelo.Usuario();
        public EditUserForm()
        {
            InitializeComponent();
        }
        public EditUserForm(Modelo.Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }
    }
}
