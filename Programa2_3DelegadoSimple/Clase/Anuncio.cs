namespace Programa2_3DelegadoSimple.Clase
{
    class Anuncio
    {
        public static void MetAnuncio(string pAnuncio)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine("Somos anunciados por: {0}", pAnuncio);
        }
    }
}
