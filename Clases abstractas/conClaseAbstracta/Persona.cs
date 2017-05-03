using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClaseAbstracta
{
    public class Persona : Humano
    {
        //public abstract void Mostrar(); ERROR. PARCIAL.
        //los metodos abstractos solo van en la clases abstractas

        protected int DNI;
        
        public Persona(int dni, string nombre):base(nombre)
        {
            this.DNI = dni;
        }

    

    }
}
