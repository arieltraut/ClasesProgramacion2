using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormProductos
{
    public partial class Form1 : Form
    {
        List<Producto> lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Producto producto = ProductoDAO.ObtieneProducto(1);
            richTextBox1.Text = producto.ToString(); 
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto("Producto1","rojo");
            ProductoDAO.InsertaProducto(producto1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = ProductoDAO.ObtieneProductos();

            foreach (Producto aux in lista)
            {
                comboBox1.Items.Add(aux.ProductId);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ProductoDAO.EliminaProducto(lista[(int.Parse((comboBox1.SelectedItem).ToString()))]);
            Form1_Load(sender, e);

        }
    }
}
