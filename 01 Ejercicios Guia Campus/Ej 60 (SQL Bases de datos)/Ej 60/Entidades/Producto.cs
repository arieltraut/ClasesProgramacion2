using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        int productId;
        string name;
        string color;
        List<Producto> listaProductos = new List<Producto>();

        public Producto(string name, string color)
        {
            this.name = name;
            this.color = color;
        }       
        
        public Producto(int productId, string name, string color) : this(name, color)
        {
            this.productId = productId;
        }

        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}\tColor: {1}",this.Name, this.Color);
        }



    }
}
