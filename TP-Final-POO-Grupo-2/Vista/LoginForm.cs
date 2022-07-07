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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = Controlador.UsuarioController.obtener_instancia().LoginUser(emailValue.Text, contraseñaValue.Text);
            if (user != null)
            {
                Controlador.UsuarioController.obtener_instancia().Add_GlobalUser(user);
                Hide();
                MainMenuLoginForm mainMenuLoginForm = new MainMenuLoginForm();
                mainMenuLoginForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }
    }
}
