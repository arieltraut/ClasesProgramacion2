using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEstante
{
    class Program
    {
        public static int OrdenarProductos(Producto prodUno, Producto prodDos)
        {
            return ((int)prodUno).CompareTo((int)prodDos);
        }
        

        static void Main(string[] args)
        {

            Console.Title = "Primer Parcial Laboratorio II - 2016 -";
            Estante est1 = new Estante(4);
            Estante est2 = new Estante(3);
            Harina h1 = new Harina(102, 37.5f, Producto.EMarcaProducto.Favorita,
            Harina.ETipoHarina.CuatroCeros);
            Harina h2 = new Harina(103, 40.25f, Producto.EMarcaProducto.Favorita,
            Harina.ETipoHarina.Integral);
            Galletita g1 = new Galletita(113, 33.65f, Producto.EMarcaProducto.Pitusas, 250f);
            Galletita g2 = new Galletita(111, 56f, Producto.EMarcaProducto.Diversión, 500f);
            Jugo j1 = new Jugo(112, 25f, Producto.EMarcaProducto.Naranjú, Jugo.ESaborJugo.Pasable);
            Jugo j2 = new Jugo(333, 33f, Producto.EMarcaProducto.Swift, Jugo.ESaborJugo.Asqueroso);
            Gaseosa g = new Gaseosa(j2, 2250f);
            if (!(est1 + h1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + j1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + h2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + j2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            Console.WriteLine("Valor total Estante1: {0}", est1.ValorEstanteTotal);
            Console.WriteLine("Valor Estante1 sólo de Galletitas: {0}",
            est1.GetValorEstante(Producto.ETipoProducto.Galletita));
            Console.WriteLine("Contenido Estante1:\n{0}", Estante.MostrarEstante(est1));
            Console.WriteLine("Estante ordenado por Código de Barra....");
            est1.GetProductos().Sort(Program.OrdenarProductos);
            Console.WriteLine(Estante.MostrarEstante(est1));
            est1 = est1 - Producto.ETipoProducto.Galletita;
            Console.WriteLine("Estante1 sin Galletitas: {0}", Estante.MostrarEstante(est1));
            Console.WriteLine("Contenido Estante2:\n{0}", Estante.MostrarEstante(est2));
            est2 -= Producto.ETipoProducto.Todos;
            Console.WriteLine("Contenido Estante2:\n{0}", Estante.MostrarEstante(est2));
            Console.ReadLine();
                               


            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Jugo jugo = new Jugo(1, 10, Producto.EMarcaProducto.Naranjú, Jugo.ESaborJugo.Asqueroso);

            //Gaseosa gaseosa = new Gaseosa(2, 10, Producto.EMarcaProducto.Manaos, 2);

            //Console.WriteLine(jugo.GetType());
            //Console.WriteLine(gaseosa.GetType());


            ////Console.WriteLine("Jugo es Gaseosa : {0}", jugo.GetType() == gaseosa.GetType());
            ////Console.WriteLine("Jugo es Gaseosa : {0}", jugo.GetType() == typeof(Producto));
            ////Console.WriteLine("Jugo es Gaseosa : {0}", jugo is Producto);

            ////Console.WriteLine(Producto.ETipoProducto.Galletita);
            ////Console.WriteLine(jugo);


            Console.ReadKey();
        }
    }
}
