using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests;

[TestClass]
public class PermittivityTest
{

    [TestMethod]
    public void PermittivityAutoTest()
    {
        var A1 = new UnitsNet.Permittivity(1, UnitsNet.Units.PermittivityUnit.FaradPerMeter);
        var A2 = new EngineeringUnits.Permittivity(1, PermittivityUnit.FaradPerMeter);

        var WorkingCompares = 0;

        foreach (PermittivityUnit EU in UnitTypebase.ListOf<PermittivityUnit>())
        {

            var Error = 1E-5;
            var RelError = 2E-4;

            IEnumerable<UnitsNet.Units.PermittivityUnit> UNList = UnitsNet.Permittivity.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.PermittivityUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.PermittivityUnit.NanowattPerSquareMeter) Error = 0.0001220703125;

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