using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class SpecificHeatCapacityTests
{

    [TestMethod]
    public void Compare()
    {

        //BtuPerPoundFahrenheit should have been named BtuPerPoundRankine
        //Rankine to Fahrenheit, is what Kelvin is to DegreeCelsius

        UnitsNet.SpecificEntropy L1 = new(1, UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin);
        EngineeringUnits.SpecificEntropy L2 = new(1, SpecificEntropyUnit.JoulePerKilogramKelvin);

        Assert.AreEqual(0, L2.As(SpecificEntropyUnit.BtuPerPoundRankine) - L1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit), 9.4E-10);
        Assert.AreEqual(0, L2.As(SpecificEntropyUnit.JoulePerKilogramKelvin) - L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin), 0);

    }

    [TestMethod]
    public void Compare2()
    {

        //BtuPerPoundFahrenheit should have been named BtuPerPoundRankine
        //Rankine to Fahrenheit, is what Kelvin is to DegreeCelsius

        UnitsNet.SpecificEntropy L1 = new(1, UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit);
        EngineeringUnits.SpecificEntropy L2 = new(1, SpecificEntropyUnit.BtuPerPoundRankine);

        //Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)}");
        //Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin)}");

        //UnitsNet: 4186,8
        //EngineeringUnits: 4186,816458133984

        //UnitsNet dont not use a high precision for this conversion

        Assert.AreEqual(0, L2.As(SpecificEntropyUnit.BtuPerPoundRankine) - L1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit), 0);
        Assert.AreEqual(0, L2.As(SpecificEntropyUnit.JoulePerKilogramKelvin) - L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin), 0.02);

        //Difference in procent
        Assert.AreEqual(0, HelperClass.Percent(L2.As(SpecificEntropyUnit.JoulePerKilogramKelvin), L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)), 0.0004);

    }
}
