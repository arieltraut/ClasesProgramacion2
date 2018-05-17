using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_42
{
    class Excepcion : DivideByZeroException
    {
        public Excepcion(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
