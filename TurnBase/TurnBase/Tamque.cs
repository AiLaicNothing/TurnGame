using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    public class Tanque : Unidad
    {
        public Tanque() : base("Tank", 100, 200, 40) { }

        public override void Attack(IObjetivo target)
        {
            if (target is Soldado || target is Estructura)
            {
                Console.WriteLine($"{Name} attacks {target.GetType().Name} for {Damage}");
                target.TakeDamage(Damage);
            }
            else
            {
                Console.WriteLine($"{Name} cannot attack {target.GetType().Name}");
            }
        }
    }
}
