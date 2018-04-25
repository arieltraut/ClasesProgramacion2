using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34
{
    class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        public Colores color;
        
        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }

        public VehiculoTerrestre(short cantRuedas, short cantPuertas, Colores color)
        {
            this.cantidadRuedas = cantRuedas;
            this.cantidadPuertas = cantPuertas;
            this.color = color;
        }
    }
}
