using System;
using System.Globalization;
using EngineeringUnits.Units;

namespace EngineeringUnits.Parsing
{
    public static class LengthParser
    {
        public static Length Parse(string input, IFormatProvider? culture = null)
        {
            if (!TryParse(input, out var length, culture))
                throw new FormatException($"Could not parse Length from '{input}'. Expected formats like '12.3 m' or '10metre'.");
            return length;
        }

        public static bool TryParse(string input, out Length length, IFormatProvider? culture = null)
        {
            length = default;

            //If input is empty
            if (string.IsNullOrWhiteSpace(input))
                return false;

            //Trim end
            input = input.Trim();


            //Splitting value and unit
            if (!TrySplitNumberAndUnit(input, out var numberPart, out var unitPart))
                return false;

            //Putting the value into a double
            if (!TryParseDouble(numberPart, culture, out var value))
                return false;

            //If the user picked a Synonyms we transfer it into our choose
            unitPart = UnitTokenRegistry<LengthUnit>.NormalizeToken(unitPart);

            // Getting the unit based on the Normalized unit name
            if (!UnitTokenRegistry<LengthUnit>.TryResolve(unitPart, out var unit))
                return false;

            length = new Length(value, unit);
            return true;
        }

        // "12.3 m" -> numberPart="12.3", unitPart="m"
        // "10metre" -> numberPart="10", unitPart="metre"
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

                // number chars: digits, sign, separators, exponent markers
                if (char.IsDigit(c) || c == '+' || c == '-' || c == '.' || c == ',' || c == 'e' || c == 'E')
                {
                    i++;
                    continue;
                }

                // allow whitespace between number and unit
                if (char.IsWhiteSpace(c))
                {
                    i++;
                    continue;
                }

                // first non-number -> unit starts
                break;
            }

            int endNum = i;

            // skip whitespace before unit
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

            // Simple and deterministic:
            // 1) If a culture is provided, use it
            // 2) Otherwise, try Invariant first (handles "12.3")
            // 3) Then CurrentCulture (handles "12,3" on dk-DK, etc.)
            const NumberStyles style = NumberStyles.Float | NumberStyles.AllowThousands;

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