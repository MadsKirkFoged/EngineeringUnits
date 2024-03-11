using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class IntelligentUnits
{
    [TestMethod]
    public void TestIntelligentUnits01()
    {
        var voltage1 = ElectricPotential.From(3, ElectricPotentialUnit.Millivolt); // 3 millivolts
        var current1 = ElectricCurrent.From(5, ElectricCurrentUnit.Milliampere); // 5 milliamps

        Power power1 = voltage1 * current1; // 15 microwatts
        UnknownUnit power2 = voltage1 * current1;
        dynamic power3 = voltage1 * current1;
        UnknownUnit power4 = voltage1 * current1;

        Assert.IsTrue(power1.ToString().Contains('W')); // needs to be in watts, not kg * m2 / s3
        Assert.AreEqual(power1.ToString(), power2.ToString());
        Assert.AreEqual(power1.ToString(), power3.ToString());
        Assert.AreEqual(power1.ToString(), power4.ToString());
    }

    [TestMethod]
    public void TestIntelligentUnits02()
    {
        UnknownUnit repetitions = Length.FromMeter(240) / Length.FromMeter(1); // TODO: Replace this with a Dimensionless scalar when that is supported !
        var minute = Duration.FromSecond(2);

        Frequency freq1 = repetitions / minute; // 2 Hertz
        UnknownUnit freq2 = repetitions / minute;
        dynamic freq3 = repetitions / minute;
        UnknownUnit freq4 = repetitions / minute;

        Assert.IsTrue(freq1.ToString().Contains("Hz")); // needs to be in Hertz, not 1 / s
        Assert.AreEqual(freq1.ToString(), freq2.ToString());
        Assert.AreEqual(freq1.ToString(), freq3.ToString());
        Assert.AreEqual(freq1.ToString(), freq4.ToString());
    }

    [TestMethod]
    public void TestIntelligentUnits03()
    {
        SpecificEntropy P1 = new(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
        MassFlow M1 = new(1, MassFlowUnit.KilogramPerSecond);
        Temperature T2 = new(10, TemperatureUnit.DegreeCelsius);
        Temperature T1 = new(5, TemperatureUnit.DegreeCelsius);

        Power Q1 = M1 * P1 * (T2 - T1);
        UnknownUnit Q2 = M1 * P1 * (T2 - T1);
        dynamic Q3 = M1 * P1 * (T2 - T1);
        UnknownUnit Q4 = M1 * P1 * (T2 - T1);

        Assert.IsTrue(Q1.ToString().Contains('W')); // needs to be in watts, not kg * m2 / s3
        Assert.AreEqual(Q1.ToString(), Q2.ToString());
        Assert.AreEqual(Q1.ToString(), Q3.ToString());
        Assert.AreEqual(Q1.ToString(), Q4.ToString());
    }

    [TestMethod]
    public void TestIntelligentUnits04()
    {
        var charge = ElectricCharge.FromCoulomb(27e-6);
        var voltage = ElectricPotential.FromVolt(3);
        var length = Length.FromMeter(9);

        Permittivity p1 = charge / voltage / length;
        UnknownUnit p2 = charge / voltage / length;
        dynamic p3 = charge / voltage / length;
        UnknownUnit p4 = charge / voltage / length;

        Assert.IsTrue(p1.ToString().Contains('F')); // needs to be in Farads per meter
        Assert.IsTrue(p1.ToString().Contains('m'));
        Assert.AreEqual(p1.ToString(), p2.ToString());
        Assert.AreEqual(p1.ToString(), p3.ToString());
        Assert.AreEqual(p1.ToString(), p4.ToString());
    }
}
