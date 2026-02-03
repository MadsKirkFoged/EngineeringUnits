using System;
using System.Text;

namespace EngineeringUnits.Parsing
{
    public static class UnitExpressionNormalizer
    {
        public static string Normalize(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input ?? "";

            // Normalize multiplication dots to '*'
            input = input.Trim()
                         .Replace('·', '*')
                         .Replace('⋅', '*'); // optional

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