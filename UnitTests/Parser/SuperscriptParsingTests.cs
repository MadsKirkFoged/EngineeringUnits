using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class SuperscriptParsingTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        // Helper: UnknownUnit returned by QuantityExpressionParser should be BaseUnit-derived
        private static decimal AsSI(UnknownUnit u) => ((EngineeringUnits.BaseUnit)u).AsSI;

        // --------------------------
        // Typed quantity parsing
        // --------------------------

        [TestMethod]
        public void Acceleration_ShouldParse_SuperscriptDenominator()
        {
            // m/s²
            var a = Acceleration.Parse("1 m/s²", Inv);
            Assert.AreEqual(1m, a.AsSI, 1e-9m);
        }

        [TestMethod]
        public void Acceleration_ShouldParse_SuperscriptNegativeExponent()
        {
            // m·s⁻²
            var a = Acceleration.Parse("1 m·s⁻²", Inv);
            Assert.AreEqual(1m, a.AsSI, 1e-9m);
        }

        [TestMethod]
        public void Area_ShouldParse_SuperscriptSquare()
        {
            var area = Area.Parse("2 m²", Inv);
            Assert.AreEqual(2m, area.AsSI, 1e-9m);
        }

        [TestMethod]
        public void Volume_ShouldParse_SuperscriptCube()
        {
            var vol = Volume.Parse("3 m³", Inv);
            Assert.AreEqual(3m, vol.AsSI, 1e-9m);
        }

        [TestMethod]
        public void Frequency_ShouldParse_SuperscriptMinusOne()
        {
            // Your unit set already contains "s⁻¹" as a frequency symbol in many builds,
            // but regardless, the normalizer should translate this to s^-1.
            var f = Frequency.Parse("4 s⁻¹", Inv);
            Assert.AreEqual(4m, f.AsSI, 1e-9m);
        }

        [TestMethod]
        public void Pressure_ShouldParse_Superscripts()
        {
            // Pa == kg/(m·s²)
            var p = Pressure.Parse("1 kg/(m·s²)", Inv);
            Assert.AreEqual(1m, p.AsSI, 1e-9m);
        }

        [TestMethod]
        public void Energy_ShouldParse_Superscripts()
        {
            // J == kg·m²/s²
            var e = Energy.Parse("1 kg·m²/s²", Inv);
            Assert.AreEqual(1m, e.AsSI, 1e-6m);
        }

        [TestMethod]
        public void Power_ShouldParse_Superscripts()
        {
            // W == kg·m²/s³
            var p = Power.Parse("1 kg·m²/s³", Inv);
            Assert.AreEqual(1m, p.AsSI, 1e-6m);
        }

        [TestMethod]
        public void Density_ShouldParse_SuperscriptCubeInDenominator()
        {
            // kg/m³
            var d = Density.Parse("5 kg/m³", Inv);
            Assert.AreEqual(5m, d.AsSI, 1e-9m);
        }

        // --------------------------
        // Expression parser + superscripts
        // --------------------------

        [TestMethod]
        public void QuantityExpressionParser_ShouldHandle_Superscripts_InLiterals()
        {
            var u = QuantityExpressionParser.Parse("1 m/s² + 2 m/s²", Inv);
            Assert.AreEqual(3m, AsSI(u), 1e-9m);
        }

        [TestMethod]
        public void QuantityExpressionParser_ShouldHandle_Superscripts_WithParentheses()
        {
            var u = QuantityExpressionParser.Parse("(10 m²) / (2 s²)", Inv);
            Assert.AreEqual(5m, AsSI(u), 1e-9m); // value 5, unit m²/s²
        }

        [TestMethod]
        public void QuantityExpressionParser_ShouldHandle_Superscripts_WithUnaryMinus()
        {
            var u = QuantityExpressionParser.Parse("-(10 m² - 5 m²)", Inv);
            Assert.AreEqual(-5m, AsSI(u), 1e-9m);
        }

        [TestMethod]
        public void QuantityExpressionParser_ShouldHandle_Superscripts_WithDotMultiply()
        {
            // Force: N == kg·m/s² (in SI)
            var u = QuantityExpressionParser.Parse("2 kg·m/s²", Inv);
            Assert.AreEqual(2m, AsSI(u), 1e-9m);
        }

        // --------------------------
        // Equivalence sanity (superscript vs caret)
        // --------------------------

        [TestMethod]
        public void SuperscriptAndCaretForms_ShouldBeEquivalent_ForAcceleration()
        {
            var a1 = Acceleration.Parse("1 m/s²", Inv);
            var a2 = Acceleration.Parse("1 m/s^2", Inv);
            Assert.AreEqual(a1.AsSI, a2.AsSI, 1e-12m);
        }

        [TestMethod]
        public void SuperscriptAndCaretForms_ShouldBeEquivalent_ForEnergy()
        {
            var e1 = Energy.Parse("1 kg·m²/s²", Inv);
            var e2 = Energy.Parse("1 kg*m^2/s^2", Inv);
            Assert.AreEqual(e1.AsSI, e2.AsSI, 1e-6m);
        }

        // --------------------------
        // Negative tests (optional, to see current behavior)
        // --------------------------

        [TestMethod]
        public void InvalidSuperscriptSequence_ShouldFail_Friendly()
        {
            // Lone superscript minus with no digit is not meaningful.
            // Depending on your normalizer, this may fail. We assert it DOES fail (or you can flip this if you prefer).
            var r = QuantityExpressionParser.ParseWithWarnings("1 s⁻ + 1 s", Inv);
            Assert.IsFalse(r.Success);
            Assert.IsFalse(string.IsNullOrWhiteSpace(r.Error));
        }
    }
}