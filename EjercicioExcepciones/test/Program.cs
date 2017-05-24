using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            Entidades.Carrera miCarrera = new Entidades.Carrera();

            try
            {

                miCarrera.Correr();

            }
            catch (Exception ex)
            {

                Console.Write(ex);
            }

        }
    }
}
