using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this ()
        {
            this.razonSocial = nombreEmpresa;
        }


        #region Propiedades

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }
        #endregion

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumLocal = 0, acumProvincial = 0, retorno = 0;            
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    Local auxLocal = (Local)llamada;
                    acumLocal += auxLocal.CostoLlamada;
                }
                else if (llamada is Provincial)
                {
                    Provincial auxProv = (Provincial)llamada;
                    acumProvincial += auxProv.CostoLlamada; 
                }           
            }  
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = acumLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = acumProvincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = acumLocal + acumProvincial;
                    break;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------");            
            sb.AppendLine("Razon Social: " + razonSocial);
            sb.AppendLine("Ganancia Total: \t$" + GananciasPorTotal.ToString("0.##"));
            sb.AppendLine("Ganancia Local: \t$" + GananciasPorLocal.ToString("0.##"));
            sb.AppendLine("Ganancia Provincial: \t$" + GananciasPorProvincial.ToString("0.##"));
            sb.AppendLine("------------------------------------");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine(llamada.ToString());
                
                /*Sin polimorfismo
                /*if (llamada is Local)
                {
                    Local aux = (Local)llamada;
                    sb.AppendLine(aux.ToString());
                }
                else if (llamada is Provincial)
                {
                    Provincial aux = (Provincial)llamada;
                    sb.AppendLine(aux.ToString());
                }*/
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (!Object.ReferenceEquals(nuevaLlamada, null))
                listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach(Llamada aux in c.listaDeLlamadas)
            {
                if(aux == llamada)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
                c.AgregarLlamada(nuevaLlamada);
            else
                throw new CentralitaException("No se pudo cargar, ya existe llamada","c","+");
            return c;
        }
    }
}
