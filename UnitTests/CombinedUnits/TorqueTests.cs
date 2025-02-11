using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class TorqueTests
{
    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Torque(65.743, UnitsNet.Units.TorqueUnit.KilonewtonMeter);
        var A2 = new EngineeringUnits.Torque(65.743, TorqueUnit.KilonewtonMeter);

        var WorkingCompares = 0;

        foreach (TorqueUnit EU in UnitTypebase.ListOf<TorqueUnit>())
        {

            var Error = 2E-4;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.TorqueUnit> UNList = UnitsNet.Torque.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.TorqueUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.TorqueUnit.KilogramForceCentimeter)
                    Error = 0.013645293889567256;
                if (UN == UnitsNet.Units.TorqueUnit.KilogramForceMillimeter)
                    Error = 0.13645293843001127;

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
        Assert.AreEqual(22, WorkingCompares);
    }
}
