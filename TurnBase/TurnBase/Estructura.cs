using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    public class Estructura : IObjetivo
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Estructura(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
