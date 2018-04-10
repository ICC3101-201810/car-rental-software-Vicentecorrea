using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4VicenteCorrea
{
    class Institucion : Cliente
    {
        string autorizacion;
        List<string> autorizaciones = new List<string>();
        public Institucion(string miNombre, string miAutorizacion) : base(miNombre)
        {
            autorizacion = miAutorizacion;
            autorizaciones.Add(autorizacion);

        }
        public override void ArrendarVehiculo(Vehiculo vehiculo)
        {
            base.ArrendarVehiculo(vehiculo);

            if (autorizaciones.Contains(vehiculo.GetAutorizacion()) == false)
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
