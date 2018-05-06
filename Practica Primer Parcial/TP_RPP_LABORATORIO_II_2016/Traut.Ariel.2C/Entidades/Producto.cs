using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int codigoBarra;
        protected EMarcaProducto marca;
        protected float precio;


        public enum EMarcaProducto
        {
            Manaos,
            Pitusas,
            Naranjú,
            Diversión,
            Swift,
            Favorita
        }

        public enum ETipoProducto
        {
            Galletita,
            Gaseosa,
            Jugo,
            Harina,
            Todos
        }




        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this.codigoBarra = codigoBarra;
            this.marca = marca;
            this.precio = precio;
        }



        public EMarcaProducto Marca
        {
            get { return this.marca; }
        }

        public float Precio
        {
            get { return this.precio; }
        }

        public abstract float CalcularCostoDeProduccion
        {
            get;
        }





        private string MostrarProducto(Producto p)
        {
            return string.Format("C.Barra: {0}\tMarca: {1}\tPrecio: {2}", 
                p.codigoBarra, p.Marca, p.Precio);
        }


        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }







        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            if(prodUno.Equals(prodDos) && prodUno.Marca == prodDos.Marca && prodUno.codigoBarra == prodDos.codigoBarra)
                return true;
            return false;
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }


        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            return (prodUno.Marca == marca) ? true : false; 
                //(Enum.IsDefined(Producto.EMarcaProducto,prodUno.marca)); //////////////////////////////ver
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        public static explicit operator int(Producto p)
        {
            return p.codigoBarra;
        }

        public static implicit operator string(Producto p)
        {
            return p.MostrarProducto(p);
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType()) ? true : false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        } 
    }
}
