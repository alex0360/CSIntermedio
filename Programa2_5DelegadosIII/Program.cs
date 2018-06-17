namespace Programa2_5DelegadosIII
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Creamos el refri
            Clases.Refrigerador miRefri = new Clases.Refrigerador(70, -20);
            System.Random random = new System.Random();

            // Variables para multicasting, necesitamos la instancia para poder adicionar o eliminar
            Clases.Refrigerador.ReservasBajas kilos1 = new Clases.Refrigerador.ReservasBajas(InformeKilos);
            Clases.Refrigerador.ReservasBajas kilos2 = new Clases.Refrigerador.ReservasBajas(Clases.Tienda.MandaViveres);
            Clases.Refrigerador.Descongelado desc1 = new Clases.Refrigerador.Descongelado(InformeGrados);

            // Adicionamos los handlers
            miRefri.AddMetodoReservas(kilos1);
            miRefri.AddMetodoReservas(kilos2);
            miRefri.AddMetodoDescongelado(desc1);

            //relleno
            miRefri.Grados = -15;

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
