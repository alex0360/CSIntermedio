namespace Programa4_7Steam.Clases.Metodos
{
    class Writer
    {

        public Writer(string name)
        {
            Carateres car = new Carateres();
            int n = 0;

            System.IO.Stream fileStream =
                   new System.IO.FileStream(
                       name,
                       System.IO.FileMode.Create,
                       System.IO.FileAccess.Write,
                       System.IO.FileShare.None);

                System.IO.StreamWriter writer = 
                    new System.IO.StreamWriter(fileStream);

            
            for (n=0; n < 35; n++)
            {
                // Ponemos la posicion
                writer.Write(System.Convert.ToChar(car.Carater(n)));
            }
            writer.Close();
            fileStream.Close();
        }
    }
}
