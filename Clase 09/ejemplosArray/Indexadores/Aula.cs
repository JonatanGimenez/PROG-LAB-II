using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Aula
    {
        private int numeroDeAula;
        private List<Alumno> listaAlumno;

        public Aula()
        {
            this.listaAlumno = new List<Alumno>();
        }

        public Alumno this [int indice]
        {
            get { return this.listaAlumno[indice]; }
        }
        
    }
}
