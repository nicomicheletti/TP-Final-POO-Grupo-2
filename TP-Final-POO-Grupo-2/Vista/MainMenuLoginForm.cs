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

                for (int j = 0; j < options.ToList().Count; j++)
                {
                    if (options.ToList()[j].Name == listaUserFormularios[i].NombreSistema)
                    {
                        options.ToList()[j].Enabled = true;
                    }
                }
            }

            var onlyAdminOption = menuStrip1.Items.Find("formGestionarUsuarios", true);
            if (onlyAdminOption[0].Enabled == false)
            {
                // ES UN CLIENTE POR LO QUE SOLO PUEDE AGREGAR UN CLIENTE, dejo la variable en memoria
                Controlador.UsuarioController.obtener_instancia().setIfIsCliente(true);
            }
        }

        private void formUsuario_Click(object sender, EventArgs e)
        {
            AddUserForm usuarioFrm = new AddUserForm();
            usuarioFrm.Show();
        }

        private void formGestionarUsuarios_Click(object sender, EventArgs e)
        {
            ManageUserForm manageUserForm = new ManageUserForm();
            manageUserForm.Show();
        }
    }
}
