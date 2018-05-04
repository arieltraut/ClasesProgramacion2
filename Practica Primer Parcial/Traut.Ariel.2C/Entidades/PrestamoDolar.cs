using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;


        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
            : base(prestamo.Monto, prestamo.Vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
            : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }


        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

            
        private float CalcularInteres()
        {
            float retorno = 0;
            switch (this.Periodicidad)
            {
                case (PeriodicidadDePagos.Mensual):
                    retorno = this.Monto + ((this.Monto * 25) / 100);
                    break;
                case (PeriodicidadDePagos.Bimestral):
                    retorno = this.Monto + ((this.Monto * 35) / 100);
                    break;
                case (PeriodicidadDePagos.Trimestral):
                    retorno = this.Monto + ((this.Monto * 40) / 100);
                    break;
            }        
            return retorno;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int diferencia = (int)((nuevoVencimiento - this.Vencimiento).TotalDays);
            if (diferencia > 0)
                this.monto += (diferencia * 2.5f);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\t{1}\t{2}", base.Mostrar(), this.Periodicidad, this.Interes.ToString());
            return sb.ToString();
        }
    }
}
