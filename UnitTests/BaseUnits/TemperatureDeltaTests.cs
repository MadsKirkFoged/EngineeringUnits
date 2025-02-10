using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.BaseUnits;

[TestClass]
public class TemperatureDeltaTests
{

    [TestMethod]
    public void AutoTest()
    {
        // var A1 = new UnitsNet.TemperatureDelta(1, UnitsNet.Units.TemperatureDeltaUnit.DegreeCelsius);
        // var A2 = new EngineeringUnits.TemperatureDelta(1, TemperatureUnit.DegreeCelsius);

        // int WorkingCompares = 0;

        //foreach (var EU in Enumeration.ListOf<TemperatureUnit>())
        //{

        //    double Error = 3E-3;
        //    double RelError = 1E-5;

        //    var UNList = UnitsNet.TemperatureDelta.Units.Where(x => x.ToString() == EU.QuantityName);

        //    if (UNList.Count() == 1)
        //    {
        //        var UN = UNList.Single();

        //        //if (UN == UnitsNet.Units.TemperatureDeltaUnit.PicowattPerCubicFoot) Error = 0.0625;

        //        Debug.Print($"");
        //        Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
        //        Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
        //        Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
        //        Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                RelError);

        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                    A1.ToUnit(UN).ToString("a")
        //                    .Replace("min","m")

        //                    );

        //        WorkingCompares++;

        //    }

        //}

        //Number of comparables units
        //Assert.AreEqual(10, WorkingCompares);

    }
}