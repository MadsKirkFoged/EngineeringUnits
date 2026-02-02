using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits.Units;

namespace EngineeringUnits.Parsing
{
    public static class UnitExpressionParser
    {
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

                // Ensure we consumed everything
                if (tokenizer.Current.Kind != TokenKind.End)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        // ---------------- Tokenizer ----------------

        private enum TokenKind { Unit, Mul, Div, Pow, LParen, RParen, Int, End }

        private readonly struct Token
        {
            public TokenKind Kind { get; }
            public string Text { get; }
            public int IntValue { get; }

            public Token(TokenKind kind, string text, int intValue = 0)
            {
                Kind = kind;
                Text = text;
                IntValue = intValue;
            }
        }

        private sealed class Tokenizer
        {
            private readonly string _s;
            private int _i;

            public Token Current { get; private set; }

            public Tokenizer(string s)
            {
                _s = s;
                _i = 0;
                Next();
            }

            public void Next()
            {
                SkipWs();

                if (_i >= _s.Length)
                {
                    Current = new Token(TokenKind.End, "");
                    return;
                }

                char c = _s[_i];

                // Operators
                if (c == '*' || c == '·')
                { _i++; Current = new Token(TokenKind.Mul, c.ToString()); return; }
                if (c == '/')
                { _i++; Current = new Token(TokenKind.Div, "/"); return; }
                if (c == '^')
                { _i++; Current = new Token(TokenKind.Pow, "^"); return; }
                if (c == '(')
                { _i++; Current = new Token(TokenKind.LParen, "("); return; }
                if (c == ')')
                { _i++; Current = new Token(TokenKind.RParen, ")"); return; }

                // Signed integer exponent (only when tokenizer is asked after '^' by parser)
                if (c == '+' || c == '-' || char.IsDigit(c))
                {
                    // Only treat as Int if it's clearly an integer token (no letters right away)
                    int start = _i;
                    int sign = 1;

                    if (c == '+')
                    { sign = 1; _i++; }
                    else if (c == '-')
                    { sign = -1; _i++; }

                    int digitsStart = _i;
                    while (_i < _s.Length && char.IsDigit(_s[_i]))
                        _i++;

                    if (_i > digitsStart)
                    {
                        // If next is a letter, this was actually part of a unit token like "m2" (we don't support that here)
                        // Rollback and parse as Unit token instead
                        if (_i < _s.Length && IsUnitChar(_s[_i]))
                        {
                            _i = start;
                        }
                        else
                        {
                            int val = int.Parse(_s.Substring(digitsStart, _i - digitsStart), CultureInfo.InvariantCulture) * sign;
                            Current = new Token(TokenKind.Int, _s.Substring(start, _i - start), val);
                            return;
                        }
                    }
                    else
                    {
                        _i = start;
                    }
                }

                // Unit token
                {
                    int start = _i;
                    while (_i < _s.Length && IsUnitChar(_s[_i]))
                        _i++;
                    var token = _s.Substring(start, _i - start).Trim();

                    if (token.Length == 0)
                        throw new FormatException();
                    Current = new Token(TokenKind.Unit, token);
                    return;
                }
            }

            private void SkipWs()
            {
                while (_i < _s.Length && char.IsWhiteSpace(_s[_i]))
                    _i++;
            }

            private static bool IsUnitChar(char c)
            {
                // Letters + common unit symbols (µ, Ω, °) + US/metric tokens
                return char.IsLetter(c) || c == 'µ' || c == 'Ω' || c == '°';
            }
        }

        // ---------------- Parser ----------------

        private sealed class Parser
        {
            private readonly Tokenizer _t;

            public Parser(Tokenizer t) => _t = t;

            public UnitSystem ParseExpression()
            {
                // Expr := Factor ( ( * | / ) Factor )*
                var left = ParseFactor();

                while (_t.Current.Kind == TokenKind.Mul || _t.Current.Kind == TokenKind.Div)
                {
                    var op = _t.Current.Kind;
                    _t.Next();
                    var right = ParseFactor();
                    left = op == TokenKind.Mul ? (left * right) : (left / right);
                }

                return left;
            }

            private UnitSystem ParseFactor()
            {
                // Factor := Primary ( ^ Exponent )?
                var baseUnit = ParsePrimary();

                if (_t.Current.Kind == TokenKind.Pow)
                {
                    _t.Next();
                    int exp = ParseExponent();
                    baseUnit = Pow(baseUnit, exp);
                }

                return baseUnit;
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

                var token = _t.Current.Text;
                _t.Next();

                if (!TryResolveAnyUnitSystem(token, out var us))
                    throw new FormatException($"Unknown unit token '{token}'.");

                return us;
            }

            private int ParseExponent()
            {
                // Exponent := Int | ( Int )
                if (_t.Current.Kind == TokenKind.LParen)
                {
                    _t.Next();
                    if (_t.Current.Kind != TokenKind.Int)
                        throw new FormatException();
                    int val = _t.Current.IntValue;
                    _t.Next();
                    if (_t.Current.Kind != TokenKind.RParen)
                        throw new FormatException();
                    _t.Next();
                    return val;
                }

                if (_t.Current.Kind != TokenKind.Int)
                    throw new FormatException();
                int v = _t.Current.IntValue;
                _t.Next();
                return v;
            }

            private static UnitSystem Pow(UnitSystem u, int exp)
            {
                if (exp == 0)
                    return new UnitSystem(1m, null);

                int n = Math.Abs(exp);
                UnitSystem result = u;

                for (int i = 1; i < n; i++)
                    result = result * u;

                if (exp < 0)
                    result = new UnitSystem(1m, null) / result;

                return result;
            }

            private static bool TryResolveAnyUnitSystem(string rawToken, out UnitSystem unitSystem)
            {
                unitSystem = new UnitSystem();
                string token = UnitTokenRegistry<EnergyUnit>.NormalizeToken(rawToken);

                // Order matters: try time-related tokens before length to avoid "h" (hour vs hand).
                if (UnitTokenRegistry<EnergyUnit>.TryResolve(token, out var eu))
                { unitSystem = eu.Unit; return true; }
                if (UnitTokenRegistry<PowerUnit>.TryResolve(token, out var pu))
                { unitSystem = pu.Unit; return true; }
                if (UnitTokenRegistry<ForceUnit>.TryResolve(token, out var fu))
                { unitSystem = fu.Unit; return true; }
                if (UnitTokenRegistry<MassUnit>.TryResolve(token, out var mu))
                { unitSystem = mu.Unit; return true; }
                if (UnitTokenRegistry<DurationUnit>.TryResolve(token, out var tu))
                { unitSystem = tu.Unit; return true; }
                if (UnitTokenRegistry<LengthUnit>.TryResolve(token, out var lu))
                { unitSystem = lu.Unit; return true; }

                return false;
            }
        }
    }
}