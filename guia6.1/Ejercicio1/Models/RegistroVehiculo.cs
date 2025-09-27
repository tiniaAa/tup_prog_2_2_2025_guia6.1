using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{

    public class RegistroVehiculo:IComparable 
    {

        public string Patente { get; set; }
        public string Serie { get; set; }
        public Persona Propietario { get; set; }

        public RegistroVehiculo(string patente, Persona propietario, int serie ) 
        {
            this.Patente=patente;
            this.Serie = serie.ToString();
            this.Propietario = propietario;

            Match match = Regex.Match(patente.Trim(), @"[A-Z]{3}\s*[0-9]{3}",RegexOptions.IgnoreCase );
            if (match.Success == false )
            {
                throw new FormatoPatenteNoValidaException();
            }




        }
        public int CompareTo(object? obj)
        {
           RegistroVehiculo registro = obj as RegistroVehiculo;

            if ( registro != null )
            {
                return Patente.CompareTo(registro.Patente); 
            }
            return -1; 

        }
    }
}
