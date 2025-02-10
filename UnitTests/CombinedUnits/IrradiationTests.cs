using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class IrradiationTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Irradiation(1, UnitsNet.Units.IrradiationUnit.JoulePerSquareMeter);
        var A2 = new EngineeringUnits.Irradiation(1, IrradiationUnit.JoulePerSquareMeter);

        var WorkingCompares = 0;

        foreach (IrradiationUnit EU in UnitTypebase.ListOf<IrradiationUnit>())
        {

            var Error = 1E-4;
            var RelError = 1E-3;

            IEnumerable<UnitsNet.Units.IrradiationUnit> UNList = UnitsNet.Irradiation.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.IrradiationUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.IrradiationUnit.NanowattPerSquareMeter) Error = 0.0001220703125;

                Debug.Print($"");
                Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                Debug.Print($"UnitsNets:       {A1.ToUnit(UN):a}");
                Debug.Print($"EngineeringUnit: {A2.ToUnit(EU).DisplaySymbol()}");

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
        Assert.AreEqual(7, WorkingCompares);

    }
}