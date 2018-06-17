
namespace Programa1_3IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase.Contendor datos = new Clase.Contendor();

            foreach(int valor in datos)
            {
                System.Console.WriteLine(valor);
            }

            System.Console.ReadLine();
        }
    }
}
