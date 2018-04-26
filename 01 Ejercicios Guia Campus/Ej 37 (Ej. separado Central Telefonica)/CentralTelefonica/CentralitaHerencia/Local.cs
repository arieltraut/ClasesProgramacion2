﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base (duracion,destino,origen)
        {
            this.costo = costo;
        }
        
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {  
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\t Costo Local: ${1}", base.Mostrar(), this.CostoLlamada.ToString("0.##"));
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return (this.costo * this.Duracion);
        }


    }
}
