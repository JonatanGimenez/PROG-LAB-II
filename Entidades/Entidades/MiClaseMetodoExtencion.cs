using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MiClaseMetodoExtencion
    {
        public static void SetAnchoDeFrente(this Tienda obj, int valor)
        {
            obj.AnchoDeFrente = valor;
        }


    }
}
