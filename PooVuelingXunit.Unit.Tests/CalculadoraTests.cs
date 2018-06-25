using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PooVuelingXunit.Unit.Tests
{
   
    public class CalculadoraTests
    {
       
        public class CalculadoraTest : IClassFixture<CalculadoraTestFixture>
        {
            CalculadoraTestFixture fixture;
            public CalculadoraTest(CalculadoraTestFixture fixture)
            {
                this.fixture = fixture;
            }


            [Fact]
            public void DivisionTest()
            {
                var res = fixture.MockObject.Division(4, 2);
                Assert.Equal(2, res);
            }


            [Fact]
            public void MultiplicacionTest()
            {
                var res = fixture.MockObject.Multiplicacion(4, 2);
                Assert.Equal(8, res);
            }


            [Fact]
            public void RestaTest()
            {
                var res = fixture.MockObject.Resta(4, 2);
                Assert.Equal(2, res);
            }


            [Fact]
            public void SumaTest()
            {
                var res = fixture.MockObject.Suma(2, 2);
                Assert.Equal(4, res);
            }         
        }
    }
}
