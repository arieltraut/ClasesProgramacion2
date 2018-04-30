using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_32
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        #region Constructor

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
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

        public long Dni
        {
            get { return this.partidosJugados; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        
        
#endregion
        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DNI:\t{0}\n", dni.ToString());
            sb.AppendLine("Nombre\t" + nombre);
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
