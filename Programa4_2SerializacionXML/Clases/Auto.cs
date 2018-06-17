namespace Programa4_2SerializacionXML.Clases
{
    [System.Serializable]
    class Auto
    {
        private double costo;
        private string modelo;

        // Constructor
        public Auto(string pMoledo, double pCosto)
        {
            costo = pCosto;
            modelo = pMoledo;
        }

        public string Modelo { get { return modelo; } }
        public double Costo { get { return costo; } }

        public void showInfo()
        {   
            // Mostrar la Informacion necesaria
            System.Console.WriteLine("El auto {0}",Modelo);
            System.Console.WriteLine("Cuesta {0}",Costo);
            System.Console.WriteLine("------------------");
        }
    }
}
