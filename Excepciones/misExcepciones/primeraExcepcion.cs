using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misExcepciones
{
    public class primeraExcepcion:Exception
    {

        public primeraExcepcion(string mensaje): base(mensaje)
        {

        }

        public primeraExcepcion(string mensaje, Exception desencadenante): base(mensaje)
        {

        }












    }
}
