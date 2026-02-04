using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class QuantityExpressionParser_UnaryTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        [TestMethod]
        public void UnaryMinus_Parentheses_ShouldWork()
        {
            var u11 = QuantityExpressionParser.Parse("1 * (10 m - 5 m)", Inv);
            Assert.AreEqual(5m, ((EngineeringUnits.BaseUnit)u11).AsSI, 1e-9m);

            var u22 = QuantityExpressionParser.Parse("-1 * (10 m - 5 m)", Inv);
            Assert.AreEqual(-5m, ((EngineeringUnits.BaseUnit)u22).AsSI, 1e-9m);

            var u33 = QuantityExpressionParser.Parse("-(10 m - 5 m)", Inv);
            Assert.AreEqual(-5m, ((EngineeringUnits.BaseUnit)u33).AsSI, 1e-9m);
        }

        [TestMethod]
        public void UnaryPlus_Parentheses_ShouldWork()
        {
            var u = QuantityExpressionParser.Parse("+(10 m - 5 m)", Inv);
            Assert.AreEqual(5m, ((EngineeringUnits.BaseUnit)u).AsSI, 1e-9m);
        }

        [TestMethod]
        public void UnaryPlus_Literal_ShouldWork()
        {
            var u = QuantityExpressionParser.Parse("+10 m", Inv);
            Assert.AreEqual(10m, ((EngineeringUnits.BaseUnit)u).AsSI, 1e-9m);
        }

        [TestMethod]
        public void ScientificNotation_ShouldNotBeBrokenByLiteralScanning()
        {
            // This will FAIL if you keep the "+/- early stop" heuristic
            var u = QuantityExpressionParser.Parse("1e-3 m + 2e-3 m", Inv);
            Assert.AreEqual(0.003m, ((EngineeringUnits.BaseUnit)u).AsSI, 1e-12m);
        }

        [TestMethod]
        public void NegativeExponentInsideUnitExpression_ShouldNotBeBrokenByLiteralScanning()
        {
            // This will FAIL if the early-stop triggers on the '-' in s^-2
            var u = QuantityExpressionParser.Parse("1 s^-2 + 2 s^-2", Inv);
            Assert.AreEqual(3m, ((EngineeringUnits.BaseUnit)u).AsSI, 1e-9m);
        }
    }
}