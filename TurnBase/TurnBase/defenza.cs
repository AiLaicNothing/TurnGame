using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    class defenza : Estructura
    {
        public bool Activa => Vida > 0;

        public defenza(string nombre, int vida)
            : base(nombre, "Defensa", vida)
        {
        }

        // Método que intenta bloquear daño
        public bool Bloquear()
        {
            if (!Activa)
                return false;

            return true;
        }
    }
}



// uso: 
//defenza muro = new EstructuraDefensa("Muro defensor, 80);
//Estructura mina = new Mina("Mina de Oro", 60);

// alguien ataca la mina
//int daño = 30;

//if (muro.Bloquear())
//{
  //  muro.RecibirDaño(daño);
    //Console.WriteLine("defendido");
//}
//else
//{
  //  mina.RecibirDañio(daño);
    //Console.WriteLine("estructuras dañadas");
//}