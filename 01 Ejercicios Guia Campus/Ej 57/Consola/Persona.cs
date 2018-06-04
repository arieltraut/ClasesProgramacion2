using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Consola
{
    public class Persona
    {
        string nombre;
        string apellido;

        public Persona()
        {}
        
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        { 
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        

        public static void Guardar(Persona persona)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));  //Objeto que serializará.  //Se indica el tipo de objeto ha serializar.
                XmlTextWriter writer = new XmlTextWriter(@".\a.xml",Encoding.UTF8);  //Objeto que escribirá en XML.   //Se indica ubicación del archivo XML y su codificación.
                serializer.Serialize(writer, persona);    //Serializa el objeto persona en el archivo contenido en writer.
                writer.Close();     //Se cierra el objeto writer.
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static Persona Cargar()
        {
            Persona persona = new Persona();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona)); 
                XmlTextReader reader = new XmlTextReader(@".\a.xml");
                persona = (Persona)serializer.Deserialize(reader);  
                reader.Close(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return persona;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}",this.nombre,this.apellido);
        }
    }
}
