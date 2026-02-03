using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parser.Objects;

namespace EngineeringUnits.Parsing
{
    public static class QuantityExpressionParser
    {
        private static readonly HashSet<char> Ops = new() { '+', '-', '*', '/', '(', ')' };

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
                var tokens = Tokenize(input, culture, warnings, out string? tokenError);
                if (tokens is null)
                    return Fail(input, tokenError ?? "Failed to tokenize expression.");

                var rpn = ToRpn(tokens, out string? rpnError);
                if (rpn is null)
                    return Fail(input, rpnError ?? "Failed to parse expression.");

                var value = EvalRpn(rpn, out string? evalError);
                if (evalError != null)
                    return Fail(input, evalError, warnings);

                return new ParseResult<UnknownUnit>
                {
                    Success = true,
                    Value = value,
                    Original = input,
                    Normalized = input, // optional: later you can output canonical unit string
                    Warnings = warnings
                };
            }
            catch (WrongUnitException ex) // your engine’s mismatch exception [1](https://www.engineeringtoolbox.net/getsimdata/getunisim)
            {
                return Fail(input, ex.Message, warnings);
            }
            catch (Exception ex)
            {
                return Fail(input, ex.Message, warnings);
            }
        }

        // ---------------- Token model ----------------

        private abstract record Tok;
        private record Lit(UnknownUnit Value) : Tok;
        private record Op(char C) : Tok;

        // ---------------- Tokenize with max-munch literal parsing ----------------

        private static List<Tok>? Tokenize(string s, IFormatProvider culture, List<ParseWarning> warnings, out string? error)
        {
            error = null;
            var list = new List<Tok>();

            int i = 0;
            bool expectOperand = true;

            while (i < s.Length)
            {
                // skip whitespace
                while (i < s.Length && char.IsWhiteSpace(s[i]))
                    i++;
                if (i >= s.Length)
                    break;

                char c = s[i];

                // Parentheses always operators
                if (c == '(' || c == ')')
                {
                    list.Add(new Op(c));
                    i++;
                    expectOperand = (c == '(');
                    continue;
                }

                // Unary minus for parenthesis: -( ... )
                if (expectOperand && c == '-' && i + 1 < s.Length)
                {
                    // if next non-ws is '(' => treat as unary negate operator: 0 - ( ... )
                    int j = i + 1;
                    while (j < s.Length && char.IsWhiteSpace(s[j]))
                        j++;
                    if (j < s.Length && s[j] == '(')
                    {
                        // Insert literal 0 (dimensionless) then minus
                        var zero = QuantityParser.ParseWithWarnings("0", culture).Value!;
                        list.Add(new Lit(zero));
                        list.Add(new Op('-'));
                        i++; // consume '-'
                        expectOperand = true;
                        continue;
                    }
                }

                // Binary operators (when we’re not expecting operand)
                if (!expectOperand && (c == '+' || c == '-' || c == '*' || c == '/'))
                {
                    list.Add(new Op(c));
                    i++;
                    expectOperand = true;
                    continue;
                }

                // Otherwise we must parse a literal (max-munch)
                var (lit, consumed, litWarns, litErr) = TryParseLongestLiteral(s, i, culture);
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

        private static (UnknownUnit? value, int consumed, List<ParseWarning> warns, string? error)
            TryParseLongestLiteral(string s, int start, IFormatProvider culture)
        {
            var warns = new List<ParseWarning>();
            UnknownUnit? best = null;
            int bestEnd = -1;
            List<ParseWarning>? bestWarns = null;

            // Scan forward; keep last successful literal parse.
            // Stop if we hit a top-level math operator that cannot belong to the literal.
            // (We still allow unit expressions with '*' '/' '^' inside the literal because UnknownUnitParser handles it.)
            for (int end = start + 1; end <= s.Length; end++)
            {
                string sub = s.Substring(start, end - start).TrimEnd();
                if (sub.Length == 0)
                    continue;

                // If sub ends with an obvious incomplete token, skip
                char last = sub[sub.Length - 1];
                if (last is '+' or '-' or '*' or '/' or '^')
                    continue;

                var r = QuantityParser.ParseWithWarnings(sub, culture);
                if (r.Success && r.Value is not null)
                {
                    best = r.Value;
                    bestEnd = end;
                    bestWarns = new List<ParseWarning>(r.Warnings);
                }

                // Heuristic early stop: if next char is '+' or '-' (likely math op), we can stop searching
                if (end < s.Length)
                {
                    char next = s[end];
                    if (next == '+' || next == '-')
                        break;
                }
            }

            if (best is null)
                return (null, 0, warns, $"Could not parse quantity literal starting at: '{s.Substring(start)}'");

            return (best, bestEnd - start, bestWarns ?? warns, null);
        }

        // ---------------- Shunting-yard: tokens -> RPN ----------------

        private static List<Tok>? ToRpn(List<Tok> tokens, out string? error)
        {
            error = null;
            var output = new List<Tok>();
            var stack = new Stack<Op>();

            int Prec(char op) => op is '*' or '/' ? 2 : op is '+' or '-' ? 1 : 0;

            foreach (var t in tokens)
            {
                switch (t)
                {
                    case Lit lit:
                        output.Add(lit);
                        break;

                    case Op o when o.C == '(':
                        stack.Push(o);
                        break;

                    case Op o when o.C == ')':
                        while (stack.Count > 0 && stack.Peek().C != '(')
                            output.Add(stack.Pop());
                        if (stack.Count == 0 || stack.Peek().C != '(')
                        {
                            error = "Mismatched parentheses.";
                            return null;
                        }
                        stack.Pop(); // pop '('
                        break;

                    case Op o:
                        while (stack.Count > 0 && stack.Peek().C != '(' &&
                               Prec(stack.Peek().C) >= Prec(o.C))
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

        // ---------------- Evaluate RPN using your unit engine ops ----------------

        private static UnknownUnit? EvalRpn(List<Tok> rpn, out string? error)
        {
            error = null;
            var st = new Stack<UnknownUnit>();

            foreach (var t in rpn)
            {
                if (t is Lit lit)
                {
                    st.Push(lit.Value);
                    continue;
                }

                if (t is Op op)
                {
                    if (st.Count < 2)
                    {
                        error = "Invalid expression (missing operands).";
                        return null;
                    }

                    var b = st.Pop();
                    var a = st.Pop();

                    UnknownUnit res = op.C switch
                    {
                        '+' => a + b,
                        '-' => a - b,
                        '*' => a * b,
                        '/' => a / b,
                        _ => throw new FormatException($"Unknown operator '{op.C}'")
                    };

                    st.Push(res);
                }
            }

            if (st.Count != 1)
            {
                error = "Invalid expression (leftover operands).";
                return null;
            }

            return st.Pop();
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