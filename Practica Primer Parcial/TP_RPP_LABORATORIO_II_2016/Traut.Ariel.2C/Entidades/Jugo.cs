using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        protected ESaborJugo sabor;
        protected bool deConsumo;

        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }

        //private Jugo()
        //{
        //    this.deConsumo = true;
        //}

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            this.sabor = sabor;
            this.deConsumo = true;
        }




        public override float CalcularCostoDeProduccion
        {
            get { return this.Precio * 0.40f; }
        }




        private string MostrarJugo()
        {
            return string.Format("{0}\tSabor: {1}\n",
               this, this.sabor);
        }

        public override string ToString()
        {
            return this.MostrarJugo();
        }

        public override string Consumir()
        {
            return "Bebible";
        }
    }
}
