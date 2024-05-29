using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests;

[TestClass]
public class UnitMathTest
{

    [TestMethod]
    public void Sum() // TODO: this is testing Sum(), Average(), Min() and Max()... should probably rename the test
    {

        var list1 = new List<MassFlow>
        {
            MassFlow.FromKilogramPerSecond(2),
            MassFlow.FromKilogramPerSecond(1),
            MassFlow.FromKilogramPerSecond(3),
            MassFlow.FromKilogramPerSecond(4),
            MassFlow.FromKilogramPerSecond(5),
            MassFlow.FromKilogramPerSecond(6),
            MassFlow.FromKilogramPerSecond(7),
            MassFlow.FromKilogramPerSecond(8),
            MassFlow.FromKilogramPerSecond(10),
            MassFlow.FromKilogramPerSecond(9),
        };

        MassFlow? Average = UnitMath.Average(list1);
        MassFlow? Sum = UnitMath.Sum(list1);
        MassFlow? Max = UnitMath.Max(list1);
        MassFlow? Min = UnitMath.Min(list1);

        MassFlow? Average2 = UnitMath.Average(
            MassFlow.FromKilogramPerSecond(1),
            MassFlow.FromKilogramPerSecond(2),
            MassFlow.FromKilogramPerSecond(3),
            MassFlow.FromKilogramPerSecond(4),
            MassFlow.FromKilogramPerSecond(5),
            MassFlow.FromKilogramPerSecond(6),
            MassFlow.FromKilogramPerSecond(7),
            MassFlow.FromKilogramPerSecond(8),
            MassFlow.FromKilogramPerSecond(9),
            MassFlow.FromKilogramPerSecond(10)
            );

        MassFlow? Sum2 = UnitMath.Sum(
            MassFlow.FromKilogramPerSecond(1),
            MassFlow.FromKilogramPerSecond(2),
            MassFlow.FromKilogramPerSecond(3),
            MassFlow.FromKilogramPerSecond(4),
            MassFlow.FromKilogramPerSecond(5),
            MassFlow.FromKilogramPerSecond(6),
            MassFlow.FromKilogramPerSecond(7),
            MassFlow.FromKilogramPerSecond(8),
            MassFlow.FromKilogramPerSecond(9),
            MassFlow.FromKilogramPerSecond(10)
            );

        MassFlow? Max2 = UnitMath.Max(
            MassFlow.FromKilogramPerSecond(1),
            MassFlow.FromKilogramPerSecond(2),
            MassFlow.FromKilogramPerSecond(3),
            MassFlow.FromKilogramPerSecond(4),
            MassFlow.FromKilogramPerSecond(5),
            MassFlow.FromKilogramPerSecond(6),
            MassFlow.FromKilogramPerSecond(7),
            MassFlow.FromKilogramPerSecond(8),
            MassFlow.FromKilogramPerSecond(9),
            MassFlow.FromKilogramPerSecond(10)
            );

        MassFlow? Min2 = UnitMath.Min(
                MassFlow.FromKilogramPerSecond(1),
                MassFlow.FromKilogramPerSecond(2),
                MassFlow.FromKilogramPerSecond(3),
                MassFlow.FromKilogramPerSecond(4),
                MassFlow.FromKilogramPerSecond(5),
                MassFlow.FromKilogramPerSecond(6),
                MassFlow.FromKilogramPerSecond(7),
                MassFlow.FromKilogramPerSecond(8),
                MassFlow.FromKilogramPerSecond(9),
                MassFlow.FromKilogramPerSecond(10)
                );

        MassFlow? Average3 = list1.Average();
        MassFlow? Sum3 = list1.Sum();
        MassFlow? Max3 = list1.Max();
        MassFlow? Min3 = list1.Min();

        Assert.IsNotNull(Average);
        Assert.IsNotNull(Sum);
        Assert.IsNotNull(Max);
        Assert.IsNotNull(Min);

        Assert.AreEqual(Average.KilogramPerSecond, 5.5, 0);
        Assert.AreEqual(Sum.KilogramPerSecond, 55, 0);
        Assert.AreEqual(Max.KilogramPerSecond, 10, 0);
        Assert.AreEqual(Min.KilogramPerSecond, 1, 0);

        Assert.AreEqual(Average, Average2);
        Assert.AreEqual(Sum, Sum2);
        Assert.AreEqual(Max, Max2);
        Assert.AreEqual(Min, Min2);

        Assert.AreEqual(Average, Average3);
        Assert.AreEqual(Sum, Sum3);
        Assert.AreEqual(Max, Max3);
        Assert.AreEqual(Min, Min3);

    }
    

