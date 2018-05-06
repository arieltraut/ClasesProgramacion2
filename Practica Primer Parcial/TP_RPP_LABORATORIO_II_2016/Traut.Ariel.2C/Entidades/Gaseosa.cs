using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        protected float litros;
        protected bool deConsumo;

        ////private Jugo()
        ////{
        ////    this.deConsumo = true;
        ////}

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoBarra, marca, precio)
        {
            this.litros = litros;
            this.deConsumo = true;
        }

        public Gaseosa(Producto p, float litros)
            : this((int)p, p.Precio, p.Marca, litros)
        {
            this.litros = litros;
            this.deConsumo = true;
        }



        public override float CalcularCostoDeProduccion
        {
            get { return this.Precio * 0.42f; }
        }




        private string MostrarGaseosa()
        {
            return string.Format("{0}\tLitros: {1}\n",
               this, this.litros);
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }

        public override string Consumir()
        {
            return "Bebible";
        }
    }
}
