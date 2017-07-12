using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Local
    {
        protected int _legajo;

        protected abstract int Legajo
        {
            get;
            set;
        }


        /// <summary>
        /// retorna una cadena con el legajo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Legajo: " + this._legajo;
        }

    }
}
