using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traut.Ariel._2C
{
    public class Jefe : Persona
    {
        private DateTime fechaIngreso;


        public Jefe(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {
        }

        public Jefe(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }



        public int Antiguedad
        {
            get { return (int)((DateTime.Now - this.fechaIngreso).TotalDays); }
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = true;
            if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
            {
                //doc.Remove(2,1);
                //doc.Remove(7,1);
                retorno = true;
            }

            return retorno; ;
        }



    }
}
