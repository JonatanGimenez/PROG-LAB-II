using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Muebles unMueble = new Muebles(13, "madera", 90);
            Autos unAuto = new Autos("Chevrolet", 7788, "rojo");
            Personas unaPersona = new Personas("Daenerys", 91919191);
            TV Tv1 = new TV("LG", 50, 1080);
            TV Tv2= new TV("SONY", 60, 1080);
            TV Tv3 = new TV("PANAPHONICS", 70, 1080);
            TV Tv4 = new TV("SORNY", 80, 1080);
            TV Tv5 = new TV("MAGNETBOX", 90, 1080);
            bool dato;

            Container<TV> unContainer = new Container<TV>(10);


            dato = unContainer + Tv1;
            dato = unContainer + Tv2;
            dato = unContainer + Tv3;
            dato = unContainer + Tv4;
            dato = unContainer + Tv5;

           


        }
    }
}
