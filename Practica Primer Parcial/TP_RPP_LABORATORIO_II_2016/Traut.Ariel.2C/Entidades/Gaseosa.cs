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
        protected static bool deConsumo;


        static Gaseosa()
        {
            deConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoBarra, marca, precio)
        {
            this.litros = litros;
        }

        public Gaseosa(Producto p, float litros)
            : this((int)p, p.Precio, p.Marca, litros)
        {
        }



        public override float CalcularCostoDeProduccion
        {
            get { return this.Precio * 0.42f; }
        }




        private string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendFormat("\tLitros: {0}", this.litros.ToString());
            return sb.ToString();
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
