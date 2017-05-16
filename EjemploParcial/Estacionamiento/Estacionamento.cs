using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    public class Estacionamento
    {
        public string nombre;
        public List<Vehiculo> miListaVehiculos;

        private Estacionamento()
        {
            miListaVehiculos = new List<Vehiculo>();
        }

        public Estacionamento(string nombre):this()
        {
            this.nombre = nombre;
        }


        public static Estacionamento operator +(Estacionamento est1, Vehiculo veh1)
        {
            if (est1 != veh1)
            {
                est1.miListaVehiculos.Add(veh1);
            }

            return est1;
        }

        public static bool operator ==(Estacionamento est1, Vehiculo veh1)
        {
            bool retorno = false;

            if(est1.miListaVehiculos.Contains(veh1))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Estacionamento est1, Vehiculo veh1)
        {
            return !(est1 == veh1);
        }

        public static Estacionamento operator -(Estacionamento est1, Vehiculo veh1)
        {

           foreach (Vehiculo item in est1.miListaVehiculos)
            {
                if (item == veh1)
                {
                    est1.miListaVehiculos.RemoveAt(est1.miListaVehiculos.IndexOf(item));
                    break;
                }
                
            }
         

            return est1;
        }


    }
}
