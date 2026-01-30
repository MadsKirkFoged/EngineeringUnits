using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace EngineeringUnits.Analyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class DimensionMismatchAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "EU0001";

        private static readonly DiagnosticDescriptor Rule = new(
            id: DiagnosticId,
            title: "EngineeringUnits unit mismatch",
            messageFormat: "This is NOT a [{0}] as expected! Your Unit is a [{1}].",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            => ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();

            context.RegisterCompilationStartAction(startContext =>
            {
                var enumValueToName = SiUnitFormatter.BuildEnumValueToNameMap(startContext.Compilation);

                startContext.RegisterOperationAction(opContext =>
                {
                    AnalyzeConversion(opContext, enumValueToName);
                }, OperationKind.Conversion);
            });
        }

        private static void AnalyzeConversion(OperationAnalysisContext context, Dictionary<int, string> enumValueToName)
        {
            var conv = (IConversionOperation)context.Operation;

            if (!conv.Conversion.IsUserDefined)
                return;

            if (conv.OperatorMethod is null || conv.OperatorMethod.Name != "op_Implicit")
                return;

            if (conv.Type is null)
                return;

            if (!TryGetDimension(conv.Type, out var expected))
                return;

            if (!TryInferDimension(conv.Operand, out var actual))
                return;

            // ✅ FIX: DimVector now exposes Exps
            var expectedSi = SiUnitFormatter.FormatAsSi(expected.Exps, enumValueToName);
            var actualSi = SiUnitFormatter.FormatAsSi(actual.Exps, enumValueToName);

            // compare by canonical key
            if (expected.ToKey() != actual.ToKey())
            {
                context.ReportDiagnostic(Diagnostic.Create(
                    Rule,
                    conv.Operand.Syntax.GetLocation(),
                    expectedSi,
                    actualSi));
            }
        }

        // ---------- Dimension inference (PoC rules) ----------

        private static bool TryInferDimension(IOperation op, out DimVector dim)
        {
            // Unwrap implicit conversions like Volume -> BaseUnit
            while (op is IConversionOperation c && c.IsImplicit && c.Operand is not null)
                op = c.Operand;

            // If expression type has [UnitDimension], use it
            if (op.Type is not null && TryGetDimension(op.Type, out dim))
                return true;

            // Numeric literals => dimensionless
            if (op is ILiteralOperation lit && lit.Type is not null)
            {
                var st = lit.Type.SpecialType;
                if (st is SpecialType.System_Int32 or SpecialType.System_Int64 or
                         SpecialType.System_Double or SpecialType.System_Single or
                         SpecialType.System_Decimal)
                {
                    dim = DimVector.Dimensionless();
                    return true;
                }
            }

            // Binary operations: + - * /
            if (op is IBinaryOperation bin)
            {
                if (!TryInferDimension(bin.LeftOperand, out var left) ||
                    !TryInferDimension(bin.RightOperand, out var right))
                {
                    dim = default;
                    return false;
                }

                switch (bin.OperatorKind)
                {
                    case BinaryOperatorKind.Multiply:
                        dim = left.Add(right);
                        return true;

                    case BinaryOperatorKind.Divide:
                        dim = left.Subtract(right);
                        return true;

                    case BinaryOperatorKind.Add:
                    case BinaryOperatorKind.Subtract:
                        // For PoC: require same dimensions for +/-; otherwise "unknown" => no diagnostic
                        if (!left.StructuralEquals(right))
                        {
                            dim = default;
                            return false;
                        }
                        dim = left;
                        return true;
                }
            }

            dim = default;
            return false;
        }

        private static bool TryGetDimension(ITypeSymbol type, out DimVector dim)
        {
            // Find EngineeringUnits.UnitDimensionAttribute
            var attr = type.GetAttributes()
                .FirstOrDefault(a =>
                    a.AttributeClass?.Name == "UnitDimensionAttribute" &&
                    a.AttributeClass.ContainingNamespace.ToDisplayString() == "EngineeringUnits");

            if (attr is null)
            {
                dim = default;
                return false;
            }

            var args = attr.ConstructorArguments;

            // Build dictionary: key=BaseunitType underlying int, value=exponent
            var dict = new Dictionary<int, int>();

            for (int i = 0; i + 1 < args.Length; i += 2)
            {
                var baseUnit = (int)args[i].Value!;
                var exp = (int)args[i + 1].Value!;

                dict[baseUnit] = dict.TryGetValue(baseUnit, out var cur) ? cur + exp : exp;
                if (dict[baseUnit] == 0)
                    dict.Remove(baseUnit);
            }

            dim = DimVector.From(dict);
            return true;
        }

        // ---------- DimVector: canonical representation + keys ----------

        private readonly struct DimVector
        {
            // Always sorted, and no zero exponents.
            private readonly ImmutableArray<(int Unit, int Exp)> _terms;
            private readonly int _hash;

            private DimVector(ImmutableArray<(int Unit, int Exp)> terms)
            {
                _terms = terms;

                unchecked
                {
                    int h = 17;
                    foreach (var (u, e) in _terms)
                    {
                        h = (h * 31) + u;
                        h = (h * 31) + e;
                    }
                    _hash = h;
                }
            }

            public static DimVector Dimensionless()
                => new(ImmutableArray<(int, int)>.Empty);

            public static DimVector From(Dictionary<int, int> dict)
            {
                var terms = dict
                    .Where(kv => kv.Value != 0)
                    .OrderBy(kv => kv.Key)
                    .Select(kv => (kv.Key, kv.Value))
                    .ToImmutableArray();

                return new DimVector(terms);
            }

            // ✅ HERE IS THE FIX: Exps property for SiUnitFormatter
            public Dictionary<int, int> Exps
                => _terms.ToDictionary(t => t.Unit, t => t.Exp);

            public DimVector Add(DimVector other) => Combine(other, +1);
            public DimVector Subtract(DimVector other) => Combine(other, -1);

            private DimVector Combine(DimVector other, int sign)
            {
                var d = _terms.ToDictionary(t => t.Unit, t => t.Exp);
                foreach (var (unit, exp) in other._terms)
                {
                    var v = sign * exp;
                    d[unit] = d.TryGetValue(unit, out var cur) ? cur + v : v;
                    if (d[unit] == 0)
                        d.Remove(unit);
                }
                return From(d);
            }

            public bool StructuralEquals(DimVector other)
                => _terms.Length == other._terms.Length &&
                   _terms.AsSpan().SequenceEqual(other._terms.AsSpan());

            public override int GetHashCode() => _hash;

            public string ToKey()
                => _terms.Length == 0
                    ? "1"
                    : string.Join("|", _terms.Select(t => $"{t.Unit}:{t.Exp}"));

            public string ToDisplayString()
                => _terms.Length == 0
                    ? "1"
                    : string.Join("·", _terms.Select(t => t.Exp == 1 ? $"U{t.Unit}" : $"U{t.Unit}^{t.Exp}"));
        }
    }
}