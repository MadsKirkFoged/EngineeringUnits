using System;
using System.Globalization;
using System.Text;

namespace EngineeringUnits.Parser.UnitParser
{
    public static class UnitExpressionNormalizer
    {
        public static string Normalize(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input ?? "";

            // Normalize multiplication dots to '*'
            input = input.Trim()
                         .Replace('−', '-')  // U+2212 minus sign
                         .Replace('–', '-')  // U+2013 en dash
                         .Replace('—', '-')  // U+2014 em dash
                         .Replace('·', '*')
                         .Replace('⋅', '*')
                         .Replace('∙', '*');

            // 0) Unicode compatibility normalization (handles many fullwidth/presentation forms)
            // NOTE: This is intentionally first.
            //input = input.Normalize(NormalizationForm.FormKC);

            // 0.1) Remove invisible formatting characters (direction marks, zero-width, etc.)
            input = RemoveFormattingCharacters(input);

            // 0.2) Normalize common confusable whitespace to normal space
            input = input.Replace('\u00A0', ' ')   // NBSP
                         .Replace('\u202F', ' ')   // narrow no-break space
                         .Replace('\u2009', ' ');  // thin space

            // Normalize common operator/symbol confusables to a canonical ASCII-ish set
            input = input.Trim()
                         // minus/dash variants -> '-'
                         .Replace('−', '-')  // U+2212 minus sign
                         .Replace('–', '-')  // U+2013 en dash
                         .Replace('—', '-')  // U+2014 em dash
                         .Replace('‑', '-')  // U+2011 non-breaking hyphen
                         .Replace('‐', '-')  // U+2010 hyphen
                         .Replace('－', '-')  // U+FF0D fullwidth hyphen-minus

                         // multiplication variants -> '*'
                         .Replace('·', '*')  // U+00B7 middle dot
                         .Replace('⋅', '*')  // U+22C5 dot operator
                         .Replace('∙', '*')  // U+2219 bullet operator
                         .Replace('×', '*')  // U+00D7 multiplication sign
                         .Replace('∗', '*')  // U+2217 asterisk operator
                         .Replace('＊', '*')  // U+FF0A fullwidth asterisk

                         // division variants -> '/'
                         .Replace('÷', '/')  // U+00F7 division sign
                         .Replace('⁄', '/')  // U+2044 fraction slash
                         .Replace('∕', '/')  // U+2215 division slash
                         .Replace('／', '/')  // U+FF0F fullwidth slash

                         // caret variants -> '^'
                         .Replace('ˆ', '^')  // U+02C6 modifier letter circumflex
                         .Replace('＾', '^')  // U+FF3E fullwidth caret

                         // plus variant -> '+'
                         .Replace('＋', '+')  // U+FF0B fullwidth plus

                         // unit symbol confusables
                         .Replace('μ', 'µ')  // Greek mu -> micro sign
                         .Replace('Ω', 'Ω')  // ohm sign -> Greek omega
                         .Replace('º', '°')  // masculine ordinal -> degree sign

                         // fullwidth parentheses/brackets/braces -> ASCII
                         .Replace('（', '(').Replace('）', ')')
                         .Replace('［', '[').Replace('］', ']')
                         .Replace('｛', '{').Replace('｝', '}');



            // 1) Rewrite superscripts into ^exponent form (digits + minus only)
            var sb = new StringBuilder(input.Length * 2);

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                // Handle normal +/- directly in front of superscript digits (e.g. s-² or s+²)
                if ((c == '-' || c == '+') && i + 1 < input.Length && IsSuperscriptDigit(input[i + 1]))
                {
                    bool negative = (c == '-');
                    i++; // move to first superscript digit

                    int value = 0;
                    int digits = 0;

                    while (i < input.Length && IsSuperscriptDigit(input[i]))
                    {
                        value = (value * 10) + SuperscriptDigitValue(input[i]);
                        i++;
                        digits++;
                    }

                    i--; // for-loop will increment

                    if (digits > 0)
                    {
                        sb.Append('^');
                        if (negative)
                            sb.Append('-');
                        sb.Append(value);
                        continue;
                    }

                    // fallback if somehow no digits
                    sb.Append(c);
                    continue;
                }

                if (c == '⁻' || IsSuperscriptDigit(c))
                {
                    int start = i;
                    bool negative = false;

                    if (c == '⁻')
                    {
                        negative = true;
                        i++;
                        if (i >= input.Length || !IsSuperscriptDigit(input[i]))
                        {
                            // Lone superscript minus, keep it
                            sb.Append('⁻');
                            i = start;
                            continue;
                        }
                    }

                    int value = 0;
                    int digits = 0;

                    while (i < input.Length && IsSuperscriptDigit(input[i]))
                    {
                        value = (value * 10) + SuperscriptDigitValue(input[i]);
                        i++;
                        digits++;
                    }

                    i--; // for-loop will increment

                    if (digits > 0)
                    {
                        sb.Append('^');
                        if (negative)
                            sb.Append('-');
                        sb.Append(value);
                        continue;
                    }

                    sb.Append(c);
                    continue;
                }

                sb.Append(c);
            }

