using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits.Parser.Objects;
using EngineeringUnits.Parser.UnitParser;
using EngineeringUnits;

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

            //fx 10−1  -> 1e-1
            input = NormalizeNumericUnicode(input);
            input = NormalizeTenPowerShorthand(input); // literal-only behavior is OK he


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
            {
                // Best-effort diagnostic
                var diag = QuantityParser.ParseWithWarnings(input, culture);
                var extra = string.IsNullOrWhiteSpace(diag.Error) ? "" : $" {diag.Error}";
                throw new FormatException($"Could not parse {typeof(TQuantity).Name} from '{input}'.{extra}");
            }
            return value;
        }

        public static ParseResult<UnknownUnit> ParseWithWarnings(string? input, IFormatProvider? culture = null)
        {
            string original = input ?? "";

            if (string.IsNullOrWhiteSpace(input))
                return Fail(original, "Input was empty.");

            input = input.Trim();
            input = NormalizeNumericUnicode(input);
            input = NormalizeTenPowerShorthand(input); // literal-only behavior is OK he


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
                throw new FormatException(string.IsNullOrWhiteSpace(r.Error) ? $"Could not parse '{input}'." : $"Could not parse '{input}'. {r.Error}"
);
            return r.Value;//.TryCastToKnownUnit();
        }

        public static bool TryParse(string? input, out UnknownUnit unit, IFormatProvider? culture = null)
        {
            unit = default!;
            var r = ParseWithWarnings(input, culture);
            if (!r.Success || r.Value is null)
                return false;

            unit = r.Value;//.TryCastToKnownUnit();
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

            numberPart = input.Substring(startNum, endNum - startNum).Trim();
            if (numberPart.Length == 0)
                return false;

            // Skip whitespace after number
            while (i < input.Length && char.IsWhiteSpace(input[i]))
                i++;

            // ✅ NEW: allow "number only" => unitPart empty
            if (i >= input.Length)
            {
                unitPart = "";
                return true;
            }

            unitPart = input.Substring(i).Trim();
            return true;
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

        private static string NormalizeTenPowerShorthand(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input ?? "";

            int i = 0;
            while (i < input.Length && char.IsWhiteSpace(input[i]))
                i++;

            if (i >= input.Length)
                return input;

            // ---- Helpers ----
            static bool IsMul(char c) => c == '*' || c == '×' || c == '·' || c == '⋅' || c == '∙';
            // × (multiplication sign) and ⋅ (dot operator) are common in copied math text. [5](https://github.com/angularsen/UnitsNet)[6](https://libs.tech/project/11521218/unitsnet)

            static bool IsSupDigit(char c) => c is '⁰' or '¹' or '²' or '³' or '⁴' or '⁵' or '⁶' or '⁷' or '⁸' or '⁹';
            static int SupDigitValue(char c) => c switch
            {
                '⁰' => 0,
                '¹' => 1,
                '²' => 2,
                '³' => 3,
                '⁴' => 4,
                '⁵' => 5,
                '⁶' => 6,
                '⁷' => 7,
                '⁸' => 8,
                '⁹' => 9,
                _ => 0
            };

            static void SkipWs(string s, ref int idx)
            {
                while (idx < s.Length && char.IsWhiteSpace(s[idx]))
                    idx++;
            }

            static bool ReadAsciiDigits(string s, ref int idx, out string digits)
            {
                int start = idx;
                while (idx < s.Length && char.IsDigit(s[idx]))
                    idx++;
                digits = s.Substring(start, idx - start);
                return digits.Length > 0;
            }

            static bool TryReadExponentAfterCaret(string s, ref int idx, out string exp)
            {
                exp = "";
                SkipWs(s, ref idx);
                if (idx >= s.Length || s[idx] != '^')
                    return false;
                idx++;

                SkipWs(s, ref idx);

                bool paren = idx < s.Length && s[idx] == '(';
                if (paren)
                { idx++; SkipWs(s, ref idx); }

                char sign = '+';
                if (idx < s.Length && (s[idx] == '+' || s[idx] == '-'))
                {
                    sign = s[idx];
                    idx++;
                }

                if (!ReadAsciiDigits(s, ref idx, out var digits))
                    return false;

                if (paren)
                {
                    SkipWs(s, ref idx);
                    if (idx >= s.Length || s[idx] != ')')
                        return false;
                    idx++;
                }

                exp = (sign == '-' ? "-" : "") + digits;
                return true;
            }

            static bool TryReadSuperscriptExponent(string s, ref int idx, out string exp)
            {
                exp = "";
                SkipWs(s, ref idx);

                char sign = '+';
                if (idx < s.Length && s[idx] == '⁻')
                { sign = '-'; idx++; }
                else if (idx < s.Length && s[idx] == '⁺')
                { sign = '+'; idx++; }

                int val = 0;
                int digits = 0;
                while (idx < s.Length && IsSupDigit(s[idx]))
                {
                    val = (val * 10) + SupDigitValue(s[idx]);
                    digits++;
                    idx++;
                }

                if (digits == 0)
                    return false;

                exp = (sign == '-' ? "-" : "") + val.ToString(CultureInfo.InvariantCulture);
                return true;
            }

            // ---- Pattern 1: STARTS WITH 10^exp ----
            if (i + 1 < input.Length && input[i] == '1' && input[i + 1] == '0')
            {
                int j = i + 2;

                // 10^...  -> 1e...
                int k = j;
                if (TryReadExponentAfterCaret(input, ref k, out var expCaret))
                    return input.Substring(0, i) + "1e" + expCaret + input.Substring(k);

                // 10⁻¹ / 10¹ -> 1e...
                k = j;
                if (TryReadSuperscriptExponent(input, ref k, out var expSup))
                    return input.Substring(0, i) + "1e" + expSup + input.Substring(k);

                // Lost-caret shorthand: 10-1 or 10+3 (NO spaces, start only) -> 1e-1 / 1e+3
                // Only if sign is immediately after 10 and digits immediately after sign.
                if (j < input.Length && (input[j] == '-' || input[j] == '+'))
                {
                    int d = j + 1;
                    int dStart = d;
                    while (d < input.Length && char.IsDigit(input[d]))
                        d++;
                    if (d > dStart)
                    {
                        string expDigits = input.Substring(dStart, d - dStart);
                        return input.Substring(0, i) + "1e" + input[j] + expDigits + input.Substring(d);
                    }
                }
            }

            // ---- Pattern 2: <coef> * 10^exp  (or ×, ⋅, ·) ----
            // Read coefficient token up to whitespace or mul symbol.
            int coefStart = i;
            int coefEnd = i;
            while (coefEnd < input.Length && !char.IsWhiteSpace(input[coefEnd]) && !IsMul(input[coefEnd]))
                coefEnd++;

            if (coefEnd > coefStart)
            {
                string coef = input.Substring(coefStart, coefEnd - coefStart);

                int j = coefEnd;
                SkipWs(input, ref j);

                if (j < input.Length && IsMul(input[j]))
                {
                    j++;
                    SkipWs(input, ref j);

                    if (j + 1 < input.Length && input[j] == '1' && input[j + 1] == '0')
                    {
                        int after10 = j + 2;
                        int k = after10;

                        if (TryReadExponentAfterCaret(input, ref k, out var expCaret))
                            return input.Substring(0, coefStart) + coef + "e" + expCaret + input.Substring(k);

                        k = after10;
                        if (TryReadSuperscriptExponent(input, ref k, out var expSup))
                            return input.Substring(0, coefStart) + coef + "e" + expSup + input.Substring(k);
                    }
                }
            }

            return input;
        }
        private static string NormalizeNumericUnicode(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input ?? "";

            // Normalize common unicode minus/plus and odd spaces that break numeric parsing
            // U+2212 is MINUS SIGN (very common in copied math) [1](https://skillbolt.dev/blog/top-10-github-repos-engineering-students-should-know)[2](https://github.com/lbborkowski/engineering-unit-converter)
            return input
                .Replace('\u00A0', ' ')  // NBSP
                .Replace('−', '-')       // U+2212 minus sign [1](https://skillbolt.dev/blog/top-10-github-repos-engineering-students-should-know)[2](https://github.com/lbborkowski/engineering-unit-converter)
                .Replace('–', '-')       // en dash
                .Replace('—', '-')       // em dash
                .Replace('‑', '-')       // non-breaking hyphen
                .Replace('－', '-')      // fullwidth hyphen-minus
                .Replace('＋', '+');     // fullwidth plus
        }


    }
    }