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
        protected static bool deConsumo;

        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }

        static Galletita()
        {
            deConsumo = true;
        }


        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso)
            : base(codigoBarra, marca, precio)
        {
            this.peso = peso;
        }




        public override float CalcularCostoDeProduccion
        {
            get { return this.Precio * 0.33f; }
        }




        private string MostrarGalletita(Galletita g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(g);
            sb.AppendFormat("\tPeso: {0}", g.peso.ToString());
            return sb.ToString();
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
