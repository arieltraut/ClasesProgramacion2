using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Clase_5
{
    class Producto
    {
        protected string codigoDeBarra;
        protected string marca;
        protected float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Codigo de barra: " + p.codigoDeBarra);
            sb.AppendLine("Marca: " + p.marca);
            sb.AppendLine("Precio: " + p.precio);
            sb.AppendLine("-------------");
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (!(object.ReferenceEquals(p1, null)) && !(object.ReferenceEquals(p2, null)))
            {
                if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                    retorno = true;
                else
                    retorno = false;
            }
            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                return false;
            else
                return true;
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (p.marca == marca)
                return true;
            else
                return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            if (p.marca == marca)
                return false;
            else
                return true;
        }



    }
}
