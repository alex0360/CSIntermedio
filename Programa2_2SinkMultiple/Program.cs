namespace Programa2_2SinkMultiple
{
    class Program
    {

        #region referencias
        // Creamos el sink
        private static Clase.Refrigerador miRefri = new Clase.Refrigerador(20, -5);
        private static System.Random rnd = new System.Random();
           
        // Sink1 tiene el codigo que se ejecuta cuando suceda el evento
        private static Clase.RefrigeradorSink sink1 = new Clase.RefrigeradorSink();
        private static Clase.TiendaSink sink2 = new Clase.TiendaSink();

        #endregion

        static void Main(string[] args)
        {
            // Adicionamos el sink al refri
            miRefri.AddSink(sink1);
            // sink2
            miRefri.AddSink(sink2);

            // El refri hace su trabajo
            Program.Loop();
            System.Console.ReadLine();
        }

        static private void Loop()
        {
            while (miRefri.Kilos > 0 && sink1.Paro == false)
            {
                // El refri trabaja y le sacamos kilos al azar
                miRefri.Trabajo(rnd.Next(1, 7));
                System.Threading.Thread.Sleep(700);
            }
        }
    }
}
