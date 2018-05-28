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
            bool retorno = true;
            try
            {
                foreach (IAcciones aux in this.lista)
                {
                    if(aux.UnidadesDeEscritura >= 10)
                    {
                        aux.UnidadesDeEscritura -= 10;
                        //aux.Escribir("123456789012345678901234567890");
                        if(aux.UnidadesDeEscritura < 10)
                            aux.Recargar(10);
                    }
                    else
                    {
                        retorno = false;
                    }          
                }
            }
            catch(NotImplementedException e)
            {
                throw e;
            }
            return retorno;
        }
    }
}