namespace Programa4_5SerialiComposionXML.Clases.Metodos
{
    class Read
    {
        public void shopRead()
        {
            System.Console.Clear();
            leer("Auto.aut").showInfo();
        }

        private Auto leer(string name)
        {
            // Instaciamos el formatiador de tipo Binary
            System.Xml.Serialization.XmlSerializer formatiador
                = new System.Xml.Serialization.XmlSerializer(typeof (Auto),new System.Type[] { typeof(Motor)});

            // Creamos el stream
            System.IO.Stream stream =
                new System.IO.FileStream(
                    name,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.Read,
                    System.IO.FileShare.None);

            // Deserealizamos
            Auto auto = (Auto)formatiador.Deserialize(stream);

            // Cerramos la conexion
            stream.Close();

            return auto;
        }
    }
}
