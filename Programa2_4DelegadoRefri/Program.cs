namespace Programa2_4DelegadoRefri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri
            Clases.Refrigerador miRefri = new Clases.Refrigerador(70, -20);
            System.Random random = new System.Random();

            // Adicinamos los handlers
            miRefri.addMetodoReservas(new Clases.Refrigerador.ReservasBajas(InformeKilos));
            miRefri.addMetodoDescongelado(new Clases.Refrigerador.Descongelado(InformeGrados));

            // bucle finito
            while (miRefri.Kilos > 0) {
                miRefri.Trabajar(random.Next(1, 5));
            }
            System.Console.ReadKey();
        }

        public static void InformeKilos(int pkilos)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("-->Reservas bajas de alimentos");
            System.Console.WriteLine("-->Quedan {0} Kilos", pkilos);
        }

        public static void InformeGrados(int pGrados)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine("-->Temperatura del Refrigerador");
            System.Console.WriteLine("-->Esta {0} Grados", pGrados);
        }
    }
}