    [TestMethod]
    public void Sum_Temperature() // TODO: this is testing [Sum()], Average(), Min() and Max()... should probably rename the test
    {
        // TEMP -----------------------------------------------------------------------------
            // This tests the method used by the Aggregate function in UnitMath.Sum()
            // (1) From Kelvin
            var T1a = Temperature.FromKelvin(10);
            var T1b = Temperature.FromKelvin(20);

            // The Aggregate() method in Sum() does this:
            var T1_UU = new UnknownUnit(0m, T1a) + T1a + T1b;

            // This is correct if temperatures constructed from Kelvin
            Assert.AreEqual(Temperature.FromKelvin(T1a.Kelvin + T1b.Kelvin), (Temperature)T1_UU);


            // (2) From Degrees C
            var T2a = Temperature.FromDegreeCelsius(10);
            var T2b = Temperature.FromDegreeCelsius(20);

            // The Aggregate() method in Sum() currently does this (causes error)
            var T2_UU = new UnknownUnit(0m, T2a) + T2a + T2b;
            // Assert.AreEqual(Temperature.FromKelvin(T2a.Kelvin + T2b.Kelvin), (Temperature)T2_UU);

            // For Temperature from DegreeCelsius, it should do this:
            var T2_UU_fixedCelsius = new UnknownUnit(-273.15m, T2a) + T2a + T2b;
            Assert.AreEqual(Temperature.FromKelvin(T2a.Kelvin + T2b.Kelvin), (Temperature)T2_UU_fixedCelsius);

            // More generally, for all temperatues:
            var T2_UU_fixedTemp1 = new UnknownUnit(Temperature.Zero) + T2a + T2b;
            var T2_UU_fixedTemp2 = new UnknownUnit(0m, T2a.ToUnit(TemperatureUnit.SI)) + T2a + T2b;
            Assert.AreEqual(Temperature.FromKelvin(T2a.Kelvin + T2b.Kelvin), (Temperature)T2_UU_fixedTemp1);
            Assert.AreEqual(Temperature.FromKelvin(T2a.Kelvin + T2b.Kelvin), (Temperature)T2_UU_fixedTemp2);

        // TEMP -----------------------------------------------------------------------------

        // Kelvin
        var list1K = new List<Temperature>
        {
            Temperature.FromKelvin(2),
            Temperature.FromKelvin(1),
            Temperature.FromKelvin(3),
            Temperature.FromKelvin(4),
            Temperature.FromKelvin(5),
            Temperature.FromKelvin(6),
            Temperature.FromKelvin(7),
            Temperature.FromKelvin(8),
            Temperature.FromKelvin(10),
            Temperature.FromKelvin(9),
        };

        Temperature? AverageK = UnitMath.Average(list1K);
        Temperature? SumK =     UnitMath.Sum(list1K);
        Temperature? MaxK =     UnitMath.Max(list1K);
        Temperature? MinK =     UnitMath.Min(list1K);

        Temperature? Average2K = UnitMath.Average(
            Temperature.FromKelvin(1),
            Temperature.FromKelvin(2),
            Temperature.FromKelvin(3),
            Temperature.FromKelvin(4),
            Temperature.FromKelvin(5),
            Temperature.FromKelvin(6),
            Temperature.FromKelvin(7),
            Temperature.FromKelvin(8),
            Temperature.FromKelvin(9),
            Temperature.FromKelvin(10)
            );

        Temperature? Sum2K = UnitMath.Sum(
            Temperature.FromKelvin(1),
            Temperature.FromKelvin(2),
            Temperature.FromKelvin(3),
            Temperature.FromKelvin(4),
            Temperature.FromKelvin(5),
            Temperature.FromKelvin(6),
            Temperature.FromKelvin(7),
            Temperature.FromKelvin(8),
            Temperature.FromKelvin(9),
            Temperature.FromKelvin(10)
            );

        Temperature? Max2K = UnitMath.Max(
            Temperature.FromKelvin(1),
            Temperature.FromKelvin(2),
            Temperature.FromKelvin(3),
            Temperature.FromKelvin(4),
            Temperature.FromKelvin(5),
            Temperature.FromKelvin(6),
            Temperature.FromKelvin(7),
            Temperature.FromKelvin(8),
            Temperature.FromKelvin(9),
            Temperature.FromKelvin(10)
            );

        Temperature? Min2K = UnitMath.Min(
            Temperature.FromKelvin(1),
            Temperature.FromKelvin(2),
            Temperature.FromKelvin(3),
            Temperature.FromKelvin(4),
            Temperature.FromKelvin(5),
            Temperature.FromKelvin(6),
            Temperature.FromKelvin(7),
            Temperature.FromKelvin(8),
            Temperature.FromKelvin(9),
            Temperature.FromKelvin(10)
            );

        Temperature? Average3K = list1K.Average();
        Temperature? Sum3K = list1K.Sum();
        Temperature? Max3K = list1K.Max();
        Temperature? Min3K = list1K.Min();

        Assert.IsNotNull(AverageK);
        Assert.IsNotNull(SumK);
        Assert.IsNotNull(MaxK);
        Assert.IsNotNull(MinK);

        Assert.AreEqual(AverageK.Kelvin, 5.5, 0);
        Assert.AreEqual(SumK.Kelvin, 55, 0);
        Assert.AreEqual(MaxK.Kelvin, 10, 0);
        Assert.AreEqual(MinK.Kelvin, 1, 0);

        Assert.AreEqual(AverageK, Average2K);
        Assert.AreEqual(SumK, Sum2K);
        Assert.AreEqual(MaxK, Max2K);
        Assert.AreEqual(MinK, Min2K);

        Assert.AreEqual(AverageK, Average3K);
        Assert.AreEqual(SumK, Sum3K);
        Assert.AreEqual(MaxK, Max3K);
        Assert.AreEqual(MinK, Min3K);


        // DegreesCelsius
        var list1C = new List<Temperature>
        {
            Temperature.FromDegreeCelsius(2),
            Temperature.FromDegreeCelsius(1),
            Temperature.FromDegreeCelsius(3),
            Temperature.FromDegreeCelsius(4),
            Temperature.FromDegreeCelsius(5),
            Temperature.FromDegreeCelsius(6),
            Temperature.FromDegreeCelsius(7),
            Temperature.FromDegreeCelsius(8),
            Temperature.FromDegreeCelsius(10),
            Temperature.FromDegreeCelsius(9),
        };

        Temperature? AverageC = UnitMath.Average(list1C);
        Temperature? SumC =     UnitMath.Sum(list1C);
        Temperature? MaxC =     UnitMath.Max(list1C);
        Temperature? MinC =     UnitMath.Min(list1C);

        Temperature? Average2C = UnitMath.Average(
            Temperature.FromDegreeCelsius(1),
            Temperature.FromDegreeCelsius(2),
            Temperature.FromDegreeCelsius(3),
            Temperature.FromDegreeCelsius(4),
            Temperature.FromDegreeCelsius(5),
            Temperature.FromDegreeCelsius(6),
            Temperature.FromDegreeCelsius(7),
            Temperature.FromDegreeCelsius(8),
            Temperature.FromDegreeCelsius(9),
            Temperature.FromDegreeCelsius(10)
            );

        Temperature? Sum2C = UnitMath.Sum(
            Temperature.FromDegreeCelsius(1),
            Temperature.FromDegreeCelsius(2),
            Temperature.FromDegreeCelsius(3),
            Temperature.FromDegreeCelsius(4),
            Temperature.FromDegreeCelsius(5),
            Temperature.FromDegreeCelsius(6),
            Temperature.FromDegreeCelsius(7),
            Temperature.FromDegreeCelsius(8),
            Temperature.FromDegreeCelsius(9),
            Temperature.FromDegreeCelsius(10)
            );

        Temperature? Max2C = UnitMath.Max(
            Temperature.FromDegreeCelsius(1),
            Temperature.FromDegreeCelsius(2),
            Temperature.FromDegreeCelsius(3),
            Temperature.FromDegreeCelsius(4),
            Temperature.FromDegreeCelsius(5),
            Temperature.FromDegreeCelsius(6),
            Temperature.FromDegreeCelsius(7),
            Temperature.FromDegreeCelsius(8),
            Temperature.FromDegreeCelsius(9),
            Temperature.FromDegreeCelsius(10)
            );

        Temperature? Min2C = UnitMath.Min(
            Temperature.FromDegreeCelsius(1),
            Temperature.FromDegreeCelsius(2),
            Temperature.FromDegreeCelsius(3),
            Temperature.FromDegreeCelsius(4),
            Temperature.FromDegreeCelsius(5),
            Temperature.FromDegreeCelsius(6),
            Temperature.FromDegreeCelsius(7),
            Temperature.FromDegreeCelsius(8),
            Temperature.FromDegreeCelsius(9),
            Temperature.FromDegreeCelsius(10)
            );

        Temperature? Average3C = list1C.Average();
        Temperature? Sum3C = list1C.Sum();
        Temperature? Max3C = list1C.Max();
        Temperature? Min3C = list1C.Min();

        Assert.IsNotNull(AverageC);
        Assert.IsNotNull(SumC);
        Assert.IsNotNull(MaxC);
        Assert.IsNotNull(MinC);

        Assert.AreEqual(AverageC.DegreeCelsius, 5.5, 0);
        Assert.AreEqual(SumC.DegreeCelsius, 2513.35, 0); // This is a little weird but I guess correct..
        Assert.AreEqual(MaxC.DegreeCelsius, 10, 0);
        Assert.AreEqual(MinC.DegreeCelsius, 1, 0);

        Assert.AreEqual(AverageC, Average2C);
        Assert.AreEqual(SumC, Sum2C);
        Assert.AreEqual(MaxC, Max2C);
        Assert.AreEqual(MinC, Min2C);

        Assert.AreEqual(AverageC, Average3C);
        Assert.AreEqual(SumC, Sum3C);
        Assert.AreEqual(MaxC, Max3C);
        Assert.AreEqual(MinC, Min3C);
    }

