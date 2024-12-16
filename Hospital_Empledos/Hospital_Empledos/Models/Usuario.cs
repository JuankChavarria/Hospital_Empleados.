using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empledos.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public DateTime? FechaRegistro { get; set; } = DateTime.Now;
    
        public Usuario() { }

        public Usuario(int idUsuario, string nombre, string correo, string contraseña, string rol, DateTime? fechaRegistro)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Correo = correo;
            Contraseña = contraseña;
            Rol = rol;
            FechaRegistro = fechaRegistro;
        }
    }
}