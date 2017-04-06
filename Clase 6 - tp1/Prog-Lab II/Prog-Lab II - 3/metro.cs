using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Lab_II___3
{
    class metro
    {
        public int cantidad;

        private metro(int cantidad)
        {
            this.cantidad = cantidad;
        }

        //casteo con conversion
        public static implicit operator metro(KILOMETRO km)
        {
            return new metro(km.cantidad * 1000);
        }

        //sobrecarga con conversion
        public static metro operator + (metro metro, KILOMETRO km)
        {
            int aux;
            
            aux = km.cantidad * 1000;

            return new metro(metro.cantidad + aux);
        }

    }
}
