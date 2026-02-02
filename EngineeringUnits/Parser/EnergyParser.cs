using System;
using System.Globalization;
using EngineeringUnits.Units;

namespace EngineeringUnits.Parsing
{
    public static class EnergyParser
    {
        public static Energy Parse(string input, IFormatProvider? culture = null)
        {
            if (!TryParse(input, out var energy, culture))
                throw new FormatException($"Could not parse Energy from '{input}'. Examples: '12 J', '1 kWh', '3 N*m', '2 kg*m^2/s^2'.");
            return energy;
        }

        public static bool TryParse(string input, out Energy energy, IFormatProvider? culture = null)
        {
            energy = default!;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            input = input.Trim();

            if (!TrySplitNumberAndUnit(input, out var numberPart, out var unitPart))
                return false;

            if (!TryParseDouble(numberPart, culture, out var valueDouble))
                return false;

            unitPart = UnitTokenRegistry<EnergyUnit>.NormalizeToken(unitPart);

            // 1) Direct energy unit token
            if (UnitTokenRegistry<EnergyUnit>.TryResolve(unitPart, out var eu))
            {
                energy = new Energy(valueDouble, eu);
                return true;
            }

            // 2) Unit expression -> UnitSystem
            if (!UnitExpressionParser.TryParse(unitPart, out var exprUnit))
                return false;

            // 3) Confirm it is energy dimension (SI-normalized compare)
            // UnitSystem equality is dimension-based; GetSIUnitsystem helps normalize raw units. [1](https://github.com/MadsKirkFoged/EngineeringUnits/blob/master/EngineeringUnits/UnitSystem.cs)[2](https://github.com/MadsKirkFoged/EngineeringUnits/blob/master/EngineeringUnits/UnitSystemExtensions.cs)
            var exprSI = exprUnit.GetSIUnitsystem();
            var energySI = EnergyUnit.SI.Unit.GetSIUnitsystem();

            if (exprSI != energySI)
                return false;

            // 4) Convert to Joules using UnknownUnit conversion machinery
            var unknown = new UnknownUnit((decimal)valueDouble, exprUnit);
            decimal joules = (decimal)unknown.GetValueAs(EnergyUnit.SI.Unit);

            // Create energy in SI
            energy = new Energy((double)joules, EnergyUnit.SI);
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