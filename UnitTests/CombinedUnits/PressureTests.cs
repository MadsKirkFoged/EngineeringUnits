using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class PressureTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Pressure(65.743, UnitsNet.Units.PressureUnit.Bar);
        var A2 = new EngineeringUnits.Pressure(65.743, PressureUnit.Bar);

        var WorkingCompares = 0;

        foreach (PressureUnit EU in UnitTypebase.ListOf<PressureUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.PressureUnit> UNList = UnitsNet.Pressure.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.PressureUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.PressureUnit.Micropascal)
                    Error = 0.0009765625;
                if (UN == UnitsNet.Units.PressureUnit.KilogramForcePerSquareMeter)
                    Error = 0.013645294005982578;

                Debug.Print($"");
                Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");
                Debug.Print($"UnitsNets:       {A1.ToUnit(UN):a}");
                Debug.Print($"EngineeringUnit: {A2.ToUnit(EU).DisplaySymbol()}");

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        RelError);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(42, WorkingCompares);
    }

    [TestMethod]
    public void PressureEquals()
    {
        //var U0 = new UnitsNet.PressureChangeRate(5464.48, UnitsNet.Units.PressureChangeRateUnit.KilopascalPerMinute);
        var U1 = new UnitsNet.PressureChangeRate(682, UnitsNet.Units.PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond);
        var U2 = new UnitsNet.PressureChangeRate(5, UnitsNet.Units.PressureChangeRateUnit.PascalPerSecond);
        var U3 = new UnitsNet.PressureChangeRate(468, UnitsNet.Units.PressureChangeRateUnit.AtmospherePerSecond);
        var U4 = new UnitsNet.PressureChangeRate(0.2458, UnitsNet.Units.PressureChangeRateUnit.KilopascalPerMinute);
        var U5 = new UnitsNet.PressureChangeRate(4.4568, UnitsNet.Units.PressureChangeRateUnit.PoundForcePerSquareInchPerSecond);
        var U6 = new UnitsNet.PressureChangeRate(1, UnitsNet.Units.PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond);
        var U7 = new UnitsNet.PressureChangeRate(4444577, UnitsNet.Units.PressureChangeRateUnit.PascalPerMinute);
        var U8 = new UnitsNet.PressureChangeRate(989866, UnitsNet.Units.PressureChangeRateUnit.KilopascalPerSecond);
        var U9 = new UnitsNet.PressureChangeRate(456, UnitsNet.Units.PressureChangeRateUnit.MegapascalPerMinute);

        //var E0 = new EngineeringUnits.PressureChangeRate(5464.48, PressureChangeRateUnit.KilopascalPerMinute);
        var E1 = new EngineeringUnits.PressureChangeRate(682, PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond);
        var E2 = new EngineeringUnits.PressureChangeRate(5, PressureChangeRateUnit.PascalPerSecond);
        var E3 = new EngineeringUnits.PressureChangeRate(468, PressureChangeRateUnit.AtmospherePerSecond);
        var E4 = new EngineeringUnits.PressureChangeRate(0.2458, PressureChangeRateUnit.KilopascalPerMinute);
        var E5 = new EngineeringUnits.PressureChangeRate(4.4568, PressureChangeRateUnit.PoundForcePerSquareInchPerSecond);
        var E6 = new EngineeringUnits.PressureChangeRate(1, PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond);
        var E7 = new EngineeringUnits.PressureChangeRate(4444577, PressureChangeRateUnit.PascalPerMinute);
        var E8 = new EngineeringUnits.PressureChangeRate(989866, PressureChangeRateUnit.KilopascalPerSecond);
        var E9 = new EngineeringUnits.PressureChangeRate(456, PressureChangeRateUnit.MegapascalPerMinute);

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

    
    [TestMethod]
    public void PressureReference()
    {
        //Creating new with undefined
        var P1 = new Pressure(10, PressureUnit.Bar);
        Assert.AreEqual(P1.ToString(), "10 bar");
        Assert.AreEqual($"{P1}", "10 bar");

        //Creating new with undefined and setting to Absolute
        Pressure P2 = P1.ToUnit(PressureUnit.BarA);
        Assert.AreEqual(P2.ToString(), "10 bara");
        Assert.AreEqual($"{P2}", "10 bara");

        //Converting from undefined to Gauge
        Pressure P3 = P1.ToUnit(PressureUnit.BarG);
        Assert.AreEqual(P3.ToString(), "8.987 barg");
        Assert.AreEqual($"{P3}", "8.987 barg");

        //Creating new with Gauge
        var P4 = new Pressure(10m, PressureUnit.BarG);
        Assert.AreEqual(P4.ToString(), "10 barg");
        Assert.AreEqual($"{P4}", "10 barg");

        //Creating new with Absolute
        var P5 = new Pressure(10m, PressureUnit.BarA);
        Assert.AreEqual(P5.ToString(), "10 bara");
        Assert.AreEqual($"{P5}", "10 bara");

        //Converting from Gauge to Gauge
        Pressure P6 = P4.ToUnit(PressureUnit.BarG);
        Assert.AreEqual(P6.ToString(), "10 barg");
        Assert.AreEqual($"{P6}", "10 barg");

        //Converting from Absolute to Gauge
        Pressure P7 = P5.ToUnit(PressureUnit.BarG);
        Assert.AreEqual(P7.ToString(), "8.987 barg");
        Assert.AreEqual($"{P7}", "8.987 barg");

        //Converting from Gauge to Absolute
        Pressure P8 = P4.ToUnit(PressureUnit.BarA);
        Assert.AreEqual(P8.ToString(), "11.01 bara");
        Assert.AreEqual($"{P8}", "11.01 bara");

        //Converting from Absolute to Absolute
        Pressure P9 = P5.ToUnit(PressureUnit.BarA);
        Assert.AreEqual(P9.ToString(), "10 bara");
        Assert.AreEqual($"{P9}", "10 bara");
    }

    [TestMethod]
    public void AbsoluteToAbsolute()
    {
        //Arrange
        var A = new Pressure(10, PressureUnit.BarA);

        //Act
        Pressure G = A.ToUnit(PressureUnit.BarG);

        //Assert
        Assert.AreEqual(A, G);
    }

    [TestMethod]
    public void GaugeAddGauge()
    {
        //Arrange
        var A = new Pressure(10, PressureUnit.BarG);
        var B = new Pressure(5, PressureUnit.BarG);

        //Act
        Pressure C = A + B;
        var K3 = A.As(PressureUnit.SI) - B.As(PressureUnit.SI);

        //Assert
        Assert.AreEqual(C.ToString(), "17.03 bar");
        Assert.AreEqual(C.As(PressureUnit.Bar), 17.0265);
        Assert.AreEqual(C.As(PressureUnit.BarA), 17.0265);
        Assert.AreEqual(K3, 500000);
    }
}

