using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public PuntoDat()
        { }
        
        
        public string Contenido
        {
            get { return this.contenido; }
            set { this.contenido = value; }
        }
        
        
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



        public bool Guardar(string ruta, PuntoDat obj)
        {

            FileStream fs = new FileStream(ruta, FileMode.Create);
            //Objeto que escribirá en binario. //Se indica ubicación del archivo binario y el modo.
            BinaryFormatter ser = new BinaryFormatter();
            //Objeto que serializará.   //Se crea el objeto serializador.

            ser.Serialize(fs, obj);
            //Serializa el objeto obj en el archivo contenido en fs.

            fs.Close();
            //Se cierra el objeto fs

            return true;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat aux = new PuntoDat();
            if (this.ValidarArchivo(ruta))
            {
                FileStream fs = new FileStream(ruta, FileMode.Open);
                //Objeto que leerá en binario.   //Se indica ubicación del archivo binario y el modo.

                BinaryFormatter ser = new BinaryFormatter();
                //Objeto que Deserializará.   //Se crea el objeto deserializador.

                aux = (PuntoDat)ser.Deserialize(fs);
                //Deserializa el archivo contenido en fs, lo guarda en aux.

                fs.Close();
                //Se cierra el objeto fs.
            }
            return aux;
        }
    


    }
}
