using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._42
{
    class UnaException : Exception
    {
        public UnaException(string mensaje, Exception innerException)
            : base(mensaje,innerException)
        {
        }       
        
        public UnaException(string mensaje)
            : this(mensaje, null)
        {
        }
    }
}
