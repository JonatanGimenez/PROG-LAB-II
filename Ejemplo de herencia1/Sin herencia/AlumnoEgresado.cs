using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class AlumnoEgresado
    {
        private int _Dni;
        private String _Legajo;
        private String _Nombre;
        private String _Apellido;
        private DateTime _FechaEgreso;

        public AlumnoEgresado(int dni, string legajo, DateTime fechaEgreso)
        {
            this._Dni = dni;
            this._Legajo = legajo;
            this._FechaEgreso = fechaEgreso;
        }

        public void Mostrar()
        {
            StringBuilder bloque = new StringBuilder();
            
            bloque.AppendLine("Dni: " + this._Dni);
            bloque.AppendLine("Legajo: " + this._Legajo);
            bloque.AppendLine("Nombre: " + this._Nombre);
            bloque.AppendLine("Apellido: " + this._Apellido);
            bloque.AppendLine("Fecha de ingreso: " + this._FechaEgreso);

            Console.WriteLine(bloque.ToString());
            
        }
    }


}
