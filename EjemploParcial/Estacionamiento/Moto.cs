using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    public class Moto : Vehiculo
    {
        private int cilindrada;


        public Moto(int cilidrada1, string patente1): base(patente1)
        {
            this.cilindrada = cilidrada1;
        }
    }
}
