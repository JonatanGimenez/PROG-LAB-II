using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Motor
    {
        
        public string marca;

        
        public void fallar()
        {
            int numero = Carrera._rnd.Next(1, 10);

            if (numero == 7)

            throw new motorExcepcion("El motor ha fallado " + this.marca);
        }



    }
}
