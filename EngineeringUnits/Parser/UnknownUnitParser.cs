using System;
using System.Globalization;

namespace EngineeringUnits.Parsing
{
    public static class UnknownUnitParser
    {
        public static UnknownUnit Parse(string input, IFormatProvider? culture = null)
        {
            if (!TryParse(input, out var u, culture))
                throw new FormatException($"Could not parse '{input}'. Expected formats like '10 m', '2 N*m', '3 kg*m^2/s^2'.");
            return u!;
        }

        public static bool TryParse(string input, out UnknownUnit unit, IFormatProvider? culture = null)
        {
            unit = default!;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            input = input.Trim();

            if (!TrySplitNumberAndUnit(input, out var numberPart, out var unitExpr))
                return false;

            if (!TryParseDouble(numberPart, culture, out var value))
                return false;

            if (!UnitExpressionParser.TryParse(unitExpr, out var unitSystem))
                return false;

            unit = new UnknownUnit((decimal)value, unitSystem);
            return true;
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
                {
                    i++;
                    continue;
                }

                if (char.IsWhiteSpace(c))
                {
                    i++;
                    continue;
                }

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