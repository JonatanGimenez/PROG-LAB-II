using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TV
    {
        public string marca;
        public int pulgadas;
        public int resolucion;

        public TV(string marca, int pulg, int res)
        {
            this.marca = marca;
            this.pulgadas = pulg;
            this.resolucion = res;

        }

        public override bool Equals(object obj)
        {
            return ((TV)obj == this);
        }

        public static bool operator ==(TV tv1, TV tv2)
        {
            return (tv1.marca == tv2.marca && tv1.pulgadas == tv2.pulgadas && tv1.resolucion == tv2.resolucion);
        }

        public static bool operator !=(TV tv1, TV tv2)
        {
           return !(tv1 == tv2);
        }

        public override string ToString()
        {
            StringBuilder retorno;
            retorno = new StringBuilder();

            retorno.AppendLine("marca: " + marca);
            retorno.AppendLine("pulgadas: " + pulgadas);
            retorno.AppendLine("resolucion: " + resolucion);
            
            return retorno.ToString();
        }
    }
}
