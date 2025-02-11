using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class HeatTransferCoefficientTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.HeatTransferCoefficient(65.743, UnitsNet.Units.HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);
        var A2 = new EngineeringUnits.HeatTransferCoefficient(65.743, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);

        var WorkingCompares = 0;

        foreach (HeatTransferCoefficientUnit EU in UnitTypebase.ListOf<HeatTransferCoefficientUnit>())
        {

            var Error = 1E-5;
            var RelError = 4E-4;

            IEnumerable<UnitsNet.Units.HeatTransferCoefficientUnit> UNList = UnitsNet.HeatTransferCoefficient.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.HeatTransferCoefficientUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.HeatTransferCoefficientUnit.WattPerSquareMeterKelvin)
                    Error = 0.0014674503834157804;
                if (UN == UnitsNet.Units.HeatTransferCoefficientUnit.WattPerSquareMeterCelsius)
                    Error = 0.0014674503834157804;

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
                        .Replace("\u00b7", "")
                        );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(3, WorkingCompares);
    }
}
