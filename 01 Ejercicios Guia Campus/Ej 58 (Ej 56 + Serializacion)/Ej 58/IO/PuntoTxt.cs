using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        protected override bool ValidarArchivo(string ruta)
        {
            bool retorno = false;
            try
            {
                base.ValidarArchivo(ruta);
                string extension = Path.GetExtension(ruta);
                if (extension == ".txt")
                    retorno = true;
                else
                    throw new ArchivoIncorrectoException("El archivo no es un txt.");
            }
            catch (FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }

            return retorno;
        }

        bool Guardar(string ruta)
        {
            if (this.ValidarArchivo(ruta))
            {
                StreamWriter escritura = new StreamWriter(ruta);
                escritura.Write(RichTe);
                escritura.Close();
            }

            return true;
        }

    }
}
