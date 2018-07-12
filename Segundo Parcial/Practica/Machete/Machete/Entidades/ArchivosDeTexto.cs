using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    class ArchivosDeTexto
    {
        public static bool Guardar(string texto, string archivo)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, true)) //append
                {
                    file.WriteLine(texto);
                    file.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
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
