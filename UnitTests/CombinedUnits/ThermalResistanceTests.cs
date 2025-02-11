using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ThermalResistanceTests
{
    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.ThermalResistance(65.743, UnitsNet.Units.ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
        var A2 = new EngineeringUnits.ThermalResistance(65.743, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);

        var WorkingCompares = 0;

        foreach (ThermalResistanceUnit EU in UnitTypebase.ListOf<ThermalResistanceUnit>())
        {

            var Error = 3E-4;
            var RelError = 1E-1;

            IEnumerable<UnitsNet.Units.ThermalResistanceUnit> UNList = UnitsNet.ThermalResistance.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.ThermalResistanceUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie)
                    Error = 0.0542845837316861;

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
                                A1.ToUnit(UN).ToString("a"));

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(5, WorkingCompares);
    }
}
