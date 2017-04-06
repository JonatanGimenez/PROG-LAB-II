using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Lab_II___3
{

    class Auto
    {
        //Atributos
        Rueda ruedaD1;
        Rueda ruedaD2;
        Rueda ruedaT1;
        Rueda ruedaT2;
        public static int cantidadDeInstancias;
        private eFabricante fabricante;
        //public static Random miNumRandon;********
        private int kilometrosRecorridos;

        /* Los atributos privados son accesibles para su
        escritura (asignarle un valor). a traves de los
        constructores publicos y los metodos publicos.
        pueden ser accesidos para lectura (devolver el valor 
        del dato) a traves de metodos publicos.
        en este lenguaje tambien se los puede acceder para
        lectura y escritura a traves de las propiedades*/

        //Constructor
        public Auto()
        {
            this.ruedaD1 = new Rueda();
            this.ruedaD2 = new Rueda();
            this.ruedaT1 = new Rueda();
            this.ruedaT2 = new Rueda();

            Auto.cantidadDeInstancias++;

            this.fabricante = eFabricante.ford;
        }

        /*Constructores de instacia: 
         * tiene el mismo nombre que la clase. 
         * pueden tener modificador de visibilidad (public, private, etc)
         * No tiene valor de retorno
         * pueden tener parametros
         * se ejecuta al crear una instacia de la clase (objeto)
         * se puede y debe usar el operador "this."
         * puede acceder a los atributos de instancia
         * puede acceder a los atributos estaticos
        */

        /*constructores estaticos:
         * no puede tener acceso a la visibilidad 
         * no se puede utilizar el operador "this."
         */

        static Auto()
        {
            Auto.cantidadDeInstancias = 0;        
        }

        //Metodos

        public void agregarKilometros(int kilometros)
        {
            this.kilometrosRecorridos = this.kilometrosRecorridos + kilometros;
        }


        public void volverACero()
        {
            this.kilometrosRecorridos = 0;
        }


        public int getKms()
        {
            return this.kilometrosRecorridos;
        }

        public void mostrarAuto()
        {
            Console.WriteLine(this.fabricante);
            Console.WriteLine(this.kilometrosRecorridos);
            this.ruedaD1.mostrarRueda();
            this.ruedaD2.mostrarRueda();
            this.ruedaT1.mostrarRueda();
            this.ruedaT2.mostrarRueda();
        }



    }
}
/*
 * El fabricante cargado se genere de manera ramdon entre las tres 
 opciones existentes. (usar switch con numero ramdon para asignar marca);
 * Probar que haya generado 3 numeros
*/