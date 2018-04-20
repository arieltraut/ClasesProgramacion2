using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_31
{
    class Cliente
    {
        private string nombre;
        private int numero;

        #region Constructores y Propiedades

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.Nombre = nombre;
        }
        
        
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
        #endregion

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return (Object.ReferenceEquals(c1.Numero,c2.Numero)) ? true : false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
