namespace Programa2_1Sink.Clase
{
    class RefrigeradorSink : Interface.IEventosRefri
    {
        // Esta es la clase sink
        // Aqui colocamos los handlers de los eventos definidos en la interface

        public void EventReservaBajas(int pKilos)
        {
            // Aqui se coloca todo el codigo necesario para ejecutar cuando suceda el evento

            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("-->Reservas Bajas de alimentos");
            System.Console.WriteLine("--> Quedan {0} kilos", pKilos);
        }
    }
}
