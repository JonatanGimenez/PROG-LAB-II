using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Lab_II___3
{
    class Program
    {
        static void Main(string[] args)
        {
        
           //Auto.miNumRandon = new Random();*****

            Rueda miRueda = new Rueda();

            Auto auto1 = new Auto();
            Auto auto2 = new Auto();
            Auto auto3 = new Auto();
            Auto auto4 = new Auto();

            eFabricante fabricante;

            fabricante = eFabricante.chevrolet;

           //fabricante = (eFabricante)3;

            //instancia de variables tipo kilometro.
            KILOMETRO kilometroAux;
            KILOMETRO kilometro1 = new KILOMETRO(10);
            KILOMETRO kilometro2 = new KILOMETRO(5);

            //sumar dos variables del tipo kilometro por medio del metodo "sumar" y por medio del operador "+".
            kilometroAux = KILOMETRO.sumar(kilometro1, kilometro2);
            kilometroAux = kilometro1 + kilometro2;

            //sumar una variable del tipo kilometro y una variable de tipo int.
            int dato = kilometro1 + 33;

            //sobrecarga del operador "==";
            //if (kilometro1 == kilometro2)
            //{
 
            //}

            int numero = (int)3.5;

            KILOMETRO k1 = (KILOMETRO)33; //explicito (le pongo el tipo de clase)

            // de kilometro a int.
            KILOMETRO k2 = 66;

            //int num = k1 + k2; //implicito

            //de int a kilometro.
            int num = k2;

            //se llama al constructor dentro de la clase.
            metro unMetro = k1;

            metro resultado = unMetro + k2;


            


         
          


        }
    }
}
