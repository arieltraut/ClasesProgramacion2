using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo:IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }
        
        



        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }




        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura = (this.UnidadesDeEscritura - (texto.Length * 0.3f));
            EscrituraWrapper retorno = new EscrituraWrapper(texto,this.Color);
            return retorno;
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;

        }

        public override string ToString()
        {
            return string.Format("Es Boligrafo\tColor: {0}\tTamanio mina: {1}\n", Color, UnidadesDeEscritura);
        }

    }
}
