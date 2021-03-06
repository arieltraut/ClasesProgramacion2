﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
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

        //private Euro();

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Operaciones

        public static explicit operator Pesos(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() * Euro.GetCotizacion());
            return new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.GetCotizacion());
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        #endregion

        #region Suma y Resta

        /// <summary>
        /// Suma Dolares y Pesos y retorna su resultado en Dolares
        /// </summary>
        /// <param name="m">Objeto Dolar para operar</param>
        /// <param name="c">Objeto Pesos para operar</param>
        /// <returns>Objeto Dolar sumado</returns>
        public static Euro operator +(Euro e, Pesos p)
        {
            Dolar d = new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
            return new Euro(d.GetCantidad() * Euro.GetCotizacion() + e.GetCantidad());
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Dolar d = new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
            return new Euro(d.GetCantidad() * Euro.GetCotizacion() - e.GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro((d.GetCantidad() * Euro.GetCotizacion()) + e.GetCantidad());
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro((d.GetCantidad() * Euro.GetCotizacion()) - e.GetCantidad());
        }

        #endregion

        #region Igual o Distinto

        public override bool Equals(object obj)
        {
            if (obj is Euro)
            {
                Euro temp = (Euro)obj;
                if (GetCantidad() == temp.GetCantidad())
                    return true;
            }
            return false;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.Equals(e2);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }        
        

        public static bool operator ==(Euro e, Pesos p)
        {
            bool retorno = false;
            Dolar d = new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
            if (object.ReferenceEquals(e.GetCantidad(), (d.GetCantidad() * Dolar.GetCotizacion())))
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            if (e.GetCantidad() == (d.GetCantidad() * Euro.GetCotizacion()))
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(d == e);
        }



        #endregion
    }
}
