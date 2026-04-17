using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    internal class Estructura
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Vida { get; set; }

        public Estructura(string nombre, string tipo, int vida)
        {
            Nombre = nombre;
            Tipo = tipo;
            Vida = vida;
        }

        public void RecibirDanio(int daño)
        {
            Vida = Vida - daño;

            if (Vida < 0)
            {
                Vida = 0;
            }
        }
    }

    // llamar a la clase :
   // Estructura casa = new Estructura("Casa", "Defensa", 100);
    //Estructura mina = new Estructura("Mina", "Recoleccion", 60);