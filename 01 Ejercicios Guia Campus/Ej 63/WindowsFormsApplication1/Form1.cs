using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Thread miHilo;

        
        public Form1()
        {
            InitializeComponent();
            //timer1.Enabled = true;
            //timer1.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.miHilo = new Thread(AsignarHora);
            this.miHilo.Start();
        }


        private void AsignarHora()
        {
            while(true)
            {
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate()
                    {
                        this.lblHora.Text = DateTime.Now.ToString();
                    }
                    );
                }
                Thread.Sleep(1000);
            }

        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblHora.Text = DateTime.Now.ToString();
        }
    }
}
