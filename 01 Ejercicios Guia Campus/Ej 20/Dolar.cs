using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        #region Get

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        #endregion

        #region Constructores

        //private Dolar();

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Operaciones

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        /*public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }*/

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        #endregion

        #region Suma y Resta

        /// <summary>
        /// Suma Dolares y Pesos y retorna su resultado en Dolares
        /// </summary>
        /// <param name="m">Objeto Dolar para operar</param>
        /// <param name="c">Objeto Pesos para operar</param>
        /// <returns>Objeto Dolar sumado</returns>
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar resultado = new Dolar((p.GetCantidad() / Pesos.GetCotizacion()) + d.GetCantidad());
            return resultado;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar resultado = new Dolar((p.GetCantidad() / Pesos.GetCotizacion()) - d.GetCantidad());
            return resultado;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar resultado = new Dolar((e.GetCantidad() * Euro.GetCotizacion()) + d.GetCantidad());
            return resultado;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar resultado = new Dolar((e.GetCantidad() * Euro.GetCotizacion()) - d.GetCantidad());
            return resultado;
        }

        #endregion

        #region Igual o Distinto

        public override bool Equals(object obj)
        {
            if (obj is Dolar)
            {
                Dolar temp = (Dolar)obj;
                if (GetCantidad() == temp.GetCantidad())
                    return true;
            }
            return false;
        }
        
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.Equals(d2);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        } 



        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;

            if (d.GetCantidad() == (p.GetCantidad() * Pesos.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;

            if (d.GetCantidad() == (e.GetCantidad() * Euro.GetCotizacion()))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        #endregion
    }
}
