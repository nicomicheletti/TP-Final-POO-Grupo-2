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
    public partial class GestionarUsuarioFrm : Form
    {
        public GestionarUsuarioFrm()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioFrm usuarioFrm = new UsuarioFrm();
            usuarioFrm.Show();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuarioFrm modificarFrm  = new ModificarUsuarioFrm();
            modificarFrm.Show();
        }
    }
}
