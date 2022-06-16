using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class UsuarioController
    {
        private static UsuarioController _instancia;

        readonly Modelo.ContextoContainer _context = Modelo.SingletonContext.obtener_instancia().Contexto;
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
        public bool AddUsuario(Modelo.Usuario usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return true;
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
        public bool LoginUser(string email, string contraseña)
        {
            try
            {
                var user = _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Contraseña == contraseña);
                if (user == null)
                {
                    return false;
                }
    
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
