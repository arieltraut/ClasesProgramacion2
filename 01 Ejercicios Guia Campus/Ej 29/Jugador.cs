using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        #region Constructor

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        #endregion

        public float GetPromedioGoles()
        {
            this.promedioGoles = (partidosJugados == 0) ? 0 : (float)totalGoles / partidosJugados;
            return promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DNI:\t{0}\n", dni.ToString());
            sb.AppendLine("Nombre\t" + nombre);
            sb.AppendLine("P. Jug:\t" + partidosJugados.ToString());
            sb.AppendLine("Goles:\t" + totalGoles.ToString());
            sb.AppendLine("Prom:\t" + GetPromedioGoles().ToString("0.##"));

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Jugador && !Object.ReferenceEquals(obj,null))
            {
                Jugador aux = (Jugador)obj;
                if (dni == aux.dni)
                    return true;
            }
            return false;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Equals(j2);
        }
        
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        } 
    }
}
