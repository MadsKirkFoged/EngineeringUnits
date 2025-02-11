using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class KinematicViscosityTests
{
    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.KinematicViscosity(65.743, UnitsNet.Units.KinematicViscosityUnit.Kilostokes);
        var A2 = new EngineeringUnits.KinematicViscosity(65.743, KinematicViscosityUnit.Kilostokes);

        var WorkingCompares = 0;

        foreach (KinematicViscosityUnit EU in UnitTypebase.ListOf<KinematicViscosityUnit>())
        {

            var Error = 2E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.KinematicViscosityUnit> UNList = UnitsNet.KinematicViscosity.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.KinematicViscosityUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.KinematicViscosityUnit.Nanostokes)
                    Error = 0.015625;

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
        Assert.AreEqual(8, WorkingCompares);
    }
}
