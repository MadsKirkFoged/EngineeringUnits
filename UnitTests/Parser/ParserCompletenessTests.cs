using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringUnits;
using EngineeringUnits.Parsing;
using EngineeringUnits.Units;
using EngineeringUnits.Parser.UnitParser;

namespace UnitTests.Parsing
{
    /// <summary>Regression tests for the gaps found when reviewing the unit parser.</summary>
    [TestClass]
    public class ParserCompletenessTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;
        private static readonly CultureInfo Da = CultureInfo.GetCultureInfo("da-DK");

        private static void AreClose(double expected, double actual, string because)
        {
            double tol = System.Math.Max(1e-12, System.Math.Abs(expected) * 1e-9);
            Assert.AreEqual(expected, actual, tol, because);
        }

        // ---------------- milli vs mega (case-sensitive prefixes) ----------------

        [TestMethod]
        public void Typed_MilliAndMegaPrefixes_AreNotConfused()
        {
            AreClose(0.005, ElectricCurrent.Parse("5 mA", Inv).As(ElectricCurrentUnit.Ampere), "mA");
            AreClose(5e6, ElectricCurrent.Parse("5 MA", Inv).As(ElectricCurrentUnit.Ampere), "MA");
            AreClose(0.005, ElectricPotential.Parse("5 mV", Inv).As(ElectricPotentialUnit.Volt), "mV");
            AreClose(5e6, ElectricPotential.Parse("5 MV", Inv).As(ElectricPotentialUnit.Volt), "MV");
            AreClose(5e6, Pressure.Parse("5 MPa", Inv).As(PressureUnit.Pascal), "MPa");
            AreClose(0.005, Pressure.Parse("5 mPa", Inv).As(PressureUnit.Pascal), "mPa");
            AreClose(5e6, Power.Parse("5 MW", Inv).As(PowerUnit.Watt), "MW");
            AreClose(0.005, Power.Parse("5 mW", Inv).As(PowerUnit.Watt), "mW");
            Assert.IsFalse(Length.TryParse("5 Mm", out _, Inv), "there is no megameter; Mm must not fall back to mm");
            AreClose(0.005, Length.Parse("5 mm", Inv).As(LengthUnit.Meter), "mm");
            Assert.IsFalse(Mass.TryParse("5 Mg", out _, Inv), "there is no megagram; Mg must not fall back to mg");
            AreClose(5e-6, Mass.Parse("5 mg", Inv).As(MassUnit.Kilogram), "mg");
            AreClose(5e6, Frequency.Parse("5 MHz", Inv).As(FrequencyUnit.Hertz), "MHz");
            Assert.IsFalse(Frequency.TryParse("5 mHz", out _, Inv), "there is no millihertz; mHz must not become MHz");
            AreClose(5e6, Energy.Parse("5 MJ", Inv).As(EnergyUnit.Joule), "MJ");
            AreClose(0.005, Energy.Parse("5 mJ", Inv).As(EnergyUnit.Joule), "mJ");
            AreClose(0.001, ElectricResistance.Parse("1 mΩ", Inv).As(ElectricResistanceUnit.SI), "mΩ");
            AreClose(1e6, ElectricResistance.Parse("1 MΩ", Inv).As(ElectricResistanceUnit.SI), "MΩ");
        }

        [TestMethod]
        public void CaseInsensitiveFallback_OnlyWhenUnambiguous()
        {
            AreClose(5000, Pressure.Parse("5 KPA", Inv).As(PressureUnit.Pascal), "KPA can only mean kPa");
            AreClose(5000, Length.Parse("5 KM", Inv).As(LengthUnit.Meter), "KM can only mean km");

            // The case of a leading prefix letter always counts: MPA is mega
            AreClose(5e6, Pressure.Parse("5 MPA", Inv).As(PressureUnit.Pascal), "MPA is MPa");

            // ...but all-lowercase input loses that information: mpa could be MPa or mPa
            Assert.IsFalse(Pressure.TryParse("5 mpa", out _, Inv));
            var ex = Assert.ThrowsExactly<FormatException>(() => Pressure.Parse("5 mpa", Inv));
            StringAssert.Contains(ex.Message, "Ambiguous");
            Assert.IsFalse(Power.TryParse("5 mw", out _, Inv));
            AreClose(5000, Power.Parse("5 kw", Inv).As(PowerUnit.Watt), "kw can only mean kW");

            // single letters are always case-sensitive
            Assert.IsFalse(Length.TryParse("5 M", out _, Inv));
            Assert.IsFalse(UnitParser.TryParse("a", out _));
        }

