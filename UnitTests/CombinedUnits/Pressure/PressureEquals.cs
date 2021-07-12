using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class PressureEquals
    {



        [TestMethod]
        public void Pressure()
        {
            var U0 = new UnitsNet.PressureChangeRate(5464.48, UnitsNet.Units.PressureChangeRateUnit.KilopascalPerMinute);
            var U1 = new UnitsNet.PressureChangeRate(682, UnitsNet.Units.PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond);
            var U2 = new UnitsNet.PressureChangeRate(5, UnitsNet.Units.PressureChangeRateUnit.PascalPerSecond);
            var U3 = new UnitsNet.PressureChangeRate(468, UnitsNet.Units.PressureChangeRateUnit.AtmospherePerSecond);
            var U4 = new UnitsNet.PressureChangeRate(0.2458, UnitsNet.Units.PressureChangeRateUnit.KilopascalPerMinute);
            var U5 = new UnitsNet.PressureChangeRate(4.4568, UnitsNet.Units.PressureChangeRateUnit.PoundForcePerSquareInchPerSecond);
            var U6 = new UnitsNet.PressureChangeRate(1, UnitsNet.Units.PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond);
            var U7 = new UnitsNet.PressureChangeRate(4444577, UnitsNet.Units.PressureChangeRateUnit.PascalPerMinute);
            var U8 = new UnitsNet.PressureChangeRate(989866, UnitsNet.Units.PressureChangeRateUnit.KilopascalPerSecond);
            var U9 = new UnitsNet.PressureChangeRate(456, UnitsNet.Units.PressureChangeRateUnit.MegapascalPerMinute);

            var E0 = new EngineeringUnits.PressureChangeRate(5464.48, EngineeringUnits.PressureChangeRateUnit.KilopascalPerMinute);
            var E1 = new EngineeringUnits.PressureChangeRate(682, EngineeringUnits.PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond);
            var E2 = new EngineeringUnits.PressureChangeRate(5, EngineeringUnits.PressureChangeRateUnit.PascalPerSecond);
            var E3 = new EngineeringUnits.PressureChangeRate(468, EngineeringUnits.PressureChangeRateUnit.AtmospherePerSecond);
            var E4 = new EngineeringUnits.PressureChangeRate(0.2458, EngineeringUnits.PressureChangeRateUnit.KilopascalPerMinute);
            var E5 = new EngineeringUnits.PressureChangeRate(4.4568, EngineeringUnits.PressureChangeRateUnit.PoundForcePerSquareInchPerSecond);
            var E6 = new EngineeringUnits.PressureChangeRate(1, EngineeringUnits.PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond);
            var E7 = new EngineeringUnits.PressureChangeRate(4444577, EngineeringUnits.PressureChangeRateUnit.PascalPerMinute);
            var E8 = new EngineeringUnits.PressureChangeRate(989866, EngineeringUnits.PressureChangeRateUnit.KilopascalPerSecond);
            var E9 = new EngineeringUnits.PressureChangeRate(456, EngineeringUnits.PressureChangeRateUnit.MegapascalPerMinute);



            Assert.AreEqual(U1 > U7, E1 > E7);
            Assert.AreEqual(U4 > U6, E4 > E6);
            Assert.AreEqual(U6 > U8, E6 > E8);
            Assert.AreEqual(U9 > U5, E9 > E5);
            Assert.AreEqual(U8 > U9, E8 > E9);
            Assert.AreEqual(U7 > U1, E7 > E1);
            Assert.AreEqual(U8 > U1, E8 > E1);
            Assert.AreEqual(U5 > U2, E5 > E2);
            Assert.AreEqual(U1 > U3, E1 > E3);
            Assert.AreEqual(U9 > U4, E9 > E4);
            Assert.AreEqual(U8 > U5, E8 > E5);
            Assert.AreEqual(U1 > U6, E1 > E6);
            Assert.AreEqual(U4 > U7, E4 > E7);
            Assert.AreEqual(U2 > U8, E2 > E8);
            Assert.AreEqual(U8 > U9, E8 > E9);
            Assert.AreEqual(U7 > U8, E7 > E8);
            Assert.AreEqual(U2 > U5, E2 > E5);
            Assert.AreEqual(U2 > U7, E2 > E7);
            Assert.AreEqual(U6 > U9, E6 > E9);
            Assert.AreEqual(U4 > U6, E4 > E6);
            Assert.AreEqual(U8 > U4, E8 > E4);
            Assert.AreEqual(U5 > U9, E5 > E9);
            Assert.AreEqual(U4 > U9, E4 > E9);
            Assert.AreEqual(U6 > U7, E6 > E7);
            Assert.AreEqual(U2 > U8, E2 > E8);
            Assert.AreEqual(U8 > U7, E8 > E7);
            Assert.AreEqual(U5 > U6, E5 > E6);
            Assert.AreEqual(U4 > U5, E4 > E5);
            Assert.AreEqual(U2 > U4, E2 > E4);
            Assert.AreEqual(U3 > U1, E3 > E1);
            Assert.AreEqual(U5 > U2, E5 > E2);
            Assert.AreEqual(U7 > U3, E7 > E3);
            Assert.AreEqual(U8 > U4, E8 > E4);
            Assert.AreEqual(U4 > U5, E4 > E5);
            Assert.AreEqual(U7 > U6, E7 > E6);
            Assert.AreEqual(U1 > U7, E1 > E7);
            Assert.AreEqual(U3 > U8, E3 > E8);
            Assert.AreEqual(U5 > U9, E5 > E9);
            Assert.AreEqual(U6 > U1, E6 > E1);
            Assert.AreEqual(U8 > U1, E8 > E1);
            Assert.AreEqual(U9 > U2, E9 > E2);
            Assert.AreEqual(U4 > U2, E4 > E2);
            Assert.AreEqual(U5 > U3, E5 > E3);
            Assert.AreEqual(U2 > U5, E2 > E5);
            Assert.AreEqual(U1 > U8, E1 > E8);
            Assert.AreEqual(U2 > U7, E2 > E7);
            Assert.AreEqual(U3 > U6, E3 > E6);
            Assert.AreEqual(U2 > U4, E2 > E4);
            Assert.AreEqual(U4 > U9, E4 > E9);
            Assert.AreEqual(U5 > U8, E5 > E8);
            Assert.AreEqual(U6 > U5, E6 > E5);
            Assert.AreEqual(U9 > U4, E9 > E4);
            Assert.AreEqual(U8 > U2, E8 > E2);
            Assert.AreEqual(U7 > U1, E7 > E1);
            Assert.AreEqual(U5 > U1, E5 > E1);

            Assert.AreEqual(U1 < U7, E1 < E7);
            Assert.AreEqual(U4 < U6, E4 < E6);
            Assert.AreEqual(U6 < U8, E6 < E8);
            Assert.AreEqual(U9 < U5, E9 < E5);
            Assert.AreEqual(U8 < U9, E8 < E9);
            Assert.AreEqual(U7 < U1, E7 < E1);
            Assert.AreEqual(U8 < U1, E8 < E1);
            Assert.AreEqual(U5 < U2, E5 < E2);
            Assert.AreEqual(U1 < U3, E1 < E3);
            Assert.AreEqual(U9 < U4, E9 < E4);
            Assert.AreEqual(U8 < U5, E8 < E5);
            Assert.AreEqual(U1 < U6, E1 < E6);
            Assert.AreEqual(U4 < U7, E4 < E7);
            Assert.AreEqual(U2 < U8, E2 < E8);
            Assert.AreEqual(U8 < U9, E8 < E9);
            Assert.AreEqual(U7 < U8, E7 < E8);
            Assert.AreEqual(U2 < U5, E2 < E5);
            Assert.AreEqual(U2 < U7, E2 < E7);
            Assert.AreEqual(U6 < U9, E6 < E9);
            Assert.AreEqual(U4 < U6, E4 < E6);
            Assert.AreEqual(U8 < U4, E8 < E4);
            Assert.AreEqual(U5 < U9, E5 < E9);
            Assert.AreEqual(U4 < U9, E4 < E9);
            Assert.AreEqual(U6 < U7, E6 < E7);
            Assert.AreEqual(U2 < U8, E2 < E8);
            Assert.AreEqual(U8 < U7, E8 < E7);
            Assert.AreEqual(U5 < U6, E5 < E6);
            Assert.AreEqual(U4 < U5, E4 < E5);
            Assert.AreEqual(U2 < U4, E2 < E4);
            Assert.AreEqual(U3 < U1, E3 < E1);
            Assert.AreEqual(U5 < U2, E5 < E2);
            Assert.AreEqual(U7 < U3, E7 < E3);
            Assert.AreEqual(U8 < U4, E8 < E4);
            Assert.AreEqual(U4 < U5, E4 < E5);
            Assert.AreEqual(U7 < U6, E7 < E6);
            Assert.AreEqual(U1 < U7, E1 < E7);
            Assert.AreEqual(U3 < U8, E3 < E8);
            Assert.AreEqual(U5 < U9, E5 < E9);
            Assert.AreEqual(U6 < U1, E6 < E1);
            Assert.AreEqual(U8 < U1, E8 < E1);
            Assert.AreEqual(U9 < U2, E9 < E2);
            Assert.AreEqual(U4 < U2, E4 < E2);
            Assert.AreEqual(U5 < U3, E5 < E3);
            Assert.AreEqual(U2 < U5, E2 < E5);
            Assert.AreEqual(U1 < U8, E1 < E8);
            Assert.AreEqual(U2 < U7, E2 < E7);
            Assert.AreEqual(U3 < U6, E3 < E6);
            Assert.AreEqual(U2 < U4, E2 < E4);
            Assert.AreEqual(U4 < U9, E4 < E9);
            Assert.AreEqual(U5 < U8, E5 < E8);
            Assert.AreEqual(U6 < U5, E6 < E5);
            Assert.AreEqual(U9 < U4, E9 < E4);
            Assert.AreEqual(U8 < U2, E8 < E2);
            Assert.AreEqual(U7 < U1, E7 < E1);
            Assert.AreEqual(U5 < U1, E5 < E1);

            Assert.AreEqual(U1 >= U7, E1 >= E7);
            Assert.AreEqual(U4 >= U6, E4 >= E6);
            Assert.AreEqual(U6 >= U8, E6 >= E8);
            Assert.AreEqual(U9 >= U5, E9 >= E5);
            Assert.AreEqual(U8 >= U9, E8 >= E9);
            Assert.AreEqual(U7 >= U1, E7 >= E1);
            Assert.AreEqual(U8 >= U1, E8 >= E1);
            Assert.AreEqual(U5 >= U2, E5 >= E2);
            Assert.AreEqual(U1 >= U3, E1 >= E3);
            Assert.AreEqual(U9 >= U4, E9 >= E4);
            Assert.AreEqual(U8 >= U5, E8 >= E5);
            Assert.AreEqual(U1 >= U6, E1 >= E6);
            Assert.AreEqual(U4 >= U7, E4 >= E7);
            Assert.AreEqual(U2 >= U8, E2 >= E8);
            Assert.AreEqual(U8 >= U9, E8 >= E9);
            Assert.AreEqual(U7 >= U8, E7 >= E8);
            Assert.AreEqual(U2 >= U5, E2 >= E5);
            Assert.AreEqual(U2 >= U7, E2 >= E7);
            Assert.AreEqual(U6 >= U9, E6 >= E9);
            Assert.AreEqual(U4 >= U6, E4 >= E6);
            Assert.AreEqual(U8 >= U4, E8 >= E4);
            Assert.AreEqual(U5 >= U9, E5 >= E9);
            Assert.AreEqual(U4 >= U9, E4 >= E9);
            Assert.AreEqual(U6 >= U7, E6 >= E7);
            Assert.AreEqual(U2 >= U8, E2 >= E8);
            Assert.AreEqual(U8 >= U7, E8 >= E7);
            Assert.AreEqual(U5 >= U6, E5 >= E6);
            Assert.AreEqual(U4 >= U5, E4 >= E5);
            Assert.AreEqual(U2 >= U4, E2 >= E4);
            Assert.AreEqual(U3 >= U1, E3 >= E1);
            Assert.AreEqual(U5 >= U2, E5 >= E2);
            Assert.AreEqual(U7 >= U3, E7 >= E3);
            Assert.AreEqual(U8 >= U4, E8 >= E4);
            Assert.AreEqual(U4 >= U5, E4 >= E5);
            Assert.AreEqual(U7 >= U6, E7 >= E6);
            Assert.AreEqual(U1 >= U7, E1 >= E7);
            Assert.AreEqual(U3 >= U8, E3 >= E8);
            Assert.AreEqual(U5 >= U9, E5 >= E9);
            Assert.AreEqual(U6 >= U1, E6 >= E1);
            Assert.AreEqual(U8 >= U1, E8 >= E1);
            Assert.AreEqual(U9 >= U2, E9 >= E2);
            Assert.AreEqual(U4 >= U2, E4 >= E2);
            Assert.AreEqual(U5 >= U3, E5 >= E3);
            Assert.AreEqual(U2 >= U5, E2 >= E5);
            Assert.AreEqual(U1 >= U8, E1 >= E8);
            Assert.AreEqual(U2 >= U7, E2 >= E7);
            Assert.AreEqual(U3 >= U6, E3 >= E6);
            Assert.AreEqual(U2 >= U4, E2 >= E4);
            Assert.AreEqual(U4 >= U9, E4 >= E9);
            Assert.AreEqual(U5 >= U8, E5 >= E8);
            Assert.AreEqual(U6 >= U5, E6 >= E5);
            Assert.AreEqual(U9 >= U4, E9 >= E4);
            Assert.AreEqual(U8 >= U2, E8 >= E2);
            Assert.AreEqual(U7 >= U1, E7 >= E1);
            Assert.AreEqual(U5 >= U1, E5 >= E1);

            Assert.AreEqual(U1 <= U7, E1 <= E7);
            Assert.AreEqual(U4 <=U6, E4 <= E6);
            Assert.AreEqual(U6 <=U8, E6 <= E8);
            Assert.AreEqual(U9 <=U5, E9 <= E5);
            Assert.AreEqual(U8 <=U9, E8 <= E9);
            Assert.AreEqual(U7 <=U1, E7 <= E1);
            Assert.AreEqual(U8 <=U1, E8 <= E1);
            Assert.AreEqual(U5 <=U2, E5 <= E2);
            Assert.AreEqual(U1 <=U3, E1 <= E3);
            Assert.AreEqual(U9 <=U4, E9 <= E4);
            Assert.AreEqual(U8 <=U5, E8 <= E5);
            Assert.AreEqual(U1 <=U6, E1 <= E6);
            Assert.AreEqual(U4 <=U7, E4 <= E7);
            Assert.AreEqual(U2 <=U8, E2 <= E8);
            Assert.AreEqual(U8 <=U9, E8 <= E9);
            Assert.AreEqual(U7 <=U8, E7 <= E8);
            Assert.AreEqual(U2 <=U5, E2 <= E5);
            Assert.AreEqual(U2 <=U7, E2 <= E7);
            Assert.AreEqual(U6 <=U9, E6 <= E9);
            Assert.AreEqual(U4 <=U6, E4 <= E6);
            Assert.AreEqual(U8 <=U4, E8 <= E4);
            Assert.AreEqual(U5 <=U9, E5 <= E9);
            Assert.AreEqual(U4 <=U9, E4 <= E9);
            Assert.AreEqual(U6 <=U7, E6 <= E7);
            Assert.AreEqual(U2 <=U8, E2 <= E8);
            Assert.AreEqual(U8 <=U7, E8 <= E7);
            Assert.AreEqual(U5 <=U6, E5 <= E6);
            Assert.AreEqual(U4 <=U5, E4 <= E5);
            Assert.AreEqual(U2 <=U4, E2 <= E4);
            Assert.AreEqual(U3 <=U1, E3 <= E1);
            Assert.AreEqual(U5 <=U2, E5 <= E2);
            Assert.AreEqual(U7 <=U3, E7 <= E3);
            Assert.AreEqual(U8 <=U4, E8 <= E4);
            Assert.AreEqual(U4 <=U5, E4 <= E5);
            Assert.AreEqual(U7 <=U6, E7 <= E6);
            Assert.AreEqual(U1 <=U7, E1 <= E7);
            Assert.AreEqual(U3 <=U8, E3 <= E8);
            Assert.AreEqual(U5 <=U9, E5 <= E9);
            Assert.AreEqual(U6 <=U1, E6 <= E1);
            Assert.AreEqual(U8 <=U1, E8 <= E1);
            Assert.AreEqual(U9 <=U2, E9 <= E2);
            Assert.AreEqual(U4 <=U2, E4 <= E2);
            Assert.AreEqual(U5 <=U3, E5 <= E3);
            Assert.AreEqual(U2 <=U5, E2 <= E5);
            Assert.AreEqual(U1 <=U8, E1 <= E8);
            Assert.AreEqual(U2 <=U7, E2 <= E7);
            Assert.AreEqual(U3 <=U6, E3 <= E6);
            Assert.AreEqual(U2 <=U4, E2 <= E4);
            Assert.AreEqual(U4 <=U9, E4 <= E9);
            Assert.AreEqual(U5 <=U8, E5 <= E8);
            Assert.AreEqual(U6 <=U5, E6 <= E5);
            Assert.AreEqual(U9 <=U4, E9 <= E4);
            Assert.AreEqual(U8 <=U2, E8 <= E2);
            Assert.AreEqual(U7 <=U1, E7 <= E1);
            Assert.AreEqual(U5 <=U1, E5 <= E1);
        }                           
    }                                
}                                    
                             
                             
                             
                             
                             
                             
                             
                             
                             
                             
                             