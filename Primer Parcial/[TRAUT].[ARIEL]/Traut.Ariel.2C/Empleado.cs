using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traut.Ariel._2C
{
    public class Empleado : Persona
    {
        private Departamentos departamento;
        private short piso;


        public Empleado(string nombre, string apellido, string documento, short piso, Departamentos departamento)
            : base(nombre, apellido, documento)
        {
            this.departamento = departamento;
            this.piso = piso;
        }




        public string PisoDepartamento
        {
            get { return String.Format("{0}º{1}",this.piso.ToString(),this.departamento.ToString()); }
        }





        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
            {
                //doc.Remove(2,1);
                //doc.Remove(7,1);
                retorno = true;
            }

            return retorno;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\tPiso Departamento: {1}\n", base.ExponerDatos(), this.PisoDepartamento);
            
            return sb.ToString();
        }


    }
}
