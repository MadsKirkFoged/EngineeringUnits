using System.Globalization;
using System.Text;

namespace EngineeringUnits.Parser.UnitParser
{
    /// <summary>
    /// Character-level clean-up of copy/pasted unit text before tokenizing:
    /// <list type="bullet">
    /// <item>removes invisible formatting characters and odd spaces</item>
    /// <item>maps look-alike characters to one canonical form (minus signs, multiplication dots, slashes, µ, Ω, °, brackets...)</item>
    /// <item>rewrites superscript exponents to caret form (m² -> m^2, s⁻¹ -> s^-1)</item>
    /// </list>
    /// It never inserts operators; implicit multiplication is handled by <see cref="UnitExpressionParser"/>.
    /// </summary>
    public static class UnitExpressionNormalizer
    {
        public static string Normalize(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input ?? "";

            var sb = new StringBuilder(input.Length + 8);

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (IsFormattingCharacter(c))
                    continue;

                // Superscript exponents: ², ⁻², -², ⁺², +²
                if (c is '⁻' or '⁺' or '-' or '+' || IsSuperscriptDigit(c))
                {
                    int j = i;
                    bool negative = false;

                    if (c is '⁻' or '-')
                    { negative = true; j++; }
                    else if (c is '⁺' or '+')
                    { j++; }

                    if (j < input.Length && IsSuperscriptDigit(input[j]))
                    {
                        int value = 0;
                        while (j < input.Length && IsSuperscriptDigit(input[j]))
                        {
                            value = (value * 10) + SuperscriptDigitValue(input[j]);
                            j++;
                        }

                        if (sb.Length == 0 || sb[sb.Length - 1] != '^')
                            sb.Append('^');
                        if (negative)
                            sb.Append('-');
                        sb.Append(value.ToString(CultureInfo.InvariantCulture));

                        i = j - 1;
                        continue;
                    }

                    // Not followed by superscript digits: keep as-is (a lone '⁻' is rejected by the tokenizer)
                    sb.Append(c);
                    continue;
                }

                // Degree followed by space(s) and a temperature letter: "° C" -> "°C"
                if (c == '°' || c == 'º' || c == '˚')
                {
                    int j = i + 1;
                    while (j < input.Length && IsSpace(input[j]))
                        j++;

                    sb.Append('°');
                    if (j > i + 1 && j < input.Length && input[j] is 'C' or 'F' or 'R' &&
                        (j + 1 >= input.Length || !char.IsLetter(input[j + 1])))
                    {
                        i = j - 1; // drop the spaces; the letter is appended next iteration
                    }
                    continue;
                }

                switch (c)
                {
                    case '℃': sb.Append("°C"); continue;
                    case '℉': sb.Append("°F"); continue;
                }

                sb.Append(MapCharacter(c));
            }

            return sb.ToString().Trim();
        }

        private static char MapCharacter(char c) => c switch
        {
            // whitespace variants -> space
            ' ' or ' ' or ' ' or ' ' or ' ' or ' ' or '　' or '\t' => ' ',

            // minus/dash variants -> '-'
            '−' or '–' or '—' or '‑' or '‐' or '－' => '-',
            '＋' => '+',

            // multiplication: explicit '*' and typographic product dot '·' are different operators
            '×' or '∗' or '＊' => '*',
            '⋅' or '∙' or '•' or '・' => '·',

            // division variants -> '/'
            '÷' or '⁄' or '∕' or '／' => '/',

            // caret variants -> '^'
            'ˆ' or '＾' => '^',

            // unit symbol look-alikes
            'μ' => 'µ',          // Greek mu -> micro sign
            'Ω' => 'Ω',     // ohm sign -> Greek omega
            'K' => 'K',     // kelvin sign -> K
            'Å' => 'Å',     // angstrom sign -> Å
            // (′ and ″ are kept: they are arcminute/arcsecond, not feet/inches)

            // bracket variants -> parentheses ("[m]" and "{m}" are common ways to write a unit)
            '（' or '［' or '｛' or '[' or '{' => '(',
            '）' or '］' or '｝' or ']' or '}' => ')',

            _ => c,
        };

        private static bool IsFormattingCharacter(char c)
            => CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.Format; // ZWSP, ZWJ, direction marks, BOM...

        private static bool IsSpace(char c) => char.IsWhiteSpace(c) || MapCharacter(c) == ' ';

        internal static bool IsSuperscriptDigit(char c) =>
            c is '⁰' or '¹' or '²' or '³' or '⁴' or '⁵' or '⁶' or '⁷' or '⁸' or '⁹';

        internal static int SuperscriptDigitValue(char c) => c switch
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
            _ => -1,
        };
    }
}
