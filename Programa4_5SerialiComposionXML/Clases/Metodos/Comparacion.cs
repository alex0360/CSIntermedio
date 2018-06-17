namespace Programa4_5SerialiComposionXML.Clases.Metodos
{
    public class Comparacion
    {
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
        public bool isNumber(string readValue)
        {
            System.Text.RegularExpressions.Regex isnumber =
                new System.Text.RegularExpressions.Regex("[^0-9]");
            return !isnumber.IsMatch(readValue);
        }
    }
}
