using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TurnBase
{
    internal class TempSoldiers:TempBase
    {
        private string name;
        private int price;
        private int hp;
        private int dmg;
        private int speed;
        public TempSoldiers(string name, int price, int hp, int dmg, int speed)
        {
            this.name = name;
            this.price = price;
            this.hp = hp;
            this.price= price;
            this.speed = speed;
        }
        public override void data()
        {
            Console.WriteLine("Data:" + name + "," + price + "," + hp + "," + dmg + "," + speed);
        }
    }
}
