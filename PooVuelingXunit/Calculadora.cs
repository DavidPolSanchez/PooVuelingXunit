using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
namespace PooVuelingXunit
{
    public class Calculadora : ICalculadora, ICloneable
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int Division(int num1, int num2)
        {
            Log.Info("Log:Interactuando con Division.");
            return num1 / num2;
            
        }

        public int Multiplicacion(int num1, int num2)
        {
            Log.Info("Log:Interactuando con Multiplicacion.");
            return num1 * num2;
            
        }

        public int Resta(int num1, int num2)
        {
            Log.Info("Log:Interactuando con Resta.");
            return num1 - num2;
            
        }

        public int Suma(int num1, int num2)
        {
            Log.Info("Log:Interactuando con Suma.");
            return num1 + num2;
            
        }

    }
}
