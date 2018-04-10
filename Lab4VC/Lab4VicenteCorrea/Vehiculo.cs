using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4VicenteCorrea
{
    abstract class Vehiculo
    {
        string nombre;
        int cantidad;
        string licencia;
        string autorizacion;
        public Vehiculo(string miNombre,int miCantidad, string miLicencia, string miAutorizacion)
        {
            nombre = miNombre;
            cantidad = miCantidad;
            licencia = miLicencia;
            autorizacion = miAutorizacion;
        }
        public int GetCantidad()
        {
            return cantidad;
        }
        public string GetLicencia()
        {
            return licencia;
        }
        public string GetAutorizacion()
        {
            return autorizacion;
        }
        public string GetNombre()
        {
            return nombre;
        }
    }
}
