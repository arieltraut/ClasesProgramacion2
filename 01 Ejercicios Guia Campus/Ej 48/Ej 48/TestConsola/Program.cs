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
            Contabilidad<Factura, Recibo> miContabilidad = new Contabilidad<Factura, Recibo>();

            Factura factura1 = new Factura(20);
            Factura factura2 = new Factura(21);
            Factura factura3 = new Factura(22);
            Factura factura4 = new Factura(23);

            Recibo recibo1 = new Recibo(1);
            Recibo recibo2 = new Recibo(2);
            Recibo recibo3 = new Recibo(3);
            Recibo recibo4 = new Recibo(4);

            miContabilidad += factura1;
            miContabilidad += factura2;
            miContabilidad += factura3;
            miContabilidad += factura4;
            miContabilidad += recibo1;
            miContabilidad += recibo2;
            miContabilidad += recibo3;
            miContabilidad += recibo4;


            Console.WriteLine(miContabilidad.Mostrar());
            Console.ReadKey();
        }
    }
}
