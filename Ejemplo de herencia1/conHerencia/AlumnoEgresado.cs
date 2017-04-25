using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class AlumnoEgresado:Alumno // AlumnoEgresado es un Alumno con mas atributos.
    {

        private DateTime _FechaEgreso;// el atributo que Alumno no tiene.

        public AlumnoEgresado(int dni, string legajo, DateTime fechaEgreso):base(dni,legajo)
        {
            this._FechaEgreso = fechaEgreso;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            StringBuilder FechaDeEgreso = new StringBuilder();
            FechaDeEgreso.AppendLine("Fecha de egreso: " + this._FechaEgreso);

            Console.WriteLine(FechaDeEgreso.ToString());
        }
    }


}
