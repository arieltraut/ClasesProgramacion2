using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string documento;
        private string nombre;
        private string apellido;

        public Persona()
        { }

        public Persona(string nombre, string apellido, string documento)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #region Propiedades
        public string Documento
        {
            get { return this.documento; }
            set
            {
                if (ValidarDocumentacion(value))
                    this.documento = value;
            }
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
        #endregion

        #region Metodos
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\tApellido: {1}\tDocumento: {2}\t", this.nombre, this.apellido, this.documento);
            return sb.ToString();
        }


        protected abstract bool ValidarDocumentacion(string doc);

        #endregion
    }
}
