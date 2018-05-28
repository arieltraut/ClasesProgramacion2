using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cartuchera1
    {
        List<IAcciones> lista = new List<IAcciones>();

        public bool ProbarElementos()
        {
            bool retorno = false;
            foreach (IAcciones aux in this.lista)
            {
                if(aux.UnidadesDeEscritura >= 10)
                {
                    aux.UnidadesDeEscritura -= 10;
                    if(aux.UnidadesDeEscritura < 10)
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
