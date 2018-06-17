using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_1.Clases
{
    class Divicion:IOperacion
    {
        private double r = 0;
        public void Calcular(double a, double b)
        {
            r = a / b;
        }
        public void Mostrar()
        {
            System.Console.WriteLine("El resultado de la division {0}", r);
        }
    }
}
