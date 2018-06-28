using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        #region Constructor
        public MGeneral(string nombre, string apellido) : base(nombre, apellido)
        {
        }
        #endregion

        #region Metodos
        public void IniciarAtencion(Paciente p)
        {
            Thread hiloAtencion = new Thread(Atender);
            hiloAtencion.Start();
        }

        protected override void Atender()
        {
            Thread.Sleep(tiempoAleatorio.Next(1500,2200));
            this.FinalizarAtencion();
        }
        #endregion

    }
}
