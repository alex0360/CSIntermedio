namespace Programa3_1Index.Clases
{
    class Auto
    {
        double costo;
        string modelo;

        // Constrictor
        public Auto(string pModelo, double pCosto)
        {
            // Inicialiar  los datos
            costo = pCosto;
            modelo = pModelo;
        }

        public void ShopInfo()
        {
            // Mostramos la informacion
            System.Console.WriteLine("Tu automovil {0}", modelo);
            System.Console.WriteLine("Costo {0}", costo);
            System.Console.WriteLine();
        }
    }
}
