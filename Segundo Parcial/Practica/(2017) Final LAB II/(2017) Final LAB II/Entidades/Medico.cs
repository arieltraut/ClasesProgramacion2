using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        // Delegado del evento
        public delegate void FinAtencionPaciente(Paciente p, Medico m);  //object sender, EventArgs e
        // Evento del tipo del delegado
        public event FinAtencionPaciente AtencionFinalizada;

        #region Atributos
        private Paciente pacienteActual;
        protected static Random tiempoAleatorio;
        #endregion


        #region Constructores
        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido) : base (nombre, apellido)
        {
        }
        #endregion



        #region Propiedades
        public virtual string EstaAtendiendoA
        {
            get { return this.pacienteActual.ToString(); }
        }

        public Paciente AtenderA
        {
            set { this.pacienteActual = value; }
        }
        #endregion



        #region Metodos
        protected abstract void Atender();

        protected void FinalizarAtencion()
        {
            AtencionFinalizada(this.pacienteActual,this);
            this.pacienteActual = null;
        }
        #endregion
    }
}
