using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantiSumas)
        {
            this.cantidadSumas = cantiSumas;
        }

        public Sumador()
            : this(0)
        {
        }
        

        public int CantidadSumas //propiedad, la creé solo para poder mostrar cuanto vale cantidadSumas
        {
            get
            {
                return cantidadSumas;
            }
        }



        public long Sumar (long a, long b)
        {
            cantidadSumas += 1;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas += 1;
            return a + b;
        }

        explicit operator int Conversion (Sumador s)
        {

        }
    

    }
}
