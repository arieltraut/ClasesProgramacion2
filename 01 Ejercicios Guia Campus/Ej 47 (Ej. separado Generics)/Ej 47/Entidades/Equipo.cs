using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        string nombre;
        DateTime fechaCreacion;


        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        
        
        public string Nombre
        {
            get { return this.nombre; }
        }


        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion) ? true : false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public override bool Equals(object obj)
        {
            return (Equipo)obj == this;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



        
        public string Ficha()
        {
            return String.Format("{0} fundado el {1}", this.nombre, this.fechaCreacion.ToShortDateString()); 
        }
    }
}
