namespace Programa2_4DelegadoRefri.Clases
{
    class Refrigerador
    {
        // Delegados
        public delegate void ReservasBajas(int pKilos);
        public delegate void Descongelado(int pGrados);

        private int kilosAlimentos = 0;
        private int grados = 0;

        // Variables de invocacion
        private ReservasBajas reservas;
        private Descongelado descongelado;

        public Refrigerador(int pKilos, int pGrados)
        {
            // Colocar los valores.
            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        // Metodos para referenciar las variables
        public void addMetodoReservas(ReservasBajas pMetodo)
        {
            reservas = pMetodo;
        }

        public void addMetodoDescongelado(Descongelado pMetodo)
        {
            descongelado = pMetodo;
        }

        // Propiedades Necesarias
        public int Kilos { get { return kilosAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int pConsumo)
        {
            // Actualizamos los kilos del refri
            kilosAlimentos -= pConsumo;

            // Subimos la temperatura
            grados += 1;

            System.Console.ForegroundColor = System.ConsoleColor.Gray;
            System.Console.WriteLine("{0} Kilos, {1} grados",kilosAlimentos,grados);

            // Hay que verificar si se cumple la condicion para
            // invocar los handlers del evento

            // Esta es la condicion del evento para los kilos
            if (kilosAlimentos < 10)
                // Invocamos el metodo
                reservas(kilosAlimentos);
            // Este es la condicion del evento para la temperatura
            if (grados > 0)
                // Invocamos el metodo
                descongelado(grados);
        }
    }
}
