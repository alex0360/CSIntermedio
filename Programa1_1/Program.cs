using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double valA = 0.0;
            double valB = 0.0;
            string valor = "";

            Clases.Ejecutar ejecutar = new Clases.Ejecutar();

            ejecutar._Ejecutar(opcion, valA, valB, valor);

        }
    }
}
