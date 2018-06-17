namespace Programa2_2SinkMultiple.Clase
{
    class RefrigeradorSink : Interface.IEventosRefri
    {
        // Esta es la clase sink
        private bool paro = false;
        public bool Paro { get { return paro; } }


        // Aqui colocamos los handlers de los eventos definidos en la interface

        public void EventReservaBajas(int pKilos)
        {
            // Aqui se coloca todo el codigo necesario para ejecutar cuando suceda el evento

            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("-->Reservas Bajas de alimentos");
            System.Console.WriteLine("--> Quedan {0} kilos", pKilos);
        }

        public void EventDescongelado(int pGrado)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine("--->El refri se descongela");

            if (pGrado > 0)
                paro = true;
        }
    }
}
