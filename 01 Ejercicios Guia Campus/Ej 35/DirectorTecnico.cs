using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35
{
    class DirectorTecnico : Persona
    {
        DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) : base (nombre)
        {
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public new string  MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("F. Nac:\t" + this.fechaNacimiento);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is DirectorTecnico && !Object.ReferenceEquals(obj, null))
            {
                DirectorTecnico aux = (DirectorTecnico)obj;
                if (Dni == aux.Dni)
                    return true;
            }
            return false;
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Equals(dt2);
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
