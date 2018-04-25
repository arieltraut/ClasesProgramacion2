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
            return (partidosJugados == 0) ? 0 : (float)totalGoles / partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(dni.ToString());
            sb.AppendLine(nombre);
            sb.AppendLine(partidosJugados.ToString());
            sb.AppendLine(totalGoles.ToString());
            sb.AppendLine(GetPromedioGoles().ToString());

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if ((!Object.ReferenceEquals(j1, null)) || !(Object.ReferenceEquals(j2, null)))
                if (j1.dni == j2.dni)
                    return true;
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
