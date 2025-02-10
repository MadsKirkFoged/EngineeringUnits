using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class PressureChangeRateTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.PressureChangeRate(1, UnitsNet.Units.PressureChangeRateUnit.MegapascalPerMinute);
        var A2 = new EngineeringUnits.PressureChangeRate(1, PressureChangeRateUnit.MegapascalPerMinute);

        var WorkingCompares = 0;

        foreach (PressureChangeRateUnit EU in UnitTypebase.ListOf<PressureChangeRateUnit>())
        {

            var Error = 7E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.PressureChangeRateUnit> UNList = UnitsNet.PressureChangeRate.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.PressureChangeRateUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.PressureChangeRateUnit.PicowattPerCubicFoot) Error = 0.0625;

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
        Assert.AreEqual(13, WorkingCompares);

    }
}