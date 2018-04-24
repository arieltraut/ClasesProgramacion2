using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_33
{
    class Libro
    {
        private List<string> paginas = new List<string>();

        public string this[int i]
        {
            get
            {
                return (i > paginas.Count || i < 0) ? "" : paginas[i]; 
            }

            set
            {
                if (i >= paginas.Count)
                    paginas.Add(value);
                else if (i >= 0) 
                    paginas[i] = value;
            }
        }
    }
}
