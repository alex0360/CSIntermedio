﻿using System.Xml.Serialization;

namespace Programa4_5SerialiComposionXML.Clases.Metodos
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
                string modelo = "";
                double costo = 0;
                int cilindros = 0;
                int hp = 0;


                Auto auto = new Auto();
                Motor motor = new Motor();

                auto.Modelo = Modelo(modelo);
                auto.Costo = Costo(costo);

                motor.Cilindros = Cilindros(cilindros);
                motor.HP = HP(hp);

                if (!e.Evento(error))
                {
                    auto.Motor = motor;
                    System.Console.Clear();
                    System.Console.WriteLine("Auto a serializar");
                    auto.showInfo();
                    Crear("Auto.aut", auto);
                }
                else
                {
                    System.Console.Clear();
                    System.Console.WriteLine(motor.Cilindros + " " + motor.HP + " " + error);
                }
            }
        }    

        public string Modelo(string modelo) {

            System.Console.WriteLine("Dame el modelo");
            valor = System.Console.ReadLine();
            if (e.Evento(valor))
            {
                modelo = valor;
                valor = "";
            }
            else error = "El modelo es nulo. \n";

            return modelo;
        }
        public double Costo(double costo) {

            System.Console.WriteLine("Dame el Costo");
            valor = System.Console.ReadLine();
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
        public int Cilindros(int cilindros)
        {
            
            System.Console.WriteLine("Dame la cantidad de Cilindros");
                valor = System.Console.ReadLine();
                if (e.Evento(valor))
                {
                    if (e.isNumber(valor))
                    {
                        cilindros = System.Convert.ToInt32(valor);
                    }
                    valor = "";
                }
                else error += "La Cantidad de Cilindors\nNo es un numero \n ";

            return cilindros;
        }
        public int HP(int hp) {

                System.Console.WriteLine("Dame la cantidad de HP");
                valor = System.Console.ReadLine();
                if (e.Evento(valor))
                {
                    if (e.isNumber(valor))
                    {
                        hp = System.Convert.ToInt32(valor);
                    }
                    valor = "";
                }
                else error += "La Cantidad de HP\nNo es un numero \n ";
                
            return hp;
        }

        private void Crear(System.String name, Auto auto)
        {
            // Instaciamos el formatiador de tipo Binary

            XmlSerializer formatiador 
            = new XmlSerializer(typeof(Auto),new System.Type[] { typeof(Motor)});

            // Creamos el stream
            System.IO.Stream stream =
                new System.IO.FileStream(
                    name,
                    System.IO.FileMode.Create,
                    System.IO.FileAccess.Write,
                    System.IO.FileShare.None);

            // Serializando
            formatiador.Serialize(stream, auto);

            // Seramos la Steam
            stream.Close();
        }
    }
}
