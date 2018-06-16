using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Entidades
{
    public class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            this.filaClientes = new List<string>();
        }
        
         
        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
        }

        public void AtenderClientes()
        {
            foreach (string cliente in this.filaClientes)
            {
                Console.WriteLine("Nombre: {0}\t Caja: {1}",cliente, Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }

    
    }
}
