using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ForceChangeRateTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.ForceChangeRate(1, UnitsNet.Units.ForceChangeRateUnit.DecanewtonPerSecond);
        var A2 = new EngineeringUnits.ForceChangeRate(1, ForceChangeRateUnit.DecanewtonPerSecond);

        var WorkingCompares = 0;

        foreach (ForceChangeRateUnit EU in UnitTypebase.ListOf<ForceChangeRateUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.ForceChangeRateUnit> UNList = UnitsNet.ForceChangeRate.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.ForceChangeRateUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.ForceChangeRateUnit.NanoohmMeter) Error = 0.0001220703125;

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

                                //.Replace("min", "m")
                                .Replace("kipf", "klbf")
                                );

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(15, WorkingCompares);

    }
}