            var normalized = sb.ToString();

            // 2) Insert '*' only in safe adjacency cases (never between letters!)
            normalized = InsertSafeImplicitMultiplication(normalized);

            // 3) Turn whitespace into '*' safely (between meaningful tokens only)
            normalized = CollapseWhitespaceToStar(normalized);

            return normalized;
        }


        public static string Normalize2(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input ?? "";

            // 0) Unicode compatibility normalization (handles many fullwidth/presentation forms)
            // NOTE: This is intentionally first.
            input = input.Normalize(NormalizationForm.FormKC);

            // 0.1) Remove invisible formatting characters (direction marks, zero-width, etc.)
            input = RemoveFormattingCharacters(input);

            // 0.2) Normalize common confusable whitespace to normal space
            input = input.Replace('\u00A0', ' ')   // NBSP
                         .Replace('\u202F', ' ')   // narrow no-break space
                         .Replace('\u2009', ' ');  // thin space

            // Normalize common operator/symbol confusables to a canonical ASCII-ish set
            input = input.Trim()
                         // minus/dash variants -> '-'
                         .Replace('−', '-')  // U+2212 minus sign
                         .Replace('–', '-')  // U+2013 en dash
                         .Replace('—', '-')  // U+2014 em dash
                         .Replace('‑', '-')  // U+2011 non-breaking hyphen
                         .Replace('‐', '-')  // U+2010 hyphen
                         .Replace('－', '-')  // U+FF0D fullwidth hyphen-minus

                         // multiplication variants -> '*'
                         .Replace('·', '*')  // U+00B7 middle dot
                         .Replace('⋅', '*')  // U+22C5 dot operator
                         .Replace('∙', '*')  // U+2219 bullet operator
                         .Replace('×', '*')  // U+00D7 multiplication sign
                         .Replace('∗', '*')  // U+2217 asterisk operator
                         .Replace('＊', '*')  // U+FF0A fullwidth asterisk

                         // division variants -> '/'
                         .Replace('÷', '/')  // U+00F7 division sign
                         .Replace('⁄', '/')  // U+2044 fraction slash
                         .Replace('∕', '/')  // U+2215 division slash
                         .Replace('／', '/')  // U+FF0F fullwidth slash

                         // caret variants -> '^'
                         .Replace('ˆ', '^')  // U+02C6 modifier letter circumflex
                         .Replace('＾', '^')  // U+FF3E fullwidth caret

                         // plus variant -> '+'
                         .Replace('＋', '+')  // U+FF0B fullwidth plus

                         // unit symbol confusables
                         .Replace('μ', 'µ')  // Greek mu -> micro sign
                         .Replace('Ω', 'Ω')  // ohm sign -> Greek omega
                         .Replace('º', '°')  // masculine ordinal -> degree sign

                         // fullwidth parentheses/brackets/braces -> ASCII
                         .Replace('（', '(').Replace('）', ')')
                         .Replace('［', '[').Replace('］', ']')
                         .Replace('｛', '{').Replace('｝', '}');

            // 1) Rewrite superscripts into ^exponent form (digits + minus only)
            var sb = new StringBuilder(input.Length * 2);

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '⁻' || IsSuperscriptDigit(c))
                {
                    int start = i;
                    bool negative = false;

                    if (c == '⁻')
                    {
                        negative = true;
                        i++;
                        if (i >= input.Length || !IsSuperscriptDigit(input[i]))
                        {
                            // Lone superscript minus, keep it
                            sb.Append('⁻');
                            i = start;
                            continue;
                        }
                    }

                    int value = 0;
                    int digits = 0;

                    while (i < input.Length && IsSuperscriptDigit(input[i]))
                    {
                        value = (value * 10) + SuperscriptDigitValue(input[i]);
                        i++;
                        digits++;
                    }

                    i--; // for-loop will increment

                    if (digits > 0)
                    {
                        sb.Append('^');
                        if (negative)
                            sb.Append('-');
                        sb.Append(value);
                        continue;
                    }

                    sb.Append(c);
                    continue;
                }

