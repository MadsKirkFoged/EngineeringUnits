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
        public const string EU0001 = "EU0001"; // conversion mismatch
        public const string EU0002 = "EU0002"; // add/sub mismatch
        public const string EU0003 = "EU0003"; // compare mismatch
        //public const string EU0004 = "EU0004"; // argument mismatch
        //public const string EU0005 = "EU0005"; // return mismatch

        private static readonly DiagnosticDescriptor ConversionRule = new(
            id: EU0001,
            title: "EngineeringUnits unit mismatch",
            messageFormat: "This is NOT a [{0}] as expected! Your Unit is a [{1}].",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor AddSubtractRule = new(
            id: EU0002,
            title: "EngineeringUnits can't add/subtract different units",
            messageFormat: "Trying to do [{0}] {2} [{1}]. Can't add/subtract two different units!",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor CompareRule = new(
            id: EU0003,
            title: "EngineeringUnits can't compare different units",
            messageFormat: "Trying to compare [{0}] {2} [{1}]. Can't compare two different units!",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        //private static readonly DiagnosticDescriptor ArgumentRule = new(
        //    id: EU0004,
        //    title: "EngineeringUnits argument unit mismatch",
        //    messageFormat: "This is NOT a [{0}] as expected! Your Unit is a [{1}]",
        //    category: "EngineeringUnits",
        //    defaultSeverity: DiagnosticSeverity.Warning,
        //    isEnabledByDefault: true);

        //private static readonly DiagnosticDescriptor ReturnRule = new(
        //    id: EU0005,
        //    title: "EngineeringUnits return unit mismatch",
        //    messageFormat: "This is NOT a [{0}] as expected! Your Unit is a [{1}]",
        //    category: "EngineeringUnits",
        //    defaultSeverity: DiagnosticSeverity.Warning,
        //    isEnabledByDefault: true);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            => ImmutableArray.Create(ConversionRule, AddSubtractRule, CompareRule);//, ArgumentRule, ReturnRule);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();

            // Build enum value->name map once per compilation for SI formatting
            context.RegisterCompilationStartAction(startContext =>
            {
                var enumValueToName = SiUnitFormatter.BuildEnumValueToNameMap(startContext.Compilation);

                startContext.RegisterOperationAction(opContext =>
                    AnalyzeConversion(opContext, enumValueToName),
                    OperationKind.Conversion);

                startContext.RegisterOperationAction(opContext =>
                    AnalyzeBinary(opContext, enumValueToName),
                    OperationKind.Binary);

                //startContext.RegisterOperationAction(opContext =>
                //    AnalyzeArgument(opContext, enumValueToName),
                //    OperationKind.Argument);

                //startContext.RegisterOperationAction(opContext =>
                //    AnalyzeReturn(opContext, enumValueToName),
                //    OperationKind.Return);
            });
        }

        // ---------------- EU0001: UnknownUnit -> Quantity implicit conversion ----------------
        private static void AnalyzeConversion(OperationAnalysisContext context, Dictionary<int, string> enumValueToName)
        {
            var conv = (IConversionOperation)context.Operation;

            if (!conv.Conversion.IsUserDefined)
                return;

            // Your generated code uses user-defined implicit conversions (op_Implicit)
            if (conv.OperatorMethod is null || conv.OperatorMethod.Name != "op_Implicit")
                return;

            if (conv.Type is null)
                return;

            if (!TryGetDimension(conv.Type, out var expected))
                return;

            if (!TryInferDimension(conv.Operand, out var actual))
                return;

            if (expected.ToKey() == actual.ToKey())
                return;

            var expectedSi = SiUnitFormatter.FormatAsSi(expected.Exps, enumValueToName);
            var actualSi = SiUnitFormatter.FormatAsSi(actual.Exps, enumValueToName);

            context.ReportDiagnostic(Diagnostic.Create(
                ConversionRule,
                conv.Operand.Syntax.GetLocation(),
                expectedSi,
                actualSi));
        }

        // ---------------- EU0002 + EU0003: Binary operators ----------------
        private static void AnalyzeBinary(OperationAnalysisContext context, Dictionary<int, string> enumValueToName)
        {
            var bin = (IBinaryOperation)context.Operation;

            // We handle: +, -, and comparisons (<, >, <=, >=, ==, !=)
            var isAddSub = bin.OperatorKind is BinaryOperatorKind.Add or BinaryOperatorKind.Subtract;

            var isCompare =
                bin.OperatorKind is BinaryOperatorKind.LessThan
                                or BinaryOperatorKind.LessThanOrEqual
                                or BinaryOperatorKind.GreaterThan
                                or BinaryOperatorKind.GreaterThanOrEqual
                                or BinaryOperatorKind.Equals
                                or BinaryOperatorKind.NotEquals;

            if (!isAddSub && !isCompare)
                return;

            // Infer both sides (if unknown => no diagnostic to avoid noise)
            if (!TryInferDimension(bin.LeftOperand, out var left))
                return;
            if (!TryInferDimension(bin.RightOperand, out var right))
                return;

            // Same dimension => OK
            if (left.ToKey() == right.ToKey())
                return;

            var leftSi = SiUnitFormatter.FormatAsSi(left.Exps, enumValueToName);
            var rightSi = SiUnitFormatter.FormatAsSi(right.Exps, enumValueToName);

            if (isAddSub)
            {
                var opSymbol = bin.OperatorKind == BinaryOperatorKind.Add ? "+" : "-";
                context.ReportDiagnostic(Diagnostic.Create(
                    AddSubtractRule,
                    bin.Syntax.GetLocation(),
                    leftSi,
                    rightSi,
                    opSymbol));
            }
            else
            {
                var opSymbol = OperatorSymbol(bin.OperatorKind);
                context.ReportDiagnostic(Diagnostic.Create(
                    CompareRule,
                    bin.Syntax.GetLocation(),
                    leftSi,
                    rightSi,
                    opSymbol));
            }
        }

        private static string OperatorSymbol(BinaryOperatorKind kind) => kind switch
        {
            BinaryOperatorKind.LessThan => "<",
            BinaryOperatorKind.LessThanOrEqual => "<=",
            BinaryOperatorKind.GreaterThan => ">",
            BinaryOperatorKind.GreaterThanOrEqual => ">=",
            BinaryOperatorKind.Equals => "==",
            BinaryOperatorKind.NotEquals => "!=",
            _ => "?"
        };

        // ---------------- EU0004: Argument mismatch ----------------
        //private static void AnalyzeArgument(OperationAnalysisContext context, Dictionary<int, string> enumValueToName)
        //{
        //    var arg = (IArgumentOperation)context.Operation;

        //    // Parameter type must be a known quantity type (has UnitDimension)
        //    var paramType = arg.Parameter?.Type;
        //    if (paramType is null)
        //        return;

        //    if (!TryGetDimension(paramType, out var expected))
        //        return;

        //    // Infer actual dimension from the passed expression
        //    if (!TryInferDimension(arg.Value, out var actual))
        //        return;

        //    if (expected.ToKey() == actual.ToKey())
        //        return;

        //    var expectedSi = SiUnitFormatter.FormatAsSi(expected.Exps, enumValueToName);
        //    var actualSi = SiUnitFormatter.FormatAsSi(actual.Exps, enumValueToName);

        //    context.ReportDiagnostic(Diagnostic.Create(
        //        ArgumentRule,
        //        arg.Value.Syntax.GetLocation(),
        //        expectedSi,
        //        actualSi));
        //}

        // ---------------- EU0005: Return mismatch ----------------
        // ---------------- EU0005: Return mismatch ----------------
        //private static void AnalyzeReturn(OperationAnalysisContext context, Dictionary<int, string> enumValueToName)
        //{
        //    var ret = (IReturnOperation)context.Operation;

        //    // Nothing returned (e.g., "return;" in void method)
        //    if (ret.ReturnedValue is null)
        //        return;

        //    // The containing symbol for both methods and local functions is IMethodSymbol
        //    if (context.ContainingSymbol is not IMethodSymbol method)
        //        return;

        //    // Ignore void returns
        //    if (method.ReturnsVoid)
        //        return;

        //    var returnType = method.ReturnType;

        //    // Only care about return types that are dimensioned quantities
        //    if (!TryGetDimension(returnType, out var expected))
        //        return;

        //    if (!TryInferDimension(ret.ReturnedValue, out var actual))
        //        return;

        //    if (expected.ToKey() == actual.ToKey())
        //        return;

        //    var expectedSi = SiUnitFormatter.FormatAsSi(expected.Exps, enumValueToName);
        //    var actualSi = SiUnitFormatter.FormatAsSi(actual.Exps, enumValueToName);

        //    context.ReportDiagnostic(Diagnostic.Create(
        //        ReturnRule,
        //        ret.ReturnedValue.Syntax.GetLocation(),
        //        expectedSi,
        //        actualSi));
        //}

        // ---------- Dimension inference (same as your PoC, with + - requiring equal dims) ----------
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
                        // For +/-: require same dimensions to infer; otherwise unknown
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