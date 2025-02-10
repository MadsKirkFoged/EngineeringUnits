using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class LuminosityTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Luminosity(1, UnitsNet.Units.LuminosityUnit.Watt);
        var A2 = new EngineeringUnits.Luminosity(1, PowerUnit.Watt);

        var WorkingCompares = 0;

        foreach (PowerUnit EU in UnitTypebase.ListOf<PowerUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.LuminosityUnit> UNList = UnitsNet.Luminosity.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.LuminosityUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.LuminosityUnit.Femtowatt)
                    Error = 0.125;
                if (UN == UnitsNet.Units.LuminosityUnit.SolarLuminosity)
                    RelError = 0.004000160006396456;

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
        Assert.AreEqual(14, WorkingCompares);
    }
}