using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Persona
    {
        protected int _Dni;
        protected string _Nombre;
        protected string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private string _legajo;

        public Persona(int dni)
        {
            this._Dni = dni; 
        }
      
        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine("DNI: " + this._Dni);
            Bloque.AppendLine("Apellido: " + this._Apellido);
            Bloque.AppendLine("Nombre: " + this._Nombre);
            return Bloque.ToString();
        }


        public void Mostrar()
        {           
            Console.Write(this.ToString());
        }
    
    }
}
