using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Code;

namespace UnitTest.Test
{
    [TestClass]
    public class AritmeticaTest
    {
        [TestMethod]
        public void Suma_SumaDosNumeros_RetornaTrue()
        {
            //  Arrange
            var aritmetica = new Aritmetica();

            //  Act
            var resultado = aritmetica.Suma(1,4);

            //  Assert
            Assert.IsTrue(resultado == 5);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_DivisionEntreCero_RetornaDivideByZeroException()
        {
            //  Arrange
            var aritmetica = new Aritmetica();

            //  Act
            aritmetica.Division(5, 0);

            // Assert no necesario.
        }
    }
}
