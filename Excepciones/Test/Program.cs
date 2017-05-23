using EjemploExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 10;

            int resultado = 0;

            try
            {
                //Calculadora calcular = new Calculadora();

                //calcular.generarExcepcion();

                Program.capturarExcepcion();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


            try
            {
                num1 = int.Parse(Console.ReadLine());
                resultado = num2 / num1;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No se puede dividir por cero");

                resultado = num2 / 1;


            }
            catch (FormatException ex)
            {

                Console.WriteLine("Error, numero ingresado no valido");

                resultado = num2 / 1;
                

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);

                throw;
            }
            finally
            {

                Console.WriteLine("Resultado: " + resultado);

                Console.ReadKey();

            }
        }


        public static void capturarExcepcion() 
        {
            Calculadora.Calcular();
        }
    }
}
