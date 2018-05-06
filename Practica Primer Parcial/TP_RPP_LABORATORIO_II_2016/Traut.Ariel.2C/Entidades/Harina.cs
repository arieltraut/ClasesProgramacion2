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
        protected bool deConsumo;

        public enum ETipoHarina
        {
            CuatroCeros,
            TresCeros,
            Integral
        }

        //private Harina()
        //{
        //    this.deConsumo = true;
        //}

        public Harina(int codigoBarra, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigoBarra, marca, precio)
        {
            this.tipo = tipo;
            this.deConsumo = true;
        }





        public override float CalcularCostoDeProduccion
        {
            get { return this.Precio * 0.60f; }
        }




        private string MostrarHarina()
        {
            return string.Format("{0}\tTipo: {1}\n",
               this, this.tipo.ToString());
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }
    }
}