    //Create test

    [TestMethod]
    public void Pow()
    {
        var twoMeters = Length.From(2, LengthUnit.Meter);

        UnknownUnit powMinus3 = twoMeters.Pow(-3);
        UnknownUnit powMinus2 = twoMeters.Pow(-2);
        UnknownUnit powMinus1 = twoMeters.Pow(-1);
        UnknownUnit pow0 = twoMeters.Pow(0);
        UnknownUnit pow1 = twoMeters.Pow(1);
        UnknownUnit pow2 = twoMeters.Pow(2);
        UnknownUnit pow3 = twoMeters.Pow(3);

        Assert.AreEqual(Math.Pow(2, -3), (double)powMinus3.AsSI);
        Assert.AreEqual(Math.Pow(2, -2), (double)powMinus2.AsSI);
        Assert.AreEqual(Math.Pow(2, -1), (double)powMinus1.AsSI);
        Assert.AreEqual(Math.Pow(2, 0), (double)pow0.AsSI);
        Assert.AreEqual(Math.Pow(2, 1), (double)pow1.AsSI);
        Assert.AreEqual(Math.Pow(2, 2), (double)pow2.AsSI);
        Assert.AreEqual(Math.Pow(2, 3), (double)pow3.AsSI);
    }

    [TestMethod]
    public void Sum02()
    {

        var list1 = new List<UnknownUnit>
        {
            Length.FromKilometer(1)/Duration.FromHour(2),
            Length.FromKilometer(1)/Duration.FromHour(1),
            Length.FromKilometer(1)/Duration.FromHour(3),
            Length.FromKilometer(1)/Duration.FromHour(5),
            Length.FromKilometer(1)/Duration.FromHour(4)

        };

        UnknownUnit? Average = UnitMath.Average(list1);
        UnknownUnit? Sum = UnitMath.Sum(list1);
        UnknownUnit? Max = UnitMath.Max(list1);
        UnknownUnit? Min = UnitMath.Min(list1);

        UnknownUnit? Average2 = UnitMath.Average(
        Length.FromKilometer(1) / Duration.FromHour(1),
        Length.FromKilometer(1) / Duration.FromHour(2),
        Length.FromKilometer(1) / Duration.FromHour(3),
        Length.FromKilometer(1) / Duration.FromHour(4),
        Length.FromKilometer(1) / Duration.FromHour(5)
        );

        UnknownUnit? Sum2 = UnitMath.Sum(
            Length.FromKilometer(1) / Duration.FromHour(1),
            Length.FromKilometer(1) / Duration.FromHour(2),
            Length.FromKilometer(1) / Duration.FromHour(3),
            Length.FromKilometer(1) / Duration.FromHour(4),
            Length.FromKilometer(1) / Duration.FromHour(5)
            );

        UnknownUnit? Max2 = UnitMath.Max(
            Length.FromKilometer(1) / Duration.FromHour(1),
            Length.FromKilometer(1) / Duration.FromHour(2),
            Length.FromKilometer(1) / Duration.FromHour(3),
            Length.FromKilometer(1) / Duration.FromHour(4),
            Length.FromKilometer(1) / Duration.FromHour(5)
            );

        UnknownUnit? Min2 = UnitMath.Min(
            Length.FromKilometer(1) / Duration.FromHour(1),
            Length.FromKilometer(1) / Duration.FromHour(2),
            Length.FromKilometer(1) / Duration.FromHour(3),
            Length.FromKilometer(1) / Duration.FromHour(4),
            Length.FromKilometer(1) / Duration.FromHour(5)
                );

        UnknownUnit? Average3 = list1.Average();
        UnknownUnit? Sum3 = list1.Sum();
        UnknownUnit? Max3 = list1.Max();
        UnknownUnit? Min3 = list1.Min();

        Assert.IsNotNull(Average);
        Assert.IsNotNull(Sum);
        Assert.IsNotNull(Max);
        Assert.IsNotNull(Min);

        Assert.AreEqual(Average.As(SpeedUnit.KilometerPerhour), 0.4566666666666667);
        Assert.AreEqual(Sum.As(SpeedUnit.KilometerPerhour), 2.283333333333333);
        Assert.AreEqual(Max.As(SpeedUnit.KilometerPerhour), 1);
        Assert.AreEqual(Min.As(SpeedUnit.KilometerPerhour), 0.2);

        Assert.AreEqual(Average, Average2);
        Assert.AreEqual(Sum, Sum2);
        Assert.AreEqual(Max, Max2);
        Assert.AreEqual(Min, Min2);

        Assert.AreEqual(Average, Average3);
        Assert.AreEqual(Sum, Sum3);
        Assert.AreEqual(Max, Max3);
        Assert.AreEqual(Min, Min3);

    }

