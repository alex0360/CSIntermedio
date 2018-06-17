namespace Programa4_4SerialiComposionBinary.Clases.Metodos
{
    class Write
    {
       string valor;
        Comparacion e = new Comparacion();

        public void Crear(int opcion)
        {
            string error = "";

            // Crear la instancia
            if (e.Evento(opcion))
            {
                string modelo = "";
                double costo = 0;

                System.Console.WriteLine("Dame el modelo");
                valor = System.Console.ReadLine();
                if (e.Evento(valor))
                {
                    modelo = valor;
                    valor = "";
                }
                else error = "El modelo es nulo. \n";

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

                if (e.Evento(error))
                {
                    System.Console.Clear();
                    System.Console.WriteLine(modelo + " " + valor + " " + error);
                }
                else
                {
                    Auto auto = new Auto(modelo, costo);
                    System.Console.Clear();
                    System.Console.WriteLine("Auto a serializar");
                    auto.showInfo();
                    Crear("Auto.aut", auto);
                }
            }
        }

        private void Crear(System.String name, Auto auto)
        {
            // Instaciamos el formatiador de tipo Binary
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter fomatiador
                = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            // Creamos el stream
            System.IO.Stream stream =
                new System.IO.FileStream(
                    name,
                    System.IO.FileMode.Create,
                    System.IO.FileAccess.Write,
                    System.IO.FileShare.None);

            // Serializando
            fomatiador.Serialize(stream, auto);

            // Seramos la Steam
            stream.Close();
        }
    }
}
