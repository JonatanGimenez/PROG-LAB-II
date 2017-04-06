using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Lab_II___3
{
    class KILOMETRO
    {
        //atributos
        public int cantidad;


        //constructor
        public KILOMETRO(int cantidad)
        {
            this.cantidad = cantidad;
        }

        //para sumar dos variables de tipo kilomentro
        public static KILOMETRO sumar(KILOMETRO km1, KILOMETRO km2)
        {
            KILOMETRO auxKm = new KILOMETRO(0);
           
            auxKm.cantidad = km1.cantidad + km2.cantidad;

            return auxKm;
        }

        //sumar variable de tipo kilometro usando el operador "+";
        public static KILOMETRO operator + (KILOMETRO km1, KILOMETRO km2)
        {
            KILOMETRO auxKm = new KILOMETRO(0);

            auxKm.cantidad = km1.cantidad + km2.cantidad;

            return auxKm;
        }


        //sumar variable de tipo kilomentro y un entero int.
        public static int operator + (KILOMETRO km1, int numero1)
        {
            int aux;

            aux = km1.cantidad + numero1;

            return aux;
        }

        //sobrecarga del operador "=="
        public static bool operator ==(KILOMETRO km1, KILOMETRO km2)
        {

            if (km1.cantidad == km2.cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(KILOMETRO km1, KILOMETRO km2)
        {

            if(!(km1.cantidad == km2.cantidad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public static explicit operator KILOMETRO(int numero)
        {
            KILOMETRO km = new KILOMETRO(0);

            km.cantidad = numero;

            return km;
        }*/

        //casteo implicito de un entero a kilometro
        public static implicit operator KILOMETRO(int numero)
        {
            return new KILOMETRO(numero);
        }

        //casteo implicito de un kilometro a un entero
        public static implicit operator int(KILOMETRO km)
        {
            return km.cantidad;
        }

    }
}
