namespace Programa4_7Steam.Clases.Metodos
{
    public class Comparacion
    {
        //1234567890abcefghijklmnopqrstuvwxyz
        public char[] carater;


        public Comparacion(string name)
        {

            if (!System.IO.File.Exists(name))
            {
                Writer writer = new Writer(name);
            }

        }

        public bool Evento(string e)
        {
            if (e != "" && e != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Evento(int e)
        {
            if (e == 1 || e == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Estudiar este codigo mas adelante
        public bool IsNumber(string readValue)
        {
            System.Text.RegularExpressions.Regex isnumber =
                new System.Text.RegularExpressions.Regex("[^0-9]");
            return !isnumber.IsMatch(readValue);
        }
    }
}
