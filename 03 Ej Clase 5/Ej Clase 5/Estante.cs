using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Clase_5
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        #region Constructores

        /// <summary>
        /// Inicializo un nuevo estante, inicializando la lista según una capacidad.
        /// </summary>
        /// <param name="capacidad">Cantidad de productos que podrá contener el estante.</param>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        /// <summary>
        /// Inicializo un nuevo Estante, asignando los atributos capacidad y ubicación
        /// </summary>
        /// <param name="capacidad">Cantidad de productos que podrá contener el estante.</param>
        /// <param name="ubicacion">Código de ubicación del Estante</param>
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        #endregion

        /// <summary>
        /// Publico la lista de Productos
        /// </summary>
        /// <returns></returns>
        public Producto[] GetProductos ()
        {
            return this.productos;
        }

        /// <summary>
        /// Muestro los datos del estante elegido
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string MostrarEstante (Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La ubicacion del estante es: " + e.ubicacionEstante);
            Producto[] p = e.GetProductos();
            for (int i = 0; i < p.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(p[i]));
            }
            /* Con forech seria asi:
            foreach (Producto p in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }*/

            return sb.ToString();
        }

        /// <summary>
        /// Analizo si el Producto está en el Estante
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns>True si el Producto está en el Estante</returns>
        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto aux in e.productos)
            {
                // Valido que la posición del Array no sea null
                if (!object.ReferenceEquals(aux, null))
                {  
                    if (aux == p) // Utilizo la sobrecarga del == de Producto
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Analizo si el Producto NO está en el Estante
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns>True si el Producto NO está en el Estante</returns>
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p); // Al negar la sobrecarga == estamos haciendo la inversa
        }


        /// <summary>
        /// Agrego un Producto al Estante, si hay lugar y no hay uno igual ya cargado
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto p)
        {
            // Si el Estante no contiene el Producto...
            if (e != p)
            {
                // Recorro la lista de productos del estante...
                for (int i = 0; i < e.productos.Length; i++)
                {
                    // Busco un espacio vacio
                    if (object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        // Si agregué, rompo el lazo para no volver a agregarlo.
                        return true;
                    }
                }
            }
            // Si no salió hasta acá es porque no agregó el ítem
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (object.ReferenceEquals(e.productos[i], p))
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }       
    }
}
