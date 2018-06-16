using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        //EEstado estado;
        private string trackingID;

        #region Constructor
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }
        #endregion

        
        #region Propiedades (falta estado)
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        //public EEstado Estado
        //{
        //    get { return this.estado; }
        //    set { this.estado = value; }
        //}

        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }
        #endregion

        #region Metodos
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return String.Format("{0} para {1}", elemento.trackingID, elemento.direccionEntrega);
        }

        public void MockCicloDeVida()
        {
            Thread.Sleep(10000);

        }



        #endregion

        #region Operators & Override (ver ToString)
        public override string ToString(IMostrar<Paquete> elemento) //ver
        {
            return elemento.MostrarDatos(elemento);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;
            return (p1.TrackingID == p2.TrackingID);
        }

        public override bool Equals(object obj)
        {
            return this == (Paquete)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion


    }
}
