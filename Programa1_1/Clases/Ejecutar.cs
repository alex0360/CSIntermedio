using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1_1.Clases
{
    class Ejecutar
    {
        private int Delegar(int opcion, string valor)
        {
            opcion = System.Convert.ToInt32(valor);
            if (opcion == 5)
            {
                System.Environment.Exit(0);
            }
            return opcion;
        }
        IOperacion operacion; 
        public void _Ejecutar(int opcion, double valA, double valB, string valor)
        {
            while (opcion != 5)
            {
                System.Console.WriteLine("1-Suma, 2-Resta, 3-Multi, 4-Division, 5-Salir");
                System.Console.WriteLine("Que Opcion deseas?");
                valor = System.Console.ReadLine();
                if (System.Convert.ToInt32(valor) >= 1 && System.Convert.ToInt32(valor) <= 5)
                {
                    opcion = Delegar(opcion,valor);
         
                    System.Console.WriteLine("Dame el valor de a");
                    valor = System.Console.ReadLine();
                    valA = System.Convert.ToDouble(valor);

                    System.Console.WriteLine("Dame el valor de b");
                    valor = System.Console.ReadLine();
                    valB = System.Convert.ToDouble(valor);

                    
                    if (opcion == 1)
                        operacion = new Suma();
                    if (opcion == 2)
                        operacion = new restar();
                    if (opcion == 3)
                        operacion = new Multiplicacion();
                    if (opcion == 4)
                        operacion = new Clases.Divicion();

                    operacion.Calcular(valA, valB);
                    operacion.Mostrar();
                    System.Console.WriteLine("");
                }
                else
                {
                    System.Console.WriteLine(valor+" no es un valor numerico del aceptable");
                }
            }
        }
    }
}
