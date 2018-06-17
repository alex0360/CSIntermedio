namespace Programa4_6Archivo.Clases.Metodos
{
    class Read
    {
        public void shopRead()
        {
            System.Console.Clear();
            leer("Auto.arc");
        }

        protected void leer(string name)
        {

            // Creamos el stream
            System.IO.Stream stream =
                new System.IO.FileStream(
                    name,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.Read,
                    System.IO.FileShare.None);

            // Deserealizamos
            //Auto auto = (Auto)formatiador.Deserialize(stream);

            // Creamos el Lector
            System.IO.BinaryReader binaryReader = 
                new System.IO.BinaryReader(stream);

            // Leemos en el mismo orden 

            string modelo;
            double costo;
            int cantidad;
            bool disponible;
            byte conteo;

            // Tamando el cuenta el tipo
            modelo = binaryReader.ReadString();
            costo = binaryReader.ReadDouble();
            Auto auto = new Auto(modelo, costo);
            cantidad = binaryReader.ReadInt32();
            disponible = binaryReader.ReadBoolean();
            conteo = binaryReader.ReadByte();

            // Cerramos la conexion
            binaryReader.Close();
            stream.Close();

            Mostrar(auto, cantidad, disponible, conteo);
        }

        protected void Mostrar(Auto auto, int cantidad, bool disponible, byte conteo) {
            auto.showInfo();
            System.Console.WriteLine("Canditida {0}\nDisponible {1}\nContados{2}", cantidad, disponible, conteo);
        }
    }

}
