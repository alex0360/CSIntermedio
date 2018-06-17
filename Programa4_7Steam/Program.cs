namespace Programa4_7Steam
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases.Metodos.Read read = 
                new Clases.Metodos.Read("Datos.txt");
            System.Console.WriteLine("\n------------\n");
            System.Console.ReadKey();
        }
    }
}
