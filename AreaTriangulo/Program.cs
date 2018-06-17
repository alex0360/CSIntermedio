using System;
using System.Text.RegularExpressions;
namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor="";
            string error="";
            int b=0, h=0;


            Console.WriteLine("Introducir Base");
            valor=Console.ReadLine();
            if (isNumber(valor)) {
                Base(Convert.ToInt32(valor));
            }

            Console.WriteLine("Introducir Height");
            valor = Console.ReadLine();
            if (isNumber(valor))
            {
                Height(Convert.ToInt32(valor));
            }

            if (Error()) {
                Console.Clear();
                Area();
            }
            Console.ReadKey();
            #region funcion
            int Base(int pB)
            {
                b = pB;
                if (Evento(b))
                {
                    return b;
                }
                else
                {
                    return 0;
                }
            }

            int Height(int pH) {
                h = pH;
                if (Evento(h))
                {
                    return h;
                }
                else {
                    return 0;
                }
            }

            void Area() {
                int resurtado = b * h / 2;
              
                Console.WriteLine("Area:{0} x {1}/2",b,h);
                Console.WriteLine("Area={0}",resurtado);  
            }

            bool isNumber(string readValor)
            {
                Regex isnumber = new Regex("[^0-9]");
                return !isnumber.IsMatch(readValor);
            }

            bool Evento(int var)
            {
                if (var > 0)
                    return true;
                else
                    return false;
            }

            bool Error() {

                if (error == "")
                
                    return true;
                
                else
                    return false;
            }
            #endregion
        }


    }
}
