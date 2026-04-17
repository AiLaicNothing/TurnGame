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

        public Estructura(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }
    }
}