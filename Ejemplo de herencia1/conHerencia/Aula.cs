using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Aula
    {
        private int _numero;
        private string _nombre;
        private List<Persona> _ListadoDePersonas;
        private int capacidad;


        public Aula(int numero, string nombre, int capacidad)
        {
            this._nombre = nombre;
            this._numero = numero;
            this._ListadoDePersonas = new List<Persona>();
        }

        public int cantidadDePersonas
        {
            get
            {
                return this._ListadoDePersonas.Count();
            }
        }

        public int cantidadDeProfesores
        {
            get
            {
                int contador = 0;
                foreach (Persona item in this._ListadoDePersonas)
                {
                    //getType
                    //typeOf

                    if (item is Profesor)
                    {
                        contador++;
                    }
                    
                }
                return contador;
            }
        }

        public bool agregarPersona(Persona unaPersona)
        {
            this._ListadoDePersonas.Add(unaPersona);

            return true;
        }

        public bool borrarPersona(Persona unaPersona)
        {

            return true;
        }
    }
    
}
