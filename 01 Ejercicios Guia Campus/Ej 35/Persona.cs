using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35
{
    class Persona
    {
        private long dni;
        private string nombre;


        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre) : this (nombre)
        {
            this.dni = dni;
        }
        
        
        public long Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DNI:\t{0}\n", dni.ToString());
            sb.AppendLine("Nombre\t" + nombre);
            return sb.ToString();
        }
    }
}
