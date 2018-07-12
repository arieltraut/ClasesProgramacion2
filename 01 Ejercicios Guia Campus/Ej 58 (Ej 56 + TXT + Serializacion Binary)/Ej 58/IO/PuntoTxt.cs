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

        public bool Guardar(string ruta, string obj)
        {
            StreamWriter escritura = new StreamWriter(ruta); //hacer try/catch
            escritura.Write(obj);
            escritura.Close();
            return true;
        }

        public string Leer(string ruta)
        {
            string retorno;
            StreamReader lectura = new StreamReader(ruta);
            retorno = lectura.ReadToEnd();
            lectura.Close(); 
            return retorno;
        }

    }
}
