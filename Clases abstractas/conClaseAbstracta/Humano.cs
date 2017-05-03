using conHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClaseAbstracta
{
    public abstract class Humano
    {

        protected string nombre;
        

        public Humano(string nombre)
        {
            this.nombre = nombre;
        }

        //metodo abstracto = clase abstracta.

        //los metodos abstractos no tienen implementacion.

        public abstract void Mostrar();

        //constructor de la clase abstracta.


   
        



    }
}
