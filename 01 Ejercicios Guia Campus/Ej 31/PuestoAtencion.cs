using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej_31
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        public PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        
        public static int NumeroActual
        {
            get
            {
                return numeroActual + 1;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(3000);
            return true;
        }

    }
}
