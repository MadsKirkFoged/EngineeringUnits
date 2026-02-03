using System;
using System.Globalization;
using EngineeringUnits.Parsing;

namespace EngineeringUnits.Parsing
{
    public static class QuantityParser
    {
        /// <summary>
        /// Parses either:
        ///  - "<number> <TUnit token>"  (token resolved using UnitTokenRegistry<TUnit> only)
        ///  - "<number> <unit expression>" (expression parsed to UnitSystem, dimension-checked vs siUnit)
        /// </summary>
        public static bool TryParse<TQuantity, TUnit>(
            string? input,
            Func<double, TUnit, TQuantity> factory,
            TUnit siUnit,
            out TQuantity value,
            IFormatProvider? culture = null,
            bool allowUnitExpressions = true)
            where TUnit : UnitTypebase
        {
            value = default!;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            input = input.Trim();

            if (!TrySplitNumberAndUnit(input, out var numberPart, out var unitPart))
                return false;

            if (!TryParseDouble(numberPart, culture, out var number))
                return false;


            unitPart = unitPart.Trim();

            // If the unit expression begins with '/', rewrite it as "(rest)^-1"
            // This avoids introducing numeric literals (like "1/s") into the unit-expression grammar.
            if (unitPart.StartsWith("/", StringComparison.Ordinal))
            {
                var rest = unitPart.Substring(1).Trim();
                if (rest.Length == 0)
                    return false;

                unitPart = $"({rest})^-1";
            }


            // 1) First try: typed token only (safe, no cross-quantity matches)
            if (UnitParser<TUnit>.TryParse(unitPart, out var unitToken))
            {
                value = factory(number, unitToken);
                return true;
            }

            // 2) Second try: unit expression -> UnitSystem -> dimension-check -> convert to SI -> construct
            if (!allowUnitExpressions)
                return false;

            if (!UnitParser.TryParse(unitPart, out var unitSystem))
                return false;

            // Dimension check (SI-normalized compare)
            // UnitSystem equality is dimension-based and GetSIUnitsystem normalizes symbols/constants. [1](https://careerkarma.com/blog/git-download-a-single-file-from-github/)[2](https://github.com/MadsKirkFoged/)
            if (unitSystem.GetSIUnitsystem() != siUnit.Unit.GetSIUnitsystem())
                return false;

            // Convert numeric value expressed in "unitSystem" to SI quantity value
            // Use UnknownUnit as the intermediate (value + UnitSystem), then convert via existing conversion machinery. [3](https://www.nuget.org/packages/EngineeringUnits/1.1.0)
            var unknown = new UnknownUnit((decimal)number, unitSystem);
            decimal siValue = (decimal)unknown.GetValueAs(siUnit.Unit);

            value = factory((double)siValue, siUnit);
            return true;
        }

        public static TQuantity Parse<TQuantity, TUnit>(
            string? input,
            Func<double, TUnit, TQuantity> factory,
            TUnit siUnit,
            IFormatProvider? culture = null,
            bool allowUnitExpressions = true)
            where TUnit : UnitTypebase
        {
            if (!TryParse(input, factory, siUnit, out TQuantity value, culture, allowUnitExpressions))
                throw new FormatException($"Could not parse {typeof(TQuantity).Name} from '{input}'.");
            return value;
        }

        private static bool TrySplitNumberAndUnit(string input, out string numberPart, out string unitPart)
        {
            numberPart = "";
            unitPart = "";

            int i = 0;
            while (i < input.Length && char.IsWhiteSpace(input[i]))
                i++;
            if (i >= input.Length)
                return false;

            int startNum = i;

            while (i < input.Length)
            {
                char c = input[i];

                if (char.IsDigit(c) || c == '+' || c == '-' || c == '.' || c == ',' || c == 'e' || c == 'E')
                { i++; continue; }

                if (char.IsWhiteSpace(c))
                { i++; continue; }

                break;
            }

            int endNum = i;

            while (i < input.Length && char.IsWhiteSpace(input[i]))
                i++;
            if (i >= input.Length)
                return false;

            int startUnit = i;

            numberPart = input.Substring(startNum, endNum - startNum).Trim();
            unitPart = input.Substring(startUnit).Trim();

            return numberPart.Length > 0 && unitPart.Length > 0;
        }

        private static bool TryParseDouble(string s, IFormatProvider? culture, out double value)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(s))
                return false;

            const NumberStyles style = NumberStyles.Float | NumberStyles.AllowThousands;

            int lastDot = s.LastIndexOf('.');
            int lastComma = s.LastIndexOf(',');

            bool hasDot = lastDot >= 0;
            bool hasComma = lastComma >= 0;

            bool looksDotDecimal =
                (hasDot && !hasComma) ||
                (hasDot && hasComma && lastDot > lastComma);

            bool looksCommaDecimal =
                (hasComma && !hasDot) ||
                (hasDot && hasComma && lastComma > lastDot);

            if (looksDotDecimal)
            {
                if (double.TryParse(s, style, CultureInfo.InvariantCulture, out value))
                    return true;
                if (culture != null && double.TryParse(s, style, culture, out value))
                    return true;
                if (double.TryParse(s, style, CultureInfo.CurrentCulture, out value))
                    return true;
                return false;
            }

            if (looksCommaDecimal)
            {
                if (culture != null && double.TryParse(s, style, culture, out value))
                    return true;
                if (double.TryParse(s, style, CultureInfo.CurrentCulture, out value))
                    return true;

                if (!hasDot)
                {
                    var normalized = s.Replace(',', '.');
                    if (double.TryParse(normalized, style, CultureInfo.InvariantCulture, out value))
                        return true;
                }

                return false;
            }

            if (culture != null && double.TryParse(s, style, culture, out value))
                return true;
            if (double.TryParse(s, style, CultureInfo.InvariantCulture, out value))
                return true;
            if (double.TryParse(s, style, CultureInfo.CurrentCulture, out value))
                return true;

            return false;
        }
    }
}