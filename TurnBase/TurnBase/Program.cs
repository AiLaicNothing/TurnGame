using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestUnit t = new TestUnit();

            Console.WriteLine("Initial Health: " + t.Health);

            t.TakeDamage(20);

            Console.WriteLine("After Damage: " + t.Health);

            Console.WriteLine("Is Alive: " + t.IsAlive());

            Console.ReadLine();
        }
    }
    public class TestUnit : Unidad
    {   
        public TestUnit() : base("Test", 0, 100, 10) { }

        public override void Attack(IObjetivo target)
        {
            Console.WriteLine("Attacking...");

        }
    }
}
