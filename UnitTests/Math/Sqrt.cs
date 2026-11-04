using System.Collections.Generic;
using EngineeringUnits.Units;
using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Math;

[TestClass]
public class Sqrt
{
    [TestMethod]
    public void Sqrt1()
    {
        Speed M6 = (Area.FromAcre(10) / Duration.FromSecond(1).Pow(2)).Sqrt();

        Assert.AreEqual(201.168, M6.SI);
    }

    [TestMethod]
    public void Sqrt2()
    {
        var A1 = Area.FromSquareFoot(19);

        Length L1 = A1.Sqrt();

        Assert.AreEqual(1.3285923979911973, L1.SI);
    }

    [TestMethod]
    public void SqrtOfNegative()
    {
        var A1 = Area.FromSquareFoot(-19);

        Length L1 = A1.Sqrt();

        Assert.IsNull(L1);
    }

    [TestMethod]
    public void SqrtOfZero()
    {
        var A1 = Area.FromSquareFoot(0);

        Length L1 = A1.Sqrt();

        Assert.AreEqual(0, L1.SI);
    }

    [TestMethod]
    public void SqrtOfForceSquared()
    {
        const double PoundForceValue = 100.0;
        var poundForceOriginal = Force.FromPoundForce(PoundForceValue);
        var poundForceSquared = poundForceOriginal * poundForceOriginal;

        var sqrtValue = (Force)poundForceSquared.Sqrt();
        var poundForceActual = sqrtValue.PoundForce;

        Assert.AreEqual(PoundForceValue, sqrtValue.PoundForce, 1e-6);
        var dummy = 1;
    }

    private static readonly Dictionary<string, ForceUnit> ForceUnits = new()
    {
        [nameof(ForceUnit.Newton)] = ForceUnit.Newton,
        [nameof(ForceUnit.Kilonewton)] = ForceUnit.Kilonewton,
        [nameof(ForceUnit.Millinewton)] = ForceUnit.Millinewton,
        [nameof(ForceUnit.Dyn)] = ForceUnit.Dyn,
        [nameof(ForceUnit.Poundal)] = ForceUnit.Poundal,
        [nameof(ForceUnit.PoundForce)] = ForceUnit.PoundForce,
        [nameof(ForceUnit.KilogramForce)] = ForceUnit.KilogramForce,
        [nameof(ForceUnit.TonneForce)] = ForceUnit.TonneForce,
        [nameof(ForceUnit.ShortTonForce)] = ForceUnit.ShortTonForce,
        [nameof(ForceUnit.OunceForce)] = ForceUnit.OunceForce,
        [nameof(ForceUnit.KilopoundForce)] = ForceUnit.KilopoundForce,
    };

    [TestMethod]
    [DataRow(nameof(ForceUnit.Newton))]
    [DataRow(nameof(ForceUnit.Kilonewton))]
    [DataRow(nameof(ForceUnit.Millinewton))]
    [DataRow(nameof(ForceUnit.Dyn))]
    [DataRow(nameof(ForceUnit.Poundal))]
    [DataRow(nameof(ForceUnit.PoundForce))]
    [DataRow(nameof(ForceUnit.KilogramForce))]
    [DataRow(nameof(ForceUnit.TonneForce))]
    [DataRow(nameof(ForceUnit.ShortTonForce))]
    [DataRow(nameof(ForceUnit.OunceForce))]
    [DataRow(nameof(ForceUnit.KilopoundForce))]
    public void SqrtOfForceSquared_AllForceUnits(string unitName)
    {
        const double Value = 100.0;
        ForceUnit unit = ForceUnits[unitName];
        var F1 = new Force(Value, unit);

        var F1_calculated = (Force)(F1 * F1).Sqrt();

        Assert.AreEqual(Value, F1_calculated.As(unit), Value * 1e-9, unitName);
        Assert.AreEqual(F1.SI, F1_calculated.SI, F1.SI * 1e-9, unitName);
    }

    [TestMethod]
    public void SqrtOfForceToTheFourth()
    {
        // g carries Count = 4 -> must come back as g²
        var F1 = Force.FromPoundForce(100);

        var result = (F1 * F1 * F1 * F1).Sqrt();

        Assert.AreEqual(F1.SI * F1.SI, (double)result.AsSI, F1.SI * F1.SI * 1e-9);
    }

    [TestMethod]
    public void SqrtOfAreaPerForceSquared()
    {
        // g carries Count = -2: (ft² / lbf²)^0.5 = ft / lbf
        var A1 = Area.FromSquareFoot(9);
        var F1 = Force.FromPoundForce(100);

        var result = (A1 / (F1 * F1)).Sqrt();

        double expected = System.Math.Sqrt(A1.SI) / F1.SI;
        Assert.AreEqual(expected, (double)result.AsSI, expected * 1e-9);
    }

    [TestMethod]
    public void SqrtOfMixedForceUnits()
    {
        // Two different constants (g from lbf, 1000 from kN), each with an odd Count
        var F1 = Force.FromPoundForce(100);
        var F2 = new Force(2, ForceUnit.Kilonewton);

        var F_calculated = (Force)(F1 * F2).Sqrt();

        double expected = System.Math.Sqrt(F1.SI * F2.SI);
        Assert.AreEqual(expected, F_calculated.SI, expected * 1e-9);
    }

    [TestMethod]
    public void SqrtOfMixedForceUnitsWithEvenAndOddCounts()
    {
        // lbf · kN · kN · N: g has an odd Count (1), 1000 an even one (2)
        var F1 = Force.FromPoundForce(100);
        var F2 = new Force(2, ForceUnit.Kilonewton);
        var F3 = new Force(3, ForceUnit.Kilonewton);
        var F4 = Force.FromNewton(5);

        var result = (F1 * F2 * F3 * F4).Sqrt();

        double expected = System.Math.Sqrt(F1.SI * F2.SI * F3.SI * F4.SI);
        Assert.AreEqual(expected, (double)result.AsSI, expected * 1e-9);
    }
}
