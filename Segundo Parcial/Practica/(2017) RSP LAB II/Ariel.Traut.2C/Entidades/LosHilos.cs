using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Interfaces;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        private int id;
        private List<InfoHilo> misHilos;

        // Delegado del evento
        public delegate void DelegadoHilos(string mensaje);
        // Evento del tipo del delegado
        public event DelegadoHilos AvisoFin;


        public LosHilos()
        {
            this.id = 0;
            this.misHilos = new List<InfoHilo>();
        }

        #region Propiedad
        public string Bitacora
        {
            set 
            {
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string ruta = Path.Combine(escritorio, "bitacora.txt");
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(ruta, true))
                    {
                        file.WriteLine(value);
                        file.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            get
            {
                string retorno = string.Empty;
                try
                {
                    string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + "bitacora.txt";
                    using (System.IO.StreamReader file = new System.IO.StreamReader(fullPath)) //@"C:\Users\ariee\Desktop\bitacora.txt"
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
        #endregion

        #region Metodos
        private LosHilos AgregarHilo(LosHilos hilos)
        {
            this.id++;
            this.misHilos.Add(new InfoHilo(hilos.id,hilos));
            return hilos;
        }

        public void RespuestaHilo(int id)
        {
            String mensaje = String.Format("Terminó el hilo {0}.", id);
            Bitacora = mensaje;
            AvisoFin(mensaje);
        }         
        #endregion

        #region Operadores
        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad < 1)
                throw new CantidadInvalidaException();
            else
            {
                do
                {
                    hilos.AgregarHilo(hilos);
                    cantidad--;
                } while (cantidad > 0);
            }
            return hilos;
        }
        #endregion





    }
}
