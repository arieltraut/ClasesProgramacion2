using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico
    {
        public enum Especialidad
        {
            Traumatologo,
            Odontologo
        }
                
        #region Constructor
        public MEspecialista(string nombre, string apellido, Especialidad e) : base(nombre, apellido)
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
            Thread.Sleep(tiempoAleatorio.Next(5000,10000));
            this.FinalizarAtencion();
        }
        #endregion
    }
}
