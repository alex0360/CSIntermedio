namespace Programa3_1Index.Clases
{
    class Tienda
    {
        private Auto[] disponible;

        public Tienda()
        {
            disponible = new Auto[4];

            disponible[0] = new Auto("Maserati", 220540.56);
            disponible[1] = new Auto("Fit", 3898994.09);
            disponible[2] = new Auto("March", 5682192.45);
            disponible[3] = new Auto("Spark", 8469211.45);
        }
        // Creacion del indixe

        public Auto this[int index]
        {           
            get { if (index > 0 || index < 4) return disponible[index]; else return null; }
            set { disponible[index] = value; }
        }
    }
}
