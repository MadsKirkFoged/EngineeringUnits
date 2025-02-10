using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class MolarEnergyTest
{

    [TestMethod]
    public void MolarEnergyAutoTest()
    {
        var A1 = new UnitsNet.MolarEnergy(1, UnitsNet.Units.MolarEnergyUnit.KilojoulePerMole);
        var A2 = new EngineeringUnits.MolarEnergy(1, MolarEnergyUnit.KilojoulePerMole);

        var WorkingCompares = 0;

        foreach (MolarEnergyUnit EU in UnitTypebase.ListOf<MolarEnergyUnit>())
        {

            var Error = 1E-5;
            var RelError = 2E-4;

            IEnumerable<UnitsNet.Units.MolarEnergyUnit> UNList = UnitsNet.MolarEnergy.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.MolarEnergyUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.MolarEnergyUnit.NanowattPerSquareMeter) Error = 0.0001220703125;

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
        Assert.AreEqual(3, WorkingCompares);

    }
}