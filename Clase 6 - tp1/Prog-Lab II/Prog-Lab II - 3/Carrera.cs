using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Lab_II___3
{
    class Carrera
    {
        //Atributos
        public Auto auto1; 
        public Auto auto2; 
        public Auto auto3; 
        public Auto auto4; 
        public Auto auto5;
        public Auto auto6;

        //Instanciamiento de atributos en el constructor:
        public Carrera()
        {
            auto1 = new Auto();
            auto2 = new Auto();
            auto3 = new Auto();
            auto4 = new Auto();
            auto5 = new Auto();
            auto6 = new Auto();
        }


        //Metodos
        /// <summary>
        /// se recibe un entero que representa la cantidad de iteraciones
        /// que se realizaran asignandole a cada auto una cantidad de kilometros random.
        /// al terminar las iteraciones mostrar que auto recorrio mas y gano la carrera.
        /// </summary>
        /// <param name="minutos"></param>
        public void porTiempo(int minutos)
        {
            int contador;
            Random random = new Random();
           
            for(contador = 0; contador > minutos; contador++)
            {
                auto1.agregarKilometros(random.Next(10,100));
                auto2.agregarKilometros(random.Next(10,100));
                auto3.agregarKilometros(random.Next(10,100));
                auto4.agregarKilometros(random.Next(10,100));
                auto5.agregarKilometros(random.Next(10,100));
                auto6.agregarKilometros(random.Next(10,100));
                contador++;

            }

            //Console.WriteLine(auto1.mostrarAuto);
        }

        //public correrCarrera(KILOMETRO kms)
    }   
}
