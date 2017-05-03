using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conClaseAbstracta
{
    public abstract class Empleado : Humano
    {

        public Empleado(string nombre): base(nombre)
        {

        }

        public abstract float Sueldo
        {
            get;
            set;
        }
        
        //se puede implementar pero no es obligatorio.
        /*public override void Mostrar()
        {
            //throw new NotImplementedException();
        }*/

    }
}
