
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
    }
}
