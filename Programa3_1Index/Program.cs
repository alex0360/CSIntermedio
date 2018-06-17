namespace Programa3_1Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Clases.Tienda tienda = new Clases.Tienda();

            Clases.Auto miAuto = tienda[1];
            miAuto.ShopInfo();
            System.Console.Write("-------\n");

            for(; n<4; n++)
            {
                tienda[n].ShopInfo();
            }
            System.Console.ReadKey();
        }
    }
}
