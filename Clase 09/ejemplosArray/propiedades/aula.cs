using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propiedades
{
    /// <summary>
    /// en esta clase realizaremos la practica
    /// sobre el concepto de propiedades
    /// </summary>
    public class aula
    {
        private int numero;
        private List<Alumno> miLista;
        private int capacidad;
        private String _profesor;

        public String profesor
        {
            get { return this.profesor; }

            set { this.profesor = value; }
        }

        public int getterCapacidad()
        {
            return this.capacidad;
        }

        public void setterCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }


    }
}
