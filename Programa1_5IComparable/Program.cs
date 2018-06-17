namespace Programa1_5IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases.Restangulo[] restangulo 
                = new Clases.Restangulo[5];

            restangulo[0] = new Clases.Restangulo(7, 5);
            restangulo[1] = new Clases.Restangulo(6, 4);
            restangulo[2] = new Clases.Restangulo(4, 3);
            restangulo[3] = new Clases.Restangulo(7, 6);
            restangulo[4] = new Clases.Restangulo(5, 7);

            // Implemetamos arreglos original
            foreach (Clases.Restangulo r in restangulo)
                System.Console.WriteLine(r);

            System.Console.WriteLine("-----------------");

            // Hacemos uso de sort, el cual necesita la 
            // implementacion de IComparable
            System.Array.Sort(restangulo);

            // Imprimimos arreglos ordenados
            foreach (Clases.Restangulo r in restangulo)
                System.Console.WriteLine(r);

            System.Console.ReadKey();
        }
    }
}
