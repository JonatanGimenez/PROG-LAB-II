using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
    public class Carrera
    {

        public List<Auto> listaDeAutos;
        public static Random _rnd;

        static Carrera()
        {
            _rnd = new Random();
        }

        public Carrera()
        {
            this.listaDeAutos = new List<Auto>();

            this.listaDeAutos.Add(new Auto());
            this.listaDeAutos.Add(new Auto());
            this.listaDeAutos.Add(new Auto());
            this.listaDeAutos.Add(new Auto());
            this.listaDeAutos.Add(new Auto());


        }


        public void Correr()
        {
            int i ;
            //Auto auto = new Auto();
            try
            {
                for (i= 0; i < 10; i++)
                {
                    foreach (Auto item in listaDeAutos)
                    {
                        item.Andar();
                    }
                    
                }
             

            }
            catch (miExcepcion ex)
            {
                
                throw  new Exception(ex.Message + "datos de la carrera o vuelta",  ex);
            }

          
            
        }




    }
}
