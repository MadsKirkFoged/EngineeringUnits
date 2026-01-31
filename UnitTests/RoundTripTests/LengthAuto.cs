using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringUnits;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EngineeringUnits.NumberExtensions.NumberToLength;
using System;

[TestClass]
public class LengthRoundTripAllUnitsTests
{
    [TestMethod]
    public void RoundTrip_All_LengthUnits_InOneTest()
    {
        var fields = typeof(LengthUnit).GetFields(BindingFlags.Public | BindingFlags.Static)
                                       .Where(f => f.FieldType == typeof(LengthUnit))
                                       .ToArray();

        foreach (var f in fields)
        {
            var via = (LengthUnit)f.GetValue(null)!;

            Length original = 1.23456789.Meter;
            Length roundTrip = original.ToUnit(via).ToUnit(LengthUnit.Meter);

            Assert.IsTrue(original == roundTrip, $"Failed via {f.Name} ({via})");
        }
    }

    // Values chosen to cover: zero, sign, tiny, normal, large, and "awkward" decimals.
    // Keep them reasonable so they don't overflow when converting to very small units like Nanometer.
    double[] values =
    [
        0.0,
            1.0,
            -1.0,
            1e-12,          // very small
            1e-6,           // small
            0.1,            // awkward in binary floating-point
            123.456789,     // typical engineering value
            1e6,            // large
            1e9             // very large (still safe for most length units)
    ];



    [TestMethod]
    public void RoundTrip_All_LengthUnits_Across_Magnitudes()
    {

        var units = GetPublicStaticUnits<LengthUnit>()            
            .GroupBy(u => u.ToString())
            .Select(g => g.First())
            .ToList();

        foreach (var via in units)
        {
            foreach (var v in values)
            {
                // Arrange
                Length original = new Length(v, LengthUnit.Meter);

                try
                {
                    // Act
                    Length roundTrip = original.ToUnit(via).ToUnit(LengthUnit.Meter);

                    // Assert (strict physical equality)
                    Assert.IsTrue(original == roundTrip,
                        $"Round-trip failed. value={v}, via={via} ({via}), " +
                        $"original={original}, roundTrip={roundTrip}");
                }
                catch (Exception ex)
                {
                    Assert.Fail(
                        $"Exception during round-trip. value={v}, via={via} ({via}). " +
                        $"Message: {ex.Message}\n{ex}");
                }
            }
        }
    }

    [TestMethod]
    public void RoundTrip_All_MassUnits_Across_Magnitudes()
    {

        var units = GetPublicStaticUnits<MassUnit>()
            .GroupBy(u => u.ToString())
            .Select(g => g.First())
            .ToList();

        foreach (var via in units)
        {
            foreach (var v in values)
            {
                // Arrange
                Mass original = new Mass(v, MassUnit.Kilogram);

                try
                {
                    // Act
                    Mass roundTrip = original.ToUnit(via).ToUnit(MassUnit.Kilogram);

                    // Assert (strict physical equality)
                    Assert.IsTrue(original == roundTrip,
                        $"Round-trip failed. value={v}, via={via} ({via}), " +
                        $"original={original}, roundTrip={roundTrip}");
                }
                catch (Exception ex)
                {
                    Assert.Fail(
                        $"Exception during round-trip. value={v}, via={via} ({via}). " +
                        $"Message: {ex.Message}\n{ex}");
                }
            }
        }
    }

    private static IEnumerable<TUnit> GetPublicStaticUnits<TUnit>()
    {
        return typeof(TUnit)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(TUnit))
            .Select(f => (TUnit)f.GetValue(null)!)
            .Where(u => u is not null)!;
    }




}