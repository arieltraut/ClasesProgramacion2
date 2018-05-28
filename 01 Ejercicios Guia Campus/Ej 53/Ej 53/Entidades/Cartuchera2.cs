using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cartuchera2<T,U> where T : Lapiz where U : Boligrafo
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
                if (((IAcciones)aux).UnidadesDeEscritura >= 10)
                {
                    ((IAcciones)aux).UnidadesDeEscritura -= 10;
                    if (((IAcciones)aux).UnidadesDeEscritura < 10)
                        ((IAcciones)aux).Recargar(10);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            foreach (Boligrafo aux in this.boligrafos)
            {
                if (aux.UnidadesDeEscritura >= 10)
                {
                    aux.UnidadesDeEscritura -= 10;
                    if (aux.UnidadesDeEscritura < 10)
                        aux.Recargar(10);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

    }
}
