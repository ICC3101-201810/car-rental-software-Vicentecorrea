using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4VicenteCorrea
{
    class Persona : Cliente
    {
        string licencia;
        List<string> licencias = new List<string>();

        public Persona(string miNombre,string miLicencia) : base(miNombre)
        {
            licencia = miLicencia;
            licencias.Add(licencia);
        }

       
        public override void ArrendarVehiculo(Vehiculo vehiculo)
        {
            base.ArrendarVehiculo(vehiculo);

            if (licencias.Contains(vehiculo.GetLicencia()) == false)
            {
                puedeArrendar = false;
            }
            if (puedeArrendar)
            {
                vehiculosArrendados.Add(vehiculo);
                Console.WriteLine("{0} arrendado por {1}", vehiculo.GetNombre(), GetNombre());
            }
            else
            {
                Console.WriteLine("{0} no pudo ser arrendado por {1}", vehiculo.GetNombre(), GetNombre());
            }
        }
    }
}
