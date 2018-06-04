using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_43
{
    class CompetenciaNoDisponibleException : Exception
    {
        string nombreClase;
        string nombreMetodo;


        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje,innerException)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }       
        
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null)
        {
        }




        public string NombreClase
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}:\n",this.NombreMetodo,this.NombreClase);
            sb.AppendLine(this.Message);
            sb.AppendLine(this.InnerException.Message);
            
            return sb.ToString();
        }

    }
}
