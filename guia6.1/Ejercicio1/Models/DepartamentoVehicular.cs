using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class DepartamentoVehicular
    {
        public int CantidadRegistros { get { return registros.Count; } }
        int serie;
        List<RegistroVehiculo> registros = new List<RegistroVehiculo>();

        public RegistroVehiculo RegistrarVehiculo(Persona propietario,string patente )
        {
            RegistroVehiculo registro = new RegistroVehiculo(patente, propietario, ++serie);
            registros.Add( registro );
            return registro;


        }
        public void Ordenar()
        {
            registros.Sort();
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx<registros.Count && idx>=0)
            {
                return registros[idx];
            }
            return null;
        }

    }
}
