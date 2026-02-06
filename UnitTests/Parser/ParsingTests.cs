
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using EngineeringUnits;

namespace UnitTests.Parsing
{
    [TestClass]
    public class QuantityExpressionTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        [TestMethod]
        public void Energy_Parse_ShouldAccept_EquivalentExpressions()
        {
            var a = Energy.Parse("1 N*m", Inv);
            var b = Energy.Parse("1 kg*m^2/s^2", Inv);
            var c = Energy.Parse("1 W*h", Inv);

            Assert.AreEqual(1m, a.AsSI, 1e-9m);
            Assert.AreEqual(1m, b.AsSI, 1e-9m);
            Assert.AreEqual(3600m, c.AsSI, 1e-9m);
        }

        [TestMethod]
        public void Pressure_Parse_ShouldAccept_NewtonPerSquareMeter_IfYouWantThat()
        {
            // Enable this once you're happy pressure expressions are intended.
            var p = Pressure.Parse("1 N/m^2", Inv);
            Assert.AreEqual(1m, p.AsSI, 1e-9m);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UnicodeMinus_InExponent_ShouldParse()
        {
            var a = UnknownUnit.Parse("1 kg*m^2*s^-2", CultureInfo.InvariantCulture);
            var b = UnknownUnit.Parse("1 kg*m^2*s^−2", CultureInfo.InvariantCulture); // U+2212

            Assert.AreEqual(((EngineeringUnits.BaseUnit)a).AsSI, ((EngineeringUnits.BaseUnit)b).AsSI, 1e-12m);
            Assert.IsTrue(a.Unit.GetSIUnitsystem() == b.Unit.GetSIUnitsystem());
        }

        [TestMethod]
        public void SuperscriptNegativeExponent_ShouldParse_ForAcceleration()
        {
            var inv = CultureInfo.InvariantCulture;

            var a1 = Acceleration.Parse("1 m·s⁻²", inv);
            Assert.AreEqual(1m, a1.AsSI, 1e-9m);

            // Mixed unicode minus + superscript digit (common copy/paste)
            var a2 = Acceleration.Parse("1 m·s−²", inv); // U+2212 + U+00B2
            Assert.AreEqual(1m, a2.AsSI, 1e-9m);

            // ASCII '-' + superscript digit (after normalization)
            var a3 = Acceleration.Parse("1 m·s-²", inv);
            Assert.AreEqual(1m, a3.AsSI, 1e-9m);
        }


        [TestMethod]
        public void TypedParse_PowerOfTen_ShouldWork()
        {
            var p = Pressure.Parse("10^−1 Pa", CultureInfo.InvariantCulture);
            Assert.AreEqual(0.1m, p.AsSI, 1e-12m);
        }

        [TestMethod]
        public void UnknownUnitParse_PowerOfTen_ShouldWork()
        {
            var u = UnknownUnit.Parse("10−1 Pa", CultureInfo.InvariantCulture);
            Assert.AreEqual(0.1m, ((EngineeringUnits.BaseUnit)u).AsSI, 1e-12m);
        }

    }
}