        /// <summary>Every predefined unit's own symbol must resolve back to that unit within its quantity.</summary>
        [TestMethod]
        public void EveryUnitSymbol_RoundTripsThroughItsTypedRegistry()
        {
            var failures = new List<string>();
            var knownAmbiguous = new HashSet<string> { "cwt" }; // short vs long hundredweight share a symbol

            var unitTypes = typeof(UnitTypebase).Assembly.GetTypes()
                .Where(t => t.Namespace == "EngineeringUnits.Units" && !t.IsAbstract && typeof(UnitTypebase).IsAssignableFrom(t));

            foreach (var type in unitTypes)
            {
                var tryParse = typeof(UnitParser<>).MakeGenericType(type)
                    .GetMethod("TryParse", new[] { typeof(string), type.MakeByRefType(), typeof(string).MakeByRefType() })!;

                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => type.IsAssignableFrom(f.FieldType)))
                {
                    if (field.GetValue(null) is not UnitTypebase unit || field.IsDefined(typeof(SecondarySymbolAttribute)))
                        continue;

                    var symbol = unit.ToString();
                    if (string.IsNullOrWhiteSpace(symbol) || knownAmbiguous.Contains(symbol))
                        continue;

                    var args = new object?[] { symbol, null, null };
                    bool ok = (bool)tryParse.Invoke(null, args)!;
                    var resolved = args[1] as UnitTypebase;

                    if (!ok || resolved is null)
                    {
                        failures.Add($"{type.Name}.{field.Name} '{symbol}': {args[2] ?? "not found"}");
                        continue;
                    }

                    if (resolved.Unit.SumConstant() != unit.Unit.SumConstant() ||
                        resolved.Unit.SumOfBConstants() != unit.Unit.SumOfBConstants())
                    {
                        failures.Add($"{type.Name}.{field.Name} '{symbol}' resolved to a different unit ({resolved})");
                    }
                }
            }

            Assert.AreEqual(0, failures.Count, "Symbols that do not round-trip:\n" + string.Join("\n", failures));
        }

        [TestMethod]
        public void SharedSymbols_PreferTheCommonUnit_InUnitExpressions()
        {
            AreClose(0.005, QuantityParser.Parse("5 g", Inv).GetValueAsDouble(MassUnit.Kilogram.Unit), "g is gram");
            AreClose(5000, Density.Parse("5 g/cm3", Inv).As(DensityUnit.SI), "g in an expression is gram");
            AreClose(1, QuantityParser.Parse("1 Hz", Inv).GetValueAsDouble(FrequencyUnit.Hertz.Unit), "Hz is 1/s");
            AreClose(1e9, Volume.Parse("1 km³", Inv).As(VolumeUnit.SI), "km³ is cubic kilometer, not 1000 m³");

            // typed parsing still finds the quantity's own meaning
            AreClose(2 * 9.80665, Acceleration.Parse("2 g", Inv).As(AccelerationUnit.SI), "g in Acceleration is standard gravity");
        }

        // ---------------- offsets ----------------

        [TestMethod]
        public void OffsetTemperatures_InCompoundUnits_AreDifferences()
        {
            AreClose(1, SpecificHeatCapacity.Parse("1 J/(kg·°C)", Inv).As(SpecificHeatCapacityUnit.SI), "J/(kg·°C) == J/(kg·K)");
            AreClose(1.730741469816273, ThermalConductivity.Parse("1 BTU/(h·ft·°F)", Inv).As(ThermalConductivityUnit.SI), "BTU/(h·ft·°F) is positive (offset removed)");
            AreClose(293.15, Temperature.Parse("20 °C", Inv).As(TemperatureUnit.Kelvin), "a lone °C keeps its offset");

            var r = QuantityParser.ParseWithWarnings("1 J/(kg·°C)", Inv);
            Assert.IsTrue(r.Warnings.Any(w => w.Code == "OFFSET_UNIT_IN_COMPOUND"));
        }

        [TestMethod]
        public void GaugePressure_KeepsItsOffset()
        {
            AreClose(201325, (double)QuantityParser.Parse("1 barg", Inv).GetValueAs(PressureUnit.Pascal.Unit), "untyped barg");
            AreClose(6894.757293168361 + 101325, Pressure.Parse("1 psig", Inv).As(PressureUnit.Pascal), "psig");
            AreClose(6894.757293168361, Pressure.Parse("1 psia", Inv).As(PressureUnit.Pascal), "psia");
        }

        // ---------------- TryParse never throws ----------------

        [DataTestMethod]
        [DataRow("1e400 m")]
        [DataRow("79228162514264337593543950336 m")]
        [DataRow("5 mpa")]
        [DataRow("abc")]
        [DataRow("m^2147483647")]
        [DataRow("5 m^99999")]
        [DataRow("")]
        public void TryParse_NeverThrows(string input)
        {
            Assert.IsFalse(Length.TryParse(input, out _, Inv));
            _ = QuantityParser.TryParse(input, out _, Inv);
            _ = UnitParser.TryParse(input, out _);
            _ = QuantityExpressionParser.TryParse(input, out _, Inv);
        }

        [TestMethod]
        public void HugeExponent_FailsFast()
        {
            var sw = Stopwatch.StartNew();
            Assert.IsFalse(UnitParser.TryParse("m^2147483647", out _, out var error));
            Assert.IsTrue(sw.ElapsedMilliseconds < 1000);
            StringAssert.Contains(error, "too large");

            Assert.IsTrue(UnitParser.TryParse("m^100", out _));
            Assert.IsTrue(UnitParser.TryParse("s^-123", out _));
        }

        [TestMethod]
        public void UnitParser_TryParse_DoesNotThrowOnAmbiguity()
        {
            Assert.IsTrue(UnitParser.TryParse("Nm", out var torque));
            Assert.IsTrue(torque == TorqueUnit.NewtonMeter.Unit);
        }

        // ---------------- numbers ----------------

        [DataTestMethod]
        [DataRow("5 eV", 8.010882825e-19)]
        [DataRow("5 erg", 5e-7)]
        [DataRow("5e3 J", 5000)]
        [DataRow("5E-3 J", 0.005)]
        public void ExponentLetter_IsOnlyAnExponentBeforeDigits(string input, double joules)
        {
            AreClose(joules, Energy.Parse(input, Inv).As(EnergyUnit.Joule), input);
        }

        [DataTestMethod]
        [DataRow("1 000 m", 1000)]
        [DataRow("1 000 000,5 m", 1000000.5)]
        [DataRow("1.234,5 m", 1234.5)]
        [DataRow("1,234.5 m", 1234.5)]
        [DataRow("1,5 m", 1.5)]      // a single comma with one decimal is a decimal comma, never "15"
        [DataRow("1,234 m", 1234)]   // three digits after a single comma: grouping (invariant culture)
        [DataRow("1,000,000 m", 1000000)]
        public void Numbers_DigitGroupingAndDecimalSeparators(string input, double meters)
        {
            AreClose(meters, Length.Parse(input, Inv).As(LengthUnit.Meter), input);
        }

        [TestMethod]
        public void Numbers_CommaCulture()
        {
            AreClose(1.234, Length.Parse("1,234 m", Da).As(LengthUnit.Meter), "da-DK decimal comma");
        }

        [DataTestMethod]
        [DataRow("1.2.3,4.5 m")]
        [DataRow("1,23,4 m")]
        [DataRow("- 5 m")]
        public void Numbers_Malformed_Fail(string input)
        {
            Assert.IsFalse(Length.TryParse(input, out _, Inv));
        }

        // ---------------- grammar ----------------

        [DataTestMethod]
        [DataRow("m2", "m^2")]
        [DataRow("mm2", "mm^2")]
        [DataRow("kg/m3", "kg/m^3")]
        [DataRow("W/m2K", "W/(m^2*K)")]
        [DataRow("s-1", "s^-1")]
        [DataRow("m s-1", "m/s")]
        [DataRow("m.s-1", "m/s")]
        [DataRow("m.s^-1", "m/s")]
        [DataRow("1/s", "s^-1")]
        [DataRow("/s", "s^-1")]
        [DataRow("1/(m s)", "m^-1*s^-1")]
        [DataRow("[m]", "m")]
        [DataRow("{m}/s", "m/s")]
        [DataRow("W/m K", "W/(m*K)")]
        [DataRow("W/m·K", "W/(m*K)")]
        [DataRow("J/kg K", "J/(kg*K)")]
        [DataRow("m/s*kg", "(m/s)*kg")]
        [DataRow("sq ft", "ft^2")]
        [DataRow("%", "%")]
        [DataRow("℃", "°C")]
        [DataRow("mm H2O", "mmH2O")]
        [DataRow("in wc", "inH2O")]
        public void UnitExpressions_Equivalent(string a, string b)
        {
            Assert.IsTrue(UnitParser.TryParse(a, out var ua, out var ea), $"'{a}': {ea}");
            Assert.IsTrue(UnitParser.TryParse(b, out var ub, out var eb), $"'{b}': {eb}");
            Assert.IsTrue(ua == ub, $"dimension of '{a}' vs '{b}'");
            Assert.AreEqual((double)ub.SumConstant(), (double)ua.SumConstant(), System.Math.Abs((double)ub.SumConstant()) * 1e-12, $"factor of '{a}' vs '{b}'");
        }

        [TestMethod]
        public void ImplicitDenominator_EmitsWarning()
        {
            Assert.IsTrue(UnitExpressionParser.TryParseWithWarnings("W/m K", out _, out var warnings, out _));
            Assert.IsTrue(warnings.Any(w => w.Code == "UNIT_DENOMINATOR_GROUPING"));

            Assert.IsTrue(UnitExpressionParser.TryParseWithWarnings("W/(m K)", out _, out warnings, out _));
            Assert.IsFalse(warnings.Any(w => w.Code == "UNIT_DENOMINATOR_GROUPING"));
        }

        [DataTestMethod]
        [DataRow("m^0.5", "Fractional")]
        [DataRow("m^(1/2)", "Fractional")]
        [DataRow("m^2^3", "Chained")]
        [DataRow("m()", "Empty parentheses")]
        [DataRow("m₂", "Unexpected character")]
        [DataRow("2m", "numbers are not allowed")]
        [DataRow("totallyNotAUnit", "Unknown unit")]
        public void UnitExpressions_Invalid_HaveHelpfulErrors(string input, string expected)
        {
            Assert.IsFalse(UnitParser.TryParse(input, out _, out var error));
            StringAssert.Contains(error, expected);
        }

        // ---------------- names/synonyms ----------------

        [TestMethod]
        public void CommonNames_Resolve()
        {
            AreClose(0.001, Volume.Parse("1 L", Inv).As(VolumeUnit.SI), "L");
            AreClose(1e-6, Volume.Parse("1 mL", Inv).As(VolumeUnit.SI), "mL");
            AreClose(1000, Volume.Parse("1 ML", Inv).As(VolumeUnit.SI), "ML is megaliter");
            AreClose(0.003785411784, Volume.Parse("1 gal", Inv).As(VolumeUnit.SI), "gal is US gallon");
            AreClose(0.45359237, Mass.Parse("1 lbm", Inv).As(MassUnit.Kilogram), "lbm");
            AreClose(907.18474, Mass.Parse("1 ton", Inv).As(MassUnit.Kilogram), "ton (mass) is short ton");
            AreClose(Power.Parse("1 TR", Inv).As(PowerUnit.Watt), Power.Parse("1 ton", Inv).As(PowerUnit.Watt), "ton (power) is refrigeration ton");
            AreClose(86400, Duration.Parse("1 d", Inv).As(DurationUnit.Second), "d");
            AreClose(360, Angle.Parse("1 rev", Inv).As(AngleUnit.Degree), "rev");
            AreClose(1e-10, Length.Parse("1 Å", Inv).As(LengthUnit.Meter), "Å");
            AreClose(9.80665, Pressure.Parse("1 mmH2O", Inv).As(PressureUnit.Pascal), "mmH2O");
            AreClose(293.15, Temperature.Parse("20 ℃", Inv).As(TemperatureUnit.Kelvin), "℃");
            AreClose(293.15, Temperature.Parse("68 ℉", Inv).As(TemperatureUnit.Kelvin), "℉");
            Assert.IsTrue(UnitParser.TryParse("mho", out var mho) && mho == ElectricAdmittanceUnit.Siemens.Unit, "mho");
        }

        [TestMethod]
        public void DegreeSignWithSpace_IsTemperature()
        {
            AreClose(293.15, (double)QuantityParser.Parse("20 ° C", Inv).GetValueAs(TemperatureUnit.Kelvin.Unit), "° C");
        }

        [TestMethod]
        public void Typed_KeepsTheUsersUnit_WhenItIsAPredefinedOne()
        {
            var e = Energy.Parse("5 kW h", Inv);
            Assert.AreEqual("kWh", e.Unit.ToString());
            AreClose(1.8e7, e.As(EnergyUnit.Joule), "kW h");
        }

        // ---------------- quantity arithmetic ----------------

        [DataTestMethod]
        [DataRow("10 m/2/s", 5)]          // 10 m ÷ 2 ÷ s
        [DataRow("10 m / 2 s", 5)]        // literal "2 s"
        [DataRow("1/s + 2/s", 3)]         // "2/s" is still a literal
        [DataRow("2^3 m", 8)]
        [DataRow("(2 m)^2", 4)]
        [DataRow("2 (3 m)", 6)]
        [DataRow("(5) m", 5)]
        [DataRow("5 m-3 m", 2)]           // inside arithmetic '-' is always subtraction
        [DataRow("1e-3 m + 2e-3 m", 0.003)]
        [DataRow("1 kg*mm^5/s^3 * 1 s^3", 1e-15)]
        public void Expressions_Evaluate(string input, double expectedSI)
        {
            var r = QuantityExpressionParser.ParseWithWarnings(input, Inv);
            Assert.IsTrue(r.Success, $"'{input}': {r.Error}");
            AreClose(expectedSI, (double)((EngineeringUnits.BaseUnit)r.Value!).AsSI, input);
        }

        [TestMethod]
        public void Expressions_10mPer2PerS_HasSpeedDimension()
        {
            var u = QuantityExpressionParser.Parse("10 m/2/s", Inv);
            Assert.IsTrue(u.Unit == SpeedUnit.SI.Unit);
        }

        [TestMethod]
        public void LongExpressions_AreFast()
        {
            var input = string.Join(" + ", Enumerable.Repeat("1.5 kg*m^2/s^2", 200));
            var sw = Stopwatch.StartNew();
            var r = QuantityExpressionParser.ParseWithWarnings(input, Inv);
            sw.Stop();

            Assert.IsTrue(r.Success, r.Error);
            Assert.IsTrue(sw.ElapsedMilliseconds < 2000, $"took {sw.ElapsedMilliseconds} ms");
        }

        // ---------------- API ----------------

        [TestMethod]
        public void Quantities_HaveTryParse()
        {
            Assert.IsTrue(Length.TryParse("5 km", out var length, Inv));
            AreClose(5000, length.As(LengthUnit.Meter), "TryParse value");

            Assert.IsFalse(Length.TryParse("5 s", out var none, Inv));
            Assert.IsNull(none);

            Assert.IsTrue(MassConcentration.TryParse("5 g/L", out var c, Inv));
            AreClose(5, c.As(DensityUnit.SI), "hand-written quantity TryParse");
        }
    }
}
