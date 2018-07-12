using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        #region Propiedades
        public string AnioDivision
        {
            get { return String.Format("{0}º{1}", this.anio, this.division); }
        }
        #endregion

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
            return String.Format("{0}Año/Division: {1}\n", base.ExponerDatos(), AnioDivision);
        }
    }
}