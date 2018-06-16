using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public Correo()
        {
 
        }
        
        #region Propiedades
        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }
        #endregion


        #region Metodos
        public void FinEntregas()
        {
            foreach (Thread aux in this.mockPaquetes)
            {
                if (aux.IsAlive)
                    aux.Abort();
            }          
            //Environment.Exit(Environment.ExitCode);
        }
                
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Paquete aux in (List<Paquete>)elementos)
            {
                sb.AppendFormat("{0} para {1} ({2})", aux.TrackingID, aux.DireccionEntrega,
                aux.Estado.ToString()); //ver estado
            }
            return sb.ToString();
        }
        #endregion


        #region Operadores
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete aux in c.Paquetes)
            {
                if (aux == p)
                    throw new TrackingIdRepetidoException("Paquete repetido");
            }
            c.Paquetes.Add(p);
            Thread hiloMock = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hiloMock);            
            hiloMock.Start();
            return c;
        }       
        #endregion

    }
}
