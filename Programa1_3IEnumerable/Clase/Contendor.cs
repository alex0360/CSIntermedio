namespace Programa1_3IEnumerable.Clase
{
    class Contendor: System.Collections.IEnumerable
    {
        private int[] valores = new int[10];

        public Contendor()
        {
            for(int n =0; n<10; n++)
            {
                valores[n] = n * n;
            }
        }

        // Implementando el GetEnumerator necesario por IEnumerable
        System.Collections.IEnumerator  
            System.Collections.IEnumerable.GetEnumerator()
        {
            // Instanciamos el enumerador y lo regresamos
            return (new ContenedorEnum(valores));
        }
    }

    class ContenedorEnum : System.Collections.IEnumerator
    { 
        public int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        //metodos de la interface
        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length) return true;
            else return false;
        }

        public void Reset()
        {
            posicion = -1;
        }

        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
    }

}
