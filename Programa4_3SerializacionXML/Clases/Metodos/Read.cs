namespace Programa4_3SerializacionXML.Clases.Metodos
{
    class Read
    {
        public void shopRead()
        {
            System.Console.Clear();
            Auto auto = new Auto();
            leer("Auto.aut",auto).showInfo();
        }

        private Auto leer(string name, Auto auto)
        {
            // Instaciamos el formatiador de tipo Binary
            System.Xml.Serialization.XmlSerializer fomatiador
                = new System.Xml.Serialization.XmlSerializer(typeof(Auto));

            // Creamos el stream
            System.IO.Stream stream =
                new System.IO.FileStream(
                    name,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.Read,
                    System.IO.FileShare.None);

            // Deserealizamos
            auto = (Auto)fomatiador.Deserialize(stream);

            // Cerramos la conexion
            stream.Close();

            return auto;
        }
    }
}
