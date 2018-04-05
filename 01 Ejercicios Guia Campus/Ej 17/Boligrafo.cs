using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100; //const = constante similar a define (no cambia)
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public void SetTinta(short tinta)
        {
            short aux = (Int16)(this.tinta + tinta); // casting a int16 porque da error sino, no se sabe porque
            if (aux <= cantidadTintaMaxima)
                this.tinta = aux;
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short aux = (Int16)(this.tinta - gasto); // casting a int16 porque da error sino, no se sabe porque
            if (aux > 0)
            {
                this.tinta = aux;
                for(int i=0; <gasto; int++)
                {

                }

            }
            
            return false;
        }

    }
}
