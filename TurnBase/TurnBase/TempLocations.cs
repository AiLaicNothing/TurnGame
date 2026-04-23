using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    internal class TempLocation:TempBase
    {
        private string name;
        private int price;
        private int hp;
        private int dmg;
        private int speed;
        public TempLocation(string name, int price, int hp, int dmg)
        {
            this.name = name;
            this.price = price;
            this.hp = hp;
            this.price = price;
        }
        public override void data()
        {
            Console.WriteLine("Data:" + name + "," + price + "," + hp + "," + dmg);
        }
    }
}
