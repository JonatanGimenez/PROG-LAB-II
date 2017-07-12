using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoGuardarException:Exception
    {
        public NoGuardarException()
        {

        }

        public NoGuardarException(string message):base(message)
        {

        }

        public NoGuardarException(string message, Exception ex)
            : base(message,ex)
        { }
    }
}
