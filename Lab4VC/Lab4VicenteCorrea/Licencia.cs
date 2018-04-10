using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4VicenteCorrea
{
    class Licencia
    {

        string licencia;

        public Licencia(string miLicencia)
        {
            licencia = miLicencia;
        }
        public string GetNombre()
        {
            return licencia;
        }
    }
}
