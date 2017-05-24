using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace Entidades
{
    public class Ruedas
    {

        public string marca;


        public void Pinchar()
        {
            int numero = Carrera._rnd.Next(1, 10);

            if (numero == 7)

            throw new ruedaExcepcion("La ruedad se ha pinchado " + this.marca);
        }

    }
}
