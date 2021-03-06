﻿namespace Programa4_2SerializacionXML.Clases.Metodos
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
            System.Runtime.Serialization.Formatters.Soap.SoapFormatter fomatiador
                = new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

            // Creamos el stream
            System.IO.Stream stream =
                new System.IO.FileStream(
                    name,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.Read,
                    System.IO.FileShare.None);

            // Deserealizamos
            Auto auto = (Auto)fomatiador.Deserialize(stream);

            // Cerramos la conexion
            stream.Close();

            return auto;
        }
    }
}
