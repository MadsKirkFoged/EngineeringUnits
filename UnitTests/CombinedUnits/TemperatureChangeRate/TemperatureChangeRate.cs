using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests;

[TestClass]
public class TemperatureChangeRateTest
{

    [TestMethod]
    public void TemperatureChangeRateAutoTest()
    {
        var A1 = new UnitsNet.TemperatureChangeRate(1, UnitsNet.Units.TemperatureChangeRateUnit.DegreeCelsiusPerMinute);
        var A2 = new EngineeringUnits.TemperatureChangeRate(1, TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        var WorkingCompares = 0;

        foreach (TemperatureChangeRateUnit EU in UnitTypebase.ListOf<TemperatureChangeRateUnit>())
        {

            var Error = 3E-3;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.TemperatureChangeRateUnit> UNList = UnitsNet.TemperatureChangeRate.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.TemperatureChangeRateUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.TemperatureChangeRateUnit.PicowattPerCubicFoot) Error = 0.0625;

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
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                            A1.ToUnit(UN).ToString("a")
                            //.Replace("min","m")

                            );

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(10, WorkingCompares);

    }
}