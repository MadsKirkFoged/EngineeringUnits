using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests;

[TestClass]
public class MolarEntropyTest
{

    [TestMethod]
    public void MolarEntropyAutoTest()
    {
        var A1 = new UnitsNet.MolarEntropy(1, UnitsNet.Units.MolarEntropyUnit.KilojoulePerMoleKelvin);
        var A2 = new EngineeringUnits.MolarEntropy(1, MolarEntropyUnit.KilojoulePerMoleKelvin);

        var WorkingCompares = 0;

        foreach (MolarEntropyUnit EU in UnitTypebase.ListOf<MolarEntropyUnit>())
        {

            var Error = 1E-5;
            var RelError = 2E-4;

            IEnumerable<UnitsNet.Units.MolarEntropyUnit> UNList = UnitsNet.MolarEntropy.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.MolarEntropyUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.MolarEntropyUnit.NanowattPerSquareMeter) Error = 0.0001220703125;

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
                Assert.AreEqual(
                    A2.ToUnit(EU).DisplaySymbol(),
                    A1.ToUnit(UN).ToString("a")
                        .Replace('*', '\u00b7')
                        );

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(3, WorkingCompares);

    }
}