using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace Controlador
{
    public class UsuarioController
    {
        private static UsuarioController _instancia;

        readonly Modelo.ContextoContainer _context = Modelo.SingletonContext.obtener_instancia().Contexto;
        public Modelo.Usuario globalUser = null;

        public static UsuarioController obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new UsuarioController();
            }
            return _instancia;
        }

        public List<Modelo.Usuario> GetAllUsuarios()
        {
            return _context.Usuarios.ToList();
        }
        public int AddUsuario(Modelo.Usuario usuario)
        {
            try
            {
                var user = _context.Usuarios.FirstOrDefault(x => x.Email == usuario.Email);
                // VALIDAR SI YA EXISTE USUARIO CON ESE MAIL
                if (user != null)
                {
                    return 1;
                }

                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return 2;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool EditUser(Modelo.Usuario usuario)
        {
            try
            {
                var findedUser = _context.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
                if (findedUser == null)
                {
                    return false;
                }

                findedUser.Nombre = usuario.Nombre;
                findedUser.Email = usuario.Email;
                findedUser.Dni = usuario.Dni;
                findedUser.Contraseña = usuario.Contraseña;
                findedUser.Perfil = usuario.Perfil;

                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public bool DeleteUser(Modelo.Usuario usuario)
        {
            try
            {
                var userToDelete = _context.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
                _context.Usuarios.Remove(userToDelete);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public Modelo.Usuario LoginUser(string email, string contraseña)
        {
            try
            {
                contraseña = Base64Encode(contraseña);

                var user = _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Contraseña == contraseña);
                
                if (user == null)
                {
                    return null;
                }
                
                return user;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public void Add_GlobalUser(Modelo.Usuario usuario)
        {
            globalUser = usuario;
        }

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
