using EngineeringUnits.Parser.Accessories;
using EngineeringUnits.Parser.Objects;
using EngineeringUnits.Parsing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace EngineeringUnits.Parser.UnitParser
{
    /// <summary>
    /// Parses unit expressions such as <c>kg·m²/s²</c>, <c>W/(m·K)</c>, <c>J kg^-1 K^-1</c> or <c>m3/h</c> into a <see cref="UnitSystem"/>.
    /// <para>Grammar (highest precedence last):</para>
    /// <code>
    /// expression := product (('*' | '/') product)*      explicit operators, left-associative
    /// product    := factor (['·'] factor)*              '·' or juxtaposition ("kg m"), binds tighter than '/'
    /// factor     := primary ['^' exponent]              also m², m2, s-1, s⁻¹
    /// primary    := unit | '(' expression ')' | '1'
    /// </code>
    /// <para>
    /// Because a product binds tighter than '/', <c>W/m K</c> and <c>W/m·K</c> mean W/(m·K) (the usual
    /// engineering reading). Explicit <c>*</c> keeps the left-to-right reading: <c>m/s*kg</c> = (m/s)·kg.
    /// A <c>UNIT_DENOMINATOR_GROUPING</c> warning is emitted when this rule decided the meaning.
    /// </para>
    /// <para>Offset temperatures (°C, °F) inside compound units are read as temperature differences (with a warning).</para>
    /// </summary>
    public static class UnitExpressionParser
    {
        /// <summary>Largest exponent magnitude accepted. Protects against absurd inputs like m^2147483647.</summary>
        public const int MaxExponent = 1000;

        public static bool TryParseWithWarnings(string text, out UnitSystem unitSystem, out List<ParseWarning> warnings, out string? error)
        {
            warnings = new List<ParseWarning>();
            return TryParseCore(text, UnitParseOptions.Default, out unitSystem, warnings, out error);
        }

        public static bool TryParse(string text, out UnitSystem unitSystem)
            => TryParse(text, out unitSystem, out _);

        public static bool TryParse(string text, out UnitSystem unitSystem, out string? error)
            => TryParseCore(text, UnitParseOptions.Default, out unitSystem, warnings: null, out error);

        internal static bool TryParseCore(string? text, UnitParseOptions options, out UnitSystem unitSystem, List<ParseWarning>? warnings, out string? error)
        {
            unitSystem = new UnitSystem();
            error = null;

            if (string.IsNullOrWhiteSpace(text))
                return true; // "no unit" = dimensionless

            try
            {
                var normalized = UnitExpressionNormalizer.Normalize(text!);
                var tokens = Tokenize(normalized, options);
                var parser = new Parser(tokens, normalized, options, warnings);

                var parsed = parser.ParseAll();

                // A lone offset unit ("°C", "barg") keeps its offset; inside a compound unit it becomes a difference
                var offsetFixed = parser.IsSingleUnit
                    ? (unit: parsed, warnings: new List<ParseWarning>())
                    : OffsetUnitNormalizer.Normalize(parsed);
                warnings?.AddRange(offsetFixed.warnings);
                unitSystem = offsetFixed.unit;
                return true;
            }
            catch (AmbiguousUnitTokenException ex)
            {
                error = ex.Message;
                return false;
            }
            catch (FormatException ex)
            {
                error = string.IsNullOrWhiteSpace(ex.Message) ? "Could not parse unit expression." : ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                // Keep this user-friendly (no stack traces)
                error = $"Could not parse unit expression: {ex.Message}";
                return false;
            }
        }

        // ---------------- tokens ----------------

        private enum TokenKind { Word, Number, Star, Dot, Slash, Caret, Plus, Minus, LParen, RParen, End }

        private readonly struct Token
        {
            public TokenKind Kind { get; }
            public string Text { get; }
            public int Position { get; }
            public bool SpaceBefore { get; }

            public Token(TokenKind kind, string text, int position, bool spaceBefore)
            {
                Kind = kind;
                Text = text;
                Position = position;
                SpaceBefore = spaceBefore;
            }

            public int End => Position + Text.Length;
            public string Describe() => Kind == TokenKind.End ? "end of expression" : $"'{Text}'";
        }

        private static bool IsWordStart(char c) =>
            char.IsLetter(c) || c is '°' or '%' or '‰' or '‱' or '\'' or '"' or '′' or '″' or '℧';

        private static bool IsAsciiDigit(char c) => c is >= '0' and <= '9';

        private static List<Token> Tokenize(string s, UnitParseOptions options)
        {
            var tokens = new List<Token>();
            bool space = false;
            int i = 0;

            TokenKind PrevKind() => tokens.Count == 0 ? TokenKind.End : tokens[tokens.Count - 1].Kind;
            void Add(TokenKind kind, string text, int pos) { tokens.Add(new Token(kind, text, pos, space)); space = false; }

            while (i < s.Length)
            {
                char c = s[i];

                if (char.IsWhiteSpace(c))
                { space = true; i++; continue; }

                switch (c)
                {
                    case '*': Add(TokenKind.Star, "*", i); i++; continue;
                    case '·': Add(TokenKind.Dot, "·", i); i++; continue;
                    case '/': Add(TokenKind.Slash, "/", i); i++; continue;
                    case '^': Add(TokenKind.Caret, "^", i); i++; continue;
                    case '(': Add(TokenKind.LParen, "(", i); i++; continue;
                    case ')': Add(TokenKind.RParen, ")", i); i++; continue;
                }

                if (c is '+' or '-')
                {
                    // "s-1", "m-2": signed exponent written without caret (must touch the unit, digits must follow)
                    if (options.AllowSignedPlainExponent && !space && PrevKind() is TokenKind.Word or TokenKind.RParen &&
                        i + 1 < s.Length && IsAsciiDigit(s[i + 1]))
                    {
                        tokens.Add(new Token(TokenKind.Caret, "", i, false));
                    }

                    Add(c == '+' ? TokenKind.Plus : TokenKind.Minus, c.ToString(), i);
                    i++;
                    continue;
                }

                if (c == '.')
                {
                    // "m.s-1", "N.m": dot used as multiplication between units
                    if (!space && PrevKind() is TokenKind.Word or TokenKind.RParen &&
                        i + 1 < s.Length && (IsWordStart(s[i + 1]) || s[i + 1] == '('))
                    {
                        Add(TokenKind.Dot, ".", i);
                        i++;
                        continue;
                    }

                    if (!(i + 1 < s.Length && IsAsciiDigit(s[i + 1])))
                        throw new FormatException($"Unexpected character '.' at position {i}.");
                }

                if (IsAsciiDigit(c) || c == '.')
                {
                    int start = i;
                    while (i < s.Length && (IsAsciiDigit(s[i]) || s[i] == '.' || s[i] == ','))
                        i++;
                    Add(TokenKind.Number, s.Substring(start, i - start), start);
                    continue;
                }

                if (IsWordStart(c))
                {
                    int start = i;
                    while (i < s.Length && (IsWordStart(s[i]) || IsAsciiDigit(s[i])))
                        i++;
                    Add(TokenKind.Word, s.Substring(start, i - start), start);
                    continue;
                }

                if (c is '½' or '¼' or '¾' or '⅓' or '⅔')
                    throw new FormatException("Fractional exponents (like ^½ or ^0.5) are not supported.");

                throw new FormatException($"Unexpected character '{c}' (U+{(int)c:X4}) at position {i}.");
            }

            tokens.Add(new Token(TokenKind.End, "", s.Length, space));
            return tokens;
        }

        // ---------------- parser ----------------

        private sealed class Parser
        {
            private const int MaxWordsInName = 4;

            private readonly List<Token> _tokens;
            private readonly string _text;
            private readonly UnitParseOptions _options;
            private readonly List<ParseWarning>? _warnings;
            private int _pos;
            private int _unitNames;
            private bool _splitWord;

            /// <summary>True when the whole expression was one unit name, e.g. "°C" or "(barg)" (not "°C/s" or "m2").</summary>
            public bool IsSingleUnit =>
                _unitNames == 1 && !_splitWord &&
                _tokens.All(t => t.Kind is TokenKind.Word or TokenKind.LParen or TokenKind.RParen or TokenKind.End);

            public Parser(List<Token> tokens, string text, UnitParseOptions options, List<ParseWarning>? warnings)
            {
                _tokens = tokens;
                _text = text;
                _options = options;
                _warnings = warnings;
            }

            private Token Current => _tokens[_pos];
            private Token Peek(int offset) => _tokens[Math.Min(_pos + offset, _tokens.Count - 1)];
            private void Next() { if (_pos < _tokens.Count - 1) _pos++; }

            public UnitSystem ParseAll()
            {
                var result = ParseExpression(topLevel: true);

                if (Current.Kind == TokenKind.RParen)
                    throw new FormatException($"Unmatched ')' at position {Current.Position}.");
                if (Current.Kind != TokenKind.End)
                    throw new FormatException($"Unexpected {Current.Describe()} at position {Current.Position}.");

                return result;
            }

            private UnitSystem ParseExpression(bool topLevel = false)
            {
                UnitSystem left;

                // "/s" == "1/s"
                if (topLevel && _pos == 0 && Current.Kind == TokenKind.Slash)
                {
                    if (!_options.AllowLeadingSlash)
                        throw new FormatException("Unit expression cannot start with '/'.");
                    left = new UnitSystem();
                }
                else
                {
                    left = ParseProduct(afterSlash: false);
                }

                while (true)
                {
                    if (Current.Kind == TokenKind.Star)
                    {
                        Next();
                        left *= ParseProduct(afterSlash: false);
                        continue;
                    }

                    if (Current.Kind == TokenKind.Slash)
                    {
                        int slashPos = Current.Position;
                        Next();
                        left /= ParseProduct(afterSlash: true, slashPos);
                        continue;
                    }

                    return left;
                }
            }

            private UnitSystem ParseProduct(bool afterSlash, int slashPos = 0)
            {
                var left = ParseFactor();
                int factors = 1;

                while (true)
                {
                    if (Current.Kind == TokenKind.Dot)
                    {
                        Next();
                        left *= ParseFactor();
                        factors++;
                        continue;
                    }

                    // implicit multiplication: "kg m", "(m)(s)", "m(s)"
                    if (Current.Kind is TokenKind.Word or TokenKind.LParen)
                    {
                        left *= ParseFactor();
                        factors++;
                        continue;
                    }

                    break;
                }

                if (afterSlash && factors > 1 && _warnings is not null)
                {
                    int end = _tokens[_pos - 1].End;
                    string denominator = _text.Substring(slashPos + 1, end - slashPos - 1).Trim();
                    _warnings.Add(new ParseWarning
                    {
                        Code = "UNIT_DENOMINATOR_GROUPING",
                        Message = $"'/{denominator}' was read as '/({denominator})': multiplication without '*' binds tighter than '/'. Use parentheses to be explicit.",
                    });
                }

                return left;
            }

            private UnitSystem ParseFactor()
            {
                var u = ParsePrimary();

                if (Current.Kind == TokenKind.Caret)
                {
                    Next();
                    u = Pow(u, ParseExponent());

                    if (Current.Kind == TokenKind.Caret)
                        throw new FormatException($"Chained exponents are not supported (position {Current.Position}). Use parentheses, e.g. (m^2)^3.");
                }

                return u;
            }

            private UnitSystem ParsePrimary()
            {
                var t = Current;

                switch (t.Kind)
                {
                    case TokenKind.LParen:
                        Next();
                        if (Current.Kind == TokenKind.RParen)
                            throw new FormatException($"Empty parentheses at position {t.Position}.");
                        var inner = ParseExpression();
                        if (Current.Kind != TokenKind.RParen)
                            throw new FormatException($"Missing ')' for '(' at position {t.Position}.");
                        Next();
                        return inner;

                    case TokenKind.Number:
                        // Only a literal 1 is meaningful inside a unit ("1/s"); other numbers belong to the value.
                        if (_options.AllowNumericOne && t.Text == "1")
                        {
                            Next();
                            return new UnitSystem();
                        }
                        throw new FormatException($"Unexpected number '{t.Text}' at position {t.Position}; numbers are not allowed inside a unit expression.");

                    case TokenKind.Word:
                        return ParseUnitName();

                    default:
                        throw new FormatException($"Expected a unit but found {t.Describe()} at position {t.Position}.");
                }
            }

            private int ParseExponent()
            {
                int start = Current.Position;
                bool paren = false;

                if (Current.Kind == TokenKind.LParen)
                { paren = true; Next(); }

                int sign = 1;
                if (Current.Kind is TokenKind.Plus or TokenKind.Minus)
                {
                    sign = Current.Kind == TokenKind.Minus ? -1 : 1;
                    Next();
                }

                if (Current.Kind != TokenKind.Number)
                    throw new FormatException($"Expected an integer exponent at position {start}, but found {Current.Describe()}.");

                var digits = Current.Text;
                if (digits.IndexOf('.') >= 0 || digits.IndexOf(',') >= 0 ||
                    (paren && Peek(1).Kind == TokenKind.Slash))
                    throw new FormatException("Fractional exponents (like ^0.5 or ^(1/2)) are not supported.");

                if (!int.TryParse(digits, NumberStyles.None, CultureInfo.InvariantCulture, out int value) || value > MaxExponent)
                    throw new FormatException($"Exponent '{digits}' is too large (max {MaxExponent}).");
                Next();

                if (paren)
                {
                    if (Current.Kind != TokenKind.RParen)
                        throw new FormatException($"Missing ')' in exponent at position {start}.");
                    Next();
                }

                return sign * value;
            }

            /// <summary>
            /// Resolves the unit name at the current position. Tries multi-word names first ("sq ft", "deg C",
            /// "nautical mile"), then the single word, then "unit + trailing digits" ("m2", "m3", "W/m2K").
            /// </summary>
            private UnitSystem ParseUnitName()
            {
                _unitNames++;
                int words = 1;
                while (words < MaxWordsInName &&
                       Peek(words).Kind == TokenKind.Word &&
                       Peek(words).SpaceBefore)
                {
                    words++;
                }

                for (int n = words; n >= 2; n--)
                {
                    // "N m^-2" is N·m⁻², not (N m)⁻²: an exponent binds to the last word only
                    if (Peek(n).Kind == TokenKind.Caret)
                        continue;

                    var name = string.Join(" ", Enumerable.Range(0, n).Select(k => Peek(k).Text));
                    if (TryResolveMultiWord(name, out var multi))
                    {
                        for (int k = 0; k < n; k++)
                            Next();
                        return multi;
                    }
                }

                var word = Current;
                Next();
                return ResolveWord(word.Text, word.Position);
            }

            private UnitSystem ResolveWord(string word, int position)
            {
                if (TryResolve(word, out var unit))
                    return unit;

                _splitWord = true;

                // "m2" -> m^2, "m2K" -> m^2·K, "ms2" -> ms^2. Letters are never split ("kg" is not k·g).
                int d = 0;
                while (d < word.Length && !IsAsciiDigit(word[d]))
                    d++;

                if (d > 0 && d < word.Length)
                {
                    int e = d;
                    while (e < word.Length && IsAsciiDigit(word[e]))
                        e++;

                    var head = word.Substring(0, d);
                    var digits = word.Substring(d, e - d);
                    var tail = word.Substring(e);

                    if (!TryResolve(head, out var headUnit))
                        throw new FormatException($"Unknown unit '{head}' (in '{word}') at position {position}.");

                    if (!int.TryParse(digits, NumberStyles.None, CultureInfo.InvariantCulture, out int exp) || exp > MaxExponent)
                        throw new FormatException($"Exponent '{digits}' is too large (max {MaxExponent}).");

                    var result = Pow(headUnit, exp);
                    if (tail.Length > 0)
                        result *= ResolveWord(tail, position + e);
                    return result;
                }

                throw new FormatException($"Unknown unit '{word}' at position {position}.");
            }

            private static bool TryResolveMultiWord(string name, out UnitSystem unit)
            {
                // An ambiguous multi-word name is not an error: fall back to reading the words separately.
                unit = default!;
                if (GlobalUnitTokenRegistry.Resolve(name, out var resolved, out _) != TokenResolution.Found)
                    return false;
                unit = resolved.Unit;
                return true;
            }

            private static bool TryResolve(string token, out UnitSystem unit)
            {
                unit = default!;
                switch (GlobalUnitTokenRegistry.Resolve(token, out var resolved, out var candidates))
                {
                    case TokenResolution.Found:
                        unit = resolved.Unit;
                        return true;
                    case TokenResolution.Ambiguous:
                        throw new AmbiguousUnitTokenException(GlobalUnitTokenRegistry.NormalizeToken(token),
                                                              GlobalUnitTokenRegistry.DescribeCandidates(candidates));
                    default:
                        return false;
                }
            }

            /// <summary>Raises every raw unit to <paramref name="exp"/> in O(1) (no repeated multiplication).</summary>
            private static UnitSystem Pow(UnitSystem u, int exp)
            {
                if (exp == 1)
                    return u;
                if (exp == 0)
                    return new UnitSystem();

                return new UnitSystem(u.ListOfUnits.Select(r => r.CloneWithNewCount(r.Count * exp)).ToList());
            }
        }
    }

    /// <summary>Switches for the parts of the unit grammar that clash with arithmetic in <see cref="QuantityExpressionParser"/>.</summary>
    internal readonly struct UnitParseOptions
    {
        /// <summary>"/s" is read as "1/s".</summary>
        public bool AllowLeadingSlash { get; init; }

        /// <summary>A literal "1" may appear as a factor ("1/s").</summary>
        public bool AllowNumericOne { get; init; }

        /// <summary>"s-1" is read as "s^-1".</summary>
        public bool AllowSignedPlainExponent { get; init; }

        public static UnitParseOptions Default => new()
        {
            AllowLeadingSlash = true,
            AllowNumericOne = true,
            AllowSignedPlainExponent = true,
        };

        /// <summary>Inside arithmetic, '/', '-', '+' and numbers belong to the expression, not the unit.</summary>
        public static UnitParseOptions ExpressionLiteral => new()
        {
            AllowLeadingSlash = false,
            AllowNumericOne = false,
            AllowSignedPlainExponent = false,
        };
    }
}
