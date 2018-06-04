using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada,IGuardar<string>
    {
        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this (llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
        }

        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (this.Duracion) *  0.99f;
                    break;
                case Franja.Franja_2:
                    retorno = (this.Duracion) * 1.25f;
                    break;
                case Franja.Franja_3:
                    retorno = (this.Duracion) * 0.66f;
                    break;
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\t Costo Prov:  ${1}", base.Mostrar(), this.CostoLlamada.ToString("0.##"));
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        public override string ToString()
        {
            return Mostrar();
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

        bool IGuardar<string>.Guardar()
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

        string IGuardar<string>.Leer()
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
