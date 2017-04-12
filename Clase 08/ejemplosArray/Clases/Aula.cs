using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        public int numero;
        public Alumno[] misAlumnos;


        //
        public Aula()
        {
            this.misAlumnos = new Alumno[10];
        }

        //
        public void agregarAlumno(Alumno alumno)
        {
            if (this.obtenerLugarLibre() != -1)
            {
               this.misAlumnos[obtenerLugarLibre()] = alumno;
            }
        }

        //
        public int obtenerLugarLibre()
        {
            int retorno = -1;
            int contador = 0;

            foreach (Alumno itemAlumno in this.misAlumnos)
            {
                if ((object)itemAlumno == null)
                {
                     return contador;
                }
                contador++;
            }

            return retorno;
        }

        //
        public void borrarAlumno(Alumno alumno)
        {
            int indiceBorrar= this.retornarIndiceDeObjeto(alumno);

            if (indiceBorrar != -1)
            {

                this.misAlumnos[indiceBorrar] = null;
            
            }
            else
            {
                Console.WriteLine("no existe");
            }
        }

        //retorna el indice del objeto pasado por parametro,
        //retorna -1 si no lo encuentra.
        private int retornarIndiceDeObjeto(Alumno alumno)
        {
            int retorno = -1;
            int contador;

            for (contador = 0; contador < this.misAlumnos.Length; contador++)
            {
                if (null != this.misAlumnos.GetValue(contador) && alumno == this.misAlumnos[contador])
                {
                    return contador;
                }
            }
            

            return retorno;
        }

    }
}
