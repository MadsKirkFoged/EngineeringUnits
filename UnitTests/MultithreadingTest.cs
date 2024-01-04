using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTests;

[TestClass]
public class MultithreadingTest
{

    [TestMethod]
    public async Task Multithreading()
    {
        var maxLoops = new ParallelOptions { MaxDegreeOfParallelism = 100 };

        int[] numbers = [.. Enumerable.Range(0, 1000)];


        await Parallel.ForEachAsync(numbers, maxLoops, async (number, cancellationToken) =>
        {
            var DegreeCelsius = new Temperature(0, TemperatureUnit.DegreeCelsius);
            var Fahrenheit = new Temperature(32, TemperatureUnit.DegreeFahrenheit);

            Assert.AreEqual(DegreeCelsius, Fahrenheit);


            var Foot = new Length(3, LengthUnit.Foot);
            var Yard = new Length(1, LengthUnit.Yard);

            Assert.AreEqual(Foot, Yard);

            Power f1 = new(19, PowerUnit.KilojoulePerHour);
            Power f2 = f1.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));

            Power f3 = new(17, PowerUnit.KilojoulePerHour);
            Power f4 = f3.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));

            Power f5 = new(-17, PowerUnit.KilojoulePerHour);
            Power f6 = f5.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));

            Power f7 = new(-19, PowerUnit.KilojoulePerHour);
            Power f8 = f7.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));

            Power f9 = new(4, PowerUnit.Watt);
            Power f10 = f9.InRangeOf(Power.FromWatt(-5), Power.FromWatt(5));



            Assert.AreEqual(5, f2.Watt);
            Assert.AreNotEqual(6, f2.Watt);
            Assert.AreEqual(17, f4.KilojoulePerHour);
            Assert.AreEqual(-17, f6.KilojoulePerHour);
            Assert.AreEqual(-5, f8.Watt);
            Assert.AreEqual(4, f10.Watt);

            Length L1 = new(3.87, LengthUnit.Inch);
            Length L2 = new(2.78, LengthUnit.Meter);

            Length L3 = L1 + L2;
            Length L4 = L2 + L1;


            Assert.AreEqual(287.8298, L3.As(LengthUnit.Centimeter), 0.0000001);
            Assert.AreEqual(113.31881889763779527559055118, L3.As(LengthUnit.Inch));
            Assert.AreEqual(287.8298, L4.As(LengthUnit.Centimeter));
            Assert.AreEqual(113.31881889763779527559055118, L4.As(LengthUnit.Inch));

            double? value = 100;
            ElectricCurrent e = ElectricCurrent.From(value, ElectricCurrentUnit.Milliampere);
            Length e2 = Length.From(value, null);
            Assert.IsNotNull(e);
            Assert.IsNull(e2);

        });




    }






}
