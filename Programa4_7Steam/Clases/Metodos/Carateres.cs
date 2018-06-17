namespace Programa4_7Steam.Clases.Metodos
{
    
    class Carateres
    {
        public System.Collections.Generic.List<char> c;

        int cantidad = 0;

        public byte Carater(int p) {
             c = new System.Collections.Generic.List<char>();
            //Numeros
            c.Add('1'); c.Add('2'); c.Add('3'); c.Add('4'); c.Add('5');
            c.Add('6'); c.Add('7'); c.Add('8'); c.Add('9'); c.Add('0');
            //alfabeto
            c.Add('a'); c.Add('b'); c.Add('c'); c.Add('e'); c.Add('f');
            c.Add('g'); c.Add('h'); c.Add('i'); c.Add('j'); c.Add('k');
            c.Add('l'); c.Add('m'); c.Add('n'); c.Add('o'); c.Add('p');
            c.Add('q'); c.Add('r'); c.Add('s'); c.Add('t'); c.Add('u');
            c.Add('v'); c.Add('w'); c.Add('x'); c.Add('y'); c.Add('z');
            Cantidad = c.Count;
                return System.Convert.ToByte(c[p]);
        }
        public int Cantidad { set { cantidad = value; } get { return cantidad; } }
       
    }
}
