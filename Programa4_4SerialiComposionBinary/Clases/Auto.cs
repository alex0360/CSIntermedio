namespace Programa4_4SerialiComposionBinary.Clases
{
    [System.Serializable]
    class Auto
    {
        private double costo;
        private string modelo;
        Motor motor;

        public string Modelo { get { return modelo; } }
        public double Costo { get { return costo; } }
        public Motor Motor { set { motor = value; } }

        // Constructor
        public Auto(string pMoledo, double pCosto)
        {
            costo = pCosto;
            modelo = pMoledo;
            motor = new Motor();
        }
    
        public void showInfo()
        {   
            // Mostrar la Informacion necesaria
            System.Console.WriteLine("El auto {0}",Modelo);
            System.Console.WriteLine("Cuesta {0}",Costo);
            motor.ShopMotor();
            System.Console.WriteLine("------------------");
        }
    }
}
