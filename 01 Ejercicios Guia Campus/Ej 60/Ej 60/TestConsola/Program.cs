using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto("Producto1", "rojo");
            ProductoDAO.InsertaProducto(producto1);
            Console.WriteLine(producto1.Name + producto1.Color);
            Console.ReadKey();
        }
    }
}
