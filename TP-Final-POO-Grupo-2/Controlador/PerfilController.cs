using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class PerfilController
    {
        private static PerfilController _instancia;

        public static PerfilController obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new PerfilController();
            }
            return _instancia;
        }

        public List<Modelo.Perfil> GetAllPerfiles()
        {
            return Modelo.SingletonContext.obtener_instancia().Contexto.Perfiles.ToList();
        }
    }
}
