using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class HeatFluxTest
{

    [TestMethod]
    public void HeatFluxAutoTest()
    {
        var A1 = new UnitsNet.HeatFlux(1, UnitsNet.Units.HeatFluxUnit.WattPerSquareMeter);
        var A2 = new EngineeringUnits.HeatFlux(1, HeatFluxUnit.WattPerSquareMeter);

        var WorkingCompares = 0;

        foreach (HeatFluxUnit EU in UnitTypebase.ListOf<HeatFluxUnit>())
        {

            var Error = 1E-4;
            var RelError = 1E-3;

            IEnumerable<UnitsNet.Units.HeatFluxUnit> UNList = UnitsNet.HeatFlux.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.HeatFluxUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.HeatFluxUnit.CaloriePerSecondSquareCentimeter)
                    RelError = 0.06687685105569595;
                if (UN == UnitsNet.Units.HeatFluxUnit.KilocaloriePerHourSquareMeter)
                    Error = 0.0005754222366169959;
                if (UN == UnitsNet.Units.HeatFluxUnit.KilocaloriePerHourSquareMeter)
                    RelError = 0.06687685105570863;
                if (UN == UnitsNet.Units.HeatFluxUnit.KilocaloriePerSecondSquareCentimeter)
                    RelError = 0.06687685105571355;

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

                                );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(18, WorkingCompares);
    }
}