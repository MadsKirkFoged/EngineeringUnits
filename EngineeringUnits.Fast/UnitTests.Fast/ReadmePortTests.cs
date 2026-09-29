using EngineeringUnits.Fast;
using EngineeringUnits.NumberExtensions.NumberToDensity.Fast;
using EngineeringUnits.NumberExtensions.NumberToLength.Fast;
using EngineeringUnits.NumberExtensions.NumberToMass.Fast;
using EngineeringUnits.NumberExtensions.NumberToMassFlow.Fast;
using EngineeringUnits.NumberExtensions.NumberToSpecificEntropy.Fast;
using EngineeringUnits.NumberExtensions.NumberToTemperature.Fast;
using EngineeringUnits.NumberExtensions.NumberToVolume.Fast;

using EngineeringUnits.Units.Fast;

namespace UnitTests.Fast;

/// <summary>
/// Every code sample from the EngineeringUnits README, ported. Lines marked CHANGED are what porting code needs;
/// everything else compiles unchanged (apart from the namespace).<br></br>
/// NOT PORTED: the Parse samples (Length.Parse("10 m"), UnknownUnit.Parse/Eval) - Fast has no parser.
/// </summary>
[TestClass]
public class ReadmePortTests
{
    [TestMethod]
    public void TheOnlyPlaceYouCareAboutUnitsIsAtTheEdge()
    {
        double inputfield = 21;
        Temperature tIn = Temperature.FromDegreesCelsius(inputfield);
        Temperature tOut = tIn - 10.Kelvin;

        // CHANGED: no ToUnit() - values are stored in SI. Pick the unit when you print or export.
        string output2 = tOut.ToString(TemperatureUnit.DegreeFahrenheit, "S2");

        Assert.AreEqual(11, tOut.DegreeCelsius, 1e-12);
        Assert.AreEqual("52 °F", output2);
    }

    [TestMethod]
    public void UnitSafeEngineeringMath()
    {
        SpecificEntropy p1 = 1.JoulePerKilogramKelvin;
        MassFlow m1 = 1.KilogramPerSecond;
        Temperature t2 = 10.DegreeCelsius;
        Temperature t1 = 5.DegreeCelsius;

        Power q = m1 * p1 * (t2 - t1);
        Assert.AreEqual(5, q.Watt, 1e-12);
    }

    [TestMethod]
    public void Conversion()
    {
        Length oneMeter = 1.Meter;

        // CHANGED: ToUnit(Foot) + ToUnit(Meter) is a no-op in Fast (always SI), so round trips are trivially exact.
        // Converting a number in and out of a unit is what can round:
        double inFoot = oneMeter.Foot;
        Length backToMeter = Length.FromFoot(inFoot);

        Assert.IsTrue(oneMeter.IsCloseTo(backToMeter));   // CHANGED: == would be an exact double compare
    }

    [TestMethod]
    public void CreatingQuantities()
    {
        Length length1 = Length.FromYard(1);
        Length length2 = new Length(1, LengthUnit.Yard);
        Length length3 = 1.Yard;
        Assert.AreEqual(length1, length2);
        Assert.AreEqual(length1, length3);
    }

    [TestMethod]
    public void ExportingValues()
    {
        Speed drivingSpeed = Speed.FromKilometerPerHour(60);

        double mph = drivingSpeed.As(SpeedUnit.MilePerHour);
        Assert.AreEqual(37.28227, mph, 1e-5);

        // CHANGED: EngineeringUnits prints "60 km/h" (it remembers the unit). Fast prints SI unless you pick a unit.
        Assert.AreEqual("16.67 m/s", drivingSpeed.ToString());
        Assert.AreEqual("60 km/h", drivingSpeed.ToString(SpeedUnit.KilometerPerHour));
        Assert.AreEqual("37.28 mph", drivingSpeed.ToString(SpeedUnit.MilePerHour));
    }

    [TestMethod]
    public void Helpers()
    {
        MassFlow m1 = MassFlow.FromKilogramPerSecond(-10);
        MassFlow m2 = m1.Abs();
        Assert.AreEqual(10, m2.KilogramPerSecond);

        Length l1 = Length.FromMeter(5);
        Length l2 = Length.FromMeter(15);
        Length min = Length.Min(l1, l2);                 // CHANGED: (l1, l2).Min() is not ported
        Length avg = new[] { l1, l2 }.Average();          // CHANGED: (l1, l2).Average() is not ported
        var list = new List<Length> { l1, l2 };
        Length max = list.Max();
        Assert.AreEqual(5, min.Meter); Assert.AreEqual(10, avg.Meter); Assert.AreEqual(15, max.Meter);

        Length l3 = new Length(54.3, LengthUnit.Foot);
        Area a1 = l3.Pow(2);
        Length l4 = a1.Sqrt();
        Assert.AreEqual(54.3, l4.Foot, 1e-12);

        Power pMin = Power.FromWatt(-5), pMax = Power.FromWatt(5);
        Assert.AreEqual(5, Power.FromWatt(19).Clamp(pMin, pMax).Watt);
        Assert.AreEqual(-5, Power.FromWatt(-19).Clamp(pMin, pMax).Watt);
    }

    [TestMethod]
    public void Currency()
    {
        // NOT PORTED: ExchangeRates and €/£/kr units. USD units work:
        Cost price = Cost.FromMillionUSDollar(10);
        Length road = Length.FromKilometer(10);
        LengthCost pricePerLength = price / road;
        Assert.AreEqual(1000, pricePerLength.USDollarPerMeter, 1e-9);
    }

    [TestMethod]
    public void PhysicalConstants()
    {
        Energy e = Mass.FromKilogram(1) * Constants.SpeedOfLight.Pow(2);
        Assert.AreEqual(8.987551787368176e16, e.Joule, 1);
    }

    [TestMethod]
    public void CatchUnitMistakesEarly()
    {
        Mass mass = 10.Kilogram;
        Volume volume = 4.CubicMeter;
        Density d1 = mass / volume;
        Assert.AreEqual(2.5, d1.KilogramPerCubicMeter);

        // Density d2 = volume / mass;   -> error EUF0001 (see the analyzer tests)
    }
}
