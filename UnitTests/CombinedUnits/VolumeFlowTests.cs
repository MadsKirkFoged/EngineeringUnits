using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace UnitTests.CombinedUnits;

[TestClass]
public class VolumeFlowTests
{
    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.VolumeFlow(65.743, UnitsNet.Units.VolumeFlowUnit.CubicFootPerHour);
        var A2 = new EngineeringUnits.VolumeFlow(65.743, VolumeFlowUnit.CubicFootPerHour);

        var WorkingCompares = 0;

        foreach (VolumeFlowUnit EU in UnitTypebase.ListOf<VolumeFlowUnit>())
        {

            var Error = 9E-4;
            var RelError = 4E-4;

            IEnumerable<UnitsNet.Units.VolumeFlowUnit> UNList = UnitsNet.VolumeFlow.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.VolumeFlowUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.VolumeFlowUnit.NanoliterPerDay)
                    Error = 0.5234375;
                if (UN == UnitsNet.Units.VolumeFlowUnit.UkGallonPerDay)
                    Error = 0.020195131377477082;

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
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol()
                                .Replace("day", "d"),
                                A1.ToUnit(UN).ToString("a")
                                .Replace("day", "d")
                                //.Replace("min", "m")
                                .Replace("L", "l")
                                .Replace("cy", "yd\u00b3")
                                .Replace("hr", "h")
                                );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(56, WorkingCompares);
    }
}
