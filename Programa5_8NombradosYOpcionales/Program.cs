using System;

namespace Programa5_8NombradosYOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
         
            // Invocamos la funcion de forma normal
            // tres posiciones.
            Nombrado.MostrarDatos(3,5,7);

            #region Parametros Nombrado
            // Parametros Nombrados
            Console.WriteLine("Ahora con Nombrado");
            // Invocamos la funcion con primero en normal, los demas
            // en otro orden un posicional, dos nombrados.
            Nombrado.MostrarDatos(3,pC:11,pB:15);

            // Invocamos con los datos en otro orden
            // tres nombrados
            Nombrado.MostrarDatos(pB:10,pC:15,pA:4);

            /*
            // Una posicional no puede venir despues de un nombrado
            // Nombrado.MostrarDatos(pB: 5, 2, 8);
            */
            #endregion
            #region Parametros Opcionales
            Console.WriteLine("Opcionales");
            // Invocacion normal
            Opcionales.MostrarDatos(11,12,13);

            // Usamos dos parametros C usa el valor por Defaut
            Opcionales.MostrarDatos(20,21);

            // Usamos un parametros B, C usan el valor Opcional
            Opcionales.MostrarDatos(31);

            // Usamos todos los parametros Opcionales
            Opcionales.MostrarDatos();
            #endregion

            #region Ahora con Nombrado y Opcionales
            Console.WriteLine("Ahora con Nombrado y Opcionales");

            // Un Opcional con dos Nombrados
            Opcionales.MostrarDatos(pC:43, pB:42);
            #endregion

            // Dos opcionales con un nombrado
            Opcionales.MostrarDatos(pB:52);
            /*
            // No se puede
            // Probando si se coje el valor Un que diga que sera a
            //Opcionales.MostrarDatos(63, pA: 61, pB: 62);
            */
            Console.ReadKey();

        }

    }

    class Nombrado{
        public static void MostrarDatos(int pA, int pB, int pC) {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);

            Console.WriteLine("--------------------");
         }
    }

    class Opcionales
    {
        public static void MostrarDatos(int pA=1, int pB=2, int pC=3) {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);

            Console.WriteLine("--------------------");
        }
    }
}
