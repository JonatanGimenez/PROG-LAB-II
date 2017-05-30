using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class aulaLlenaExcepcion : Exception
    {

        public aulaLlenaExcepcion() : base()
        { }

        public aulaLlenaExcepcion(string mensaje) : base(mensaje)
        { }
    }
}
