﻿namespace Programa1_2IEnumerable.Clases
{
    class Auto:IAutomovil, System.ICloneable
    {
        double costo;
        double tenencia;
        string modelo;

        double valor = 5000.0;

        // Constructor
        public Auto(string pModelo, double pCosto)
        {
            //Incializar las variables
            costo = pCosto;
            modelo = pModelo;
        }

        public double Costo     { get { return costo; } set { costo = value; } }
        public double Tenencia  { get { return tenencia; } set { tenencia = value; } } 

        //metodo de la interface
        public void CalcularTenencia(double pImpuesto)
        {
            // calcular el impuesto
            tenencia = valor + costo * pImpuesto;
        }

        public void MuestraInformacion()
        {
            // Mostrar la informacion necesaria
            System.Console.WriteLine("Tu Automovil {0}",modelo);
            System.Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            System.Console.WriteLine("Total {0}", costo + tenencia);
            System.Console.WriteLine("-----------------------");
        }

        // Metodo para implementar a ICloneable
        public object Clone()
        {
            Auto temp = new Auto(modelo, costo);
            temp.Tenencia = tenencia;
            return temp;
        }
    }
}
