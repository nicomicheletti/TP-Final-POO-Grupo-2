using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace Controlador
{
    public class ProductoController
    {
        private static ProductoController _instancia;

        readonly Modelo.ContextoContainer _context = Modelo.SingletonContext.obtener_instancia().Contexto;
        public Modelo.Usuario globalUser = null;
        public bool isCliente = false;

        public static ProductoController obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ProductoController();
            }
            return _instancia;
        }

        public List<Modelo.Producto> GetProductos()
        {
            try
            {
                var a = _context.Productos.ToList();
                return _context.Productos.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void AddProducto(Modelo.Producto producto)
        {
            try
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void DeleteProducto(Modelo.Producto producto)
        {
            try
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
