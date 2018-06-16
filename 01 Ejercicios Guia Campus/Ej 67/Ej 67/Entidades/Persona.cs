using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoString(string s);
    
    public class Persona
    {
        string apellido;
        string nombre;

        public Persona(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Mostrar()
        {
            return String.Format("Nombre: {0}\t Apellido: {1}", this.nombre, this.apellido);
        }

    }
}
