using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests;

[TestClass]
public class MassMomentOfInertiaTest
{

    [TestMethod]
    public void MassMomentOfInertiaAutoTest()
    {
        var A1 = new UnitsNet.MassMomentOfInertia(1, UnitsNet.Units.MassMomentOfInertiaUnit.KilogramSquareDecimeter);
        var A2 = new EngineeringUnits.MassMomentOfInertia(1, MassMomentOfInertiaUnit.KilogramSquareDecimeter);

        var WorkingCompares = 0;

        foreach (MassMomentOfInertiaUnit EU in UnitTypebase.ListOf<MassMomentOfInertiaUnit>())
        {

            var Error = 1E-5;
            var RelError = 2E-4;

            IEnumerable<UnitsNet.Units.MassMomentOfInertiaUnit> UNList = UnitsNet.MassMomentOfInertia.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.MassMomentOfInertiaUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.MassMomentOfInertiaUnit.NanowattPerSquareMeter) Error = 0.0001220703125;

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
                //Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                //            A1.ToUnit(UN).ToString("a")

                //            );

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(28, WorkingCompares);

    }
}