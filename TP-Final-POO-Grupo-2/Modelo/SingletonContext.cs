using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SingletonContext
    {
        private static SingletonContext _instancia;
        private static ContextoContainer _contexto;

        private SingletonContext() { }

        public static SingletonContext obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new SingletonContext();
                _contexto = new ContextoContainer();
            }
            return _instancia;
        }

        public ContextoContainer Contexto
        {
            get { return _contexto; }
        }
    }
}
