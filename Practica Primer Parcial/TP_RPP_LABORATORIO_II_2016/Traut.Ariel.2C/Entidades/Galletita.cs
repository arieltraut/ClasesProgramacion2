using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        protected float peso;
        protected bool deConsumo;

        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }

        //private Galletita()
        //{
        //    this.deConsumo = true;
        //}

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso)
            : base(codigoBarra, marca, precio)
        {
            this.peso = peso;
            this.deConsumo = true;
        }




        public override float CalcularCostoDeProduccion
        {
            get { return this.Precio * 0.33f; }
        }




        private string MostrarGalletita(Galletita g)
        {
            return string.Format("{0}\tPeso: {1}\n",
               g, this.peso);
        }

        public override string ToString()
        {
            return this.MostrarGalletita(this);
        }

        public override string Consumir()
        {
            return "Comestible";
        }
    }
}
