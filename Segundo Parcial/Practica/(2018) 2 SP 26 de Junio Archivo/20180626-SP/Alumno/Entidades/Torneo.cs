using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Torneo : IEntradaSalida<bool>
    {
        public const int MAX_EQUIPOS_GRUPO = 4; 

        private List<Grupo> grupos;
        private string nombre;
        
        public Torneo(string nombre)
        {
            this.grupos = new List<Grupo>();
            this.nombre = nombre;
        }

        public bool Leer()
        {
            foreach(Grupo grupo in grupos)
            {
                

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Grupo));
                XmlTextReader reader = new XmlTextReader(@".\grupo-{0}.xml");
                grupo = (Grupo)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return grupo;
        }

        public bool Guardar()
        {
            foreach(Grupo grupo in grupos)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Grupo));  //Objeto que serializará.  //Se indica el tipo de objeto ha serializar.
                    string letra = String.Format(@".\grupo-{0}.xml",grupo.Letra);
                    XmlTextWriter writer = new XmlTextWriter(letra, Encoding.UTF8);  //Objeto que escribirá en XML.   //Se indica ubicación del archivo XML y su codificación.
                    serializer.Serialize(writer, grupo);    //Serializa el objeto persona en el archivo contenido en writer.
                    writer.Close();     //Se cierra el objeto writer.
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return true;
        }


    }
}
