using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parsing;
using EngineeringUnits.Units;

namespace UnitTests.Formatting
{
    [TestClass]
    public class UnitFormattingTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        // Helper: clone a unit system but force Symbol = null so we test formatting logic
        private static UnitSystem NoSymbol(UnitSystem u) => new UnitSystem(u, symbol: null);

        // Helper: make a predictable UnknownUnit for testing BaseUnit formatting
        private static UnknownUnit MakeUnknown(decimal value, UnitSystem unit) => new UnknownUnit(value, unit);

        // ---------------------------
        // UnitSystem: unit-only formats
        // ---------------------------

        //[TestMethod]
        //public void UnitSystem_Canonical_ShouldUseCaretAndSignedExponents_NoDivision()
        //{
        //    // Acceleration SI typically is m/s^2, but we force Symbol=null to avoid shortcut
        //    var acc = NoSymbol(AccelerationUnit.SI.Unit);

        //    var canonical = acc.ToString("C", Inv);

        //    // Must contain ^-2 somewhere for time, and must not contain '/'
        //    Assert.IsTrue(canonical.Contains("^"), $"Expected '^' in canonical: {canonical}");
        //    Assert.IsFalse(canonical.Contains("/"), $"Canonical should not contain '/': {canonical}");
        //}

        //[TestMethod]
        //public void UnitSystem_PrettyProduct_ShouldUseSuperscriptsAndDots_NoDivision()
        //{
        //    var acc = NoSymbol(AccelerationUnit.SI.Unit);

        //    var prettyProduct = acc.ToString("PP", Inv);

        //    Assert.IsFalse(prettyProduct.Contains("/"), $"PrettyProduct should not contain '/': {prettyProduct}");
        //    // It should usually contain a superscript minus or at least some exponent marker (depends on your ToSuperScript impl)
        //    Assert.IsTrue(prettyProduct.Contains("⁻") || prettyProduct.Contains("²") || prettyProduct.Contains("³"),
        //        $"Expected superscripts in PrettyProduct: {prettyProduct}");
        //}

        [TestMethod]
        public void UnitSystem_PrettyFraction_ShouldPreferFractionForSimpleUnits()
        {
            var acc = NoSymbol(AccelerationUnit.SI.Unit);

            var pf = acc.ToString("PF", Inv);

            // For acceleration, numerator should exist and denominator should exist => should become fraction for "simple"
            Assert.IsTrue(pf.Contains("/"), $"PrettyFraction expected '/' for simple unit: {pf}");
        }

        [TestMethod]
        public void UnitSystem_NoNumerator_ShouldNotRenderAsOneOverSomething_InPrettyFraction()
        {
            // Frequency SI is 1/s. It has no positive units, only negative time exponent.
            var freq = NoSymbol(FrequencyUnit.SI.Unit);

            var pf = freq.ToString("PF", Inv);

            // Your rule: if pos.Count == 0 then fall back to product form (no '1/...')
            Assert.IsFalse(pf.StartsWith("1/"), $"PF should not start with '1/': {pf}");
            Assert.IsFalse(pf.Contains("/"), $"PF should not use '/' when numerator is empty: {pf}");
        }

        [TestMethod]
        public void UnitSystem_Fraction_WithTwoFactors_ShouldUseParentheses()
        {
            // Power SI: kg·m^2/s^3. Numerator has two factors (kg and m^2), denominator has one (s^3)
            var power = NoSymbol(PowerUnit.SI.Unit);

            var pf = power.ToString("PF", Inv);

            // With your proposed policy: two numerator factors => parentheses
            Assert.IsTrue(pf.Contains("(") && pf.Contains(")"), $"Expected parentheses in PF for 2-factor numerator: {pf}");
            Assert.IsTrue(pf.Contains("/"), $"Expected '/' in PF for power-like unit: {pf}");
        }

        // ---------------------------
        // BaseUnit/UnknownUnit: combined numeric + unit formatting (U:)
        // ---------------------------

