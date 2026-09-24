using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EngineeringUnits.Parser.Objects;
using EngineeringUnits.Parser.UnitParser;

namespace EngineeringUnits.Parsing
{
    /// <summary>
    /// Evaluates arithmetic on quantities: "10 m + 5 in", "(10 m + 2 m) / 2 s", "(2 m)^2", "2 (3 m)".
    /// <para>
    /// Operands are "&lt;number&gt; &lt;unit&gt;" literals parsed by <see cref="QuantityParser"/>. Inside an expression
    /// '+', '-' and numbers always belong to the arithmetic, so write unit exponents with '^' or superscripts
    /// ("m^-2", "m⁻²"), not "m-2". "2/s" is a literal (2 per second), except directly after '/':
    /// "10 m/2/s" is 10 m ÷ 2 ÷ s.
    /// </para>
    /// </summary>
    public static class QuantityExpressionParser
    {
        public static UnknownUnit Parse(string input, IFormatProvider? culture = null)
        {
            var r = ParseWithWarnings(input, culture);
            if (!r.Success || r.Value is null)
                throw new FormatException(r.Error ?? $"Could not parse '{input}'.");
            return r.Value;
        }

        public static bool TryParse(string input, out UnknownUnit result, IFormatProvider? culture = null)
        {
            var r = ParseWithWarnings(input, culture);
            result = r.Value!;
            return r.Success && r.Value is not null;
        }

        public static ParseResult<UnknownUnit> ParseWithWarnings(string input, IFormatProvider? culture = null)
        {
            culture ??= CultureInfo.InvariantCulture;
            input ??= "";

            var warnings = new List<ParseWarning>();

            try
            {
                var tokens = Tokenize(NormalizeDashes(input), culture, warnings, out string? tokenError);
                if (tokens is null)
                    return Fail(input, tokenError ?? "Failed to tokenize expression.", warnings);

                if (tokens.Count == 0)
                    return Fail(input, "Input was empty.", warnings);

                var rpn = ToRpn(tokens, out string? rpnError);
                if (rpn is null)
                    return Fail(input, rpnError ?? "Failed to parse expression.", warnings);

                var value = EvalRpn(rpn, out string? evalError);
                if (evalError != null)
                    return Fail(input, evalError, warnings);

                return new ParseResult<UnknownUnit>
                {
                    Success = true,
                    Value = value,
                    Original = input,
                    Normalized = input,
                    Warnings = warnings
                };
            }
            catch (Exception ex)
            {
                // WrongUnitException (dimension mismatch) and anything else
                return Fail(input, ex.Message, warnings);
            }
        }

        // ---------------- Token model ----------------

        private abstract record Tok;
        private sealed record Lit(UnknownUnit Value) : Tok;
        private sealed record IntExponent(int Value) : Tok;
        private sealed record Op(char C) : Tok;

        private static string NormalizeDashes(string s)
            => s.Replace('−', '-').Replace('–', '-').Replace('—', '-').Replace('‑', '-').Replace('－', '-').Replace('＋', '+');

        // ---------------- Tokenize ----------------

        private static List<Tok>? Tokenize(string s, IFormatProvider culture, List<ParseWarning> warnings, out string? error)
        {
            error = null;
            var list = new List<Tok>();

            int i = 0;
            bool expectOperand = true;

            while (i < s.Length)
            {
                while (i < s.Length && char.IsWhiteSpace(s[i]))
                    i++;
                if (i >= s.Length)
                    break;

                char c = s[i];
                Tok? prev = list.Count > 0 ? list[list.Count - 1] : null;

                if (c == '(')
                {
                    // implicit multiplication: "2 (3 m)", "(2)(3 m)"
                    if (!expectOperand)
                        list.Add(new Op('*'));

                    list.Add(new Op('('));
                    i++;
                    expectOperand = true;
                    continue;
                }

                if (c == ')')
                {
                    list.Add(new Op(')'));
                    i++;
                    expectOperand = false;
                    continue;
                }

                // Unary plus: +( ... ) or +literal -> no-op
                if (expectOperand && c == '+')
                {
                    i++;
                    continue;
                }

                // Unary minus before parenthesis: -( ... ) == (-1) * ( ... )
                if (expectOperand && c == '-')
                {
                    int j = i + 1;
                    while (j < s.Length && char.IsWhiteSpace(s[j]))
                        j++;
                    if (j < s.Length && s[j] == '(')
                    {
                        list.Add(new Lit(new UnknownUnit(-1m, new UnitSystem())));
                        list.Add(new Op('*'));
                        i++;
                        continue;
                    }
                }

                // Power operator: "(2 m)^2", "2^3"
                if (!expectOperand && c == '^')
                {
                    i++;
                    if (!TryReadIntegerExponent(s, ref i, out int exp))
                    {
                        error = "Expected an integer exponent after '^'.";
                        return null;
                    }

                    list.Add(new Op('^'));
                    list.Add(new IntExponent(exp));
                    expectOperand = false;
                    continue;
                }

                // Binary operators
                if (!expectOperand && (c == '+' || c == '-' || c == '*' || c == '/'))
                {
                    list.Add(new Op(c));
                    i++;
                    expectOperand = true;
                    continue;
                }

                bool afterClosing = prev is Op { C: ')' } || prev is IntExponent;
                bool afterMulDiv = prev is Op { C: '*' or '/' };

                // A bare unit ("s") is an operand only after '*', '/' or as an implicit factor after ')' / an exponent.
                // At the start of an operand a number is required ("m + 10 m" is an error).
                bool bareUnit = IsUnitStart(c) && (afterClosing || afterMulDiv);

                if (!expectOperand)
                {
                    if (bareUnit && afterClosing)
                    {
                        list.Add(new Op('*')); // "(5) m", "2^3 m"
                    }
                    else
                    {
                        error = $"Unexpected '{s.Substring(i)}' (missing operator?).";
                        return null;
                    }
                }

                bool afterDivision = prev is Op { C: '/' };

                var (lit, consumed, litWarns, litErr) = TryParseLongestLiteral(s, i, culture, bareUnit, afterDivision);
                if (litErr != null)
                {
                    error = litErr;
                    return null;
                }

                warnings.AddRange(litWarns);
                list.Add(new Lit(lit!));
                i += consumed;
                expectOperand = false;
            }

            if (expectOperand && list.Count > 0)
            {
                error = "Expression ended unexpectedly (missing operand).";
                return null;
            }

            return list;
        }

