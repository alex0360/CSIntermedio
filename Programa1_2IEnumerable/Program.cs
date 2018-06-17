using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_2IEnumerable
{
    class Program
    {
        /*
            public interface IEnumerable
            {
                IEnumerator GetEnumerator();
            }

            public interface IEnumerator
            {
                bool MoverNext();
                object Current {get;}
                void Reset;
            }
        */

        static void Main(string[] args)
        {
            // Creamos la tienda
            Clases.Tienda tienda = new Clases.Tienda();

            // Recorrer y mostrar la estructura

            foreach (Clases.Auto miAuto in tienda)
            {
                miAuto.CalcularTenencia(0.05);
                miAuto.MuestraInformacion();
            }
            System.Console.ReadLine();
        }
    }
}
