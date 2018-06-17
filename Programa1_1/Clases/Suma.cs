using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_1
{
    class Suma:IOperacion
    {
        private double r = 0;
        private System.Collections.ArrayList resultado 
            = new System.Collections.ArrayList();

        //metodos a implementar
        public void Calcular(double a, double b)
        {
            r = a + b;
        }

        public void Mostrar() {
            System.Console.WriteLine("El resultado de la suma es {0}", r);
            resultado.Add(r);
        }

        //metodos propios de la clase
        public void muestraResultado()
        {
            foreach (double r in resultado)
                System.Console.WriteLine(r);
        }
    }
}
