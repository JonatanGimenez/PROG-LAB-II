using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conHerencia;


namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
           AlumnoEgresado miAlumno = new AlumnoEgresado(36324773, "12345", new DateTime(2017, 03, 21));

           miAlumno.Mostrar();

           Console.ReadKey();

        }  
    }
}
