using System;

namespace Programa4_5SerialiComposionXML.Clases
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
            cilindros = Cilindros;
            hp = HP;
        }

        public void ShopMotor() {
            Console.WriteLine("Motor***\nCilindros:{0},\nHP:{1}", cilindros, hp);
        }
    }
}
