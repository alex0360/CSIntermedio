namespace Programa4_3SerializacionXML
{
    class Program
    {

        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            #region Intancias de Objetos 
            Clases.Metodos.Comparacion e
            = new Clases.Metodos.Comparacion();

            Clases.Metodos.Write write
                = new Clases.Metodos.Write();
            Clases.Metodos.Read read
                = new Clases.Metodos.Read();
            #endregion

            System.Console.WriteLine("1) Crear y guardar un Auto. 2) leer un Auto.");

            valor = System.Console.ReadLine();
            if (e.Evento(valor))
            {
                if (e.isNumber(valor))
                {
                    opcion = System.Convert.ToInt32(valor);
                }
            }
            if (opcion == 1)
                write.Crear(opcion);
            if (opcion == 2)
                read.shopRead();
            System.Console.ReadKey();

        }
    }
}
