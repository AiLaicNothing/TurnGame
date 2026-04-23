using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    public class Helicoptero : Unidad
    {
        public Helicoptero() : base("Helicopter", 150, 150, 50) { }

        public override void Attack(IObjetivo target)
        {
            if (target is Tanque || target is Estructura)
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
