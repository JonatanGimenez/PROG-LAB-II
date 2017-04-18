using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace consolaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula miAula = new Aula();
            int contador = 0;

            miAula.agregarAlumno(new Alumno("john","gimenez",555));

            for(contador = 0 ; contador < 9 ; contador++)
            {
                miAula.agregarAlumno(new Alumno("john","gimenez",contador));
            }

            miAula.borrarAlumno(new Alumno("john", "gimenez", 6));

            miAula.agregarAlumno(new Alumno("yo", "yo", 999));

        }
    }
}