        [TestMethod]
        public void UnknownUnit_Format_G7_ShouldAffectNumberOnly_UnitUsesDefault()
        {
            var acc = NoSymbol(AccelerationUnit.SI.Unit);
            var u = MakeUnknown(74610.92m, acc);

            // "G7" should apply to number; unit should default (PF)
            var s = u.ToString("G7", Inv);

            // numeric part expected with G7 is "74610.92" (7 significant digits)
            Assert.IsTrue(s.StartsWith("74610.92"), $"Expected numeric '74610.92...' but got: {s}");

            // unit part should match default unit formatting (PF)
            var expectedUnit = acc.ToString("PF", Inv);
            Assert.IsTrue(s.EndsWith(expectedUnit), $"Expected unit '{expectedUnit}' but got: {s}");
        }

        [TestMethod]
        public void UnknownUnit_Format_G7U_PF_ShouldUsePrettyFractionUnitFormat()
        {
            var acc = NoSymbol(AccelerationUnit.SI.Unit);
            var u = MakeUnknown(123.456789m, acc);

            var expectedUnit = acc.ToString("PF", Inv);
            var s = u.ToString("G7U:PF", Inv);

            // Ensure unit part is PF
            Assert.IsTrue(s.EndsWith(expectedUnit), $"Expected PF unit '{expectedUnit}' but got: {s}");
        }

        [TestMethod]
        public void UnknownUnit_Format_G7U_PP_ShouldUsePrettyProductUnitFormat()
        {
            var acc = NoSymbol(AccelerationUnit.SI.Unit);
            var u = MakeUnknown(123.456789m, acc);

            var expectedUnit = acc.ToString("PP", Inv);
            var s = u.ToString("G7U:PP", Inv);

            Assert.IsTrue(s.EndsWith(expectedUnit), $"Expected PP unit '{expectedUnit}' but got: {s}");
        }

        [TestMethod]
        public void UnknownUnit_Format_G7U_C_ShouldUseCanonicalUnitFormat()
        {
            var acc = NoSymbol(AccelerationUnit.SI.Unit);
            var u = MakeUnknown(123.456789m, acc);

            var expectedUnit = acc.ToString("C", Inv);
            var s = u.ToString("G7U:C", Inv);

            Assert.IsTrue(s.EndsWith(expectedUnit), $"Expected C unit '{expectedUnit}' but got: {s}");
        }

        [TestMethod]
        public void UnknownUnit_Format_CustomNumeric_WithUnitOverride()
        {
            var power = NoSymbol(PowerUnit.SI.Unit);
            var u = MakeUnknown(0.000012345678m, power);

            // numeric 0.0000123 with 4 sig figs might produce "1.235E-05" depending on implementation;
            // better: use fixed-point format to avoid scientific notation differences.
            var s = u.ToString("0.000000000U:PF", Inv);


            Assert.IsTrue(s.StartsWith("0.000012346"), $"Expected fixed formatted number but got: {s}");
            Assert.IsTrue(s.EndsWith("W"), $"Expected PF unit but got: {s}");
        }

        // ---------------------------
        // Default ToString() behavior sanity
        // ---------------------------

        [TestMethod]
        public void UnitSystem_DefaultToString_ShouldBePrettyFraction()
        {
            var acc = NoSymbol(AccelerationUnit.SI.Unit);
            var s = acc.ToString(); // should route to PF by your chosen default

            // acceleration should show / in PF mode
            Assert.IsTrue(s.Contains("/"), $"Default ToString should prefer fraction for simple units: {s}");
        }

        [TestMethod]
        public void UnknownUnit_DefaultToString_ShouldUseDefaultUnitFormat()
        {
            var acc = NoSymbol(AccelerationUnit.SI.Unit);
            var u = MakeUnknown(1.23m, acc);

            var s = u.ToString(); // should use default numeric + PF unit
            Assert.IsTrue(s.Contains(acc.ToString("PF", Inv)), $"Default UnknownUnit.ToString should include PF unit: {s}");
        }
    }
}