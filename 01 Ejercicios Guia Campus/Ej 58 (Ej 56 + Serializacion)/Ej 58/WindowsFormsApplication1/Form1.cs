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
using IO;

namespace Ej_58
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
            openFile.Filter = "TXT files|*.txt|DAT files|*.dat";
            openFile.InitialDirectory = @"C:\";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ruta = openFile.FileName.ToString();
                switch (openFile.FilterIndex)
                {
                    case 1: //selected .txt
                        PuntoTxt leerTxt = new PuntoTxt();
                        richTextBox1.Text = leerTxt.Leer(openFile.FileName);
                        break;
                    case 2: //selected .dat
                        PuntoDat leerDat = new PuntoDat();
                        leerDat = leerDat.Leer(openFile.FileName);
                        richTextBox1.Text = leerDat.Contenido;
                        break;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ruta == null)
                guardarComoToolStripMenuItem_Click(sender, e);
            else
            {
                if (Path.GetExtension(ruta) == ".txt")
                {
                    PuntoTxt guardarTxt = new PuntoTxt();
                    bool aux = guardarTxt.Guardar(ruta, richTextBox1.Text);
                }
                else if (Path.GetExtension(ruta) == ".dat")
                {
                    PuntoDat guardarDat = new PuntoDat();
                    guardarDat.Contenido = richTextBox1.Text;
                    bool aux2 = guardarDat.Guardar(ruta, guardarDat);
                }
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarComo = new SaveFileDialog();
            guardarComo.Filter = "TXT files|*.txt|DAT files|*.dat";

            if (guardarComo.ShowDialog() == DialogResult.OK)
            {
                switch (guardarComo.FilterIndex)
                {
                    case 1: //selected .txt
                        PuntoTxt guardarTxt = new PuntoTxt();
                        bool aux = guardarTxt.Guardar(guardarComo.FileName,richTextBox1.Text);
                        break;
                    case 2: //selected .dat
                        PuntoDat archivoDat = new PuntoDat();
                        archivoDat.Contenido = richTextBox1.Text;
                        bool aux2 = archivoDat.Guardar(guardarComo.FileName,archivoDat);
                        break;
                }
                ruta = guardarComo.FileName;
            }
        }
    }
}
