using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
        public float Duracion
        {
            get 
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {          
            return (llamada1.Duracion.CompareTo(llamada2.Duracion));
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.Duracion.ToString());
            sb.AppendLine("Destino: " + this.nroDestino);
            sb.AppendLine("Origen: " + this.NroOrigen);
            return sb.ToString();
        }
    }
}
