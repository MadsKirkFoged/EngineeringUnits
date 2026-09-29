using System.Reflection;
using System.Text;
using static EngineeringUnits.Analyzers.Tests.Fast.AnalyzerVerifier;

namespace EngineeringUnits.Analyzers.Tests.Fast;

/// <summary>
/// Random formulas, checked against the analyzer.
///
/// The generator knows every quantity's dimension and every real relationship between them (power × duration = energy,
/// mass × acceleration = force, ...). It chains those into formulas, works out the right unit ON ITS OWN, and then
/// breaks about half of them the way people do: a * that should be a /, a forgotten factor, the wrong target type.
/// The analyzer must flag exactly the broken ones - no more, no less.
///
/// Every run uses the same seeds, so a failure can always be reproduced. The test output prints a sample of the
/// generated code, so you can read what was tested.
/// </summary>
[TestClass]
public class RandomFormulaTests
{
    private const int StatementsPerSeed = 200;

    public TestContext TestContext { get; set; } = null!;

    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    [DataRow(5)]
    public async Task RandomFormulas_AnalyzerAgreesWithTheGenerator(int seed)
    {
        var generator = new FormulaGenerator(seed);
        var (source, readable, counts) = generator.Generate(StatementsPerSeed);

        // Make sure the generator really mixes right and wrong code - otherwise the test would prove little
        Assert.IsTrue(counts.Correct >= StatementsPerSeed / 4, $"Only {counts.Correct} correct statements");
        Assert.IsTrue(counts.Wrong >= StatementsPerSeed / 4, $"Only {counts.Wrong} wrong statements");

        TestContext.WriteLine($"Seed {seed}: {counts.Correct} correct and {counts.Wrong} wrong statements. A sample:");
        foreach (var line in readable.Take(25))
            TestContext.WriteLine("    " + line);

        await VerifyAsync(source);
    }

    // ============================================================================================================
    // The generator
    // ============================================================================================================

    private sealed class FormulaGenerator(int seed)
    {
        private readonly Random _rng = new(seed);
        private static readonly Quantity[] All = LoadQuantities();
        private static readonly Dictionary<string, Quantity[]> ByDimension = All.GroupBy(q => q.Dim.Key).ToDictionary(g => g.Key, g => g.ToArray());

        // Every A * B = C and A / B = C where C is a named quantity: the "physics" the formulas are built from
        private static readonly (Quantity Left, char Op, Quantity Right, Quantity Result)[] Relations = FindRelations();

        public (string Source, List<string> Readable, (int Correct, int Wrong) Counts) Generate(int statements)
        {
            var body = new StringBuilder();
            var readable = new List<string>();
            int correct = 0, wrong = 0;

            for (int i = 0; i < statements; i++)
            {
                var (code, text, isWrong) = Statement(i);
                body.AppendLine("        " + code);
                readable.Add(text);
                if (isWrong) wrong++; else correct++;
            }

            var declarations = string.Join(Environment.NewLine, All.Select(q => $"        {q.Name} {q.Var} = {q.Name}.FromSI(1.5);"));
            var source = $$"""
                using EngineeringUnits.Fast;

                public static class Snippet
                {
                    public static void Run()
                    {
                {{declarations}}

                {{body}}
                    }
                }
                """;

            return (source, readable, (correct, wrong));
        }

