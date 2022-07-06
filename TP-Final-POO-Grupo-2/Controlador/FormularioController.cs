using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class FormularioController
    {
        private static FormularioController _instancia;

        public static FormularioController obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new FormularioController();
            }
            return _instancia;
        }

        public List<Modelo.Formulario> GetUserFormularios(Modelo.Usuario user)
        {
            //return Modelo.SingletonContext.obtener_instancia().Contexto.Formularios.ToList();
            return user.Perfil.Formulario.ToList();
        }
    }
}
