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
        
        



        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }



        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            ((IAcciones)this).UnidadesDeEscritura = (((IAcciones)this).UnidadesDeEscritura - (texto.Length * 0.1f));
            EscrituraWrapper escrito = new EscrituraWrapper(texto,((IAcciones)this).Color);
            return escrito;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException("No se ha podido recargar el lapiz."); 
        }

        public override string ToString()
        {
            return string.Format("Es Lapiz\tColor: {0}\tTamanio mina: {1}\n", ((IAcciones)this).Color, ((IAcciones)this).UnidadesDeEscritura);
        }
    }
}
