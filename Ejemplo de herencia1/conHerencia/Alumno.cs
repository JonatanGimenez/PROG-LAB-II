using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Alumno:Persona
    {
        protected String _Legajo;
       

        public Alumno(int dni, string legajo):base(dni)
        {
            this._Dni = dni;
            this._Legajo = legajo;
        }

        //virtual = se puede sobreescribir desde las clases que heredan
        public virtual void Mostrar()
        {
            StringBuilder bloque = new StringBuilder();
            
            bloque.AppendLine("Dni: " + this._Dni);
            bloque.AppendLine("Legajo: " + this._Legajo);
            bloque.AppendLine("Nombre: " + this._Nombre);
            bloque.AppendLine("Apellido: " + this._Apellido);

            Console.WriteLine(bloque.ToString());
            
        }
    }

 
}
