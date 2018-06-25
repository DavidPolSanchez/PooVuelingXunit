using System;
using Xunit;

namespace PooVuelingXunit.Integration.Tests
{ 



     public class CalculadoraXunitTests
    { 

        ICalculadora iCalculadora = new Calculadora();

        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 3)]
        [Theory()]
        public void Divisiontest(int num1, int num2, int resultado)
        {
            Assert.True(iCalculadora.Division(num1, num2) == resultado);
        }

        [InlineData(4, 2, 8)]
        [InlineData(6, 3, 18)]
        [Theory()]
        public void Multiplicaciontest(int num1, int num2, int resultado)
        {
            Assert.True(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [InlineData(4, 2, 2)]
        [InlineData(8, 3, 5)]
        [Theory()]
        public void Restatest(int num1, int num2, int resultado)
        {
            Assert.True(iCalculadora.Resta(num1, num2) == resultado);
        }

        [InlineData(2, 2, 4)]
        [InlineData(5, 3, 8)]
        [Theory()]
        public void Sumatest(int num1, int num2, int resultado)
        {
            Assert.True(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}
