using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        List<IAcciones> lista = new List<IAcciones>();

        
        public List<IAcciones> Lista
        {
            get { return this.lista; }
        }


        public bool ProbarElementos()
        {
            bool retorno = true;
            try
            {
                foreach (IAcciones aux in this.lista)
                {
                    if(aux.UnidadesDeEscritura >= 1)
                    {
                        if (aux is Lapiz)
                            aux.Escribir("vacaciones"); //0.1 por caracter
                        if (aux is Boligrafo)
                            aux.Escribir("dos");  //0.3 por caracter
                    }
                    else
                    {
                        retorno = false;
                    }

                    if (aux.UnidadesDeEscritura < 1)
                        aux.Recargar(1);
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