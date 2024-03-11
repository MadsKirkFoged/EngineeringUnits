using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests;

[TestClass]
public class LuminousFluxTest
{

    [TestMethod]
    public void LuminousFluxAutoTest()
    {
        var A1 = new UnitsNet.LuminousFlux(1, UnitsNet.Units.LuminousFluxUnit.Lumen);
        var A2 = new EngineeringUnits.LuminousFlux(1, LuminousFluxUnit.Lumen);

        var WorkingCompares = 0;

        foreach (LuminousFluxUnit EU in UnitTypebase.ListOf<LuminousFluxUnit>())
        {

            var Error = 1E-3;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.LuminousFluxUnit> UNList = UnitsNet.LuminousFlux.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.LuminousFluxUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.LuminousFluxUnit.NanowattPerSquareMeter) Error = 0.0001220703125;

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