using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Muebles
    {
        public int tamaño;
        public string material;
        public int peso;

        public Muebles(int tam, string mat, int peso)
        {
            this.tamaño = tam;
            this.material = mat;
            this.peso = peso;
        }
    }
}
