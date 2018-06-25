using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Interfaces;


namespace Entidades
{
    public class InfoHilo
    {
        IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        private static Random randomizer;

        #region Constructores
        InfoHilo()
        {
            randomizer = new Random();
        }

        public InfoHilo(int id, IRespuesta<int> callback) : this()
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(Ejecutar);
            this.hilo.Start();
        }
        #endregion

        #region Metodos
        private void Ejecutar()
        {
            Thread.Sleep(randomizer.Next(1,6));
            callback.RespuestaHilo(this.id);
        }       
        #endregion



    

}
}
