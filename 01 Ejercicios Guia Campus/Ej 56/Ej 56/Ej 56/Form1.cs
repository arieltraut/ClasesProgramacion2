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
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = theDialog.FileName.ToString();
                MessageBox.Show(theDialog.FileName.ToString());
                //richTextBox1.LoadFile(theDialog.FileName, RichTextBoxStreamType.PlainText); //otra forma
            }
            StreamReader lectura = new StreamReader(theDialog.FileName);

            richTextBox1.Text = lectura.ReadToEnd();
            lectura.Close();
    
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter guardar = new StreamWriter(ruta);
            guardar.Write(richTextBox1.Text);
        }


    }
}
