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
        protected static bool deConsumo;

        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }

        static Jugo()
        {
            deConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            this.sabor = sabor;
        }




        public override float CalcularCostoDeProduccion
        {
            get { return this.Precio * 0.40f; }
        }




        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendFormat("\tSabor: {0}", this.sabor.ToString());
            return sb.ToString();
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
