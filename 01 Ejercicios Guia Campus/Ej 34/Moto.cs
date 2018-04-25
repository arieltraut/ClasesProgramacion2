using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34
{
    class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantRuedas, short cantPuertas, Colores color,
            short cilindrada) : base (cantRuedas,cantPuertas,color)
        {
            this.cilindrada = cilindrada;
        }

    }
}
