using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        protected override bool ValidarArchivo(string ruta)
        {
            bool retorno = false;
            try
            {
                base.ValidarArchivo(ruta);
                string extension = Path.GetExtension(ruta);
                if (extension == ".dat")
                    retorno = true;
                else
                    throw new ArchivoIncorrectoException("El archivo no es un dat.");
            }
            catch (FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }

            return retorno;
        }


    }
}
