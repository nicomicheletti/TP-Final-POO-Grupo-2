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

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            perfilBindingSource.DataSource = Controlador.PerfilController.obtener_instancia().GetAllPerfiles();
            nombreValue.Text = usuario.Nombre;
            emailValue.Text = usuario.Email;
            dniValue.Text = usuario.Dni;
            //contraseñaValue.Text = usuario.Contraseña;

            perfilCombobox.SelectedItem = usuario.Perfil;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var perfil = (Modelo.Perfil)perfilCombobox.SelectedItem;

            if (contraseñaValue.Text != null && contraseñaValue.Text != "")
            {
                Modelo.Usuario editedUser = new Modelo.Usuario(nombreValue.Text, emailValue.Text, dniValue.Text, Base64Encode(contraseñaValue.Text), perfil);
                // Seteo Id para que lo pueda encontrar despues en el controller
                editedUser.Id = usuario.Id;
                var validator = Controlador.UsuarioController.obtener_instancia().EditUser(editedUser);

                if (validator)
                {
                    MessageBox.Show("Usuario guardado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar usuario");
                }
                Hide();
            }
            else
            {
                MessageBox.Show("Debe ingresar una contraseña");
            }


        }
        public string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