    [TestMethod]
    public void UnknownUnitMathTest()
    {

        var list1 = new List<UnknownUnit>
        {
            Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(2),
            Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(1),
            Acceleration.FromKilometerPerSecondSquared(2)/Duration.FromMicrosecond(3),
            Acceleration.FromKilometerPerSecondSquared(2)/Duration.FromMicrosecond(5),
            Acceleration.FromKilometerPerSecondSquared(1)/Duration.FromMicrosecond(4)

        };

        UnknownUnit? Average = UnitMath.Average(list1);
        UnknownUnit? Sum = UnitMath.Sum(list1);
        UnknownUnit? Max = UnitMath.Max(list1);
        UnknownUnit? Min = UnitMath.Min(list1);

        UnknownUnit? Average2 = UnitMath.Average(
        Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2),
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(1),
            Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(3),
            Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(5),
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(4)
        );

        UnknownUnit? Sum2 = UnitMath.Sum(
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2),
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(1),
            Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(3),
            Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(5),
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(4)
            );

        UnknownUnit? Max2 = UnitMath.Max(
             Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2),
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(1),
            Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(3),
            Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(5),
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(4)
            );

        UnknownUnit? Min2 = UnitMath.Min(
             Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2),
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(1),
            Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(3),
            Acceleration.FromKilometerPerSecondSquared(2) / Duration.FromMicrosecond(5),
            Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(4)
                );

        UnknownUnit? Average3 = list1.Average();
        UnknownUnit? Sum3 = list1.Sum();
        UnknownUnit? Max3 = list1.Max();
        UnknownUnit? Min3 = list1.Min();

        Assert.IsNotNull(Average);
        Assert.IsNotNull(Sum);
        Assert.IsNotNull(Max);
        Assert.IsNotNull(Min);

        Assert.AreEqual(Average, Average2);
        Assert.AreEqual(Sum, Sum2);
        Assert.AreEqual(Max, Max2);
        Assert.AreEqual(Min, Min2);

        Assert.AreEqual(Average, Average3);
        Assert.AreEqual(Sum, Sum3);
        Assert.AreEqual(Max, Max3);
        Assert.AreEqual(Min, Min3);

        Assert.IsTrue(Average.Equals(Average3));
        _=Max.CompareTo(Max3);
        _=Max.Equals(Max3);

    }

    [TestMethod]
    public void UnknownUnitMathTest02()
    {
        var speed = new List<UnknownUnit>
        {
            Length.FromMeter(12)/Duration.FromMinute(5),
            Length.FromMeter(5)/Duration.FromMinute(3),
            Length.FromMeter(22)/Duration.FromMinute(13),
            Length.FromMeter(2)/Duration.FromMinute(3),
            Length.FromMeter(100)/Duration.FromMinute(3)

        };
        var speed2 = new List<UnknownUnit>
        {
            Length.FromMeter(2)/Duration.FromMinute(3),
            Length.FromMeter(1)/Duration.FromMinute(3),
            Length.FromMeter(22)/Duration.FromMinute(13),
            Length.FromMeter(2)/Duration.FromMinute(3),
            Length.FromMeter(100)/Duration.FromMinute(3)

        };
        var minlist = new List<UnknownUnit?>
        {
            UnitMath.Min(speed),
            UnitMath.Min(speed2)
        };

        UnknownUnit? res = UnitMath.Min(minlist);
        UnknownUnit? max = UnitMath.Max(minlist);
        Assert.AreEqual(res, minlist.ElementAt(1));
        Assert.AreEqual(max, UnitMath.Min(speed));

    }
    [TestMethod]
    public void TestUnknownUnitEqualNullObject()
    {
        object? obj = null;
        UnknownUnit test = Acceleration.FromKilometerPerSecondSquared(1) / Duration.FromMicrosecond(2);
        _=test.Equals(obj);
        Assert.IsFalse(test.Equals(obj));

    }

    [TestMethod]
    public void SumTuple()
    {
        UnknownUnit? sum2 = (Frequency.FromHertz(1), Frequency.FromHertz(2)).Sum();
        UnknownUnit? sum3 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3)).Sum();
        UnknownUnit? sum4 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4)).Sum();
        UnknownUnit? sum5 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4), Frequency.FromHertz(5)).Sum();

        Assert.IsNotNull(sum2);
        Assert.IsNotNull(sum3);
        Assert.IsNotNull(sum4);
        Assert.IsNotNull(sum5);

        Assert.AreEqual(Frequency.FromHertz(3), (Frequency)sum2);
        Assert.AreEqual(Frequency.FromHertz(6), (Frequency)sum3);
        Assert.AreEqual(Frequency.FromHertz(10), (Frequency)sum4);
        Assert.AreEqual(Frequency.FromHertz(15), (Frequency)sum5);
    }

    [TestMethod]
    public void Average()
    {
        UnknownUnit? average2 = (Frequency.FromHertz(1), Frequency.FromHertz(2)).Average();
        UnknownUnit? average3 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3)).Average();
        UnknownUnit? average4 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4)).Average();
        UnknownUnit? average5 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4), Frequency.FromHertz(5)).Average();

        Assert.IsNotNull(average2);
        Assert.IsNotNull(average3);
        Assert.IsNotNull(average4);
        Assert.IsNotNull(average5);

        Assert.AreEqual(Frequency.FromHertz(1.5), (Frequency)average2);
        Assert.AreEqual(Frequency.FromHertz(2), (Frequency)average3);
        Assert.AreEqual(Frequency.FromHertz(2.5), (Frequency)average4);
        Assert.AreEqual(Frequency.FromHertz(3), (Frequency)average5);
    }

    [TestMethod]
    public void Average_Temperature()
    {
        // Testing DegreeCelsius
        var averageDegC2 = (Temperature.FromDegreeCelsius(1), Temperature.FromDegreeCelsius(2)).Average();
        var averageDegC3 = (Temperature.FromDegreeCelsius(1), Temperature.FromDegreeCelsius(2), Temperature.FromDegreeCelsius(3)).Average();
        var averageDegC4 = (Temperature.FromDegreeCelsius(1), Temperature.FromDegreeCelsius(2), Temperature.FromDegreeCelsius(3), Temperature.FromDegreeCelsius(4)).Average();
        var averageDegC5 = (Temperature.FromDegreeCelsius(1), Temperature.FromDegreeCelsius(2), Temperature.FromDegreeCelsius(3), Temperature.FromDegreeCelsius(4), Temperature.FromDegreeCelsius(5)).Average();

        Assert.IsNotNull(averageDegC2);
        Assert.IsNotNull(averageDegC3);
        Assert.IsNotNull(averageDegC4);
        Assert.IsNotNull(averageDegC5);

        Assert.AreEqual(Temperature.FromDegreeCelsius(1.5), (Temperature)averageDegC2);
        Assert.AreEqual(Temperature.FromDegreeCelsius(2.0), (Temperature)averageDegC3);
        Assert.AreEqual(Temperature.FromDegreeCelsius(2.5), (Temperature)averageDegC4);
        Assert.AreEqual(Temperature.FromDegreeCelsius(3.0), (Temperature)averageDegC5);

        // Testing Kelvin
        var averageK2 = (Temperature.FromKelvin(1), Temperature.FromKelvin(2)).Average();
        var averageK3 = (Temperature.FromKelvin(1), Temperature.FromKelvin(2), Temperature.FromKelvin(3)).Average();
        var averageK4 = (Temperature.FromKelvin(1), Temperature.FromKelvin(2), Temperature.FromKelvin(3), Temperature.FromKelvin(4)).Average();
        var averageK5 = (Temperature.FromKelvin(1), Temperature.FromKelvin(2), Temperature.FromKelvin(3), Temperature.FromKelvin(4), Temperature.FromKelvin(5)).Average();

        Assert.IsNotNull(averageK2);
        Assert.IsNotNull(averageK3);
        Assert.IsNotNull(averageK4);
        Assert.IsNotNull(averageK5);

        Assert.AreEqual(Temperature.FromKelvin(1.5), (Temperature)averageK2);
        Assert.AreEqual(Temperature.FromKelvin(2.0), (Temperature)averageK3);
        Assert.AreEqual(Temperature.FromKelvin(2.5), (Temperature)averageK4);
        Assert.AreEqual(Temperature.FromKelvin(3.0), (Temperature)averageK5);
    }

    [TestMethod]
    public void Mean()
    {
        UnknownUnit? mean2 = (Frequency.FromHertz(1), Frequency.FromHertz(2)).Mean();
        UnknownUnit? mean3 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3)).Mean();
        UnknownUnit? mean4 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4)).Mean();
        UnknownUnit? mean5 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4), Frequency.FromHertz(5)).Mean();

        Assert.IsNotNull(mean2);
        Assert.IsNotNull(mean3);
        Assert.IsNotNull(mean4);
        Assert.IsNotNull(mean5);

        Assert.AreEqual(Frequency.FromHertz(2), (Frequency)mean2);
        Assert.AreEqual(Frequency.FromHertz(2), (Frequency)mean3);
        Assert.AreEqual(Frequency.FromHertz(3), (Frequency)mean4);
        Assert.AreEqual(Frequency.FromHertz(3), (Frequency)mean5);
    }
    [TestMethod]
    public void Min()
    {
        UnknownUnit? min2 = (Frequency.FromHertz(1), Frequency.FromHertz(2)).Min();
        UnknownUnit? min3 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3)).Min();
        UnknownUnit? min4 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4)).Min();
        UnknownUnit? min5 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4), Frequency.FromHertz(5)).Min();

        Assert.IsNotNull(min2);
        Assert.IsNotNull(min3);
        Assert.IsNotNull(min4);
        Assert.IsNotNull(min5);

        Assert.AreEqual(Frequency.FromHertz(1), (Frequency)min2);
        Assert.AreEqual(Frequency.FromHertz(1), (Frequency)min3);
        Assert.AreEqual(Frequency.FromHertz(1), (Frequency)min4);
        Assert.AreEqual(Frequency.FromHertz(1), (Frequency)min5);
    }

    [TestMethod]
    public void Max()
    {
        UnknownUnit? max2 = (Frequency.FromHertz(1), Frequency.FromHertz(2)).Max();
        UnknownUnit? max3 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3)).Max();
        UnknownUnit? max4 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4)).Max();
        UnknownUnit? max5 = (Frequency.FromHertz(1), Frequency.FromHertz(2), Frequency.FromHertz(3), Frequency.FromHertz(4), Frequency.FromHertz(5)).Max();

        Assert.IsNotNull(max2);
        Assert.IsNotNull(max3);
        Assert.IsNotNull(max4);
        Assert.IsNotNull(max5);

        Assert.AreEqual(Frequency.FromHertz(2), (Frequency)max2);
        Assert.AreEqual(Frequency.FromHertz(3), (Frequency)max3);
        Assert.AreEqual(Frequency.FromHertz(4), (Frequency)max4);
        Assert.AreEqual(Frequency.FromHertz(5), (Frequency)max5);
    }
}
