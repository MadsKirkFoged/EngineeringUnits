using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ElectricChargeDensityTests
{

    [TestMethod]
    public void ElectricChargeDensityAutoTest()
    {
        var A1 = new UnitsNet.ElectricChargeDensity(1, UnitsNet.Units.ElectricChargeDensityUnit.CoulombPerCubicMeter);
        var A2 = new EngineeringUnits.ElectricChargeDensity(1, ElectricChargeDensityUnit.CoulombPerCubicMeter);

        var WorkingCompares = 0;

        foreach (ElectricChargeDensityUnit EU in UnitTypebase.ListOf<ElectricChargeDensityUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.ElectricChargeDensityUnit> UNList = UnitsNet.ElectricChargeDensity.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.ElectricChargeDensityUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.ElectricChargeDensityUnit.SquareMicrometer) Error = 2629720.0009765625;

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
                                A1.ToUnit(UN).ToString("a"));

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(1, WorkingCompares);

    }
}