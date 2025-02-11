using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Functionality;

[TestClass]
public class ToStringTest
{

    [TestMethod]
    public void DisplaySignificantDigits()
    {
        Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(-1));
        Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(0));
        Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(1));
        Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(2));
        Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(3));
        Assert.AreEqual("100", 100.005m.DisplaySignificantDigits(4));
        Assert.AreEqual("100.01", 100.005m.DisplaySignificantDigits(5));
        Assert.AreEqual("100.005", 100.005m.DisplaySignificantDigits(6));
        Assert.AreEqual("100.005", 100.005m.DisplaySignificantDigits(7));

        Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(-1));
        Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(0));
        Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(1));
        Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(2));
        Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(3));
        Assert.AreEqual("-100", (-100.005m).DisplaySignificantDigits(4));
        Assert.AreEqual("-100.01", (-100.005m).DisplaySignificantDigits(5));
        Assert.AreEqual("-100.005", (-100.005m).DisplaySignificantDigits(6));
        Assert.AreEqual("-100.005", (-100.005m).DisplaySignificantDigits(7));

        Assert.AreEqual("0", 0.004m.DisplaySignificantDigits(0));
        Assert.AreEqual("0", 0.004m.DisplaySignificantDigits(1));
        Assert.AreEqual("0", 0.004m.DisplaySignificantDigits(2));
        Assert.AreEqual("0", 0.004m.DisplaySignificantDigits(3));
        Assert.AreEqual("0.004", 0.004m.DisplaySignificantDigits(4));
        Assert.AreEqual("0.004", 0.004m.DisplaySignificantDigits(5));

        Assert.AreEqual("0", 0.0045m.DisplaySignificantDigits(0));
        Assert.AreEqual("0", 0.0045m.DisplaySignificantDigits(1));
        Assert.AreEqual("0", 0.0045m.DisplaySignificantDigits(2));
        Assert.AreEqual("0", 0.0045m.DisplaySignificantDigits(3));
        Assert.AreEqual("0.005", 0.0045m.DisplaySignificantDigits(4));
        Assert.AreEqual("0.0045", 0.0045m.DisplaySignificantDigits(5));

        Assert.AreEqual("0", (-0.0045m).DisplaySignificantDigits(0));
        Assert.AreEqual("0", (-0.0045m).DisplaySignificantDigits(1));
        Assert.AreEqual("0", (-0.0045m).DisplaySignificantDigits(2));
        Assert.AreEqual("0", (-0.0045m).DisplaySignificantDigits(3));
        Assert.AreEqual("-0.005", (-0.0045m).DisplaySignificantDigits(4));
        Assert.AreEqual("-0.0045", (-0.0045m).DisplaySignificantDigits(5));

        Assert.AreEqual("-879746", (-879746.13216645m).DisplaySignificantDigits(0));
        Assert.AreEqual("-789794.1111546987", (-789794.1111546987m).DisplaySignificantDigits(20));
        Assert.AreEqual("-789794.111154699", (-789794.1111546987m).DisplaySignificantDigits(15));
        Assert.AreEqual("-789794.1112", (-789794.1111546987m).DisplaySignificantDigits(10));
        Assert.AreEqual("-789794.1", (-789794.1111546987m).DisplaySignificantDigits(7));
        Assert.AreEqual("-789794.2", (-789794.1911546987m).DisplaySignificantDigits(7));

    }

    [TestMethod]
    public void ToStringS()
    {

        var value = 10.572455m;

        var T1 = new Temperature(value, TemperatureUnit.DegreeCelsius);
        var T2 = new Temperature(value, TemperatureUnit.Kelvin);
        var T3 = new Temperature(value, TemperatureUnit.DegreeFahrenheit);

        Assert.AreEqual("11 °C", $"{T1:S0}");
        Assert.AreEqual("11 K", $"{T2:S0}");
        Assert.AreEqual("11 °F", $"{T3:S0}");

        Assert.AreEqual("10.6 °C", $"{T1:S3}");
        Assert.AreEqual("10.6 K", $"{T2:S3}");
        Assert.AreEqual("10.6 °F", $"{T3:S3}");

        Assert.AreEqual("10.57 °C", $"{T1:S4}");
        Assert.AreEqual("10.57 K", $"{T2:S4}");
        Assert.AreEqual("10.57 °F", $"{T3:S4}");

        Assert.AreEqual("10.572455 °C", $"{T1:S20}");
        Assert.AreEqual("10.572455 K", $"{T2:S20}");
        Assert.AreEqual("10.572455 °F", $"{T3:S20}");

        Assert.AreEqual("°C", $"{T1:UnitOnly}");
        Assert.AreEqual("K", $"{T2:UnitOnly}");
        Assert.AreEqual("°F", $"{T3:UnitOnly}");

        Assert.AreEqual("11", $"{T1:V0}");
        Assert.AreEqual("10.572", $"{T2:V5}");
        Assert.AreEqual("10.572455", $"{T3:V10}");

    }
}
