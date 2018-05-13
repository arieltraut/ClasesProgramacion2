using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traut.Ariel._2C
{
    public class Oficina
    {
        private Departamentos departamento;
        private List<Empleado> empleados;
        private Jefe jefe;
        private short piso;

        private Oficina()
        {
            empleados = new List<Empleado>();
        }

        public Oficina(short piso, Departamentos departamento, Jefe jefe) : this ()
        {
            this.piso = piso;
            this.departamento = departamento;
            this.jefe = jefe;
        }


        public string PisoDepartamento
        {
            get { return String.Format("{0}º{1}", this.piso.ToString(), this.departamento.ToString()); }
        }






        public static explicit operator string(Oficina o)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Piso Departamento: {0}\tJefe: {1}\n", o.PisoDepartamento, o.jefe.Nombre);
            foreach (Empleado empleado in o.empleados)
            {
                sb.AppendLine(empleado.ExponerDatos());
            }
            return sb.ToString();
        }







        public static bool operator ==(Oficina o, Empleado e)
        {
            if (!Object.ReferenceEquals(o, null) && !Object.ReferenceEquals(e, null))
            {
                if (o.PisoDepartamento == e.PisoDepartamento)
                    return true; 
            }
            return false;
        }

        public static bool operator !=(Oficina o, Empleado e)
        {
            return !(o == e);
        }

        public override bool Equals(object obj) 
        {
            return (this.GetType() == obj.GetType()) ? true : false;
        }


        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static Oficina operator +(Oficina o, Empleado e)
        {
            foreach (Empleado aux in o.empleados)
            {
                if (o == e)
                {
                    o.empleados.Add(aux);
                    return o;
                }
            }
            return o;
        }



    }
}
