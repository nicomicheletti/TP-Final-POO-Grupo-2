using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ManageUserForm : Form
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AddUserForm usuarioFrm = new AddUserForm();
            usuarioFrm.Show();
            Hide();
        }

        //EDITAR USUARIO
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            var selectedUser = (Modelo.Usuario)usuarioBindingSource.Current;
            EditUserForm modificarFrm = new EditUserForm(selectedUser);
            modificarFrm.Show();
            Hide();
        }

        private void GestionarUsuarioFrm_Load(object sender, EventArgs e)
        {
            // ASIGNO LISTA DE USUARIOA A BINDING SOURCE
            usuarioBindingSource.DataSource = Controlador.UsuarioController.obtener_instancia().GetAllUsuarios();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            var selectedUser = (Modelo.Usuario)usuarioBindingSource.Current;
           var validator =  Controlador.UsuarioController.obtener_instancia().DeleteUser(selectedUser);

            if (validator == true)
            {
                MessageBox.Show("Usuario eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar usuario");
            }
            usuarioBindingSource.DataSource = Controlador.UsuarioController.obtener_instancia().GetAllUsuarios();
        }
    }
}

