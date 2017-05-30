using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestAula
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// testeamos que la lista este instanciada
        /// </summary>
        [TestMethod]
        public void listaCorrecta()
        {
           Aula miAula = new Aula(1);
           Assert.IsNotNull(miAula.Alumno);
        }

        /// <summary>
        /// verificar que el espacio se encuentre entre los valores
        /// minimo: 1
        /// maximo: 50
        /// </summary>
        [TestMethod]
        public void espacioAulaIncorrecto()
        {

            Aula aulaGrande = new Aula(51);

            if (aulaGrande.espacioDisponible != 50)
            {
                Assert.Fail("Espacio disponible mal validado {0}", aulaGrande.espacioDisponible);

            }



            Aula aulaChica = new Aula(0);

            Assert.AreNotEqual(aulaChica.espacioDisponible, 0);
            



            Aula aulaCorrecta = new Aula(20);

            Assert.AreEqual(aulaCorrecta.espacioDisponible, 20);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void agregarAlumnoEspacioDisponible()
        {
            Aula miAula = new Aula(2);

            Alumno a1 = new Alumno("Martin", "555");

            Alumno a2 = new Alumno("Moria", "999");

            miAula = miAula + a1;

            Assert.AreEqual(miAula.espacioDisponible, 1);

            miAula = miAula + a2;

            Assert.AreEqual(miAula.espacioDisponible, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void agregarAlumnosAulaLlena()
        {
            Aula miAula = new Aula(1);

            Alumno a1 = new Alumno("Martin", "555");

            Alumno a2 = new Alumno("Moria", "999");

            miAula = miAula + a1;

            try
            {
                miAula = miAula + a2;
                Assert.Fail("Nunca deberia leer el codigo debajo de una excepcion");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(aulaLlenaExcepcion));
            }
            

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void agregarAlumnoVerDato()
        {
            Aula miAula = new Aula(1);

            Alumno a1 = new Alumno("Juan", "222");

            miAula = miAula + a1;
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void agregarAlumnoMostrarCantidad()
        {
            Aula miAula = new Aula(50);

            Alumno a1 = new Alumno("Juan", "222");
            Alumno a2 = new Alumno("Juanjo", "333");
            Alumno a3 = new Alumno("Juana", "444");

            miAula = miAula + a1;
            miAula = miAula + a2;
            miAula = miAula + a3;


        }




    }
}
