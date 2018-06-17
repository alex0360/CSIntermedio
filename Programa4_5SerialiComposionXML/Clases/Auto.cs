namespace Programa4_5SerialiComposionXML.Clases
{
    [System.Serializable]
    public class Auto
    {
        private double costo;
        private string modelo;
        Motor motor;

        public string Modelo { set { modelo = value; } get { return modelo; } }
        public double Costo { set { costo = value;} get { return costo; } }
        public Motor Motor { set { motor = value; } get { return motor; } }

        // Constructor
        public Auto()
        {
            costo = 10000;
            modelo = "Auto";
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
