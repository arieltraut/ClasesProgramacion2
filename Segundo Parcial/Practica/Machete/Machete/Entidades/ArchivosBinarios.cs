using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    [Serializable]
    public class ArchivosBinarios
    {
        ArchivosBinarios()
        { }
        
        public bool Guardar(string ruta, Persona obj)
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

        public Persona Leer(string ruta)
        {
            Persona aux = new Persona();

            FileStream fs = new FileStream(ruta, FileMode.Open);
            //Objeto que leerá en binario.   //Se indica ubicación del archivo binario y el modo.

            BinaryFormatter ser = new BinaryFormatter();
            //Objeto que Deserializará.   //Se crea el objeto deserializador.

            aux = (Persona)ser.Deserialize(fs);
            //Deserializa el archivo contenido en fs, lo guarda en aux.

            fs.Close();
            //Se cierra el objeto fs.

            return aux;
        }
    }
}
