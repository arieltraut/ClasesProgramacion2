using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte capacidad;
        protected List<Producto> productos;

        

        private Estante()
        {
            productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this.capacidad = capacidad;
        }



        public float ValorEstanteTotal
        {
            get { return this.GetValorEstante(Producto.ETipoProducto.Todos); }
        }




        public List<Producto> GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad estante: " + e.capacidad);
            foreach (Producto prod in e.productos)
            {
                //if (prod is Jugo)
                //    sb.AppendLine(((Jugo)prod).ToString());
                //else if (prod is Gaseosa)
                //    sb.AppendLine(((Gaseosa)prod).ToString());
                //else if (prod is Galletita)
                //    sb.AppendLine(((Galletita)prod).ToString());
                //else if (prod is Harina)
                //    sb.AppendLine(((Harina)prod).ToString());
                sb.AppendLine(prod);
            }
            return sb.ToString();
        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float acumJugo = 0, acumGaseosa = 0, acumGalle = 0, acumHarina = 0, retorno = 0;
            foreach (Producto prod in this.productos)
            {
                if (prod is Jugo)
                    acumJugo += prod.Precio;
                else if (prod is Gaseosa)
                    acumGaseosa += prod.Precio;
                else if (prod is Galletita)
                    acumGalle += prod.Precio;
                else if (prod is Harina)
                    acumHarina += prod.Precio;
            }
            switch (tipo)
            {
                case Producto.ETipoProducto.Jugo:
                    retorno = acumJugo;
                    break;
                case Producto.ETipoProducto.Gaseosa:
                    retorno = acumGaseosa;
                    break;
                case Producto.ETipoProducto.Galletita:
                    retorno = acumGalle;
                    break;
                case Producto.ETipoProducto.Harina:
                    retorno = acumHarina;
                    break;
                case Producto.ETipoProducto.Todos:
                    retorno = acumJugo + acumGaseosa + acumGalle + acumHarina;
                    break;
            }
            return retorno;
        }




        public static bool operator ==(Estante e, Producto prod)
        {
            foreach (Producto aux in e.productos)
            {
                if (aux == prod)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static bool operator +(Estante e, Producto prod)
        {
            if (e.productos.Count < e.capacidad)
            {
                if (e != prod)
                {
                    e.productos.Add(prod);
                    return true;
                }
            }
            return false;
        }

        public static bool operator -(Estante e, Producto prod)
        {
            if (e == prod)
            {
                e.productos.Remove(prod);
                return true;
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)////////////////////ver
        {
            foreach (Producto prod in e.productos)
            {
                if (prod.GetType().ToString() == tipo.ToString())
                    e.productos.Remove(prod);
            }
            return e;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        } 
    }
}
