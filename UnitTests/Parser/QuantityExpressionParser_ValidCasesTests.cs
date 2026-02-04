using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class QuantityExpressionParser_ValidCasesTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        public static IEnumerable<object[]> ValidCases()
        {
            // (expr, expectedAsSI?, tolerance)
            // expectedAsSI is a decimal?; if null => only assert it parses.

            // --- Baseline arithmetic ---
            yield return Case("10 m + 2 m", 12m);
            yield return Case("10 m - 2 m", 8m);
            yield return Case("(10 m + 2 m) - 3 m", 9m);
            yield return Case("10 m + (2 m)", 12m);
            yield return Case("10 m + (-2 m)", 8m);

            // --- Precedence ---
            yield return Case("10 m + 2 m * 3", 16m);        // 10 + (2*3)
            yield return Case("(10 m + 2 m) * 3", 36m);      // (10+2)*3
            yield return Case("10 m + (2 m * 3)", 16m);

            // --- Unary minus (literal) and unary minus before parens ---
            yield return Case("-5 m + 10 m", 5m);
            yield return Case("10 m + (-5 m)", 5m);
            yield return Case("-(10 m - 5 m)", -5m);

            // --- Dimensionless support ---
            yield return Case("10 + 5", 15m);                // dimensionless
            yield return Case("10 * 5", 50m);
            yield return Case("10 / 5", 2m);
            yield return Case("10 m * 2", 20m);              // keep SI invariant
            yield return Case("2 * 10 m", 20m);
            yield return Case("10 m / 2", 5m);

            // --- Frequency / leading division in literals ---
            yield return Case("1/s + 2/s", 3m);              // AsSI is in 1/s
            yield return Case("2/s - 1/s", 1m);
            yield return Case("(1/s) * (10 s)", 10m);        // dimensionless (1/s * s)
            yield return Case("(2/s) * (3 s)", 6m);

            // --- Force / pressure / energy equivalences ---
            yield return Case("1 N*m - 1 kg*m^2/s^2", 0m, 1e-6m);
            yield return Case("1 Pa*m^3 - 1 J", 0m, 1e-6m);
            yield return Case("1 W*s - 1 J", 0m, 1e-6m);

            // --- Mixed arithmetic with convertible length units (unit engine decides conversions) ---
            // We only assert AsSI in meters.
            yield return Case("10 m + 5 in", 10m + (5m * 0.0254m), 1e-6m);
            yield return Case("5 in + 10 m", 10m + (5m * 0.0254m), 1e-6m);
            yield return Case("10 m + 10 m - 5 in", 20m - (5m * 0.0254m), 1e-6m);
            yield return Case("(10 m + 5 in) * 2", 2m * (10m + (5m * 0.0254m)), 1e-6m);

            // --- Power / voltage / resistance identities ---
            yield return Case("1 V*A - 1 W", 0m, 1e-6m);
            yield return Case("1 W/A - 1 V", 0m, 1e-6m);
            yield return Case("1 V/A - 1 Ohm", 0m, 1e-6m);
            yield return Case("1 A/V - 1 S", 0m, 1e-6m);

            // --- Charge / current ---
            yield return Case("1 A*s - 1 C", 0m, 1e-6m);
            yield return Case("2 C/s - 2 A", 0m, 1e-6m);

            // --- Inductance / capacitance (dimension identities) ---
            yield return Case("1 V*s/A - 1 H", 0m, 1e-6m);
            yield return Case("1 C/V - 1 F", 0m, 1e-6m);

            // --- Unit-expression heavy operands ---
            yield return Case("1 kg*mm^5/s^3 * 1 s^3", null); // Just ensure it parses & evaluates
            yield return Case("(1 kg*mm^5/s^3) * (1 s^3)", null);

            // --- Nested parentheses stress ---
            yield return Case("((10 m + 5 in) - (2 cm)) * 3",
                3m * ((10m + (5m * 0.0254m)) - 0.02m), 1e-6m);

            // --- More algebraic cancellation ---
            yield return Case("(10 m/s) * (5 s)", 50m);
            yield return Case("(10 N) * (2 m) / (4 s)", null); // (N*m)/s => W, only parse check

            // --- “SI unit present” observation tests (not asserting chosen unit, only SI value) ---
            yield return Case("1 m + 1 cm + 1 mm", 1m + 0.01m + 0.001m, 1e-9m);
            yield return Case("1000 mm - 1 m", 0m, 1e-9m);

            // --- Temperature: only assert parse success if you know it currently supports these operations ---
            // These are policy-sensitive; leave expectedAsSI null so we only detect “works/fails today”.
            yield return Case("10 °C + 5 °C", null);
            yield return Case("30 °C - 20 °C", null);
        }

        private static object[] Case(string expr, decimal? expectedAsSI, decimal tol = 1e-9m)
            => new object[] { expr, expectedAsSI, tol };

        [DataTestMethod]
        [DynamicData(nameof(ValidCases), DynamicDataSourceType.Method)]
        public void ValidExpressions_ShouldParse_AndMatchAsSI_WhenProvided(string expr, decimal? expectedAsSI, decimal tol)
        {
            var r = QuantityExpressionParser.ParseWithWarnings(expr, Inv);

            Assert.IsTrue(r.Success, $"Expected success for '{expr}', got error: {r.Error}");
            Assert.IsNotNull(r.Value, $"Success but Value was null for '{expr}'");

            if (expectedAsSI.HasValue)
            {
                // UnknownUnit should be BaseUnit-derived in this library; AsSI is the base-value view.
                // If your UnknownUnit exposes AsSI directly, keep this. Otherwise cast to BaseUnit.
                decimal actual = ((EngineeringUnits.BaseUnit)r.Value!).AsSI;
                Assert.AreEqual(expectedAsSI.Value, actual, tol, $"AsSI mismatch for '{expr}'");
            }
        }
    }
}
