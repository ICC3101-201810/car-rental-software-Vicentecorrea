using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4VicenteCorrea
{
    abstract class Cliente
    {
        string nombre;
        public List<Vehiculo> vehiculosArrendados = new List<Vehiculo>();
        public Cliente(string miNombre)
        {
            nombre = miNombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        protected bool puedeArrendar = true;
        public virtual void ArrendarVehiculo(Vehiculo vehiculo)
        {
            if (vehiculo.GetCantidad() == 0)
            {
                puedeArrendar = false;
            }

            
        }
    }

}
