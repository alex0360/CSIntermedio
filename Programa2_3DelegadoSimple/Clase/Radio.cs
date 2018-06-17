namespace Programa2_3DelegadoSimple.Clase
{
    class Radio
    {
        // Este metodo actuara como delegado
        public static void MetRadio(System.String pMensaje)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("Estamos en la clase radio");
            System.Console.WriteLine("Este es tu mensaje {0}",pMensaje);
        }
    }
}
