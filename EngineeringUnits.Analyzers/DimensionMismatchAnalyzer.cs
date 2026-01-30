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
        public const string DiagnosticId_Conversion = "EU0001";
        public const string DiagnosticId_AddSubtract = "EU0002";

        // EU0001: conversion mismatch (your existing behavior)
        private static readonly DiagnosticDescriptor ConversionRule = new(
            id: DiagnosticId_Conversion,
            title: "EngineeringUnits unit mismatch",
            messageFormat: "This is NOT a [{0}] as expected! Your Unit is a [{1}].",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        // EU0002: add/subtract mismatch (new)
        private static readonly DiagnosticDescriptor AddSubtractRule = new(
            id: DiagnosticId_AddSubtract,
            title: "EngineeringUnits can't add/subtract different units",
            messageFormat: "Trying to do [{0}] {2} [{1}]. Can't add/subtract two different units!",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            => ImmutableArray.Create(ConversionRule, AddSubtractRule);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();

            // Cache enum -> name map once per compilation for formatting
            context.RegisterCompilationStartAction(startContext =>
            {
                var enumValueToName = SiUnitFormatter.BuildEnumValueToNameMap(startContext.Compilation);

                // EU0001: conversion checks (UnknownUnit -> Quantity via op_Implicit)
                startContext.RegisterOperationAction(opContext =>
                {
                    AnalyzeConversion(opContext, enumValueToName);
                }, OperationKind.Conversion);

                // EU0002: binary operator checks for + and -
                startContext.RegisterOperationAction(opContext =>
                {
                    AnalyzeAddSubtract(opContext, enumValueToName);
                }, OperationKind.Binary);
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

            var expectedSi = SiUnitFormatter.FormatAsSi(expected.Exps, enumValueToName);
            var actualSi = SiUnitFormatter.FormatAsSi(actual.Exps, enumValueToName);

            if (expected.ToKey() != actual.ToKey())
            {
                context.ReportDiagnostic(Diagnostic.Create(
                    ConversionRule,
                    conv.Operand.Syntax.GetLocation(),
                    expectedSi,
                    actualSi));
            }
        }

        private static void AnalyzeAddSubtract(OperationAnalysisContext context, Dictionary<int, string> enumValueToName)
        {
            var bin = (IBinaryOperation)context.Operation;

            // Only + and -
            if (bin.OperatorKind is not BinaryOperatorKind.Add and not BinaryOperatorKind.Subtract)
                return;

            // Infer both sides
            if (!TryInferDimension(bin.LeftOperand, out var left))
                return;

            if (!TryInferDimension(bin.RightOperand, out var right))
                return;

            // If same dimension: OK
            if (left.ToKey() == right.ToKey())
                return;

            // Pretty format like runtime: [m³] + [kg]
            var leftSi = SiUnitFormatter.FormatAsSi(left.Exps, enumValueToName);
            var rightSi = SiUnitFormatter.FormatAsSi(right.Exps, enumValueToName);
            var opSymbol = bin.OperatorKind == BinaryOperatorKind.Add ? "+" : "-";

            // Underline the expression itself
            context.ReportDiagnostic(Diagnostic.Create(
                AddSubtractRule,
                bin.Syntax.GetLocation(),
                leftSi,
                rightSi,
                opSymbol));
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
                        // For +/-: require same dimensions to infer; otherwise "unknown"
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

        // ---------- DimVector ----------

        private readonly struct DimVector
        {
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

            // Used by SiUnitFormatter
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
