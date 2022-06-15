﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class UsuarioController
    {
        private static UsuarioController _instancia;

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
            return Modelo.SingletonContext.obtener_instancia().Contexto.Usuarios.Include("Perfil").ToList();
        }
    }
}
