using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2<T,U> where T : Lapiz where U : Boligrafo
    {
        List<T> lapices;
        List<U> boligrafos;

        public Cartuchera2()
        {
            lapices = new List<T>();
            boligrafos = new List<U>();
        }


        public bool ProbarElementos()
        {
            bool retorno = false;
            foreach (Lapiz aux in this.lapices)
            {
                if (((IAcciones)aux).UnidadesDeEscritura >= 1)
                    ((IAcciones)aux).Escribir("vacaciones"); //0.1 por caracter
                else
                    retorno = false;

                if (((IAcciones)aux).UnidadesDeEscritura < 1)
                    ((IAcciones)aux).Recargar(1);
            }


            foreach (Boligrafo aux in this.boligrafos)
            {
                if (aux.UnidadesDeEscritura >= 1)
                    aux.Escribir("dos"); //0.3 por caracter
                else
                    retorno = false;

                if (aux.UnidadesDeEscritura < 1)
                    aux.Recargar(1);
            }

            return retorno;
        }

    }
}