        private (string Code, string Readable, bool IsWrong) Statement(int i)
        {
            var formula = CorrectFormula();
            bool broken = _rng.Next(2) == 0;
            if (broken)
                formula = Break(formula);

            switch (_rng.Next(6))
            {
                // Target x = formula;
                case 0:
                {
                    var target = PickTarget(formula.Dim, wantMatch: !broken || _rng.Next(3) == 0);
                    var ok = target.Dim.Equals(formula.Dim);
                    return ($"{target.Name} x{i} = {Mark("EUF0001", formula.Text, ok)};",
                            $"{target.Name} x{i} = {formula.Text};".PadRight(90) + Verdict(ok, "EUF0001"), !ok);
                }

                // var t = formula; Target x = t;   (the analyzer has to follow the local)
                case 1:
                {
                    var target = PickTarget(formula.Dim, wantMatch: !broken || _rng.Next(3) == 0);
                    var ok = target.Dim.Equals(formula.Dim);
                    return ($"var t{i} = {formula.Text}; {target.Name} x{i} = {Mark("EUF0001", $"t{i}", ok)};",
                            $"var t{i} = {formula.Text}; {target.Name} x{i} = t{i};".PadRight(90) + Verdict(ok, "EUF0001"), !ok);
                }

                // Target x = a + b;   (b is a reordered copy of a, or something else)
                case 2:
                {
                    var other = broken ? CorrectFormula() : Shuffle(formula);
                    if (!other.Dim.Equals(formula.Dim))
                    {
                        var t = PickTarget(formula.Dim, wantMatch: true);
                        return ($"{t.Name} x{i} = {Mark("EUF0002", $"{formula.Text} + {other.Text}", false)};",
                                $"{t.Name} x{i} = {formula.Text} + {other.Text};".PadRight(90) + Verdict(false, "EUF0002"), true);
                    }
                    var target = PickTarget(formula.Dim, wantMatch: true);
                    var ok = target.Dim.Equals(formula.Dim);
                    return ($"{target.Name} x{i} = {Mark("EUF0001", $"{formula.Text} + {other.Text}", ok)};",
                            $"{target.Name} x{i} = {formula.Text} + {other.Text};".PadRight(90) + Verdict(ok, "EUF0001"), !ok);
                }

                // bool b = a > b;
                case 3:
                {
                    var other = broken ? CorrectFormula() : Shuffle(formula);
                    var ok = other.Dim.Equals(formula.Dim);
                    return ($"bool b{i} = {Mark("EUF0003", $"{formula.Text} > {other.Text}", ok)};",
                            $"bool b{i} = {formula.Text} > {other.Text};".PadRight(90) + Verdict(ok, "EUF0003"), !ok);
                }

                // var total = Target.Zero; total += formula;
                case 4:
                {
                    var target = PickTarget(formula.Dim, wantMatch: !broken || _rng.Next(3) == 0);
                    var ok = target.Dim.Equals(formula.Dim);
                    return ($"var c{i} = {target.Name}.Zero; {Mark("EUF0002", $"c{i} += {formula.Text}", ok)};",
                            $"var c{i} = {target.Name}.Zero; c{i} += {formula.Text};".PadRight(90) + Verdict(ok, "EUF0002"), !ok);
                }

                // double d = (double)(a / b);   only dimensionless values may become numbers
                default:
                {
                    var ratio = broken ? Divide(formula, CorrectFormula()) : Divide(formula, Shuffle(formula));
                    var ok = ratio.Dim.IsDimensionless;
                    return ($"double d{i} = {Mark("EUF0004", $"(double)({ratio.Text})", ok)};",
                            $"double d{i} = (double)({ratio.Text});".PadRight(90) + Verdict(ok, "EUF0004"), !ok);
                }
            }
        }

        private static string Mark(string id, string code, bool ok) => ok ? code : $"{{|{id}:{code}|}}";
        private static string Verdict(bool ok, string id) => ok ? "// ✔" : $"// ✘ {id}";

        // ---------- Formulas ----------

        private sealed record Factor(Quantity Q, int Power, bool Divide)
        {
            public string Text => Power == 1 ? Q.Var : $"{Q.Var}.Pow({Power})";
            public Dim Dim => Q.Dim.Pow(Divide ? -Power : Power);
        }

        private sealed record Formula(List<Factor> Factors, double? Scale)
        {
            public Dim Dim => Factors.Aggregate(Dim.None, (d, f) => d.Times(f.Dim));

            public string Text
            {
                get
                {
                    var sb = new StringBuilder();
                    if (Scale is { } s) sb.Append(s.ToString(System.Globalization.CultureInfo.InvariantCulture)).Append(" * ");
                    for (int i = 0; i < Factors.Count; i++)
                    {
                        var f = Factors[i];
                        if (i == 0 && Scale is null)
                            sb.Append(f.Divide ? $"1.0 / {f.Text}" : f.Text);
                        else
                            sb.Append(f.Divide ? " / " : (i == 0 ? "" : " * ")).Append(f.Text);
                    }
                    return sb.ToString().Replace("*  / ", "/ ").Replace("* / ", "/ ");
                }
            }
        }

        /// <summary>Starts with a quantity and follows 1-3 real relationships, e.g. massFlow * specificEnergy / power ...</summary>
        private Formula CorrectFormula()
        {
            var start = All[_rng.Next(All.Length)];
            var factors = new List<Factor> { new(start, 1, false) };
            var current = start;

            var steps = _rng.Next(1, 4);
            for (int s = 0; s < steps; s++)
            {
                var options = Relations.Where(r => r.Left.Dim.Equals(current.Dim)).ToArray();
                if (options.Length == 0) break;
                var r = options[_rng.Next(options.Length)];
                factors.Add(new Factor(r.Right, 1, r.Op == '/'));
                current = r.Result;
            }

            // Sometimes a squared factor with a matching square root elsewhere is too clever; keep Pow simple:
            // x * y.Pow(2) / y is still y-consistent
            if (_rng.Next(6) == 0)
            {
                var y = All[_rng.Next(All.Length)];
                factors.Add(new Factor(y, 2, false));
                factors.Add(new Factor(y, 1, true));
                factors.Add(new Factor(y, 1, true));
            }

            // Only formulas with at least two quantities: a single variable would be a named type, not an UnknownUnit
            if (factors.Count == 1)
                factors.Add(new Factor(start, 1, true)); // x / x: dimensionless

            double? scale = _rng.Next(4) == 0 ? new[] { 0.5, 2.0, 3.6, 1000.0 }[_rng.Next(4)] : null;
            return new Formula(factors, scale);
        }

