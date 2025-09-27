using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona(int dni, string nombre)
        {
            if (dni < 1000000)
            {
                throw new RangoDniIncorrectoException();
            }
            this.DNI = dni;
            this.Nombre = nombre;

        }

    }
}
