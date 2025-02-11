using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class MagnetizationTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Magnetization(1, UnitsNet.Units.MagnetizationUnit.AmperePerMeter);
        var A2 = new EngineeringUnits.Magnetization(1, MagnetizationUnit.AmperePerMeter);

        var WorkingCompares = 0;

        foreach (MagnetizationUnit EU in UnitTypebase.ListOf<MagnetizationUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.MagnetizationUnit> UNList = UnitsNet.Magnetization.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.MagnetizationUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.MagnetizationUnit.NanowattPerSquareMeter) Error = 0.0001220703125;

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
        Assert.AreEqual(1, WorkingCompares);

    }
}