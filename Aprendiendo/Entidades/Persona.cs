using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo.Entidades
{
    public class Persona
    {
        public int idPersona { get; set; }
        public string Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }      
        public DateTime FechaNacimiento { get; set; }
    }
}
