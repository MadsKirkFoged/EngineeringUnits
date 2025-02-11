using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class InformationTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Information(1, UnitsNet.Units.InformationUnit.Byte);
        var A2 = new EngineeringUnits.Information(1, InformationUnit.Byte);

        var WorkingCompares = 0;

        foreach (InformationUnit EU in UnitTypebase.ListOf<InformationUnit>())
        {

            var Error = 1E-4;
            var RelError = 1E-3;

            IEnumerable<UnitsNet.Units.InformationUnit> UNList = UnitsNet.Information.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.InformationUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.InformationUnit.CaloriePerSecondSquareCentimeter) RelError = 0.06687685105569595;

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
        Assert.AreEqual(26, WorkingCompares);

    }
}