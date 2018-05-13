using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        protected ETipoHarina tipo;
        protected static bool deConsumo;

        public enum ETipoHarina
        {
            CuatroCeros,
            TresCeros,
            Integral
        }



        static Harina()
        {
            deConsumo = true;
        }

        public Harina(int codigoBarra, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigoBarra, marca, precio)
        {
            this.tipo = tipo;
        }





        public override float CalcularCostoDeProduccion
        {
            get { return this.Precio * 0.60f; }
        }




        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this);
            sb.AppendFormat("\tTipo: {0}", this.tipo.ToString());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }
    }
}