                sb.Append(c);
            }

            var normalized = sb.ToString();

            // 2) Insert '*' only in safe adjacency cases (never between letters!)
            normalized = InsertSafeImplicitMultiplication(normalized);

            // 3) Turn whitespace into '*' safely (between meaningful tokens only)
            normalized = CollapseWhitespaceToStar(normalized);

            return normalized;
        }

        private static string RemoveFormattingCharacters(string s)
        {
            // Remove UnicodeCategory.Format characters (direction marks, joiners, etc.)
            var sb = new StringBuilder(s.Length);
            foreach (char c in s)
            {
                var cat = CharUnicodeInfo.GetUnicodeCategory(c);
                if (cat == UnicodeCategory.Format)
                    continue;

                // Additional known troublemakers (often appear in copy/paste)
                if (c == '\u200B' || c == '\u200C' || c == '\u200D') // ZWSP/ZWNJ/ZWJ
                    continue;

                sb.Append(c);
            }
            return sb.ToString();
        }

        private static bool IsSuperscriptDigit(char c) =>
            c is '⁰' or '¹' or '²' or '³' or '⁴' or '⁵' or '⁶' or '⁷' or '⁸' or '⁹';

        private static int SuperscriptDigitValue(char c) => c switch
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
            _ => throw new ArgumentOutOfRangeException(nameof(c))
        };

        private static bool IsUnitStartChar(char c) =>
            char.IsLetter(c) || c is 'µ' or 'Ω' or '°';

        private static bool IsOp(char c) =>
            c is '*' or '/' or '^';

        /// <summary>
        /// Inserts '*' only where we can be confident adjacency means multiplication.
        /// - After a complete exponent (e.g. s^3A -> s^3*A)
        /// - Between ')' and unit-start (e.g. (m^2)s -> (m^2)*s)
        /// - Between unit and '(' (e.g. m(s) -> m*(s))
        /// - Between ')' and '('
        /// Never inserts '*' between letters (so "kg" stays "kg").
        /// </summary>
        private static string InsertSafeImplicitMultiplication(string s)
        {
            var sb = new StringBuilder(s.Length * 2);

            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];
                sb.Append(a);

                if (i == s.Length - 1)
                    break;

                char b = s[i + 1];

                // Don't insert around explicit operators or division boundary
                if (IsOp(a) || IsOp(b) || a == '/' || b == '/' || a == '*' || b == '*')
                    continue;

                // Case 1: ")("  -> ")*("
                if (a == ')' && b == '(')
                {
                    sb.Append('*');
                    continue;
                }

                // Case 2: ")<unit>" -> ")*<unit>"
                if (a == ')' && IsUnitStartChar(b))
                {
                    sb.Append('*');
                    continue;
                }

                // Case 3: "<unit>(" -> "<unit>*("
                if (IsUnitStartChar(a) && b == '(')
                {
                    sb.Append('*');
                    continue;
                }

                // Case 4: After an exponent number, next is a unit start: "...^2A" -> "...^2*A"
                // Detect pattern: current char is digit AND somewhere earlier we had '^' for this exponent.
                // We only insert when we're at the END of the exponent digits.
                if (char.IsDigit(a) && IsUnitStartChar(b))
                {
                    // look backward: are we in "^[-]?\d+" right now?
                    int j = i;
                    while (j >= 0 && char.IsDigit(s[j]))
                        j--;

                    if (j >= 0 && s[j] == '-' && j - 1 >= 0 && s[j - 1] == '^')
                    {
                        // exponent like ^-2
                        sb.Append('*');
                        continue;
                    }
                    if (j >= 0 && s[j] == '^')
                    {
                        // exponent like ^2
                        sb.Append('*');
                        continue;
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Converts whitespace to '*' only when it separates two meaningful tokens.
        /// Never creates k*g from kg (since there's no whitespace inside 'kg').
        /// </summary>
        private static string CollapseWhitespaceToStar(string s)
        {
            var sb = new StringBuilder(s.Length);
            bool pendingSpace = false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsWhiteSpace(c))
                {
                    pendingSpace = true;
                    continue;
                }

                if (pendingSpace)
                {
                    // Insert '*' if previous is a "value-like end" and next is a "token start"
                    if (sb.Length > 0)
                    {
                        char prev = sb[sb.Length - 1];

                        bool prevOk = !(prev is '*' or '/' or '^' or '(');
                        bool nextOk = !(c is '*' or '/' or '^' or ')');

                        if (prevOk && nextOk)
                            sb.Append('*');
                    }
                    pendingSpace = false;
                }

                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}