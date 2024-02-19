using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace UnitTests
{
    [TestClass]
    public class UnitDouble
    {

        [TestMethod]
        public void Ratio()
        {
            MassFlow M1 = new(1, MassFlowUnit.KilogramPerSecond);
            MassFlow M2 = new(4, MassFlowUnit.KilogramPerSecond);
            Temperature T2 = new(10, TemperatureUnit.DegreeCelsius);
            Temperature T1 = new(5, TemperatureUnit.DegreeCelsius);

            Temperature F1 = new(5, TemperatureUnit.DegreeFahrenheit);

            Ratio Ratio1 = M1 / M2;
            Ratio Ratio2 = M2 / M1;

            Ratio Ratio3 = T2 / T2;
            Ratio Ratio4 = T1 / T2;

            Ratio Ratio5 = F1 / F1;

            Assert.AreEqual(F1.SI / F1.SI, Ratio5.DecimalFraction);
            
            Assert.AreEqual(1/4d, Ratio1.DecimalFraction);
            Assert.AreEqual(4/1d, Ratio2.DecimalFraction);
            Assert.AreEqual(1d, Ratio3.DecimalFraction);
            Assert.AreEqual(T2.SI / T2.SI, Ratio3.DecimalFraction);


        }



    }
}