        private static bool IsUnitStart(char c) => char.IsLetter(c) || c is '°' or '%' or '‰' or 'µ' or 'Ω';

        private static bool TryReadIntegerExponent(string s, ref int i, out int value)
        {
            value = 0;
            while (i < s.Length && char.IsWhiteSpace(s[i]))
                i++;

            bool paren = i < s.Length && s[i] == '(';
            if (paren)
                i++;

            int sign = 1;
            if (i < s.Length && (s[i] == '-' || s[i] == '+'))
            {
                sign = s[i] == '-' ? -1 : 1;
                i++;
            }

            int start = i;
            while (i < s.Length && char.IsDigit(s[i]))
                i++;

            if (i == start || !int.TryParse(s.Substring(start, i - start), NumberStyles.None, CultureInfo.InvariantCulture, out value) ||
                value > UnitExpressionParser.MaxExponent)
                return false;

            if (paren)
            {
                if (i >= s.Length || s[i] != ')')
                    return false;
                i++;
            }

            value *= sign;
            return true;
        }

        /// <summary>
        /// Finds the longest literal starting at <paramref name="start"/>. The literal can never extend past an
        /// arithmetic '+'/'-' or an unmatched ')', and only ends at token boundaries, so this is linear-ish rather
        /// than trying every substring.
        /// </summary>
        private static (UnknownUnit? value, int consumed, IReadOnlyList<ParseWarning> warns, string? error)
            TryParseLongestLiteral(string s, int start, IFormatProvider culture, bool bareUnit, bool afterDivision)
        {
            int limit = FindLiteralLimit(s, start);

            var options = UnitParseOptions.ExpressionLiteral with { AllowLeadingSlash = !afterDivision };

            for (int end = limit; end > start; end--)
            {
                if (!IsBoundary(s, end, limit))
                    continue;

                string sub = s.Substring(start, end - start).TrimEnd();
                if (sub.Length == 0)
                    continue;

                char last = sub[sub.Length - 1];
                if (last is '+' or '-' or '*' or '/' or '^' or '(')
                    continue;

                var r = QuantityParser.ParseLiteral(bareUnit ? "1 " + sub : sub, culture, options);
                if (r.Success && r.Value is not null)
                    return (r.Value, end - start, r.Warnings, null);
            }

            var tail = s.Substring(start, limit - start).Trim();
            var detail = QuantityParser.ParseLiteral(bareUnit ? "1 " + tail : tail, culture, options).Error;
            return (null, 0, Array.Empty<ParseWarning>(),
                    $"Could not parse quantity literal starting at: '{s.Substring(start)}'" + (detail is null ? "" : $" ({detail})"));
        }

        private static bool IsBoundary(string s, int end, int limit)
        {
            if (end >= limit)
                return true;

            char next = s[end];
            char prev = s[end - 1];

            return char.IsWhiteSpace(next) || next is '*' or '/' or '(' or ')' or '^' or '+' or '-' ||
                   prev == ')' ||
                   (char.IsDigit(prev) && !char.IsDigit(next) && next is not '.' and not ','); // "5m", "2^3"
        }

