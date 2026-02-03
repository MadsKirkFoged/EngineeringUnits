using System;
using System.Collections.Generic;
using System.Globalization;

namespace EngineeringUnits.Parsing
{
    public static class UnknownUnitParser
    {
        public static ParseResult<UnknownUnit> ParseWithWarnings(string? input, IFormatProvider? culture = null)
        {
            string original = input ?? "";

            if (string.IsNullOrWhiteSpace(input))
                return Fail(original, "Input was empty.");

            input = input.Trim();

            if (!TrySplitNumberAndUnit(input, out var numberPart, out var unitExpr))
                return Fail(original, "Expected '<number> <unit expression>'.");

            if (!TryParseDouble(numberPart, culture, out var value))
                return Fail(original, "Could not parse numeric value.");

            unitExpr = unitExpr.Trim();

            if (unitExpr.StartsWith("/", StringComparison.Ordinal))
            {
                var rest = unitExpr.Substring(1).Trim();
                if (rest.Length == 0)
                    return Fail(original, "Unit expression started with '/' but had no denominator.");

                unitExpr = $"({rest})^-1";
            }


            // ✅ Friendly: no exceptions, errors returned via out string
            if (!UnitExpressionParser.TryParseWithWarnings(unitExpr, out var unitSystem, out List<ParseWarning> warnings, out string? error))
                return Fail(original, error ?? "Could not parse unit expression.");

            var normalized = $"{numberPart} {unitSystem}";
            var unknown = new UnknownUnit((decimal)value, unitSystem);

            return new ParseResult<UnknownUnit>
            {
                Success = true,
                Value = unknown,
                Original = original,
                Normalized = normalized,
                Warnings = warnings
            };
        }


        public static UnknownUnit Parse(string? input, IFormatProvider? culture = null)
        {
            var r = ParseWithWarnings(input, culture);
            if (!r.Success || r.Value is null)
                throw new FormatException($"Could not parse '{input}'. {r.Error}");
            return r.Value;
        }

        public static bool TryParse(string? input, out UnknownUnit unit, IFormatProvider? culture = null)
        {
            unit = default!;
            var r = ParseWithWarnings(input, culture);
            if (!r.Success || r.Value is null)
                return false;

            unit = r.Value;
            return true;
        }

        private static ParseResult<UnknownUnit> Fail(string original, string message)
        {
            return new ParseResult<UnknownUnit>
            {
                Success = false,
                Value = null,
                Original = original,
                Normalized = "",
                Warnings = Array.Empty<ParseWarning>(),
                Error = message
            };
        }


        // ---------------- helpers ----------------

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

            numberPart = input.Substring(startNum, endNum - startNum).Trim();
            unitPart = input.Substring(i).Trim();

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