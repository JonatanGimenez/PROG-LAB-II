using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    public class Auto : Vehiculo 
    {
        private int cantidadPuertas;

        public Auto(int cantidadPuertas1)
        {
            this.cantidadPuertas = cantidadPuertas1;
        }

        public Auto(int cantidadPuertas1, string patente1): base(patente1)
        {
            this.cantidadPuertas = cantidadPuertas1;
        }
    }
}
