using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia 
{
    public class Local : Llamada,IGuardar<string>
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base (duracion,destino,origen)
        {
            this.costo = costo;
        }
        
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {  
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\t Costo Local: ${1}", base.Mostrar(), this.CostoLlamada.ToString("0.##"));
            return sb.ToString();
        }


        private float CalcularCosto()
        {
            return (this.costo * this.Duracion);
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public string RutaDeArchivo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Guardar()
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("archivo.txt", true))
                {
                    DateTime fecha = DateTime.Now;
                    file.WriteLine("{0:dddd d }de {0:MMMM }de {0:yyyy h:mm} - Se realizó una llamada", fecha);
                    file.Close();
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public string Leer()
        {
            string retorno = string.Empty;
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader("archivo.txt"))
                {
                    retorno = file.ReadToEnd();
                    file.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;           
        }
    }
}
