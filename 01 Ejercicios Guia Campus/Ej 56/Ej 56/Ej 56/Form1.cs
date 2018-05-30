using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_56
{
    public partial class Form1 : Form
    {
        string ruta;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open Text File";
            openFile.Filter = "TXT files|*.txt";
            openFile.InitialDirectory = @"C:\";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ruta = openFile.FileName.ToString();
                //MessageBox.Show(openFile.FileName.ToString());
                //richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText); //otra forma

                StreamReader lectura = new StreamReader(openFile.FileName);
                richTextBox1.Text = lectura.ReadToEnd();
                lectura.Close();
            }


        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter guardar = new StreamWriter(ruta);
            guardar.Write(richTextBox1.Text);
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarComo = new SaveFileDialog();

            if (guardarComo.ShowDialog() == DialogResult.OK)
            {
                StreamWriter escritura = new StreamWriter(guardarComo.FileName);
                escritura.Write(richTextBox1.Text);
                escritura.Close();
            }
        }
    }


    
}
