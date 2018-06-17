namespace Programa3_2SobreCargaOperadores.Clases
{
    class Imaginario
    {
        // Atributo
        private double entero;
        private double imaginario;

        // Metodo Constructor o Inicializador
        public Imaginario( double pEntero , double pImaginario)
        {
            entero      = pEntero;
            imaginario  = pImaginario;
        }

        // Propiedades
        public double Entero { get { return entero; } set { entero = value; } }
        public double Imaginari { get { return imaginario; } set { imaginario = value; } }

        // Mover el imaginario y modificacion del ToString
        public override string ToString()
        {
            if (imaginario < 0)
                return string.Format("({0} {1}i)", Entero, Imaginari);
            else
                return string.Format("({0} + {1}i)", Entero, Imaginari);
        }

        // SobreCarga de los operadores + binarios 
        public static Imaginario operator +(Imaginario i1, Imaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero + i2.Entero;
            ri = i1.Imaginari + i2.Imaginari;

            Imaginario temp = new Imaginario(re, ri);
            return temp;
        }

        // SobreCarga de los operadores - binarios 
        public static Imaginario operator -(Imaginario i1, Imaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero - i2.Entero;
            ri = i1.Imaginari - i2.Imaginari;

            Imaginario temp = new Imaginario(re, ri);
            return temp;
        }

        // SobreCarga de los operadores * binarios 
        public static Imaginario operator *(Imaginario i1, Imaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = (i1.entero * i2.entero)-(i1.imaginario *i2.imaginario);
            ri = (i1.entero * i1.imaginario) + (i2.entero * i2.imaginario);

            Imaginario temp = new Imaginario(re, ri);
            return temp;
        }

        // SobreCarga de los operadores / binarios 
        public static Imaginario operator /(Imaginario i1, Imaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = 
                ((i1.entero * i2.entero) + (i1.imaginario * i2.imaginario))
                /((i2.entero * i2.entero) + (i2.imaginario * i2.imaginario));

            ri = ((i1.imaginario * i2.entero) - (i1.Entero * i2.Imaginari))
                / ((i2.entero * i2.entero) + (i2.imaginario * i2.imaginario));

            Imaginario temp = new Imaginario(re, ri);
            return temp;
        }

    }
}
