using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4VicenteCorrea
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Auto Ferrari rojo", 5, "LA", "AA");
            Retroexcavadora retroexcavadora1 = new Retroexcavadora("Retroexcavadora demoledora", 3, "LR", "AR");
            Bus bus1 = new Bus("Bus verde", 2, "LB", "AB");

            Organizacion organizacion1 = new Organizacion("La Organizacion Bacan", "AR");   
            Persona persona1 = new Persona("Juan Perez", "LA");
            Institucion institucion1 = new Institucion("Institucion Maravillas", "AM");

            persona1.ArrendarVehiculo(auto1);
            organizacion1.ArrendarVehiculo(retroexcavadora1);
            institucion1.ArrendarVehiculo(bus1);

            Console.ReadKey();
        }
    }
}
