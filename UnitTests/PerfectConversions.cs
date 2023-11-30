using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;

[TestClass]
public class PerfectConversions
{

    [TestMethod]
    public void MeterToKilometer()
    {
        var meter = new Length(1000, LengthUnit.Meter);
        var kilometer = new Length(1, LengthUnit.Kilometer);

        Assert.AreEqual(meter, kilometer);
    }

    [TestMethod]
    public void MeterToKilometerDoubleSmallDiff1()
    {
        var meter = new Length(1000.00000000001d, LengthUnit.Meter);
        var kilometer = new Length(1, LengthUnit.Kilometer);

        Assert.AreNotEqual(meter, kilometer);
    }

    [TestMethod]
    public void MeterToKilometerDoubleSmallDiff2()
    {
        var meter = new Length(999.99999999999d, LengthUnit.Meter);
        var kilometer = new Length(1, LengthUnit.Kilometer);

        Assert.AreNotEqual(meter, kilometer);
    }



    [TestMethod]
    public void MeterToKilometerDecimalSmallDiff1()
    {
        var meter = new Length(1000.000000000000000000000001m, LengthUnit.Meter);
        var kilometer = new Length(1, LengthUnit.Kilometer);

        Assert.AreNotEqual(meter, kilometer);
    }

    [TestMethod]
    public void MeterToKilometerDecimalSmallDiff2()
    {
        var meter = new Length(999.9999999999999999999999999m, LengthUnit.Meter);
        var kilometer = new Length(1, LengthUnit.Kilometer);

        Assert.AreNotEqual(meter, kilometer);
    }

    //Add unit test from degresscelcius to Fahrenheit


    [TestMethod]
    public void FeetToYard()
    {
        var Foot = new Length(3, LengthUnit.Foot);
        var Yard = new Length(1, LengthUnit.Yard);

        Assert.AreEqual(Foot, Yard);
    }

    //Add unit test from Mil  to Twip
    [TestMethod]
    public void MileToTwip()
    {
        var Mile = new Length(1, LengthUnit.Mil);
        var Twip = new Length(1.44m, LengthUnit.Twip);

        Assert.AreEqual(Mile, Twip);
    }

    //Add unit test from Mile to Microinch
    [TestMethod]
    public void MileToMicroinch()
    {
        var Mile = new Length(1, LengthUnit.Mile);
        var Microinch = new Length(63360000000m, LengthUnit.Microinch);

        Assert.AreEqual(Mile, Microinch);
    }

    //Add unit test from Fahrenheit to kelvin
    [TestMethod]
    public void FahrenheitToKelvin()
    {
        var Fahrenheit = new Temperature(32, TemperatureUnit.DegreeFahrenheit);
        var Kelvin = new Temperature(273.15m, TemperatureUnit.Kelvin);

        Assert.AreEqual(Fahrenheit, Kelvin);
    }

    //Add unit test from degresscelcius to kelvin
    [TestMethod]
    public void DegreeCelsiusToKelvin()
    {
        var DegreeCelsius = new Temperature(0, TemperatureUnit.DegreeCelsius);
        var Kelvin = new Temperature(273.15m, TemperatureUnit.Kelvin);

        Assert.AreEqual(DegreeCelsius, Kelvin);
    }

    //Add unit test from degresscelcius to Fahrenheit
    [TestMethod]
    public void DegreeCelsiusToFahrenheit()
    {
        var DegreeCelsius = new Temperature(0, TemperatureUnit.DegreeCelsius);
        var Fahrenheit = new Temperature(32, TemperatureUnit.DegreeFahrenheit);

        Assert.AreEqual(DegreeCelsius, Fahrenheit);
    }

    [TestMethod]
    public void DegreeCelsiusToFahrenheit2()
    {
        var DegreeCelsius = new Temperature(0, TemperatureUnit.DegreeCelsius);
        var Fahrenheit = new Temperature(32.00000000000000001m, TemperatureUnit.DegreeFahrenheit);

        Assert.AreNotEqual(DegreeCelsius, Fahrenheit);
    }





    //Add unit test from Pound to Ounce
    [TestMethod]
    public void PoundToOunce()
    {
        var Pound = new Mass(1, MassUnit.Pound);
        var Ounce = new Mass(16, MassUnit.Ounce);

        Assert.AreEqual(Pound, Ounce);
    }

    //Add unit test from Slug to Pound
    [TestMethod]
    public void SlugToPound()
    {
        var Slug = new Mass(1, MassUnit.Slug);
        var Pound = new Mass(32.1740m, MassUnit.Pound);

        Assert.AreEqual(Slug, Pound);
    }

    //Add unit test from Slug to Ounce
    [TestMethod]
    public void SlugToOunce()
    {
        var Slug = new Mass(1, MassUnit.Slug);
        var Ounce = new Mass(514.784m, MassUnit.Ounce);

        Assert.AreEqual(Slug, Ounce);
    }

    //Add unit test from Kilogram to Pound
    [TestMethod]
    public void KilogramToPound()
    {
        //OBS: There is not exact conversion from Kilogram to Pound
        //This is using the full precision of the decimal type

        var kilo = new Mass(1, MassUnit.Kilogram);
        var Pound = new Mass(2.2046226218487758072297380135m, MassUnit.Pound);

        var test = kilo.GetValueAs(MassUnit.Pound);

        Assert.AreEqual(kilo, Pound);
    }

    //Add unit test from Pound to Kilogram
    [TestMethod]
    public void PoundToKilogram()
    {
        var Pound = new Mass(1, MassUnit.Pound);
        var kilo = new Mass(0.45359237m, MassUnit.Kilogram);

 
        Assert.AreEqual(kilo, Pound);
    }

}
