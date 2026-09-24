using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using EngineeringUnits.Parser.Objects;
using EngineeringUnits.Parser.UnitParser;

namespace EngineeringUnits.Parsing
{
    /// <summary>
    /// Parses "&lt;number&gt; &lt;unit expression&gt;" text such as "12.5 kPa", "1 000 m³/h", "3×10⁻² W/(m·K)" or "20 °C".
    /// All TryParse methods return false instead of throwing; Parse methods throw <see cref="FormatException"/>.
    /// </summary>
    public static class QuantityParser
    {
        // ---------------- typed (Length, Pressure, ...) ----------------

        /// <summary>
        /// Parses into a specific quantity type. The unit is resolved against <typeparamref name="TUnit"/> first
        /// ("MPa", "megapascal"), then as a unit expression ("N/mm²") that must have the dimension of <paramref name="siUnit"/>.
        /// </summary>
        public static bool TryParse<TQuantity, TUnit>(
            string? input,
            Func<double, TUnit, TQuantity> factory,
            TUnit siUnit,
            out TQuantity value,
            IFormatProvider? culture = null,
            bool allowUnitExpressions = true)
            where TUnit : UnitTypebase
            => TryParseTyped(input, factory, siUnit, out value, out _, culture, allowUnitExpressions);

        public static TQuantity Parse<TQuantity, TUnit>(
            string? input,
            Func<double, TUnit, TQuantity> factory,
            TUnit siUnit,
            IFormatProvider? culture = null,
            bool allowUnitExpressions = true)
            where TUnit : UnitTypebase
        {
            if (!TryParseTyped(input, factory, siUnit, out TQuantity value, out var error, culture, allowUnitExpressions))
                throw new FormatException($"Could not parse {typeof(TQuantity).Name} from '{input}'. {error}".TrimEnd());
            return value;
        }

