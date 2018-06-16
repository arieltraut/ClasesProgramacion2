using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio negocio = new Negocio(new Caja(), new Caja());

            negocio.Clientes.AddRange(new string[] {"cliente1", "cliente2", "cliente3", "cliente4"});

            Thread asignarCaja = new Thread(negocio.AsignarCaja);
            asignarCaja.Start();

            
            asignarCaja.Join();

            Thread atenderClientesCaja1 = new Thread(negocio.Caja1.AtenderClientes);
            atenderClientesCaja1.Name = "caja1";
            atenderClientesCaja1.Start();

            Thread atenderClientesCaja2 = new Thread(negocio.Caja2.AtenderClientes);
            atenderClientesCaja2.Name = "caja2";
            atenderClientesCaja2.Start();

            Console.ReadKey();


            




        }
    }
}
