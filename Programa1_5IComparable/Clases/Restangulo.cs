namespace Programa1_5IComparable.Clases
{
    class Restangulo:System.IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public Restangulo(double pAncho, double pAlto)
        {
            ancho = pAncho;
            alto = pAlto;
            CalcularArea();
        }

        private void CalcularArea()
        {
            area = ancho * alto;
        }

        public override System.String ToString()
        {
            return string.Format("[{0},{1}]={2}", ancho,alto,area);
        }

        // Implementar de IComparable
        // Se puede poner La Comparacion Con el nivel
        // de complejidad que deciemos
        int System.IComparable.CompareTo(object obj)
        {
            // Hacer type cast con el objeto con el cual nos vamos a comparar
            Restangulo temp = (Restangulo)obj;
            // Si somos mas grandes que el objeto regresar 1
            if (area > temp.area) return 1;
            // Si somos menoer que el objeto regresamos -1
            if (area < temp.area) return -1;
            // Si somos iguales al objeto regresamos 0
            return 0;
        }
    }
}
