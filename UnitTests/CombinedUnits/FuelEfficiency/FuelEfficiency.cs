using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class FuelEfficiencyTest
{

    [TestMethod]
    public void FuelEfficiencyAutoTest()
    {
        var A1 = new UnitsNet.FuelEfficiency(1, UnitsNet.Units.FuelEfficiencyUnit.KilometerPerLiter);
        var A2 = new EngineeringUnits.FuelEfficiency(1, FuelEfficiencyUnit.KilometerPerLiter);

        var WorkingCompares = 0;

        foreach (FuelEfficiencyUnit EU in UnitTypebase.ListOf<FuelEfficiencyUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.FuelEfficiencyUnit> UNList = UnitsNet.FuelEfficiency.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.FuelEfficiencyUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.FuelEfficiencyUnit.MilePerUkGallon)
                    RelError = 4.135417875461006E-05;

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

                                .Replace("L", "l")

                                );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(3, WorkingCompares);
    }
}