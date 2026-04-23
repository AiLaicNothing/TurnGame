using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    internal class Mina : Estructura
    {
        public int ProduccionPorTurno { get; set; }

        public Mina(string nombre, int vida)
            : base(nombre, "Recolectar", vida)
        {
            ProduccionPorTurno = 10;
        }

        // Esto simula lo que hace la mina en cada turno
        public int ProcesarTurno()
        {
            if (Vida <= 0)
                return 0; // destruida, no produce

            return ProduccionPorTurno;
        }
    }
}

//uso:
//Mina mina = new Mina("Mina de plata", 60);

// cada turno del juego:
//int dinero = mina.ProcesarTurno();
//Console.WriteLine($"La mina generó {dinero} de oro");