        /// <summary>Index of the first arithmetic '+'/'-' or unmatched ')' after <paramref name="start"/>.</summary>
        private static int FindLiteralLimit(string s, int start)
        {
            int depth = 0;

            for (int i = start; i < s.Length; i++)
            {
                char c = s[i];

                if (c == '(')
                { depth++; continue; }

                if (c == ')')
                {
                    if (--depth < 0)
                        return i;
                    continue;
                }

                if (c is '+' or '-')
                {
                    if (i == start)
                        continue; // sign of the number

                    if (IsExponentSign(s, i))
                        continue;

                    if (depth == 0)
                        return i;
                }
            }

            return s.Length;
        }

        private static bool IsExponentSign(string s, int i)
        {
            int j = i - 1;
            while (j >= 0 && char.IsWhiteSpace(s[j]))
                j--;
            if (j < 0)
                return false;

            // "^-2", "^(-2)"
            if (s[j] == '^')
                return true;
            if (s[j] == '(')
            {
                int k = j - 1;
                while (k >= 0 && char.IsWhiteSpace(s[k]))
                    k--;
                return k >= 0 && s[k] == '^';
            }

            // "1e-3" (e directly after a digit, no spaces)
            return j == i - 1 && (s[j] == 'e' || s[j] == 'E') && j > 0 && char.IsDigit(s[j - 1]);
        }

        // ---------------- Shunting-yard: tokens -> RPN ----------------

        private static List<Tok>? ToRpn(List<Tok> tokens, out string? error)
        {
            error = null;
            var output = new List<Tok>();
            var stack = new Stack<Op>();

            static int Prec(char op) => op switch
            {
                '^' => 3,
                '*' or '/' => 2,
                '+' or '-' => 1,
                _ => 0,
            };

            foreach (var t in tokens)
            {
                switch (t)
                {
                    case Lit or IntExponent:
                        output.Add(t);
                        break;

                    case Op o when o.C == '(':
                        stack.Push(o);
                        break;

                    case Op o when o.C == ')':
                        while (stack.Count > 0 && stack.Peek().C != '(')
                            output.Add(stack.Pop());
                        if (stack.Count == 0)
                        {
                            error = "Mismatched parentheses.";
                            return null;
                        }
                        stack.Pop(); // pop '('
                        break;

                    case Op o:
                        // '^' is right-associative, the rest left-associative
                        while (stack.Count > 0 && stack.Peek().C != '(' &&
                               (o.C == '^' ? Prec(stack.Peek().C) > Prec(o.C) : Prec(stack.Peek().C) >= Prec(o.C)))
                        {
                            output.Add(stack.Pop());
                        }
                        stack.Push(o);
                        break;
                }
            }

            while (stack.Count > 0)
            {
                var o = stack.Pop();
                if (o.C is '(' or ')')
                {
                    error = "Mismatched parentheses.";
                    return null;
                }
                output.Add(o);
            }

            return output;
        }

        // ---------------- Evaluate RPN ----------------

        private static UnknownUnit? EvalRpn(List<Tok> rpn, out string? error)
        {
            error = null;
            var st = new Stack<object>();

            foreach (var t in rpn)
            {
                switch (t)
                {
                    case Lit lit:
                        st.Push(lit.Value);
                        continue;

                    case IntExponent e:
                        st.Push(e.Value);
                        continue;

                    case Op op:
                        if (st.Count < 2)
                        {
                            error = "Invalid expression (missing operands).";
                            return null;
                        }

                        var b = st.Pop();
                        var a = st.Pop();

                        if (a is not UnknownUnit left)
                        {
                            error = "Invalid expression.";
                            return null;
                        }

                        if (op.C == '^')
                        {
                            if (b is not int exp)
                            {
                                error = "Exponent must be an integer.";
                                return null;
                            }
                            st.Push(left.Pow(exp)!);
                            continue;
                        }

                        if (b is not UnknownUnit right)
                        {
                            error = "Invalid expression.";
                            return null;
                        }

                        st.Push(op.C switch
                        {
                            '+' => left + right,
                            '-' => left - right,
                            '*' => left * right,
                            '/' => left / right,
                            _ => throw new FormatException($"Unknown operator '{op.C}'")
                        });
                        continue;
                }
            }

            if (st.Count != 1 || st.Peek() is not UnknownUnit result)
            {
                error = "Invalid expression (leftover operands).";
                return null;
            }

            return result;
        }

        private static ParseResult<UnknownUnit> Fail(string original, string message, IReadOnlyList<ParseWarning>? warns = null)
        {
            return new ParseResult<UnknownUnit>
            {
                Success = false,
                Value = null,
                Original = original,
                Normalized = "",
                Warnings = warns ?? Array.Empty<ParseWarning>(),
                Error = message
            };
        }
    }
}
