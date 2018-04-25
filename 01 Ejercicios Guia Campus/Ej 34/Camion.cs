using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34
{
    class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantRuedas, short cantPuertas, Colores color,
            short cantMarchas, int pesoCarga) : base (cantRuedas,cantPuertas,color)
        {
            this.cantidadMarchas = cantMarchas;
            this.pesoCarga = pesoCarga;
        }



    }
}
