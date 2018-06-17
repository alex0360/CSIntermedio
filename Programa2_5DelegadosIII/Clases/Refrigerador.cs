namespace Programa2_5DelegadosIII.Clases
{
    class Refrigerador
    {// Delegados
        public delegate void ReservasBajas(int pKilos);
        public delegate void Descongelado(int pGrados);

        protected int kilosAlimentos = 0;
        protected int grados = 0;

        public Refrigerador(int pKilos, int pGrados) {
            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        // Variables de invocacion
        public ReservasBajas reservas;
        public Descongelado descongelado;

        // Metodos para referenciar las variables
        // MultiCasting
        public void AddMetodoReservas(ReservasBajas pMetodo)
        {
            reservas += pMetodo;
        }

        public void DeleteMetodoReservas(ReservasBajas pMetodo)
        {
            reservas -= pMetodo;
        }

        public void AddMetodoDescongelado(Descongelado pMetodo)
        {
            descongelado += pMetodo;
        }

        public void DeleteMetodoDescongelado(Descongelado pMetodo)
        {
            descongelado -= pMetodo;
        }

        // Propiedades Necesarias
        public int Kilos { get { return kilosAlimentos; } set { kilosAlimentos = value; } }
        public int Grados { get { return grados; } set { grados = value; } }


        public void Trabajar(int pConsumo)
        {
            // Actualizamos los kilos del refri
            kilosAlimentos -= pConsumo;

            // Subimos la temperatura

            System.Console.ForegroundColor = System.ConsoleColor.Gray;
            System.Console.WriteLine("{0} Kilos, {1} grados", kilosAlimentos, grados);

            // Hay que verificar si se cumple la condicion para
            // invocar los handlers del evento

            // Esta es la condicion del evento para los kilos
            if (kilosAlimentos < 10)
                // Invocamos el metodo
                reservas(kilosAlimentos);
            Kilos += 1;
            // Este es la condicion del evento para la temperatura
            if (grados > 0)
                // Invocamos el metodo
                descongelado(grados);
        }
    }
}
