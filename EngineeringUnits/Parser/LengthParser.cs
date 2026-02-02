using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

            if (string.IsNullOrWhiteSpace(input))
                return false;

            input = input.Trim();

            // Splitting value and unit
            if (!TrySplitNumberAndUnit(input, out var numberPart, out var unitPart))
                return false;

            // Putting the value into a double
            if (!TryParseDouble(numberPart, culture, out var value))
                return false;

            // Normalize token
            unitPart = UnitTokenRegistry<LengthUnit>.NormalizeToken(unitPart);

            // 1) Try direct resolve (symbol/name/synonyms/ToString)
            if (!UnitTokenRegistry<LengthUnit>.TryResolve(unitPart, out var unit))
            {
                // 2) Try prefix decomposition as last resort
                if (!TryResolveWithPrefix(unitPart, out unit, out var scale))
                    return false;

                value *= scale; // convert to the base unit we resolved after stripping prefix
            }

            length = new Length(value, unit);
            return true;
        }

        private static bool TryResolveWithPrefix(string unitToken, out LengthUnit unit, out double scale)
        {
            unit = default!;
            scale = 1.0;

            // Try short prefix symbols first (case-sensitive): da, Y, Z, E, P, T, G, M, k, h, d, c, m, µ, n, p, f, a, z, y
            foreach (var p in PrefixBySymbolLongestFirst)
            {
                if (unitToken.StartsWith(p.Symbol, StringComparison.Ordinal))
                {
                    var rest = unitToken.Substring(p.Symbol.Length);
                    rest = UnitTokenRegistry<LengthUnit>.NormalizeToken(rest);

                    if (rest.Length == 0)
                        continue;

                    if (UnitTokenRegistry<LengthUnit>.TryResolve(rest, out unit))
                    {
                        scale = (double)UnitTypebase.PrefixSISize(p.Prefix);
                        return true;
                    }
                }
            }

            // Try long prefix names (case-insensitive): kilo, mega, micro, etc.
            foreach (var p in PrefixByNameLongestFirst)
            {
                if (unitToken.StartsWith(p.Name, StringComparison.OrdinalIgnoreCase))
                {
                    var rest = unitToken.Substring(p.Name.Length);
                    rest = UnitTokenRegistry<LengthUnit>.NormalizeToken(rest);

                    if (rest.Length == 0)
                        continue;

                    if (UnitTokenRegistry<LengthUnit>.TryResolve(rest, out unit))
                    {
                        scale = (double)UnitTypebase.PrefixSISize(p.Prefix);
                        return true;
                    }
                }
            }

            return false;
        }

        private static readonly (string Symbol, PreFix Prefix)[] PrefixBySymbolLongestFirst =
            new[]
            {
                ("da", PreFix.deka),

                ("Y", PreFix.yotta),
                ("Z", PreFix.zetta),
                ("E", PreFix.exa),
                ("P", PreFix.peta),
                ("T", PreFix.tera),
                ("G", PreFix.giga),
                ("M", PreFix.mega),
                ("k", PreFix.kilo),
                ("h", PreFix.hecto),

                ("d", PreFix.deci),
                ("c", PreFix.centi),
                ("m", PreFix.milli),

                ("µ", PreFix.micro), // micro sign
                ("u", PreFix.micro), // common ASCII fallback

                ("n", PreFix.nano),
                ("p", PreFix.pico),
                ("f", PreFix.femto),
                ("a", PreFix.atto),
                ("z", PreFix.zepto),
                ("y", PreFix.yocto),
            };

        private static readonly (string Name, PreFix Prefix)[] PrefixByNameLongestFirst =
            new[]
            {
                ("yotta", PreFix.yotta),
                ("zetta", PreFix.zetta),
                ("exa",   PreFix.exa),
                ("peta",  PreFix.peta),
                ("tera",  PreFix.tera),
                ("giga",  PreFix.giga),
                ("mega",  PreFix.mega),
                ("kilo",  PreFix.kilo),
                ("hecto", PreFix.hecto),
                ("deka",  PreFix.deka),

                ("deci",  PreFix.deci),
                ("centi", PreFix.centi),
                ("milli", PreFix.milli),
                ("micro", PreFix.micro),
                ("nano",  PreFix.nano),
                ("pico",  PreFix.pico),
                ("femto", PreFix.femto),
                ("atto",  PreFix.atto),
                ("zepto", PreFix.zepto),
                ("yocto", PreFix.yocto),
            };

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

                // number chars
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

            // Keep it simple: still allow exponent and thousands where it makes sense
            const NumberStyles style = NumberStyles.Float | NumberStyles.AllowThousands;

            // Heuristic: decide whether the input is dot-decimal or comma-decimal.
            // If the input contains '.' but not ',', treat it as dot-decimal and try Invariant first.
            // If the input contains ',' but not '.', treat it as comma-decimal and try provided culture first.
            // If both are present, use the last occurrence as the decimal separator.
            int lastDot = s.LastIndexOf('.');
            int lastComma = s.LastIndexOf(',');

            bool hasDot = lastDot >= 0;
            bool hasComma = lastComma >= 0;

            bool looksDotDecimal =
                hasDot && !hasComma ||
                (hasDot && hasComma && lastDot > lastComma);

            bool looksCommaDecimal =
                hasComma && !hasDot ||
                (hasDot && hasComma && lastComma > lastDot);

            // 1) If it looks like dot-decimal: prefer Invariant first to avoid "1.5" => 15 in comma cultures
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

            // 2) If it looks like comma-decimal: prefer provided culture first
            if (looksCommaDecimal)
            {
                if (culture != null && double.TryParse(s, style, culture, out value))
                    return true;

                if (double.TryParse(s, style, CultureInfo.CurrentCulture, out value))
                    return true;

                // As a fallback, normalize comma to dot and try invariant (only safe when there is no dot)
                if (!hasDot)
                {
                    var normalized = s.Replace(',', '.');
                    if (double.TryParse(normalized, style, CultureInfo.InvariantCulture, out value))
                        return true;
                }

                return false;
            }

            // 3) No separator at all: just try culture -> invariant -> current
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