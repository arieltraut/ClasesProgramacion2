using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traut.Ariel._2C
{

    
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }




        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Documento
        {
            get { return this.documento; }
            set { this.documento = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }





        public virtual string ExponerDatos()
        {
            return String.Format("Nombre: {0}\tApellido: {1}\tDocumento: {2}", Nombre, Apellido, Documento);
        }

        protected abstract bool ValidarDocumentacion(string doc);
    }
}
