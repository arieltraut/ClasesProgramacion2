using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34
{
    class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantRuedas, short cantPuertas, Colores color,
            short cantMarchas, int cantPasajeros) : base (cantRuedas,cantPuertas,color)
        {
            this.cantidadMarchas = cantMarchas;
            this.cantidadPasajeros = cantPasajeros;
        }

    }
}
