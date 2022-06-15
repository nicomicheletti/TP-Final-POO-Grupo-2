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
    public partial class UsuarioFrm : Form
    {
        public bool WantsToModify;
        public UsuarioFrm()
        {

            InitializeComponent();
        }
        public UsuarioFrm(bool wantsToModify)
        {
            WantsToModify = wantsToModify;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (WantsToModify == true)
            {
                MessageBox.Show("Quiere modificar");
            }
            else
            {
                var perfil = (Modelo.Perfil)perfilCombobox.SelectedItem;
                Modelo.Usuario usuario = new Modelo.Usuario(nombreValue.Text, emailValue.Text, dniValue.Text, contraseñaValue.Text, perfil);

                var validator = Controlador.UsuarioController.obtener_instancia().AddUsuario(usuario);

                if (validator == true)
                {
                    clearForm();
                    MessageBox.Show("Usuario guardado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar usuario");
                }
                Hide();
                GestionarUsuarioFrm gestionarUsuarioFrm = new GestionarUsuarioFrm();
                gestionarUsuarioFrm.Show();
            }
        }

        private void UsuarioFrm_Load(object sender, EventArgs e)
        {
            perfilBindingSource.DataSource = Controlador.PerfilController.obtener_instancia().GetAllPerfiles();

        }

        private void clearForm()
        {
            nombreValue.Text = "";
            emailValue.Text = "";
            dniValue.Text = "";
            contraseñaValue.Text = "";

        }
    }
}
