using System;
using System.Linq;
using Fractions;

namespace EngineeringUnits.Parsing
{
    public static class UnitSystemParserSafeFormatter
    {
        public static string ToParserSafeExpression(UnitSystem unit)
        {
            var si = unit.GetSIUnitsystem();

            // Remove the useless dimensionless combined-unit
            var cleaned = si.ListOfUnits.Where(u => !IsUselessDimensionlessCombined(u)).ToList();

            var pos = cleaned.Where(u => u.Count > 0).ToList();
            var neg = cleaned.Where(u => u.Count < 0).ToList();

            static string Format(RawUnit ru)
            {
                var sym = ru.Symbol;
                if (string.IsNullOrWhiteSpace(sym))
                    throw new FormatException($"Cannot format unit token: missing symbol for {ru.UnitType} (Count={ru.Count}).");

                int p = Math.Abs(ru.Count);
                return p == 1 ? sym : $"{sym}^{p}";
            }

            // Numerator: join with '*'
            string expr = pos.Count == 0 ? "1" : string.Join("*", pos.Select(Format));

            // Denominator: IMPORTANT — chain divisions instead of multiplying denominator factors.
            // expr / a / b  == expr / (a*b)  under left-to-right parsing.
            foreach (var d in neg.Select(Format))
            {
                expr += "/" + d;
            }

            // If expression is exactly "1" (dimensionless), return "1"
            return expr;
        }

        private static bool IsUselessDimensionlessCombined(RawUnit u)
        {
            if (u.UnitType != BaseunitType.CombinedUnit)
                return false;

            bool noSymbol = string.IsNullOrWhiteSpace(u.Symbol);
            bool isOne = u.A == Fraction.One;
            bool noOffset = u.B == Fraction.Zero;
            bool countOne = u.Count == 1;

            return noSymbol && isOne && noOffset && countOne;
        }
    }
}