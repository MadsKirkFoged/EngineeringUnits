using System;
using System.Collections.Generic;
using System.Globalization;

namespace EngineeringUnits.Parsing
{
    public static class UnitExpressionParser
    {

        public static bool TryParseWithWarnings(string text, out UnitSystem unitSystem, out List<ParseWarning> warnings)
        {
            warnings = new List<ParseWarning>();
            unitSystem = new UnitSystem();

            if (!TryParse(text, out unitSystem))
                return false;

            var normalized = OffsetUnitNormalizer.Normalize(unitSystem);
            unitSystem = normalized.unit;
            warnings.AddRange(normalized.warnings);

            return true;
        }

        public static bool TryParse(string text, out UnitSystem unitSystem)
        {
            unitSystem = new UnitSystem();
            if (string.IsNullOrWhiteSpace(text))
                return false;

            try
            {
                var tokenizer = new Tokenizer(text);
                var parser = new Parser(tokenizer);
                unitSystem = parser.ParseExpression();
                return tokenizer.Current.Kind == TokenKind.End;
            }
            catch (AmbiguousUnitTokenException)
            {
                throw; // bubble up clearly
            }
            catch
            {
                return false;
            }
        }

        private enum TokenKind { Unit, Mul, Div, Pow, LParen, RParen, Int, End }

        private readonly struct Token
        {
            public TokenKind Kind { get; }
            public string Text { get; }
            public int IntValue { get; }
            public Token(TokenKind kind, string text, int intValue = 0) { Kind = kind; Text = text; IntValue = intValue; }
        }

        private sealed class Tokenizer
        {
            private readonly string _s;
            private int _i;
            public Token Current { get; private set; }

            public Tokenizer(string s) { _s = s; _i = 0; Next(); }

            public void Next()
            {
                SkipWs();

                if (_i >= _s.Length)
                { Current = new(TokenKind.End, ""); return; }

                char c = _s[_i];

                if (c == '*' || c == '·')
                { _i++; Current = new(TokenKind.Mul, c.ToString()); return; }
                if (c == '/')
                { _i++; Current = new(TokenKind.Div, "/"); return; }
                if (c == '^')
                { _i++; Current = new(TokenKind.Pow, "^"); return; }
                if (c == '(')
                { _i++; Current = new(TokenKind.LParen, "("); return; }
                if (c == ')')
                { _i++; Current = new(TokenKind.RParen, ")"); return; }

                // Integer exponent token (only if not immediately followed by unit characters)
                if (c == '+' || c == '-' || char.IsDigit(c))
                {
                    int start = _i;
                    int sign = 1;
                    if (c == '+')
                    { _i++; }
                    else if (c == '-')
                    { sign = -1; _i++; }

                    int d0 = _i;
                    while (_i < _s.Length && char.IsDigit(_s[_i]))
                        _i++;

                    if (_i > d0)
                    {
                        if (_i >= _s.Length || !IsUnitChar(_s[_i]))
                        {
                            int val = int.Parse(_s.Substring(d0, _i - d0), CultureInfo.InvariantCulture) * sign;
                            Current = new(TokenKind.Int, _s.Substring(start, _i - start), val);
                            return;
                        }
                        _i = start;
                    }
                    else
                        _i = start;
                }

                // Unit token
                int u0 = _i;
                while (_i < _s.Length && IsUnitChar(_s[_i]))
                    _i++;
                var token = _s.Substring(u0, _i - u0).Trim();
                if (token.Length == 0)
                    throw new FormatException();
                Current = new(TokenKind.Unit, token);
            }

            private void SkipWs() { while (_i < _s.Length && char.IsWhiteSpace(_s[_i])) _i++; }

            private static bool IsUnitChar(char c)
                => char.IsLetter(c) || c == 'µ' || c == 'Ω' || c == '°';
        }

        private sealed class Parser
        {
            private readonly Tokenizer _t;
            public Parser(Tokenizer t) => _t = t;

            public UnitSystem ParseExpression()
            {
                var left = ParseFactor();

                while (true)
                {
                    // explicit ops
                    if (_t.Current.Kind == TokenKind.Mul)
                    {
                        _t.Next();
                        var right = ParseFactor();
                        left = left * right;
                        continue;
                    }

                    if (_t.Current.Kind == TokenKind.Div)
                    {
                        _t.Next();
                        var right = ParseFactor();
                        left = left / right;
                        continue;
                    }

                    // ✅ implicit multiplication by whitespace:
                    // if the next token starts a factor, treat it as "*"
                    if (_t.Current.Kind == TokenKind.Unit || _t.Current.Kind == TokenKind.LParen)
                    {
                        var right = ParseFactor();
                        left = left * right;
                        continue;
                    }

                    break;
                }

                return left;
            }

            private UnitSystem ParseFactor()
            {
                var u = ParsePrimary();

                if (_t.Current.Kind == TokenKind.Pow)
                {
                    _t.Next();
                    int exp = ParseExponent();
                    u = Pow(u, exp);
                }

                return u;
            }

            private UnitSystem ParsePrimary()
            {
                if (_t.Current.Kind == TokenKind.LParen)
                {
                    _t.Next();
                    var inner = ParseExpression();
                    if (_t.Current.Kind != TokenKind.RParen)
                        throw new FormatException();
                    _t.Next();
                    return inner;
                }

                if (_t.Current.Kind != TokenKind.Unit)
                    throw new FormatException();

                var raw = _t.Current.Text;
                _t.Next();

                var token = AnyUnitTokenRegistry.NormalizeToken(raw);

                if (!AnyUnitTokenRegistry.TryResolve(token, out var unit))
                    throw new FormatException($"Unknown unit token '{raw}'.");

                return unit.Unit;
            }

            private int ParseExponent()
            {
                if (_t.Current.Kind == TokenKind.LParen)
                {
                    _t.Next();
                    if (_t.Current.Kind != TokenKind.Int)
                        throw new FormatException();
                    int v = _t.Current.IntValue;
                    _t.Next();
                    if (_t.Current.Kind != TokenKind.RParen)
                        throw new FormatException();
                    _t.Next();
                    return v;
                }

                if (_t.Current.Kind != TokenKind.Int)
                    throw new FormatException();
                int val = _t.Current.IntValue;
                _t.Next();
                return val;
            }

            private static UnitSystem Pow(UnitSystem u, int exp)
            {
                if (exp == 0)
                    return new UnitSystem(1m, null);

                int n = Math.Abs(exp);
                UnitSystem r = u;
                for (int i = 1; i < n; i++)
                    r = r * u;

                if (exp < 0)
                    r = new UnitSystem(1m, null) / r;
                return r;
            }
        }
    }
}