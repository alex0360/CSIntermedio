namespace Programa3_3SobreCargaOperadoresUsuario.Clases
{
    internal class Imaginario
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

        // SobreCarga de operadores de Usuario
        public static Imaginario operator ++(Imaginario i1)
        {
            Imaginario temp = new Imaginario(i1.Entero + 1, i1.imaginario + 1);
            return temp;
        }

        public static Imaginario operator --(Imaginario i1)
        {
            Imaginario temp = new Imaginario(i1.Entero - 1, i1.imaginario -1);
            return temp;
        }

        // SobreCarga de operadores de igualdad y desigualdad

        public override bool Equals(object obj)
        {
            // Verificamos que sea del tipo correcto
            if (obj is Imaginario temp)
            {

                // Comparamos por igualdad
                if (imaginario == temp.Imaginari && entero == temp.Entero)
                    return true;

            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==
            (Imaginario i1, Imaginario i2)
        {
            return i1.Equals(i2);
        }

        public static bool operator !=
            (Imaginario i1, Imaginario i2) {
            return !(i1.Equals(i2));
        }

    }
}
