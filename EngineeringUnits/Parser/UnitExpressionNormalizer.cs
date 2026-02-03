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

            // 1) Trim and normalize common multiplication dot
            input = input.Trim()
                         .Replace('·', '*')
                         .Replace('⋅', '*'); // optional

            // 2) Rewrite superscripts into ^exponent form
            var sb = new StringBuilder(input.Length * 2);

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                // If we encounter a superscript sequence, rewrite it as ^<int>
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
                            // Lone superscript minus; keep as-is
                            sb.Append('⁻');
                            i = start;
                            continue;
                        }
                    }

                    int value = 0;
                    int digits = 0;

                    while (i < input.Length && IsSuperscriptDigit(input[i]))
                    {
                        value = value * 10 + SuperscriptDigitValue(input[i]);
                        i++;
                        digits++;
                    }

                    i--; // step back because for-loop will i++

                    if (digits > 0)
                    {
                        sb.Append('^');
                        if (negative)
                            sb.Append('-');
                        sb.Append(value);
                        continue;
                    }

                    // fallback: should not hit
                    sb.Append(c);
                    continue;
                }

                sb.Append(c);
            }

            // 3) Insert '*' for adjacency when it looks like implicit multiplication.
            // We do this conservatively: between ") or digit" and "(" or letter/µ/Ω/°.
            // This turns "s^3A^2/m^2" into "s^3*A^2/m^2".
            var normalized = InsertImplicitMultiplication(sb.ToString());

            // 4) Collapse whitespace (optional): treat spaces as multiplication in parser,
            // but it's nicer to make it explicit for determinism.
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

        private static string InsertImplicitMultiplication(string s)
        {
            var sb = new StringBuilder(s.Length * 2);

            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];
                sb.Append(a);

                if (i == s.Length - 1)
                    break;

                char b = s[i + 1];

                // Don't insert around operators
                if (IsOperatorOrParenBoundary(a) || IsOperatorOrParenBoundary(b))
                    continue;

                // Insert '*' when adjacency implies multiplication:
                // e.g. "...3A..." or ")A" or "mA" etc.
                if (IsLeftMultipliable(a) && IsRightMultipliable(b))
                    sb.Append('*');
            }

            return sb.ToString();
        }

        private static bool IsOperatorOrParenBoundary(char c) =>
            c is '*' or '/' or '^' or '(' or ')';

        private static bool IsLeftMultipliable(char c) =>
            char.IsLetter(c) || c is ')' || char.IsDigit(c);

        private static bool IsRightMultipliable(char c) =>
            char.IsLetter(c) || c is '(' || c is 'µ' or 'Ω' or '°';

        private static string CollapseWhitespaceToStar(string s)
        {
            var sb = new StringBuilder(s.Length);
            bool prevWasSpace = false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsWhiteSpace(c))
                {
                    prevWasSpace = true;
                    continue;
                }

                if (prevWasSpace)
                {
                    // If we have adjacency after whitespace, treat it as multiplication unless
                    // it would be awkward (start/end/operators)
                    if (sb.Length > 0)
                    {
                        char prev = sb[sb.Length - 1];
                        if (!IsOperatorOrParenBoundary(prev) && c != ')' && c != '/' && c != '*')
                            sb.Append('*');
                    }
                    prevWasSpace = false;
                }

                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}