using System.Collections;

namespace Programa1_2IEnumerable.Clases
{
    class Tienda
    {
        private Auto[] disponible;

        public Tienda()
        {
            disponible = new Auto[4];

            disponible[0] = new Auto("Soul", 220000.50);
            disponible[1] = new Auto("Fit", 175600.70);
            disponible[2] = new Auto("March", 168900.00);
            disponible[3] = new Auto("Spark", 160400.40);
        }

        public IEnumerator GetEnumerator()
        {
            // Regresar la estructura que nos interesa que
            // recorra el foreach, esta debe de implementar IEnumerator

            return disponible.GetEnumerator();
        }
    }
}
