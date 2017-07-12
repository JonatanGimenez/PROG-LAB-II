using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoGuardaException:Exception
    {
        public NoGuardaException() : base("No se a podido guardar el archivo.") { }
        public NoGuardaException(string message) : base(message) { }
        public NoGuardaException(string message, Exception ex):base(message, ex){ }
    }
}
