namespace Programa4_7Steam.Clases.Metodos
{
    class Read
    {
        long cantidad = 0;
        long n = 0;
        int valor = 0;


        public Read(string name)
        {
            Comparacion Comprovacion = new Comparacion(name);

            // Creamos el stream
            System.IO.Stream fileStream =
                new System.IO.FileStream(
                    name,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.Read,
                    System.IO.FileShare.None);

            // Obtenemos la cantidad
            cantidad = fileStream.Length;
            System.Console.WriteLine("Catida de {0} Char", cantidad);

            // Leemos byte por byte
            for (; n < cantidad; n++) {
                // Ponemos la posicion
                fileStream.Seek(n, System.IO.SeekOrigin.Begin);
                valor = fileStream.ReadByte();

                System.Console.Write((char)valor+" ");
            }
            fileStream.Close();
        }

    }

}
