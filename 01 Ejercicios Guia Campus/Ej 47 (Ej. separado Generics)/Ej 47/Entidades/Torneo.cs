using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private T a;
        private string nombre;


        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T aux in torneo.equipos)
            {
                if (Object.Equals(aux,equipo))
                    return true;
            }    
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo == equipo)
                return torneo;

            torneo.equipos.Add(equipo);
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\t{1}\n", this.a.ToString(), this.nombre);
            foreach (T equipo in this.equipos)
            {
                sb.AppendLine(equipo.ToString());
            }

            return sb.ToString();
        }

        private string CalcularPartido<T, T>(T a, T b) where T : Equipo
        {
            Random r = new Random();
            //r.Next(
            return String.Format("{0}{1} - {2}{3}" ;
        }
    }
}
