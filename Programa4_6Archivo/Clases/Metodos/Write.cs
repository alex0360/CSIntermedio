using System;

namespace Programa4_6Archivo.Clases.Metodos
{
    class Write
    {
        string valor;
        string error = "";
        Comparacion e = new Comparacion();

        public void Crear(int opcion)
        {
            // Crear la instancia
            if (e.Evento(opcion))
            {
                string modelo="";
                double costo = 0;

                Auto auto = new Auto(Modelo(modelo), Costo(costo));
                if (!e.Evento(error))
                {
                    Console.Clear();
                    auto.showInfo();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El archivo sera guardado");
                    Crear("Auto.arc",auto);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(error);
                  
                }
            }
        }    

        protected string Modelo(string modelo) {

            Console.WriteLine("Dame el modelo");
            valor = Console.ReadLine();
            if (e.Evento(valor))
            {
                modelo = valor;
                valor = "";
            }
            else error = "El modelo es nulo. \n";

            return modelo;
        }
        protected double Costo(double costo) {

            Console.WriteLine("Dame el Costo");
            valor = Console.ReadLine();
            if (e.Evento(valor))
            {
                if (e.isNumber(valor))
                {
                    costo = System.Convert.ToDouble(valor);
                }
                valor = "";
            }
            else error += "El costo es nulo,\nNo es un numero \n ";
            return costo;
        }

        protected void Crear(System.String name, Auto auto)
        {
            int cantidad=3;
            bool disponible=true;
            byte conteo=1;

            // Creamos el stream
            System.IO.Stream stream =
                new System.IO.FileStream(
                    name,
                    System.IO.FileMode.Create,
                    System.IO.FileAccess.Write,
                    System.IO.FileShare.None);

            // Creamos el estritor
            System.IO.BinaryWriter binaryWriter =
                new System.IO.BinaryWriter(stream);

            //Escribimos el atributo del objeto
            binaryWriter.Write(auto.Modelo);
            binaryWriter.Write(auto.Costo);
            //variables locales
            binaryWriter.Write(cantidad);
            binaryWriter.Write(disponible);
            binaryWriter.Write(conteo);

            binaryWriter.Close();
            stream.Close();
        }
    }
}
