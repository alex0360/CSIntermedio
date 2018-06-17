using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_2IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases.Auto Auto1 = new Clases.Auto("March", 17000);

            // Aqui pensamos que hacermos clonado
            // pero solo es otra variable referenciada a la misma instancia
            Clases.Auto Auto2 = Auto1;

            Auto1.CalcularTenencia(0.10);
            Auto2.CalcularTenencia(0.10);
            
            // Imprimir
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            System.Console.WriteLine("-------------");

            // Modificar el costo de auto uno
            Auto1.Costo = 60000;

            // Imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            System.Console.WriteLine("==================");

            // Hacemos al Clon
            Clases.Auto Auto3 = (Clases.Auto)Auto1.Clone();

            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            System.Console.WriteLine(":::::::::::::::");

            // Modificamos uno, el otro no debe cambiar
            Auto1.Costo = 25000;

            // Imprimimos para verificar
            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();
            System.Console.ReadLine();
        }
    }
}
