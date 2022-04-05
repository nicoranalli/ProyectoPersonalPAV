using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Entidades
{
    public class Persona
    {


        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Carrera { get; set; }

        public Persona(string nombre , string apellido, string fechaNacimiento, string carrera) 
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Carrera = carrera;
        }
    }
}
