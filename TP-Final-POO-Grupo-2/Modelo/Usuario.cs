//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(string nombre, string email, string dni, string contraseña, Perfil perfil)
        {
            //Id = id;
            Nombre = nombre;
            Email = email;
            Dni = dni;
            Contraseña = contraseña;
            Perfil = perfil;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Dni { get; set; }
        public string Contraseña { get; set; }
    
        public virtual Perfil Perfil { get; set; }
    }
}
