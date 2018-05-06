using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum PeriodicidadDePagos
    {
        Mensual,
        Bimestral,
        Trimestral,
    }

    public enum TipoDePrestamo
    {
        Pesos,
        Dolares,
        Todos,
    }
    
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }

        
        public float Monto
        {
            get{ return this.monto; }  
        }

        public DateTime Vencimiento
        {
            get{ return this.vencimiento; }

            set
            {
                if(value > DateTime.Today) //compare tu fijarse github fecha1.CompareTo(fecha2) return 1 se fecha1 +
                    this.vencimiento = value;
                else
                    this.vencimiento = DateTime.Today;
            }
        }


        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return (p1.Vencimiento.CompareTo(p2.Vencimiento));
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);


        public virtual string Mostrar()
        {
            return string.Format("Monto: {0}\tVencimiento: {1}", this.Monto.ToString(), this.Vencimiento.ToString()); 
        }

    }
}
