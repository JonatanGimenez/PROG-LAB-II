using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Profesor
    {
        private String _Nombre;
        private String _Apellido;
        private int _Dni;
        private String _FichaDeDocente;
        private DateTime _FechaDeIngreso;

        public Profesor(int dni, string fichaDocente)
        {
            this._Dni = dni;
            this._FichaDeDocente = fichaDocente;
        }

        public void Mostrar()
        {
            StringBuilder bloque = new StringBuilder();
            
            bloque.AppendLine("Nombre: " + this._Nombre);
            bloque.AppendLine("Apellido: " + this._Apellido);
            bloque.AppendLine("Dni: " + this._Dni);
            bloque.AppendLine("Ficha docente: " + this._FichaDeDocente);
            bloque.AppendLine("Fecha de ingreso: " + this._FechaDeIngreso);

            Console.WriteLine(bloque.ToString());
            
        }



            

    }
}
