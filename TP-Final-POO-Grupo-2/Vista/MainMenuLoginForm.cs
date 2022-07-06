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
    public partial class MainMenuLoginForm : Form
    {
        public MainMenuLoginForm()
        {
            InitializeComponent();
        }

        private void MainMenuLoginForm_Load(object sender, EventArgs e)
        {
            Modelo.Usuario usuario = Controlador.UsuarioController.obtener_instancia().globalUser;

           List<Modelo.Formulario> listaUserFormularios = Controlador.FormularioController.obtener_instancia().GetUserFormularios(usuario);

            for (int i = 0; i < listaUserFormularios.Count; i++)
            {
                var options = menuStrip1.Items.Find(listaUserFormularios[i].NombreSistema, true);

                for (int j = 0; i < options.ToList().Count; i++)
                {
                    if (options.ToList()[j].Name == listaUserFormularios[i].NombreSistema)
                    {
                        options.ToList()[j].Enabled = true;
                    }
                }
            }
        }

        private void formUsuario_Click(object sender, EventArgs e)
        {
            AddUserForm usuarioFrm = new AddUserForm();
            usuarioFrm.Show();
        }
    }
}
