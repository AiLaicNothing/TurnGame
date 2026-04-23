using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    internal class Inventario
    {
        /*  A  */
O
        public int dinero;

        public List<Unidad> unidades;
        public List<Estructura> estructuras;

        public int maxUnidades;
        public int maxEstructuras;

        public Inventario()
        {
            dinero = 100;

            unidades = new List<Unidad>();
            estructuras = new List<Estructura>();

            maxUnidades = 5;
            maxEstructuras = 3;
        }

        // recibe estructuras creadas
        public bool GuardarEstructura(Estructura e)
        {
            if (estructuras.Count >= maxEstructuras)
            {
                Console.WriteLine("--> Límite de estructuras alcanzado.");
                return false;
            }

            if (dinero < e.precio)
            {
                Console.WriteLine("--> No hay dinero suficiente.");
                return false;
            }

            dinero -= e.precio;
            estructuras.Add(e);

            return true;
        }

        // recibe unidades creadas
        public bool GuardarUnidad(Unidad u)
        {
            if (unidades.Count >= maxUnidades)
            {
                Console.WriteLine("--> Límite de unidades alcanzado.");
                return false;
            }

            if (dinero < u.precio)
            {
                Console.WriteLine("--> No hay dinero suficiente.");
                return false;
            }

            dinero -= u.precio;
            unidades.Add(u);

            return true;
        }

        // actualiza min/max - mantenimientp
        public void AumentarCapacidad(int unidadesExtra, int estructurasExtra)
        {
            maxUnidades += unidadesExtra;
            maxEstructuras += estructurasExtra;
        }
 
        public void GenerarDinero()
        {
            foreach (var e in estructuras)
            {
                if (e is EstructuraRecoleccion reco)
                {
                    dinero += reco.oroPorTurno;
                }
            }
        }

        public void Limpiar()
        {
            for (int i = 0; i < estructuras.Count; i++)
            {
                if (estructuras[i].vida <= 0)
                {
                    estructuras.RemoveAt(i);
                    i--; 
                }
            }

            for (int i = 0; i < unidades.Count; i++)
            {
                if (unidades[i].vida <= 0)
                {
                    unidades.RemoveAt(i);
                    i--; 
                }
            }
        }
    }
