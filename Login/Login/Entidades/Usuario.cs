using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Entidades
{
    public class Usuario
    {


        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime? FechaLogin { get; set; } = DateTime.Now;

        public Usuario(string nombreUsuario, string password)
        {
            NombreDeUsuario = nombreUsuario;
            Contraseña = password;
        }
    }
}
