namespace Programa3_2SobreCargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases.Imaginario im1 = new Clases.Imaginario(1, 2);
            Clases.Imaginario im2 = new Clases.Imaginario(3, 4);
            Clases.Imaginario imr;

            // Suma
            imr = im1 + im2;
            System.Console.WriteLine("{0} + {1} = {2}", im1, im2, imr);

            // Resta
            imr = im1 - im2;
            System.Console.WriteLine("{0} - {1} = {2}", im1 ,im2, imr);

            // Multipicacion
            imr = im1 * im2;
            System.Console.WriteLine("{0} * {1} = {2}", im1, im2, imr);

            // Divicion
            imr = im1 / im2;
            System.Console.WriteLine("{0} / {1} = {2}", im1, im2, imr);
            System.Console.ReadKey();
        }
    }
}
