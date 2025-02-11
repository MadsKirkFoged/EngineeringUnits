using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ForceTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Force(65.743, UnitsNet.Units.ForceUnit.Kilonewton);
        var A2 = new EngineeringUnits.Force(65.743, ForceUnit.Kilonewton);

        var WorkingCompares = 0;

        foreach (ForceUnit EU in UnitTypebase.ListOf<ForceUnit>())
        {

            var Error = 2E-5;
            var RelError = 6E-5;

            IEnumerable<UnitsNet.Units.ForceUnit> UNList = UnitsNet.Force.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.ForceUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.ForceUnit.Poundal)
                    Error = 0.2531900921021588;

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
        Assert.AreEqual(15, WorkingCompares);
    }
}
