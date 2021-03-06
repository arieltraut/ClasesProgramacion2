﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #region Constructores
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;    
        }
        #endregion


        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool x = this + value;
            } 
        }

        #region Sobrecargas

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c)
                return false;
            n.clientes.Enqueue(c);
            return true;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                    return true;
            }           
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        #endregion

        /*
        public bool operator ~(Negocio n)
        {          
            return this.caja.Atender(n.Cliente); 
        }*/
    }
}
