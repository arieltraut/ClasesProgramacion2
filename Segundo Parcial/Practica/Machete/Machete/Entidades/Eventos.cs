using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Eventos
    {
        // Delegado del evento
        public delegate void DelegadoEstado(object sender, EventArgs e);
        // Evento del tipo del delegado
        public event DelegadoEstado InformaEstado;
    }
}
