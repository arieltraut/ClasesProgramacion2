using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
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
            sb.AppendLine("Ganancia Total: " + GananciasPorTotal.ToString());
            sb.AppendLine("Ganancia Local: " + GananciasPorLocal.ToString());
            sb.AppendLine("Ganancia Provincial: " + GananciasPorProvincial.ToString());
            sb.AppendLine("--------------Llamadas--------------");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine(llamada.Mostrar().ToString());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}
