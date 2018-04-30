using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this ()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = true;
            if (!(Object.ReferenceEquals(e,null)) || !(Object.ReferenceEquals(j,null)))
            {
                foreach (Jugador aux in e.jugadores)
                {
                    if(e.jugadores.Count >= e.cantidadDeJugadores || aux == j)
                    {
                        retorno = false;
                        break;
                    }
                }
                if(retorno == true)
                    e.jugadores.Add(j);
            }
            return retorno;
        }
    }
}
