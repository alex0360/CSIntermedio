namespace Programa4_6Archivo.Clases
{
    public class Auto
    {
        private double costo;
        private string modelo;

        public string Modelo { /*set { modelo = value; }*/ get { return modelo; } }
        public double Costo { /*set { costo = value;}*/ get { return costo; } }

        // Constructor
        public Auto(string pModelo, double pCosto)
        {
            costo =pCosto;
            modelo = pModelo;
        }
    
        public void showInfo()
        {   
            // Mostrar la Informacion necesaria
            System.Console.WriteLine("El auto {0}",Modelo);
            System.Console.WriteLine("Cuesta {0}",Costo);
            System.Console.WriteLine("------------------");
        }
    }
}
