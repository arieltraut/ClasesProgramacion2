using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35
{
    class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        #region Constructor

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : base (dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        #endregion

        #region Propiedades

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public float PromedioGoles
        {
            get { return (partidosJugados == 0) ? 0 : (float)totalGoles / partidosJugados; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }
        
        
#endregion
        
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.MostrarDatos());
            sb.AppendLine("P. Jug:\t" + partidosJugados.ToString());
            sb.AppendLine("Goles:\t" + totalGoles.ToString());
            sb.AppendLine("Prom:\t" + PromedioGoles.ToString("0.##"));

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Jugador && !Object.ReferenceEquals(obj,null))
            {
                Jugador aux = (Jugador)obj;
                if (Dni == aux.Dni)
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
