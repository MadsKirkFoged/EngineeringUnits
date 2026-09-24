using System;
using System.Collections.Concurrent;
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
        public const string EU0004 = "EU0004"; // cast to number with a unit
        public const string EU0005 = "EU0005"; // [SameDimension] arguments mismatch
        public const string EU0006 = "EU0006"; // root gives fractional units

        // Passing/returning a wrong UnknownUnit into a typed parameter or return value goes
        // through the same op_Implicit conversion, so EU0001 covers arguments and returns too.

        private const string UnitDimensionAttributeName = "EngineeringUnits.UnitDimensionAttribute";
        private const string SameDimensionAttributeName = "EngineeringUnits.SameDimensionAttribute";
        private const string DimensionOfAttributeName = "EngineeringUnits.DimensionOfAttribute";

        private static readonly DiagnosticDescriptor ConversionRule = new(
            id: EU0001,
            title: "EngineeringUnits unit mismatch",
            messageFormat: "This is NOT a [{0}] as expected, your unit is a [{1}]",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor AddSubtractRule = new(
            id: EU0002,
            title: "EngineeringUnits can't add/subtract different units",
            messageFormat: "Trying to do [{0}] {2} [{1}], can't add/subtract two different units",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor CompareRule = new(
            id: EU0003,
            title: "EngineeringUnits can't compare different units",
            messageFormat: "Trying to compare [{0}] {2} [{1}], can't compare two different units",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor NumberCastRule = new(
            id: EU0004,
            title: "EngineeringUnits can't cast a unit to a number",
            messageFormat: "Can't cast [{0}] to {1}, only values without a unit can be cast to a number",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor SameDimensionRule = new(
            id: EU0005,
            title: "EngineeringUnits arguments must have the same unit",
            messageFormat: "All values passed to '{0}' must have the same unit, got [{1}] and [{2}]",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor RootRule = new(
            id: EU0006,
            title: "EngineeringUnits root gives fractional units",
            messageFormat: "Can't take {1} of [{0}], the result would have fractional units",
            category: "EngineeringUnits",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
            => ImmutableArray.Create(ConversionRule, AddSubtractRule, CompareRule, NumberCastRule, SameDimensionRule, RootRule);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();

            context.RegisterCompilationStartAction(startContext =>
            {
                var compilation = startContext.Compilation;

                // Projects that don't reference EngineeringUnits pay nothing
                var unitDimensionType = compilation.GetTypeByMetadataName(UnitDimensionAttributeName);
                if (unitDimensionType is null)
                    return;

                // These may be missing when compiling against an older EngineeringUnits
                var inference = new DimensionInference(
                    unitDimensionType,
                    compilation.GetTypeByMetadataName(SameDimensionAttributeName),
                    compilation.GetTypeByMetadataName(DimensionOfAttributeName));

                var enumValueToName = SiUnitFormatter.BuildEnumValueToNameMap(compilation);

                startContext.RegisterOperationAction(opContext =>
                    AnalyzeConversion(opContext, inference, enumValueToName),
                    OperationKind.Conversion);

                startContext.RegisterOperationAction(opContext =>
                    AnalyzeBinary(opContext, inference, enumValueToName),
                    OperationKind.Binary);

                startContext.RegisterOperationAction(opContext =>
                    AnalyzeInvocation(opContext, inference, enumValueToName),
                    OperationKind.Invocation);
            });
        }

        // ---------------- EU0001 + EU0004: user-defined conversions ----------------
        private static void AnalyzeConversion(OperationAnalysisContext context, DimensionInference inference, Dictionary<int, string> enumValueToName)
        {
            var conv = (IConversionOperation)context.Operation;

            if (!conv.Conversion.IsUserDefined || conv.OperatorMethod is null || conv.Type is null)
                return;

            switch (conv.OperatorMethod.Name)
            {
                // EU0001: UnknownUnit -> Quantity (the generated quantity types use op_Implicit)
                case "op_Implicit":
                {
                    if (!inference.TryGetDimension(conv.Type, out var expected))
                        return;

                    if (!inference.TryInfer(conv.Operand, out var actual))
                        return;

                    if (expected.Equals(actual))
                        return;

                    context.ReportDiagnostic(Diagnostic.Create(
                        ConversionRule,
                        conv.Operand.Syntax.GetLocation(),
                        SiUnitFormatter.FormatAsSi(expected.Terms, enumValueToName),
                        SiUnitFormatter.FormatAsSi(actual.Terms, enumValueToName)));
                    return;
                }

                // EU0004: (double)unknown only works when the value has no unit
                case "op_Explicit":
                {
                    if (!DimensionInference.IsNumeric(conv.Type))
                        return;

                    if (!inference.TryInfer(conv.Operand, out var actual))
                        return;

                    if (actual.Equals(DimVector.Dimensionless))
                        return;

                    context.ReportDiagnostic(Diagnostic.Create(
                        NumberCastRule,
                        conv.Syntax.GetLocation(),
                        SiUnitFormatter.FormatAsSi(actual.Terms, enumValueToName),
                        conv.Type.ToDisplayString()));
                    return;
                }
            }
        }

        // ---------------- EU0002 + EU0003: Binary operators ----------------
        private static void AnalyzeBinary(OperationAnalysisContext context, DimensionInference inference, Dictionary<int, string> enumValueToName)
        {
            var bin = (IBinaryOperation)context.Operation;

            // Quantities only take part through user-defined operators; skips all built-in number/string math
            if (bin.OperatorMethod is null)
                return;

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
            if (!inference.TryInfer(bin.LeftOperand, out var left))
                return;
            if (!inference.TryInfer(bin.RightOperand, out var right))
                return;

            // Same dimension => OK
            if (left.Equals(right))
                return;

            var leftSi = SiUnitFormatter.FormatAsSi(left.Terms, enumValueToName);
            var rightSi = SiUnitFormatter.FormatAsSi(right.Terms, enumValueToName);

            context.ReportDiagnostic(Diagnostic.Create(
                isAddSub ? AddSubtractRule : CompareRule,
                bin.Syntax.GetLocation(),
                leftSi,
                rightSi,
                OperatorSymbol(bin.OperatorKind)));
        }

        private static string OperatorSymbol(BinaryOperatorKind kind) => kind switch
        {
            BinaryOperatorKind.Add => "+",
            BinaryOperatorKind.Subtract => "-",
            BinaryOperatorKind.LessThan => "<",
            BinaryOperatorKind.LessThanOrEqual => "<=",
            BinaryOperatorKind.GreaterThan => ">",
            BinaryOperatorKind.GreaterThanOrEqual => ">=",
            BinaryOperatorKind.Equals => "==",
            BinaryOperatorKind.NotEquals => "!=",
            _ => "?"
        };

        // ---------------- EU0005 + EU0006: method calls ----------------
        private static void AnalyzeInvocation(OperationAnalysisContext context, DimensionInference inference, Dictionary<int, string> enumValueToName)
        {
            var inv = (IInvocationOperation)context.Operation;
            var rules = inference.GetRules(inv.TargetMethod);

            if (rules.HasSameDimensionGroups)
                CheckSameDimension(context, inference, enumValueToName, inv, rules);

            if (rules.Root > 1)
                CheckRoot(context, inference, enumValueToName, inv, rules);
        }

        // EU0005: every value in a [SameDimension] group must have the same unit
        private static void CheckSameDimension(OperationAnalysisContext context, DimensionInference inference, Dictionary<int, string> enumValueToName, IInvocationOperation inv, MethodRules rules)
        {
            var groups = new Dictionary<string, List<IOperation>>(StringComparer.Ordinal);

            foreach (var arg in inv.Arguments)
            {
                if (arg.Parameter is null || arg.ArgumentKind == ArgumentKind.DefaultValue)
                    continue;

                var group = rules.SameDimensionGroups[arg.Parameter.Ordinal];
                if (group is null)
                    continue;

                if (!groups.TryGetValue(group, out var items))
                {
                    items = new List<IOperation>();

                    // On instance methods the instance belongs to the default group
                    if (group.Length == 0 && inv.Instance is not null)
                        items.Add(inv.Instance);

                    groups.Add(group, items);
                }

                items.AddRange(inference.ExpandItems(arg.Value));
            }

            foreach (var items in groups.Values)
            {
                DimVector? first = null;

                foreach (var item in items)
                {
                    if (!inference.TryInfer(item, out var dim))
                        continue;

                    if (first is null)
                    {
                        first = dim;
                        continue;
                    }

                    if (dim.Equals(first.Value))
                        continue;

                    context.ReportDiagnostic(Diagnostic.Create(
                        SameDimensionRule,
                        item.Syntax.GetLocation(),
                        inv.TargetMethod.Name,
                        SiUnitFormatter.FormatAsSi(first.Value.Terms, enumValueToName),
                        SiUnitFormatter.FormatAsSi(dim.Terms, enumValueToName)));
                }
            }
        }

        // EU0006: e.g. Sqrt of [m] would give [m^0.5]
        private static void CheckRoot(OperationAnalysisContext context, DimensionInference inference, Dictionary<int, string> enumValueToName, IInvocationOperation inv, MethodRules rules)
        {
            if (!inference.TryInferResultSource(inv, rules, out var source))
                return;

            if (source.TryRoot(rules.Root, out _))
                return;

            context.ReportDiagnostic(Diagnostic.Create(
                RootRule,
                inv.Syntax.GetLocation(),
                SiUnitFormatter.FormatAsSi(source.Terms, enumValueToName),
                rules.Root == 2 ? "the square root" : $"root {rules.Root}"));
        }

        // ---------- What the [SameDimension]/[DimensionOf] attributes say about a method ----------
        private sealed class MethodRules
        {
            public static readonly MethodRules None = new(default, null, null, 1);

            public MethodRules(ImmutableArray<string?> sameDimensionGroups, string? resultParameter, string? powerParameter, int root)
            {
                SameDimensionGroups = sameDimensionGroups;
                ResultParameter = resultParameter;
                PowerParameter = powerParameter;
                Root = root;
            }

            /// <summary>[SameDimension] group per parameter ordinal, null when the parameter isn't marked.</summary>
            public ImmutableArray<string?> SameDimensionGroups { get; }
            public bool HasSameDimensionGroups => !SameDimensionGroups.IsDefault;

            /// <summary>[DimensionOf]: the result has the unit of this parameter...</summary>
            public string? ResultParameter { get; }
            /// <summary>...raised to the value of this int parameter...</summary>
            public string? PowerParameter { get; }
            /// <summary>...and then taken this root of.</summary>
            public int Root { get; }
        }

        // ---------- Dimension inference (one instance per compilation) ----------
        private sealed class DimensionInference
        {
            private readonly INamedTypeSymbol _unitDimensionType;
            private readonly INamedTypeSymbol? _sameDimensionType;
            private readonly INamedTypeSymbol? _dimensionOfType;

            private readonly ConcurrentDictionary<ITypeSymbol, DimVector?> _typeCache = new(SymbolEqualityComparer.Default);
            private readonly ConcurrentDictionary<IMethodSymbol, MethodRules> _methodCache = new(SymbolEqualityComparer.Default);
            private readonly Func<ITypeSymbol, DimVector?> _readDimension;
            private readonly Func<IMethodSymbol, MethodRules> _readRules;

            public DimensionInference(INamedTypeSymbol unitDimensionType, INamedTypeSymbol? sameDimensionType, INamedTypeSymbol? dimensionOfType)
            {
                _unitDimensionType = unitDimensionType;
                _sameDimensionType = sameDimensionType;
                _dimensionOfType = dimensionOfType;
                _readDimension = ReadDimension;
                _readRules = ReadRules;
            }

            public bool TryInfer(IOperation op, out DimVector dim)
            {
                op = UnwrapImplicitConversions(op);

                if (op.Type is not null)
                {
                    // If expression type has [UnitDimension], use it
                    if (TryGetDimension(op.Type, out dim))
                        return true;

                    // Plain numbers (literals, variables, method results) => dimensionless
                    if (IsNumeric(op.Type))
                    {
                        dim = DimVector.Dimensionless;
                        return true;
                    }
                }

                switch (op)
                {
                    case IBinaryOperation bin:
                        return TryInferBinary(bin, out dim);

                    case IUnaryOperation { OperatorKind: UnaryOperatorKind.Plus or UnaryOperatorKind.Minus } unary:
                        return TryInfer(unary.Operand, out dim);

                    case IInvocationOperation inv:
                        return TryInferInvocation(inv, out dim);
                }

                dim = default;
                return false;
            }

            private bool TryInferBinary(IBinaryOperation bin, out DimVector dim)
            {
                dim = default;

                if (!TryInfer(bin.LeftOperand, out var left) ||
                    !TryInfer(bin.RightOperand, out var right))
                    return false;

                switch (bin.OperatorKind)
                {
                    case BinaryOperatorKind.Multiply:
                        dim = left.Multiply(right);
                        return true;

                    case BinaryOperatorKind.Divide:
                        dim = left.Divide(right);
                        return true;

                    case BinaryOperatorKind.Add:
                    case BinaryOperatorKind.Subtract:
                        // For +/-: require same dimensions to infer; otherwise unknown (reported on the inner node)
                        if (!left.Equals(right))
                            return false;
                        dim = left;
                        return true;

                    default:
                        return false;
                }
            }

            // Methods marked [return: DimensionOf(...)], e.g. a.Abs(), a.Pow(2), a.Sqrt()
            private bool TryInferInvocation(IInvocationOperation inv, out DimVector dim)
            {
                dim = default;
                var rules = GetRules(inv.TargetMethod);

                if (!TryInferResultSource(inv, rules, out var source))
                    return false;

                // Fractional result: reported as EU0006, unknown from here on
                if (rules.Root > 1 && !source.TryRoot(rules.Root, out source))
                    return false;

                dim = source;
                return true;
            }

            /// <summary>The unit a [DimensionOf] method's result is based on, before any root is taken.</summary>
            public bool TryInferResultSource(IInvocationOperation inv, MethodRules rules, out DimVector dim)
            {
                dim = default;

                if (rules.ResultParameter is null)
                    return false;

                var arg = FindArgument(inv, rules.ResultParameter);
                if (arg is null || !TryInferCommon(ExpandItems(arg.Value), out dim))
                    return false;

                if (rules.PowerParameter is not null)
                {
                    // Only a constant power tells us the resulting unit
                    var power = FindArgument(inv, rules.PowerParameter);
                    if (power?.Value.ConstantValue is not { HasValue: true, Value: int exponent })
                        return false;

                    dim = dim.Pow(exponent);
                }

                return true;
            }

            /// <summary>The values an argument stands for: elements of params arrays, array initializers and tuples, otherwise the value itself.</summary>
            public IEnumerable<IOperation> ExpandItems(IOperation value)
            {
                value = UnwrapImplicitConversions(value);

                return value switch
                {
                    IArrayCreationOperation { Initializer: { } initializer } => initializer.ElementValues,
                    ITupleOperation tuple => tuple.Elements,
                    _ => new[] { value },
                };
            }

            /// <summary>Succeeds when every value with a known unit has the same one, and at least one is known.</summary>
            private bool TryInferCommon(IEnumerable<IOperation> items, out DimVector dim)
            {
                dim = default;
                var found = false;

                foreach (var item in items)
                {
                    if (!TryInfer(item, out var itemDim))
                        continue;

                    if (!found)
                    {
                        dim = itemDim;
                        found = true;
                    }
                    else if (!itemDim.Equals(dim))
                    {
                        // Mismatch: reported as EU0005, unknown from here on
                        dim = default;
                        return false;
                    }
                }

                return found;
            }

            private static IArgumentOperation? FindArgument(IInvocationOperation inv, string parameterName)
            {
                foreach (var arg in inv.Arguments)
                {
                    if (arg.Parameter?.Name == parameterName)
                        return arg;
                }

                return null;
            }

            // Unwrap implicit conversions like Volume -> BaseUnit or int -> double?
            private static IOperation UnwrapImplicitConversions(IOperation op)
            {
                while (op is IConversionOperation { IsImplicit: true } c)
                    op = c.Operand;

                return op;
            }

            public bool TryGetDimension(ITypeSymbol type, out DimVector dim)
            {
                var cached = _typeCache.GetOrAdd(type, _readDimension);
                dim = cached.GetValueOrDefault();
                return cached.HasValue;
            }

            private DimVector? ReadDimension(ITypeSymbol type)
            {
                foreach (var attr in type.GetAttributes())
                {
                    if (!SymbolEqualityComparer.Default.Equals(attr.AttributeClass, _unitDimensionType))
                        continue;

                    // Constructor arguments are flat pairs: (BaseunitType, exponent) repeated
                    var args = attr.ConstructorArguments;
                    var terms = new List<(int BaseUnit, int Exponent)>();

                    for (int i = 0; i + 1 < args.Length; i += 2)
                    {
                        if (args[i].Value is int baseUnit && args[i + 1].Value is int exp)
                            terms.Add((baseUnit, exp));
                    }

                    return DimVector.From(terms);
                }

                return null;
            }

            public MethodRules GetRules(IMethodSymbol method)
                => _methodCache.GetOrAdd(method.OriginalDefinition, _readRules);

            private MethodRules ReadRules(IMethodSymbol method)
            {
                string? resultParameter = null;
                string? powerParameter = null;
                var root = 1;

                if (_dimensionOfType is not null)
                {
                    foreach (var attr in method.GetReturnTypeAttributes())
                    {
                        if (!SymbolEqualityComparer.Default.Equals(attr.AttributeClass, _dimensionOfType) ||
                            attr.ConstructorArguments.Length != 1)
                            continue;

                        resultParameter = attr.ConstructorArguments[0].Value as string;

                        foreach (var named in attr.NamedArguments)
                        {
                            if (named.Key == "PowerParameter")
                                powerParameter = named.Value.Value as string;
                            else if (named.Key == "Root" && named.Value.Value is int r && r > 0)
                                root = r;
                        }
                    }
                }

                string?[]? groups = null;

                if (_sameDimensionType is not null)
                {
                    foreach (var parameter in method.Parameters)
                    {
                        foreach (var attr in parameter.GetAttributes())
                        {
                            if (!SymbolEqualityComparer.Default.Equals(attr.AttributeClass, _sameDimensionType))
                                continue;

                            groups ??= new string?[method.Parameters.Length];
                            groups[parameter.Ordinal] = attr.ConstructorArguments.Length == 1
                                ? attr.ConstructorArguments[0].Value as string ?? ""
                                : "";
                        }
                    }
                }

                if (resultParameter is null && groups is null)
                    return MethodRules.None;

                return new MethodRules(
                    groups is null ? default : groups.ToImmutableArray(),
                    resultParameter,
                    powerParameter,
                    root);
            }

            public static bool IsNumeric(ITypeSymbol type)
            {
                if (type is INamedTypeSymbol { OriginalDefinition.SpecialType: SpecialType.System_Nullable_T } nullable)
                    type = nullable.TypeArguments[0];

                return type.SpecialType is SpecialType.System_SByte or SpecialType.System_Byte
                    or SpecialType.System_Int16 or SpecialType.System_UInt16
                    or SpecialType.System_Int32 or SpecialType.System_UInt32
                    or SpecialType.System_Int64 or SpecialType.System_UInt64
                    or SpecialType.System_Single or SpecialType.System_Double
                    or SpecialType.System_Decimal;
            }
        }

        // ---------- DimVector: sorted (base unit, exponent) terms without zero exponents ----------
        private readonly struct DimVector : IEquatable<DimVector>
        {
            private static readonly ImmutableArray<(int BaseUnit, int Exponent)> Empty = ImmutableArray<(int, int)>.Empty;

            public static readonly DimVector Dimensionless = new(Empty);

            private readonly ImmutableArray<(int BaseUnit, int Exponent)> _terms;

            private DimVector(ImmutableArray<(int BaseUnit, int Exponent)> terms) => _terms = terms;

            public ImmutableArray<(int BaseUnit, int Exponent)> Terms => _terms.IsDefault ? Empty : _terms;

            public static DimVector From(IEnumerable<(int BaseUnit, int Exponent)> terms)
            {
                var sums = new SortedDictionary<int, int>();
                foreach (var (unit, exp) in terms)
                    sums[unit] = sums.TryGetValue(unit, out var cur) ? cur + exp : exp;

                var builder = ImmutableArray.CreateBuilder<(int, int)>(sums.Count);
                foreach (var kv in sums)
                {
                    if (kv.Value != 0)
                        builder.Add((kv.Key, kv.Value));
                }

                return new DimVector(builder.ToImmutable());
            }

            public DimVector Multiply(DimVector other) => From(Concat(Terms, other.Terms, +1));
            public DimVector Divide(DimVector other) => From(Concat(Terms, other.Terms, -1));

            public DimVector Pow(int power) => From(Terms.Select(t => (t.BaseUnit, t.Exponent * power)));

            /// <summary>Fails when an exponent isn't divisible by <paramref name="root"/>.</summary>
            public bool TryRoot(int root, out DimVector result)
            {
                foreach (var t in Terms)
                {
                    if (t.Exponent % root != 0)
                    {
                        result = default;
                        return false;
                    }
                }

                result = From(Terms.Select(t => (t.BaseUnit, t.Exponent / root)));
                return true;
            }

            private static IEnumerable<(int, int)> Concat(ImmutableArray<(int BaseUnit, int Exponent)> left, ImmutableArray<(int BaseUnit, int Exponent)> right, int sign)
            {
                foreach (var t in left)
                    yield return t;
                foreach (var (unit, exp) in right)
                    yield return (unit, sign * exp);
            }

            public bool Equals(DimVector other)
            {
                var a = Terms;
                var b = other.Terms;

                if (a.Length != b.Length)
                    return false;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                        return false;
                }

                return true;
            }

            public override bool Equals(object? obj) => obj is DimVector other && Equals(other);

            public override int GetHashCode()
            {
                unchecked
                {
                    int h = 17;
                    foreach (var (unit, exp) in Terms)
                        h = (h * 31 + unit) * 31 + exp;
                    return h;
                }
            }
        }
    }
}
