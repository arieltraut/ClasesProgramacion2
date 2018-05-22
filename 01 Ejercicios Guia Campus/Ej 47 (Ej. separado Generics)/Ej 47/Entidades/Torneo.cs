using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos = new List<T>();
        //private T a;
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
        }


        public string JugarPartido
        {
            get
            {
                T equipoUno, equipoDos;
                Random r = new Random();
                do{
                equipoUno = this.equipos[r.Next(0, this.equipos.Count)];
                equipoDos = this.equipos[r.Next(0, this.equipos.Count)];

                }while(equipoUno == equipoDos);
                return CalcularPartido<T>(equipoUno,equipoDos);
            }
        }





        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T aux in torneo.equipos)
            {
                if (aux == equipo) //Object.Equals(aux,equipo)
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

        public override bool Equals(object obj)
        {
            return (obj is T) ? true : false;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\t\n", this.nombre); //this.a.ToString()
            foreach (T equipo in this.equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido<T>(T a, T b) where T : Equipo
        {
            Random r = new Random();
            return String.Format("{0} {1} - {2} {3}", a.Nombre, r.Next(0,120).ToString(), r.Next(0,120).ToString(), b.Nombre);
        }
    }
}
