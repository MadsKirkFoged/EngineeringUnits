using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using EngineeringUnits;

namespace UnitTests.Parsing
{
    [TestClass]
    public class GeneratedParseSmokeTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        public static IEnumerable<object[]> AllQuantityParseCases()
        {
            var asm = typeof(UnitTypebase).Assembly;

            // Quantity types are typically in EngineeringUnits namespace and derive from BaseUnit
            var quantityTypes = asm.GetTypes()
                .Where(t =>
                    t.IsClass &&
                    t.Namespace == "EngineeringUnits" &&
                    typeof(EngineeringUnits.BaseUnit).IsAssignableFrom(t))
                .ToList();

            foreach (var qt in quantityTypes)
            {
                // Find Parse(string, IFormatProvider) on quantity
                var parse = qt.GetMethod(
                    "Parse",
                    BindingFlags.Public | BindingFlags.Static,
                    binder: null,
                    types: new[] { typeof(string), typeof(IFormatProvider) },
                    modifiers: null);

                if (parse is null)
                    continue;

                // Find unit type: EngineeringUnits.Units.{QuantityName}Unit
                var unitTypeName = $"EngineeringUnits.Units.{qt.Name}Unit";
                var ut = asm.GetType(unitTypeName);
                if (ut is null)
                    continue;

                // Need static field SI on unit type
                var siField = ut.GetField("SI", BindingFlags.Public | BindingFlags.Static);
                if (siField is null)
                    continue;

                var siUnit = siField.GetValue(null);
                if (siUnit is null)
                    continue;

                // Use unit token from ToString() (this is how your registry resolves symbols)
                var siToken = siUnit.ToString();
                if (string.IsNullOrWhiteSpace(siToken))
                    continue;

                // Build input
                var input = $"1 {siToken}";

                yield return new object[] { qt, ut, input };
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AllQuantityParseCases), DynamicDataSourceType.Method)]
        public void Parse_SI_ShouldReturn_AsSI_Equals_One(Type quantityType, Type unitType, string input)
        {
            var parse = quantityType.GetMethod(
                "Parse",
                BindingFlags.Public | BindingFlags.Static,
                binder: null,
                types: new[] { typeof(string), typeof(IFormatProvider) },
                modifiers: null);

            Assert.IsNotNull(parse, $"{quantityType.FullName}.Parse not found");

            object? result;
            try
            {
                result = parse!.Invoke(null, new object[] { input, Inv });
            }
            catch (TargetInvocationException tie) when (tie.InnerException != null)
            {
                Assert.Fail($"{quantityType.Name}.Parse threw: {tie.InnerException.GetType().Name}: {tie.InnerException.Message} (input='{input}')");
                return;
            }

            Assert.IsNotNull(result, $"{quantityType.Name}.Parse returned null (input='{input}')");
            Assert.IsTrue(result is EngineeringUnits.BaseUnit, $"{quantityType.Name}.Parse did not return BaseUnit-derived type.");

            var baseUnit = (EngineeringUnits.BaseUnit)result!;
            var asSi = baseUnit.AsSI; // decimal

            // Strong assertion: parsing "1 <SI>" yields base value == 1
            Assert.AreEqual(1m, asSi, 1e-12m, $"{quantityType.Name}: AsSI mismatch for '{input}'");
        }
    }
}