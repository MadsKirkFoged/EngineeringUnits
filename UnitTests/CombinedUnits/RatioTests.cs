using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public partial class RatioTests
{
    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Ratio(1, UnitsNet.Units.RatioUnit.PartPerMillion);
        var A2 = new EngineeringUnits.Ratio(1, RatioUnit.PartPerMillion);

        var WorkingCompares = 0;

        foreach (RatioUnit EU in UnitTypebase.ListOf<RatioUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.RatioUnit> UNList = UnitsNet.Ratio.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.RatioUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.RatioUnit.PicowattPerCubicFoot) Error = 0.0625;

                Debug.Print($"");
                Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        RelError);

                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol().Replace("-", ""),
                                A1.ToUnit(UN).ToString("a")

                            );

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(6, WorkingCompares);

    }

    [TestMethod]
    public void RatioMath()
    {
        MassFlow M1 = new(1, MassFlowUnit.KilogramPerSecond);
        MassFlow M2 = new(4, MassFlowUnit.KilogramPerSecond);
        Temperature T2 = new(10, TemperatureUnit.DegreeCelsius);
        Temperature T1 = new(5, TemperatureUnit.DegreeCelsius);

        Temperature F1 = new(5, TemperatureUnit.DegreeFahrenheit);

        EngineeringUnits.Ratio Ratio1 = M1 / M2;
        EngineeringUnits.Ratio Ratio2 = M2 / M1;

        EngineeringUnits.Ratio Ratio3 = T2 / T2;
        EngineeringUnits.Ratio Ratio4 = T1 / T2;

        EngineeringUnits.Ratio Ratio5 = F1 / F1;

        Assert.AreEqual(F1.SI / F1.SI, Ratio5.DecimalFraction);

        Assert.AreEqual(1 / 4d, Ratio1.DecimalFraction);
        Assert.AreEqual(4 / 1d, Ratio2.DecimalFraction);
        Assert.AreEqual(1d, Ratio3.DecimalFraction);
        Assert.AreEqual(T2.SI / T2.SI, Ratio3.DecimalFraction);

        Assert.AreEqual(0.98234151509800471d, Ratio4.DecimalFraction);
    }
}