        private static bool TryParseTyped<TQuantity, TUnit>(
            string? input,
            Func<double, TUnit, TQuantity> factory,
            TUnit siUnit,
            out TQuantity value,
            out string? error,
            IFormatProvider? culture,
            bool allowUnitExpressions)
            where TUnit : UnitTypebase
        {
            value = default!;

            try
            {
                if (!TrySplit(input, culture, out var number, out var unitPart, out error))
                    return false;

                // 1) Unit token of this quantity type only (no cross-quantity matches)
                if (unitPart.Length > 0)
                {
                    if (UnitParser<TUnit>.TryParse(unitPart, out var unitToken, out var tokenError))
                    {
                        value = factory(number.Double, unitToken);
                        return true;
                    }

                    if (tokenError is not null)
                    {
                        error = tokenError;
                        return false;
                    }
                }

                if (!allowUnitExpressions)
                {
                    error = $"Unknown {typeof(TQuantity).Name} unit '{unitPart}'.";
                    return false;
                }

                // 2) Unit expression -> UnitSystem -> dimension check
                if (!UnitExpressionParser.TryParseCore(unitPart, UnitParseOptions.Default, out var unitSystem, warnings: null, out error))
                    return false;

                if (unitSystem.GetSIUnitsystem() != siUnit.Unit.GetSIUnitsystem())
                {
                    error = unitPart.Length == 0
                        ? $"Missing unit; expected a {typeof(TQuantity).Name} unit."
                        : $"'{unitPart}' is not a {typeof(TQuantity).Name} unit (it is {DescribeDimension(unitSystem)}).";
                    return false;
                }

                // Keep the user's unit when it matches a predefined one ("5 kW h" stays in kWh)
                var known = KnownUnits<TUnit>.FindEquivalent(unitSystem);
                if (known is not null)
                {
                    value = factory(number.Double, known);
                    return true;
                }

                var unknown = new UnknownUnit(number.Decimal, unitSystem);
                decimal siValue = (decimal)unknown.GetValueAs(siUnit.Unit);
                value = factory((double)siValue, siUnit);
                return true;
            }
            catch (OverflowException)
            {
                error = "The value is too large to be represented.";
                return false;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        private static class KnownUnits<TUnit> where TUnit : UnitTypebase
        {
            private static readonly Lazy<List<TUnit>> _all = new(() => UnitTypebase.ListOf<TUnit>(), isThreadSafe: true);

            public static TUnit? FindEquivalent(UnitSystem unitSystem)
                => _all.Value.FirstOrDefault(u => UnitTokenIndex<TUnit>.UnitsEquivalent(u.Unit, unitSystem));
        }

        private static string DescribeDimension(UnitSystem u)
        {
            var si = u.GetSIUnitsystem().ToString();
            return string.IsNullOrEmpty(si) ? "dimensionless" : si;
        }

        // ---------------- untyped (UnknownUnit) ----------------

        public static ParseResult<UnknownUnit> ParseWithWarnings(string? input, IFormatProvider? culture = null)
            => ParseLiteral(input, culture, UnitParseOptions.Default);

        public static UnknownUnit Parse(string? input, IFormatProvider? culture = null)
        {
            var r = ParseWithWarnings(input, culture);
            if (!r.Success || r.Value is null)
                throw new FormatException(string.IsNullOrWhiteSpace(r.Error) ? $"Could not parse '{input}'." : $"Could not parse '{input}'. {r.Error}");
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

        /// <summary>Parses one "&lt;number&gt; &lt;unit&gt;" literal. Also used by <see cref="QuantityExpressionParser"/>.</summary>
        internal static ParseResult<UnknownUnit> ParseLiteral(string? input, IFormatProvider? culture, UnitParseOptions options)
        {
            string original = input ?? "";

            try
            {
                if (!TrySplit(input, culture, out var number, out var unitExpr, out var error))
                    return Fail(original, error!);

                var warnings = new List<ParseWarning>();
                if (!UnitExpressionParser.TryParseCore(unitExpr, options, out var unitSystem, warnings, out error))
                    return Fail(original, error ?? "Could not parse unit expression.");

                return new ParseResult<UnknownUnit>
                {
                    Success = true,
                    Value = new UnknownUnit(number.Decimal, unitSystem),
                    Original = original,
                    Normalized = $"{number.Text} {unitSystem}".Trim(),
                    Warnings = warnings
                };
            }
            catch (Exception ex)
            {
                return Fail(original, ex.Message);
            }
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

        // ---------------- number / unit split ----------------

        internal readonly struct ParsedNumber
        {
            public ParsedNumber(decimal value, string text) { Decimal = value; Text = text; }

            public decimal Decimal { get; }
            public double Double => (double)Decimal;

            /// <summary>Canonical invariant text, e.g. "1234.5" for "1.234,5".</summary>
            public string Text { get; }
        }

        private static bool TrySplit(string? input, IFormatProvider? culture, out ParsedNumber number, out string unitPart, out string? error)
        {
            number = default;
            unitPart = "";
            error = null;

            if (string.IsNullOrWhiteSpace(input))
            {
                error = "Input was empty.";
                return false;
            }

            var s = NormalizeNumericUnicode(input!.Trim());
            s = NormalizeTenPowerShorthand(s);

            int end = ScanNumber(s, 0);
            if (end == 0)
            {
                error = "Expected '<number> <unit expression>'.";
                return false;
            }

            if (!TryInterpretNumber(s.Substring(0, end), culture, out number, out error))
                return false;

            unitPart = s.Substring(end).Trim();
            return true;
        }

        private static bool IsDigit(char c) => c is >= '0' and <= '9';

        private static bool IsGroupSpace(char c) => c is ' ' or ' ' or ' ' or ' ' or ' ';

        /// <summary>
        /// Returns the end index of a number at <paramref name="start"/> (0 if none).
        /// Accepts sign, '.'/',' separators, SI digit-group spaces ("1 000 000") and an exponent.
        /// 'e'/'E' only counts as an exponent when digits follow, so "5 eV", "5 EJ" and "5 erg" keep their unit.
        /// </summary>
        private static int ScanNumber(string s, int start)
        {
            int i = start;
            int n = s.Length;

            if (i < n && (s[i] == '+' || s[i] == '-'))
                i++;

            bool anyDigit = false;
            int run = 0; // digits since the last separator

            while (i < n)
            {
                char c = s[i];

                if (IsDigit(c))
                { anyDigit = true; run++; i++; continue; }

                if ((c == '.' || c == ',') && i + 1 < n && IsDigit(s[i + 1]))
                { run = 0; i++; continue; }

                // "5." (trailing decimal point)
                if (c == '.' && anyDigit)
                { i++; break; }

                // "1 000": a space followed by exactly three digits
                if (IsGroupSpace(c) && anyDigit && run is >= 1 and <= 3 &&
                    i + 3 < n && IsDigit(s[i + 1]) && IsDigit(s[i + 2]) && IsDigit(s[i + 3]) &&
                    (i + 4 >= n || !IsDigit(s[i + 4])))
                { run = 0; i++; continue; }

                break;
            }

            if (!anyDigit)
                return 0;

            // Exponent: e3, E-3, e+03
            if (i < n && (s[i] == 'e' || s[i] == 'E'))
            {
                int j = i + 1;
                if (j < n && (s[j] == '+' || s[j] == '-'))
                    j++;
                if (j < n && IsDigit(s[j]))
                {
                    while (j < n && IsDigit(s[j]))
                        j++;
                    i = j;
                }
            }

            return i;
        }

        /// <summary>
        /// Works out which of '.' and ',' is the decimal separator:
        /// <list type="bullet">
        /// <item>both present: the last one is the decimal separator ("1,234.5", "1.234,5")</item>
        /// <item>one kind, several times: digit grouping ("1,000,000")</item>
        /// <item>a single '.': decimal</item>
        /// <item>a single ',': decimal if the culture uses ',', otherwise grouping only when exactly three digits follow ("1,234"), else decimal ("1,5")</item>
        /// </list>
        /// </summary>
        private static bool TryInterpretNumber(string raw, IFormatProvider? culture, out ParsedNumber number, out string? error)
        {
            number = default;
            error = null;

            string sign = "";
            if (raw.Length > 0 && (raw[0] == '+' || raw[0] == '-'))
            {
                sign = raw[0] == '-' ? "-" : "";
                raw = raw.Substring(1);
            }

            string exponent = "";
            int e = raw.IndexOfAny(new[] { 'e', 'E' });
            if (e >= 0)
            {
                exponent = raw.Substring(e);
                raw = raw.Substring(0, e);
            }

            bool spaceGrouped = raw.Any(IsGroupSpace);
            var mantissa = new string(raw.Where(c => !IsGroupSpace(c)).ToArray());

            int dots = mantissa.Count(c => c == '.');
            int commas = mantissa.Count(c => c == ',');

            char? decimalSep = null;
            char? groupSep = null;

            if (dots > 0 && commas > 0)
            {
                decimalSep = mantissa.LastIndexOf('.') > mantissa.LastIndexOf(',') ? '.' : ',';
                groupSep = decimalSep == '.' ? ',' : '.';
            }
            else if (dots > 1)
                groupSep = '.';
            else if (commas > 1)
                groupSep = ',';
            else if (dots == 1)
                decimalSep = '.';
            else if (commas == 1)
            {
                var nfi = NumberFormatInfo.GetInstance(culture ?? CultureInfo.CurrentCulture);
                int idx = mantissa.IndexOf(',');
                int after = mantissa.Length - idx - 1;

                if (nfi.NumberDecimalSeparator == ",")
                    decimalSep = ',';
                else if (after == 3 && idx is >= 1 and <= 3 && !spaceGrouped)
                    groupSep = ',';
                else
                    decimalSep = ',';
            }

            string intPart = mantissa;
            string fracPart = "";

            if (decimalSep is char d)
            {
                int idx = mantissa.LastIndexOf(d);
                if (mantissa.IndexOf(d) != idx)
                {
                    error = $"Could not parse numeric value '{sign}{raw}{exponent}': more than one decimal separator.";
                    return false;
                }
                intPart = mantissa.Substring(0, idx);
                fracPart = mantissa.Substring(idx + 1);
            }

            if (groupSep is char g)
            {
                var groups = intPart.Split(g);
                bool valid = groups[0].Length is >= 1 and <= 3 && groups.Skip(1).All(x => x.Length == 3);
                if (!valid)
                {
                    error = $"Could not parse numeric value '{sign}{raw}{exponent}': invalid digit grouping.";
                    return false;
                }
                intPart = string.Concat(groups);
            }

            if (intPart.Length == 0)
                intPart = "0";

            var canonical = sign + intPart + (fracPart.Length > 0 ? "." + fracPart : "") + exponent;

            if (decimal.TryParse(canonical, NumberStyles.Float, CultureInfo.InvariantCulture, out var dec))
            {
                number = new ParsedNumber(dec, canonical);
                return true;
            }

            if (double.TryParse(canonical, NumberStyles.Float, CultureInfo.InvariantCulture, out var dbl) && !double.IsInfinity(dbl))
            {
                // Between decimal and double range, or a tiny value decimal cannot hold
                if (Math.Abs(dbl) < 1e-28)
                {
                    number = new ParsedNumber(0m, canonical);
                    return true;
                }

                error = $"The value '{canonical}' is too large to be represented (max ±7.9e28).";
                return false;
            }

            error = $"Could not parse numeric value '{sign}{raw}{exponent}'.";
            return false;
        }

        // ---------------- pre-normalization ----------------

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
                while (idx < s.Length && UnitExpressionNormalizer.IsSuperscriptDigit(s[idx]))
                {
                    val = (val * 10) + UnitExpressionNormalizer.SuperscriptDigitValue(s[idx]);
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

            // ---- Pattern 2: <coef> * 10^exp  (or ×, ⋅, ·, or a spaced 'x') ----
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

                bool spacedX = j > coefEnd && j + 1 < input.Length && (input[j] == 'x' || input[j] == 'X') && char.IsWhiteSpace(input[j + 1]);

                if (j < input.Length && (IsMul(input[j]) || spacedX))
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

            // Unicode minus/plus and odd spaces break numeric parsing (U+2212 is common in copied math)
            var sb = new StringBuilder(input.Length);
            foreach (var c in input)
            {
                sb.Append(c switch
                {
                    ' ' => ' ',
                    '−' or '–' or '—' or '‑' or '－' => '-',
                    '＋' => '+',
                    _ => c,
                });
            }
            return sb.ToString();
        }
    }
}
