using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ElectricPotentialDcTest
{

    [TestMethod]
    public void ElectricPotentialDcAutoTest()
    {
        var A1 = new UnitsNet.ElectricPotentialDc(1, UnitsNet.Units.ElectricPotentialDcUnit.MicrovoltDc);
        var A2 = new EngineeringUnits.ElectricPotentialDc(1, ElectricPotentialUnit.Microvolt);

        var WorkingCompares = 0;

        foreach (ElectricPotentialUnit EU in UnitTypebase.ListOf<ElectricPotentialUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.ElectricPotentialDcUnit> UNList = UnitsNet.ElectricPotentialDc.Units.Where(x => x.ToString() == EU.QuantityName + "Dc");

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.ElectricPotentialDcUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.ElectricPotentialDcUnit.SquareMicrometer) Error = 2629720.0009765625;

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

                                .Replace("dc", "")
                                );

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(5, WorkingCompares);

    }
}