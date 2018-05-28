using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz:IAcciones
    {
        private float tamanioMina;
        
        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }
        
        



        public ConsoleColor Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }



        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.UnidadesDeEscritura = (this.UnidadesDeEscritura - (texto.Length * 0.1f));
            EscrituraWrapper retorno = new EscrituraWrapper(texto,this.Color);
            return retorno;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException(); 
        }

        public override string ToString()
        {
            return string.Format("Es Lapiz\tColor: {0}\tTamanio mina: {1}\n", Color, UnidadesDeEscritura);
        }
    }
}
