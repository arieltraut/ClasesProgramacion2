using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private EPuestoJerarquico puesto;
        private int salario;

        public enum EPuestoJerarquico
        {
            Administración,
            Gerencia,
            Sistemas,
            Accionista
        }



        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        public string Legajo
        {
            get { return this.legajo; }
        }

        public EPuestoJerarquico Puesto
        {
            get { return this.puesto; }
        }

        public int Salario
        {
            get { return this.salario; }
        }




        public Empleado(string nombre, string apellido, string legajo,
                                EPuestoJerarquico puesto, int salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.puesto = puesto;
            this.salario = salario;
        }




        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return (!Object.ReferenceEquals(e1,null) && !Object.ReferenceEquals(e2,null) ?
                e1.Equals(e2) : false);
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Empleado)
                if (((Empleado)obj).Legajo == this.Legajo)
                    return true;
            return false;
        }

    }
}
