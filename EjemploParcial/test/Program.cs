using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            Estacionamento uno;

            uno = new Estacionamento("Nuevo");

            uno = uno + new Vehiculo("A3");

            uno = uno - new Vehiculo("A3");

            



        }
    }
}
