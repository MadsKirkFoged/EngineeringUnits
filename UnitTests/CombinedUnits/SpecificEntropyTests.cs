using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace UnitTests.CombinedUnits;

[TestClass]
public class SpecificEntropyTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.SpecificEntropy(65.743, UnitsNet.Units.SpecificEntropyUnit.KilocaloriePerGramKelvin);
        var A2 = new EngineeringUnits.SpecificEntropy(65.743, SpecificEntropyUnit.KilocaloriePerGramKelvin);

        var WorkingCompares = 0;

        foreach (SpecificEntropyUnit EU in UnitTypebase.ListOf<SpecificEntropyUnit>())
        {

            var Error = 1E-5;
            var RelError = 4E-4;

            IEnumerable<UnitsNet.Units.SpecificEntropyUnit> UNList = UnitsNet.SpecificEntropy.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.SpecificEntropyUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit)
                    Error = 0.25825910954154097;

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
                                .Replace(".", "*")
                                .Replace("C", "K")
                                .Replace("\u00b0F", "\u00b0R")
                                .Replace('*', '\u00b7')
                                );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(9, WorkingCompares);
    }

}
