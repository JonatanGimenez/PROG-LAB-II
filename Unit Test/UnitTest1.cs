using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;


namespace Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        private const string RUTA = "ArchivoTest.bin";

        [TestMethod]
        public void VerificarNoGuardaException()
        {
            Tienda tienda = new Tienda(3, "Calle falsa 123", 125);

            try 
	        {
                tienda.Guardar(RUTA);
	        }
	        catch (Exception excepcion)
	        {
                Assert.IsInstanceOfType(excepcion, typeof(NoGuardaException));
	        }
        }

        [TestMethod]
        public void VerificarGuardarYLeer()
        {
            Tienda tienda = new Tienda(3, "Calle falsa 123", 125);
            Tienda tiendaAuxiliar;

            try
            {
                tienda.Guardar(RUTA);
            }
            catch (Exception)
            {
                Assert.Fail("Fallo el guardado del archivo.");
            }

            try
            {
                tienda.Cargar(out tiendaAuxiliar, RUTA);
            }
            catch (Exception)
            {
                Assert.Fail("Fallo la lectura del archivo.");
            }
        }
    }
}
