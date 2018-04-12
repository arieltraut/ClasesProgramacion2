using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar; //static


        #region Get

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar; // ver this
        }

        #endregion

        #region Constructores

        //private Pesos();

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Operators

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar (p.GetCantidad()/Pesos.GetCotizacion());    
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar d = new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        #endregion

        #region Suma y Resta

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos resultado = new Pesos((d.GetCantidad() * Pesos.GetCotizacion()) + p.GetCantidad());
            return resultado;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos resultado = new Pesos((d.GetCantidad() * Pesos.GetCotizacion()) - p.GetCantidad());
            return resultado;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() * Euro.GetCotizacion());
            Pesos resultado = new Pesos(d.GetCantidad() * Pesos.GetCotizacion() + p.GetCantidad());
            return resultado;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() * Euro.GetCotizacion());
            Pesos resultado = new Pesos(d.GetCantidad() * Pesos.GetCotizacion() - p.GetCantidad());
            return resultado;
        }

        #endregion

        public static bool operator !=(Pesos p, Dolar d)
        {
            bool retorno = true;
            if (object.ReferenceEquals(p.GetCantidad(), d.GetCantidad() * Pesos.GetCotizacion()))// ver
                retorno = false;
            return retorno;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return !(p != d);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            bool retorno = true;
            if (p1.GetCantidad() == p2.GetCantidad())
                retorno = false;
            return retorno;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return !(p1 != p2);
        }



    }
}
