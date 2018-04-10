using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4VicenteCorrea
{
    class Camion : Vehiculo
    {
        public Camion(string miNombre, int miCantidad, string miLicencia, string miAutorizacion) 
            : base(miNombre, miCantidad, miLicencia, miAutorizacion)
        {

        }
    }
}
