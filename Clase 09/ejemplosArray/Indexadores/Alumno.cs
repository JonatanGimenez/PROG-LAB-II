using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Indexadores
{
    class Alumno
    {
        private String nombre;
        private int legajo;

        public Alumno(int legajo)
        {
            this.legajo = legajo;
        }

        public Alumno(int legajo, String nombre):this(legajo)
        {   
            this.nombre = nombre;
        }       
    
    }
}
