using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    public abstract class Vehiculo
    {
        protected string patente;

        public Vehiculo(string patente1)
        {
            this.patente = patente1;
        }


        public static bool operator ==(Vehiculo veh1, Vehiculo veh2)
        {
            bool retorno = false;

            if (veh1.patente == veh2.patente)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Vehiculo veh1, Vehiculo veh2)
        {
            return !(veh1 == veh2);
        }

    }
}
