using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    public abstract class Unidad : IObjetivo
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Unidad(string name, int price, int health, int damage)
        {
            Name = name;
            Price = price;
            Health = health;
            Damage = damage;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }
    }
}
