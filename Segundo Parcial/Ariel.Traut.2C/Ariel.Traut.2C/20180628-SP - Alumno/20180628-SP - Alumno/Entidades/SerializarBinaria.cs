using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Excepciones;

namespace Entidades
{
    public class SerializarBinaria : IArchivos<Votacion>
    {
        public bool Guardar(string ruta, Votacion objeto)
        {
            try
            {
                FileStream fs = new FileStream(ruta, FileMode.Create);
                BinaryFormatter ser = new BinaryFormatter();

                ser.Serialize(fs, objeto);

                fs.Close();
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException("No se pudo guardar el archivo",ex);
            }

            return true;
        }

        public Votacion Leer(string nombre)
        {
            Votacion aux = new Votacion();
            try
            {
                FileStream fs = new FileStream(nombre, FileMode.Open);
                BinaryFormatter ser = new BinaryFormatter();
                aux = (Votacion)ser.Deserialize(fs);

                fs.Close();
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException("No se pudo leer el archivo", ex);
            }
            return aux; //ver
        }
    }
}
