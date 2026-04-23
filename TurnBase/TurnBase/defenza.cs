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
        public bool BloquearDanio()
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

//if (muro.BloquearDanio())
//{
  //  muro.RecibirDanio(daño);
    //Console.WriteLine("defendido");
//}
//else
//{
  //  mina.RecibirDanio(daño);
    //Console.WriteLine("estructuras dañadas");
//}