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
        // Delegado del evento
        public delegate void DelegadoEstado(); //ver parametros
        // Evento del tipo del delegado
        public event DelegadoEstado EventoQueGenera;

      
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
        
        private string direccionEntrega;
        EEstado estado;
        private string trackingID;

        #region Constructor
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
            this.estado = EEstado.Ingresado;
            this.EventoQueGenera += InformaEstado;
        }
        #endregion

        
        #region Propiedades
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }
        #endregion

        #region Metodos
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return String.Format("{0} para {1}", ((Paquete)elemento).trackingID, ((Paquete)elemento).direccionEntrega);
        }

        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(10000);
                Estado = (Estado == EEstado.Ingresado) ? EEstado.EnViaje : EEstado.Entregado;
                EventoQueGenera();

            } while (Estado != EEstado.Entregado);
            //falta guardar paquete en base de datos con evento
        }

        /// <summary>
        /// Generará un evento en el tiempo dado en el constructor
        /// </summary>
        public void InformaEstado()
        {

        }
        #endregion

        #region Operators & Override
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;
            return (p1.TrackingID == p2.TrackingID);
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
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
