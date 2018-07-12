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
            //Producto producto = ProductoDAO.ObtieneProducto(2); //Obtiene directo de tabla con id
            foreach (Producto aux in lista)
            {
                if(aux.ProductId.ToString() == comboBox1.SelectedItem.ToString())
                    richTextBox1.Text = aux.ToString();
            }
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto("Juan","amarillo");   //modificar para que cargue en lista antes y luego en base
            ProductoDAO.InsertaProducto(producto1);
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            Form1_Load(sender, e);
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
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            Form1_Load(sender, e);

        }
    }
}
