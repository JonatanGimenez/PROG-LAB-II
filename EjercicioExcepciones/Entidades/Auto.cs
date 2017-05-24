using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {

        public string marca;

        public Ruedas DD;
        public Ruedas DI;
        public Ruedas TD;
        public Ruedas TI;

        public Motor motor;

        public Auto()
        {
            DD = new Ruedas();
            DI = new Ruedas();
            TD = new Ruedas();
            TI = new Ruedas();
            motor = new Motor();
        }

        public void Andar()
        {
            try
            {
                this.motor.fallar();
                this.DD.Pinchar();
                this.DI.Pinchar();
                this.TD.Pinchar();
                this.TI.Pinchar();
            }
            catch (motorExcepcion ex)
            {

                throw  new miExcepcion (ex.Message + " auto motor: " + this.marca , ex);

            }
            catch (ruedaExcepcion ex)
            {

                throw new miExcepcion(ex.Message + " auto motor: " + this.marca, ex);

            }
            catch (miExcepcion ex)
            {

                throw new miExcepcion(ex.Message + " auto motor: " + this.marca, ex);

            }
 
        }

    }
}
