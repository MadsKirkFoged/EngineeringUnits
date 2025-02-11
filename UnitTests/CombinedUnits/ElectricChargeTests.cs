using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ElectricChargeTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.ElectricCharge(1, UnitsNet.Units.ElectricChargeUnit.AmpereHour);
        var A2 = new EngineeringUnits.ElectricCharge(1, ElectricChargeUnit.AmpereHour);

        var WorkingCompares = 0;

        foreach (ElectricChargeUnit EU in UnitTypebase.ListOf<ElectricChargeUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.ElectricChargeUnit> UNList = UnitsNet.ElectricCharge.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.ElectricChargeUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.ElectricChargeUnit.SquareMicrometer) Error = 2629720.0009765625;

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
        Assert.AreEqual(5, WorkingCompares);

    }
}