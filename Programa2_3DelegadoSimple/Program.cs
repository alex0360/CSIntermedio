namespace Programa2_3DelegadoSimple
{
    // Definir el delegado con las carateristicas que nos interesan
    public delegate void MiDelegado(string e);

    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto del delegado y lo refenciamos a un metodo
            MiDelegado delegado = new MiDelegado(Clase.Radio.MetRadio);

            // Ahora por medio del delegado hacemos uso del metodo
            delegado("Hola esta es la emisora 0.31");

            // Hacemos que apunte a otro metodo
            delegado = new MiDelegado(Clase.Anuncio.MetAnuncio);

            // Ahora invocamos el otro metodo
            delegado("Pastel come mucho");

            System.Threading.Thread.Sleep(4000);
        }
    }
}
