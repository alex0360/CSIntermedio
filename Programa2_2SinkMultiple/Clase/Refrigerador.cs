namespace Programa2_2SinkMultiple.Clase
{
    class Refrigerador
    {
        // Aqui guardamos todos los Sinks con los que se comunicara el refri
        private System.Collections.ArrayList listaSinks =
            new System.Collections.ArrayList();

        private int kilosAlimetos = 0;
        private int grados = 0;

        public Refrigerador( int pKilos, int pGrados)
        {
            // Coloca los valores iniciales de refri

            kilosAlimetos = pKilos;
            grados = pGrados;
        }

        // adicionamos un Sink en tiempo de ejecucion
        public void AddSink(Interface.IEventosRefri pSink)
        {
            if (pSink != null)
                listaSinks.Add(pSink);
        }

        // Eliminamos un Sink en tiempo de ejecucion
        public void DeleteSink(Interface.IEventosRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
        }

        // Propiedades necesarias
        public int Kilos { get { return kilosAlimetos; } }
        public int Grados { get { return grados; } }

        public void Trabajo(int pConsumo)
        {
            // Actulizamos los kilos del refri
            kilosAlimetos -= pConsumo;
            //subimos la temperatura
            grados += 1;

            System.Console.ForegroundColor = System.ConsoleColor.Gray;
            System.Console.WriteLine("{0} kilos, {1} grados", kilosAlimetos, grados);

            // Hay que verificar si se cumple la condicion para
            // invocar los handlers del evento

            // Esta es la condicion de evente
            if(kilosAlimetos <10)
            {
                // Invocamos a los handlers de cada Sink
                foreach(Interface.IEventosRefri handler in listaSinks)
                {
                    handler.EventReservaBajas(kilosAlimetos);
                }
            }

            // Este es la condicion para el evento de descongelado
            if(grados>=0)
            {
                // Invocamos a las handlers de cada sink
                foreach (Interface.IEventosRefri handler in listaSinks)
                {
                    handler.EventDescongelado(grados);
                }
            }
        }
    }
}
