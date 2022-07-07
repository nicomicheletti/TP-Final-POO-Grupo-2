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
    public partial class AddUserForm : Form
    {
        public bool WantsToModify;
        public AddUserForm()
        {

            InitializeComponent();
        }
        //public UsuarioFrm(bool wantsToModify)
        //{
        //    WantsToModify = wantsToModify;
        //    InitializeComponent();
        //}

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

                Modelo.Usuario usuario = new Modelo.Usuario(nombreValue.Text, emailValue.Text, dniValue.Text, Base64Encode(contraseñaValue.Text), perfil);

                var validator = Controlador.UsuarioController.obtener_instancia().AddUsuario(usuario);

                switch (validator)
                {
                    case 1:
                        {
                            MessageBox.Show("El usuario ya se encuentra registrado");
                            break;
                        }
                    case 2:
                        {
                            clearForm();
                            MessageBox.Show("Usuario guardado exitosamente");
                            Hide();
                            break;
                        }
                    default:
                        break;
                };


            }
        }

        private void UsuarioFrm_Load(object sender, EventArgs e)
        {
            perfilBindingSource.DataSource = Controlador.PerfilController.obtener_instancia().GetAllPerfiles();
            if (Controlador.UsuarioController.obtener_instancia().isCliente == true)
            {
                perfilCombobox.Enabled = false;

            }

        }

        private void clearForm()
        {
            nombreValue.Text = "";
            emailValue.Text = "";
            dniValue.Text = "";
            contraseñaValue.Text = "";

        }
        public string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