        /// <summary>The mistakes people make: flip a * and /, forget a factor, add an extra one.</summary>
        private Formula Break(Formula f)
        {
            var factors = f.Factors.ToList();
            for (int attempt = 0; attempt < 5; attempt++)
            {
                var copy = factors.ToList();
                switch (_rng.Next(3))
                {
                    case 0: // * instead of /  (or the other way round)
                        var i = _rng.Next(1, copy.Count);
                        copy[i] = copy[i] with { Divide = !copy[i].Divide };
                        break;
                    case 1 when copy.Count > 2: // forgot a factor
                        copy.RemoveAt(_rng.Next(1, copy.Count));
                        break;
                    default: // one factor too many
                        copy.Add(new Factor(All[_rng.Next(All.Length)], 1, _rng.Next(2) == 0));
                        break;
                }

                var broken = f with { Factors = copy };
                if (!broken.Dim.Equals(f.Dim))
                    return broken;
            }

            // Couldn't break it by accident-proof means (e.g. only dimensionless factors) - add length for sure
            return f with { Factors = [.. factors, new Factor(All.First(q => q.Name == "Length"), 1, false)] };
        }

        /// <summary>Same factors in another order: a * b / c == b / c * a. Must give the same unit.</summary>
        private Formula Shuffle(Formula f) => f with { Factors = f.Factors.OrderBy(_ => _rng.Next()).ToList() };

        private static Formula Divide(Formula a, Formula b)
            => new([.. a.Factors, .. b.Factors.Select(x => x with { Divide = !x.Divide })], a.Scale);

        private Quantity PickTarget(Dim dim, bool wantMatch)
        {
            if (wantMatch && ByDimension.TryGetValue(dim.Key, out var matches))
                return matches[_rng.Next(matches.Length)];

            Quantity q;
            do q = All[_rng.Next(All.Length)]; while (q.Dim.Equals(dim));
            return q;
        }

        private static (Quantity, char, Quantity, Quantity)[] FindRelations()
        {
            var result = new List<(Quantity, char, Quantity, Quantity)>();
            foreach (var a in All)
            foreach (var b in All)
            {
                if (a.Dim.IsDimensionless || b.Dim.IsDimensionless)
                    continue; // x * ratio = x is true, but not interesting
                if (ByDimension.TryGetValue(a.Dim.Times(b.Dim).Key, out var product))
                    result.Add((a, '*', b, product[0]));
                if (ByDimension.TryGetValue(a.Dim.Times(b.Dim.Pow(-1)).Key, out var quotient) && !quotient[0].Dim.IsDimensionless)
                    result.Add((a, '/', b, quotient[0]));
            }
            return [.. result];
        }
    }

    // ---------- Quantities and dimensions, read from the EngineeringUnits.Fast assembly ----------

    private sealed record Quantity(string Name, Dim Dim)
    {
        public string Var => char.ToLowerInvariant(Name[0]) + Name[1..];
    }

    private sealed record Dim(int[] Exp)
    {
        public static readonly Dim None = new(new int[9]);
        public bool IsDimensionless => Exp.All(e => e == 0);
        public string Key => string.Join(",", Exp);
        public Dim Times(Dim other) => new(Exp.Zip(other.Exp, (a, b) => a + b).ToArray());
        public Dim Pow(int p) => new(Exp.Select(e => e * p).ToArray());
        public bool Equals(Dim? other) => other is not null && Exp.SequenceEqual(other.Exp);
        public override int GetHashCode() => Key.GetHashCode();
    }

    private static Quantity[] LoadQuantities()
        => typeof(EngineeringUnits.Fast.Quantities).GetField("All")!.GetValue(null) is IEnumerable<object> list
            ? list.Select(info =>
            {
                var type = (Type)info.GetType().GetProperty("Type")!.GetValue(info)!;
                var attr = type.GetCustomAttributesData().Single(a => a.AttributeType.Name == "UnitDimensionAttribute");
                var exp = new int[9];
                for (int i = 0; i + 1 < attr.ConstructorArguments.Count; i += 2)
                    exp[(int)attr.ConstructorArguments[i].Value!] += (int)attr.ConstructorArguments[i + 1].Value!;
                return new Quantity(type.Name, new Dim(exp));
            }).ToArray()
            : throw new InvalidOperationException("Quantities.All not found");
}
