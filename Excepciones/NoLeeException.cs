using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoLeeException:Exception
    {
        private static string _mensajeBasse = "No se a podido leer el archivo";

        public NoLeeException() : base(_mensajeBasse) { }
        public NoLeeException(Exception ex) : base(ex.Message) { }
        public NoLeeException(string message):base(message){}
    }
}
