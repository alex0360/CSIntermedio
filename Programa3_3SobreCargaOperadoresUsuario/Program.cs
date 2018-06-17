namespace Programa3_3SobreCargaOperadoresUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases.Imaginario im1 = new Clases.Imaginario(1, 2);
            Clases.Imaginario im2 = new Clases.Imaginario(3, 4);
            Clases.Imaginario im3 = new Clases.Imaginario(1, 2);

            if (im1 == im3) System.Console.WriteLine("{0} Es Iguales {1}", im1, im3);
            if (im1 != im2) System.Console.WriteLine("{0} Es Diferentes {1}", im1,im2);

            System.Console.WriteLine("----------------");

            System.Console.WriteLine(im1);
            im1++;
            System.Console.WriteLine(im1);

            System.Console.WriteLine("----------------");

            System.Console.WriteLine(im2);
            im2--;
            System.Console.WriteLine(im2);

            System.Console.WriteLine("----------------");

            System.Console.WriteLine(im1);
            im1+=im2;
            System.Console.WriteLine(im1);
           
            System.Console.ReadKey();
        }
    }
}
