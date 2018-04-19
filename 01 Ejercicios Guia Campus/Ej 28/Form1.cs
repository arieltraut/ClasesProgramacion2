using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, int> miDiccionario = new Dictionary<string, int>();

        private void Calcular_Click(object sender, EventArgs e)
        {
            string[] palabras = richTextBox1.Text.Split(' ');
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            foreach (string palabra in palabras)
            {
                if (miDiccionario.ContainsKey(palabra))
                {
                    int aux = miDiccionario[palabra];
                    aux++;
                    miDiccionario[palabra] = aux;               
                }
                else
                    miDiccionario.Add(palabra,1);
            }
            foreach (KeyValuePair<string, int> entrada in miDiccionario)
            {
                sb.AppendFormat("{0} {1}", entrada.Key, entrada.Value);
                sb.AppendLine();
            }
            sb.AppendLine();
            sb.AppendLine("---------------------------");
            sb.AppendLine();
            
            foreach (var item in miDiccionario.OrderByDescending(r => r.Value).Take(3)) // var == KeyValuePair<string, int>
            {
                sb.AppendFormat("{0} {1}", item.Key, item.Value);
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString());
        }        
    }
}
