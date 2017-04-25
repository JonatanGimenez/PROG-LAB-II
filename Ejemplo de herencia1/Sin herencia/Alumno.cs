using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Alumno
    {
        private int _Dni;
        private String _Legajo;
        private String _Nombre;
        private String _Apellido;

        public Alumno(int dni, string legajo)
        {
            this._Dni = dni;
            this._Legajo = legajo;
        }

        public void Mostrar()
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
