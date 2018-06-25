using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMock;
using Xunit;
using PooVuelingXunit;

namespace PooVuelingXunit.Unit.Tests
{
    public class CalculadoraTestFixture : IDisposable
    {

        public ICalculadora MockObject { get; private set; }
        // Create the mockfactory
        private MockFactory mockfactor = new MockFactory();

        public CalculadoraTestFixture()
        {
            // Create the Mock Object "factory"
            var objmock = mockfactor.CreateMock<ICalculadora>();
            objmock.Expects.One.MethodWith(x => x.Suma(2, 2)).WillReturn(4);
            objmock.Expects.One.MethodWith(x => x.Resta(4, 2)).WillReturn(2);
            objmock.Expects.One.MethodWith(x => x.Division(4, 2)).WillReturn(2);
            objmock.Expects.One.MethodWith(x => x.Multiplicacion(4, 2)).WillReturn(8);
            this.MockObject = objmock.MockObject;
        }

        public void Dispose()
        {
        }

        
    }
}