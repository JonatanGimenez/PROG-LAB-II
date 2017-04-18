using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private String nombre;
        private String apellido;
        private int legajo;
            
        public Alumno(String nombre, String apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public static bool operator ==(Alumno x, Alumno j)
        {
            if(x.legajo == j.legajo && x.nombre == j.nombre)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Alumno x, Alumno j)
        {
           

            return !(x==j);
        }




    }
}
