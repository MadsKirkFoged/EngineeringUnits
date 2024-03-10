using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class CoefficientOfThermalExpansionTest
{

    //We dont agree on using Temperature and deltaTemperature..

    //[TestMethod]
    //public void CoefficientOfThermalExpansionAutoTest()
    //{
    //    var A1 = new UnitsNet.CoefficientOfThermalExpansion(1, UnitsNet.Units.CoefficientOfThermalExpansionUnit.InverseKelvin);
    //    var A2 = new EngineeringUnits.CoefficientOfThermalExpansion(1, EngineeringUnits.CoefficientOfThermalExpansionUnit.InverseKelvin);

    //    int WorkingCompares = 0;

    //    foreach (var EU in Enumeration.ListOf<CoefficientOfThermalExpansionUnit>())
    //    {

    //        double Error = 1E-5;
    //        double RelError = 1E-5;

    //        var UNList = UnitsNet.CoefficientOfThermalExpansion.Units.Where(x => x.ToString() == EU.QuantityName);

    //        if (UNList.Count() == 1)
    //        {
    //            var UN = UNList.Single();

    //            //if (UN == UnitsNet.Units.CoefficientOfThermalExpansionUnit.SquareMicrometer) Error = 2629720.0009765625;

    //            Debug.Print($"");
    //            Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
    //            Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
    //            Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
    //            Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

    //            //All units absolute difference
    //            Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

    //            //All units relative difference
    //            Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
    //                                                    A1.As(UN)),
    //                                                    RelError);
    //            //All units symbol compare
    //            Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
    //                            A1.ToUnit(UN).ToString("a"));

    //            WorkingCompares++;

    //        }

    //    }

    //    //Number of comparables units
    //    Assert.AreEqual(7, WorkingCompares);

    //}
}