using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Autos
    {
        public string marca;
        public int patente;
        public string color;

        public Autos(string marca, int pat, string color)
        {
            this.marca = marca;
            this.patente = pat;
            this.color = color;
        }
    }
}
