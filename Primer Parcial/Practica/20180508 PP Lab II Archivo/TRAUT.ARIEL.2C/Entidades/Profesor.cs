using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        
        public int Antiguedad
        {
            get 
            {
                return (int)((DateTime.Now - this.fechaIngreso).TotalDays);
            }
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            // Creo el patrón indicando que tendrá 1 dígito (d{1}) luego guión, luego 3 dígitos, luego guión, luego 2 dígitos
            string patron = "^\\d{2}-\\d{4}-\\d{1}$"; //  XX-XXXX-X
            if (Regex.IsMatch(doc, patron))
            {
                return true;
            }
            return false;
        }

        public override string ExponerDatos()
        {
            return String.Format("{0}\tFecha de ingreso: {1}\n",base.ExponerDatos(),this.fechaIngreso);
        }


    }
}
