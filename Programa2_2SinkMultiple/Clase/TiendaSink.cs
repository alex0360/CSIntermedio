namespace Programa2_2SinkMultiple.Clase
{
    class TiendaSink: Interface.IEventosRefri
    {
        public void EventReservaBajas(int pKilos)
        {
            // Aqui se coloca todo el codigo necesario para ejecutar
            // cuando suceda el evento.
            
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine("--->Le enviaremos sus viveres");
            System.Console.WriteLine("--->Seran {0} Kilos", pKilos);
        }

        public void EventDescongelado(int pGrados) { /*Vacio*/}
    }
}
