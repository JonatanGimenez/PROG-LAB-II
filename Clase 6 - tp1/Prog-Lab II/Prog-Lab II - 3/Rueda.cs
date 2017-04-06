using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Lab_II___3
{
    class Rueda
    {
        //atributos
        private string marca;
        private int tamaño;

        //constructor
        public Rueda()
        {
            this.marca = "Sin marca";
            this.tamaño = 0;
        }

        public Rueda(string marca)
        {
            this.marca = marca;
        }

        //constructor llama a otro constructor por medio de THIS
        // en este caso llama al que ya asignaba el atributo MARCA.

        //REPASAR SOBRECARGA DE CONSTRUCTORES.

        public Rueda(int tamaño):this()
        {
            this.tamaño = tamaño;
        }

        public Rueda(int tamaño, string marca):this(tamaño)
        {
            this.marca = marca;
        }

        //metodo

        public void mostrarRueda()
        {
            Console.WriteLine(this.marca);
            Console.WriteLine(this.tamaño);
        }

    }
}
