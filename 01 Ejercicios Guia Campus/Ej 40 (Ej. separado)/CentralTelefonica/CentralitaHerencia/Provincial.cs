﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this (llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
        }

        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (this.Duracion) *  0.99f;
                    break;
                case Franja.Franja_2:
                    retorno = (this.Duracion) * 1.25f;
                    break;
                case Franja.Franja_3:
                    retorno = (this.Duracion) * 0.66f;
                    break;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Costo llamada provincial: " + this.CostoLlamada.ToString());
            base.Mostrar();
            return sb.ToString();
        }

    }
}
