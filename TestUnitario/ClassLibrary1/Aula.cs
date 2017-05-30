using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Aula
    {
        private List<Alumno> _alumnos;
        private int _espacio;

        private int Espacio
        {
            set {

                if (value > 0 && value < 51)
                {
                    this._espacio = value;
                }
                else
                {
                    if (value < 1)
                    {
                        this._espacio = 1;
                    }
                    else 
                    {
                        this._espacio = 50;
                    }
                }
            }
        }


        private Aula()
        {
            this._alumnos = new List<Alumno>();
        }

        public Aula(int espacio):this()
        {
            Espacio = espacio;
        }

        public int espacioDisponible
        {
            get { return this._espacio - this.Alumno.Count; }
        }

        public List<Alumno> Alumno
        {
            get { return this._alumnos; }
        }

        public static Aula operator +(Aula aula, Alumno alumno)
        {
            
            if (aula.espacioDisponible == 0)
            {
                throw new aulaLlenaExcepcion("No hay lugares disponibles");
            }
            else
            {
                aula._alumnos.Add(alumno);
            }

            return aula;
        }


    }
}
