using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        private List<Empleado> nominaEmpleados;
        private string razonSocial;
        private string direccion;
        private float ganancias;



        public List<Empleado> NominaEmpleados
        { 
            get { return this.nominaEmpleados; }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
            set
            {
                this.razonSocial = value;
            }
        }
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
        public float Ganancias
        {
            get
            {
                return this.ganancias;
            }
            set
            {
                this.ganancias = value;
            }
        }




        public Empresa()
        {
            this.nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial,string direccion,float ganancias) : this()
        {
            this.razonSocial = razonSocial;
            this.direccion = direccion;
            this.ganancias = ganancias;
        }




        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            foreach (Empleado aux in empresa.NominaEmpleados)
            {
                if (aux == empleado)
                    return empresa;
            }
            empresa.NominaEmpleados.Add(empleado);
            return empresa;
        }

        public string MostrarEmpresa()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("La empresa {0} sita en la calle {1} cuenta con ganancias por {2} y con {3} empleados:\n",this.RazonSocial, this.Direccion,
                this.Ganancias.ToString(), this.NominaEmpleados.Count.ToString());
            foreach(Empleado empleado in this.NominaEmpleados)
            {
                sb.AppendLine("NOMBRE: "+ empleado.Nombre);
                sb.AppendLine("APELLIDO: "+ empleado.Apellido);
                sb.AppendLine("LEGAJO: "+ empleado.Legajo);
                sb.AppendLine("SALARIO: "+ empleado.Salario.ToString());
            }
            return sb.ToString(); 
        }

    }
}
