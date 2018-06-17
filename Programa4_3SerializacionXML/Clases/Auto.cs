namespace Programa4_3SerializacionXML.Clases
{
    [System.Serializable]

    //La Clase tiene que ser publica
    public class Auto
    {
        private double costo;
        private string modelo;

        // Constructor no debe de tener parametros
        public Auto()
        {
            costo = 0.00;
            modelo = "Null";
        }

        public string Modelo { get { return modelo; } set { modelo = value; } }
        public double Costo { get { return costo; } set { costo = value; } }

        public void showInfo()
        {   
            // Mostrar la Informacion necesaria
            System.Console.WriteLine("El auto {0}",Modelo);
            System.Console.WriteLine("Cuesta {0}",Costo);
            System.Console.WriteLine("------------------");
        }
    }
}
