using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;


        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres)
            : base(prestamo.Monto, prestamo.Vencimiento)
        {
            this.porcentajeInteres = porcentajeInteres;
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }


        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }
        
        private float CalcularInteres()
        {
            return this.Monto + ((this.Monto * porcentajeInteres) / 100);
        }



        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int diferencia = (int)((nuevoVencimiento - this.Vencimiento).TotalDays);
            if(diferencia > 0)
                this.porcentajeInteres += (diferencia * 0.25f);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\t{1}\t{2}",base.Mostrar(),this.porcentajeInteres, this.Interes.ToString());
            return sb.ToString();
        }

    }
}
