namespace Programa2_1Sink
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri

            Clase.Refrigerador miRefri = new Clase.Refrigerador(50,-20);

            System.Random rnd = new System.Random();

            // Creamos el sink
            // Sink1 tiene el codigo que se ejecuta cuando suceda el evento
            Clase.RefrigeradorSink sink1 = new Clase.RefrigeradorSink();

            // Adicionamos el sink al refri
            miRefri.AddSink(sink1);

            // El refri hace su trabajo
            while (miRefri.Kilos>0)
            {
                // El refri trabaja y le sacamos kilos al azar
                miRefri.Trabajo(rnd.Next(1, 5));
            }
            System.Console.ReadKey();
        }
    }
}
