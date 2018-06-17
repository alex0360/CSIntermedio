using System;

namespace Programa4_4SerialiComposionBinary.Clases
{
    [Serializable]
    public class Motor
    {
        private int cilindros;
        private int hp;

        public int Cilindros { get { return cilindros; } set { cilindros = value; } }
        public int HP { get { return hp; } set { hp = value; } }

        public Motor()
        {
            cilindros = 2;
            hp = 200;
        }

        public void ShopMotor() {
            Console.WriteLine("Motor***\nCilindros:{0},\nHP:{1}", Cilindros, HP);
        }
    }
}
