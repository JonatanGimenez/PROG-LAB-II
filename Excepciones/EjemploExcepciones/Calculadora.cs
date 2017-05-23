using misExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploExcepciones
{
    public class Calculadora
    {
        public static void Calcular()
        {
            //int num1 = 0;
            //int resultado = num1 / num1;

            try
            {
                Calculadora calcular1 = new Calculadora();
                calcular1.generarExcepcion();
            }
            catch (Exception ex)
            {
                throw new Exception("Static calcular " + ex.Message);
            }
        }

        public void generarExcepcion()
        {
            throw new primeraExcepcion(); 
        }



    }
}
