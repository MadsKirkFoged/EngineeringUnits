using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace EngineeringUnits.Analyzers.Fast;

/// <summary>
/// Unit checking for EngineeringUnits.Fast.<br></br>
/// Unlike the EngineeringUnits analyzer this one is FAIL-CLOSED: at runtime a Fast quantity is only a double, so there
/// is no exception to fall back on. Whenever the dimension of a value can't be proven it reports EUF0007 instead of
/// staying silent.
/// </summary>
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class FastDimensionAnalyzer : DiagnosticAnalyzer
{
    public const string EUF0001 = "EUF0001"; // conversion / write mismatch
    public const string EUF0002 = "EUF0002"; // add/sub mismatch
    public const string EUF0003 = "EUF0003"; // compare mismatch
    public const string EUF0004 = "EUF0004"; // cast to number with a unit
    public const string EUF0005 = "EUF0005"; // [SameDimension] mismatch
    public const string EUF0006 = "EUF0006"; // root gives fractional units
    public const string EUF0007 = "EUF0007"; // can't verify (fail closed)
    public const string EUF0008 = "EUF0008"; // dynamic

    internal const string Namespace = "EngineeringUnits.Fast";
    private const string UnitDimensionAttributeName = Namespace + ".UnitDimensionAttribute";
    private const string SameDimensionAttributeName = Namespace + ".SameDimensionAttribute";
    private const string DimensionOfAttributeName = Namespace + ".DimensionOfAttribute";
    private const string UnknownTypeName = Namespace + ".UnknownUnit";
    private const string Category = "EngineeringUnits.Fast";

    private static readonly DiagnosticDescriptor ConversionRule = new(EUF0001,
        "EngineeringUnits.Fast unit mismatch",
        "This is NOT a [{0}] as expected, your unit is a [{1}]",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor AddSubtractRule = new(EUF0002,
        "EngineeringUnits.Fast can't add/subtract different units",
        "Trying to do [{0}] {2} [{1}], can't add/subtract two different units",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor CompareRule = new(EUF0003,
        "EngineeringUnits.Fast can't compare different units",
        "Trying to compare [{0}] {2} [{1}], can't compare two different units",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor NumberCastRule = new(EUF0004,
        "EngineeringUnits.Fast can't cast a unit to a number",
        "Can't cast [{0}] to {1}, only values without a unit can be cast to a number",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor SameDimensionRule = new(EUF0005,
        "EngineeringUnits.Fast arguments must have the same unit",
        "All values passed to '{0}' must have the same unit, got [{1}] and [{2}]",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor RootRule = new(EUF0006,
        "EngineeringUnits.Fast root gives fractional units",
        "Can't take {1} of [{0}], the result would have fractional units",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor UnverifiedRule = new(EUF0007,
        "EngineeringUnits.Fast can't verify the unit",
        "Can't verify the unit (expected [{0}]): {1}",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true,
        description: "EngineeringUnits.Fast has no runtime unit checks, so a value whose unit the analyzer can't follow is an error. Keep UnknownUnit values inside expressions or locals, or use a named quantity (Power, Length, ...) or [UnitDimension] where they are stored.");

    private static readonly DiagnosticDescriptor DynamicRule = new(EUF0008,
        "EngineeringUnits.Fast quantities can't go through dynamic",
        "'dynamic' hides the unit from the analyzer and Fast has no runtime check - use a named quantity instead",
        Category, DiagnosticSeverity.Error, isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(
        ConversionRule, AddSubtractRule, CompareRule, NumberCastRule, SameDimensionRule, RootRule, UnverifiedRule, DynamicRule);

    public override void Initialize(AnalysisContext context)
    {
        // Generated code is checked too: there is no runtime check to catch what we skip
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
        context.EnableConcurrentExecution();

        context.RegisterCompilationStartAction(start =>
        {
            var compilation = start.Compilation;

            // Projects that don't reference EngineeringUnits.Fast pay nothing
            var unitDimension = compilation.GetTypeByMetadataName(UnitDimensionAttributeName);
            var unknown = compilation.GetTypeByMetadataName(UnknownTypeName);
            if (unitDimension is null || unknown is null)
                return;

            var names = SiUnitFormatter.BuildEnumValueToNameMap(compilation);
            var a = new Analysis(new Inference(
                unitDimension,
                unknown,
                compilation.GetTypeByMetadataName(SameDimensionAttributeName),
                compilation.GetTypeByMetadataName(DimensionOfAttributeName)), names);

            start.RegisterOperationAction(a.AnalyzeConversion, OperationKind.Conversion);
            start.RegisterOperationAction(a.AnalyzeBinary, OperationKind.Binary);
            start.RegisterOperationAction(a.AnalyzeCompound, OperationKind.CompoundAssignment);
            start.RegisterOperationAction(a.AnalyzeInvocation, OperationKind.Invocation);
            start.RegisterOperationAction(a.AnalyzeObjectCreation, OperationKind.ObjectCreation);
            start.RegisterOperationAction(a.AnalyzeSimpleAssignment, OperationKind.SimpleAssignment);
            start.RegisterOperationAction(a.AnalyzeFieldInitializer, OperationKind.FieldInitializer);
            start.RegisterOperationAction(a.AnalyzePropertyInitializer, OperationKind.PropertyInitializer);
            start.RegisterOperationAction(a.AnalyzeArgument, OperationKind.Argument);
            start.RegisterOperationAction(a.AnalyzeReturn, OperationKind.Return);
            start.RegisterOperationAction(a.AnalyzeDeconstruction, OperationKind.DeconstructionAssignment);
        });
    }

    // ======================================================================================================
    // Checks
    // ======================================================================================================
    private sealed class Analysis(Inference inference, Dictionary<int, string> names)
    {
        private string Si(DimVector d) => SiUnitFormatter.FormatAsSi(d.Terms, names);

        private void Report(OperationAnalysisContext c, DiagnosticDescriptor rule, IOperation at, params object[] args)
            => c.ReportDiagnostic(Diagnostic.Create(rule, at.Syntax.GetLocation(), args));

        /// <summary>A value goes into a place with a known dimension: EUF0001 on mismatch, EUF0007 when unprovable.</summary>
        private void CheckValue(OperationAnalysisContext c, DimVector expected, IOperation value)
        {
            var r = inference.Infer(value);
            switch (r.Kind)
            {
                case Kind.Known when !r.Dim.Equals(expected):
                    Report(c, ConversionRule, value, Si(expected), Si(r.Dim));
                    break;
                case Kind.Unknown:
                    Report(c, UnverifiedRule, value, Si(expected), r.Why!);
                    break;
            }
        }

        // ---------------- EUF0001, EUF0004, EUF0008: conversions ----------------
        public void AnalyzeConversion(OperationAnalysisContext c)
        {
            var conv = (IConversionOperation)c.Operation;
            if (conv.Type is null || conv.Operand.Type is null)
                return;

            // EUF0008: dynamic in or out of the Fast world
            if (conv.Operand.Type.TypeKind == TypeKind.Dynamic && inference.IsFastType(conv.Type))
            {
                Report(c, DynamicRule, conv.Operand);
                return;
            }
            if (conv.Type.TypeKind == TypeKind.Dynamic && inference.IsUnknown(conv.Operand.Type))
            {
                Report(c, DynamicRule, conv.Operand);
                return;
            }

            if (!conv.Conversion.IsUserDefined || conv.OperatorMethod is null)
                return;

            switch (conv.OperatorMethod.Name)
            {
                // EUF0001: UnknownUnit -> quantity
                case "op_Implicit":
                    if (!inference.IsUnknown(conv.Operand.Type) || !inference.TryGetTypeDimension(conv.Type, out var expected))
                        return;
                    CheckValue(c, expected, conv.Operand);
                    return;

                // EUF0004: (double)unknown only works when the value has no unit
                case "op_Explicit":
                    if (!Inference.IsNumeric(conv.Type) || !inference.IsUnknown(conv.Operand.Type))
                        return;

                    var r = inference.Infer(conv.Operand);
                    if (r.Kind == Kind.Known && !r.Dim.Equals(DimVector.Dimensionless))
                        Report(c, NumberCastRule, conv, Si(r.Dim), conv.Type.ToDisplayString());
                    else if (r.Kind == Kind.Unknown)
                        Report(c, UnverifiedRule, conv.Operand, "1", r.Why!);
                    return;
            }
        }

        // ---------------- EUF0002 + EUF0003: binary operators ----------------
        public void AnalyzeBinary(OperationAnalysisContext c)
        {
            var bin = (IBinaryOperation)c.Operation;
            if (!inference.IsFastOperator(bin.OperatorMethod) || !inference.TakesOnlyUnitValues(bin.OperatorMethod!))
                return;

            var isAddSub = bin.OperatorKind is BinaryOperatorKind.Add or BinaryOperatorKind.Subtract;
            var isCompare = bin.OperatorKind is BinaryOperatorKind.LessThan or BinaryOperatorKind.LessThanOrEqual
                or BinaryOperatorKind.GreaterThan or BinaryOperatorKind.GreaterThanOrEqual
                or BinaryOperatorKind.Equals or BinaryOperatorKind.NotEquals;

            if (!isAddSub && !isCompare)
                return;

            var left = inference.Infer(bin.LeftOperand);
            var right = inference.Infer(bin.RightOperand);

            if (left.Kind == Kind.Reported || right.Kind == Kind.Reported)
                return;

            if (left.Kind == Kind.Unknown || right.Kind == Kind.Unknown)
            {
                var (unknownSide, other) = left.Kind == Kind.Unknown ? (left, right) : (right, left);
                var operand = left.Kind == Kind.Unknown ? bin.LeftOperand : bin.RightOperand;
                Report(c, UnverifiedRule, operand, other.Kind == Kind.Known ? Si(other.Dim) : "?", unknownSide.Why!);
                return;
            }

            if (left.Dim.Equals(right.Dim))
                return;

            Report(c, isAddSub ? AddSubtractRule : CompareRule, bin, Si(left.Dim), Si(right.Dim), OperatorSymbol(bin.OperatorKind));
        }

        // ---------------- q += x, q -= x, q *= x, q /= x ----------------
        public void AnalyzeCompound(OperationAnalysisContext c)
        {
            var op = (ICompoundAssignmentOperation)c.Operation;
            if (!inference.IsFastOperator(op.OperatorMethod))
                return;

            var target = inference.Infer(op.Target);
            if (target.Kind != Kind.Known)
                return; // an UnknownUnit local that is compound-assigned is reported where it is used

            var value = inference.Infer(op.Value);
            if (value.Kind == Kind.Reported)
                return;

            switch (op.OperatorKind)
            {
                case BinaryOperatorKind.Add or BinaryOperatorKind.Subtract:
                    if (value.Kind == Kind.Unknown)
                        Report(c, UnverifiedRule, op.Value, Si(target.Dim), value.Why!);
                    else if (!value.Dim.Equals(target.Dim))
                        Report(c, AddSubtractRule, op, Si(target.Dim), Si(value.Dim), op.OperatorKind == BinaryOperatorKind.Add ? "+=" : "-=");
                    return;

                // q *= x keeps q's type, so x must be dimensionless
                case BinaryOperatorKind.Multiply or BinaryOperatorKind.Divide:
                    if (!inference.TryGetTypeDimension(op.Target.Type, out _))
                        return;
                    if (value.Kind == Kind.Unknown)
                        Report(c, UnverifiedRule, op.Value, "1", value.Why!);
                    else if (!value.Dim.Equals(DimVector.Dimensionless))
                    {
                        var result = op.OperatorKind == BinaryOperatorKind.Multiply ? target.Dim.Multiply(value.Dim) : target.Dim.Divide(value.Dim);
                        Report(c, ConversionRule, op, Si(target.Dim), Si(result));
                    }
                    return;
            }
        }

        // ---------------- EUF0005 + EUF0006: method calls ----------------
        public void AnalyzeInvocation(OperationAnalysisContext c)
        {
            var inv = (IInvocationOperation)c.Operation;
            var rules = inference.GetRules(inv.TargetMethod);

            if (rules.HasSameDimensionGroups)
                CheckSameDimension(c, inv.TargetMethod, inv.Arguments, inv.Instance, rules);

            if (rules.Root > 1)
            {
                var source = inference.InferResultSource(inv, rules);
                if (source.Kind == Kind.Known && !source.Dim.TryRoot(rules.Root, out _))
                    Report(c, RootRule, inv, Si(source.Dim), rules.Root == 2 ? "the square root" : $"root {rules.Root}");
            }

            CheckEqualsCompareTo(c, inv);
        }

        // length.Equals(mass) / length.CompareTo(mass) bind to the object overloads: false or an exception at runtime.
        // speed.Equals(density) on two Unknowns would compare raw doubles of different units - that one fails closed.
        private void CheckEqualsCompareTo(OperationAnalysisContext c, IInvocationOperation inv)
        {
            // "this" is only possible inside the Fast types themselves
            if (inv.TargetMethod.Name is not ("Equals" or "CompareTo") || inv.Instance is null or IInstanceReferenceOperation || inv.Arguments.Length != 1 || inv.TargetMethod.IsStatic)
                return;
            if (!inference.IsFastType(inv.Instance.Type))
                return;

            var arg = inv.Arguments[0].Value;
            var left = inference.Infer(inv.Instance);
            var right = inference.Infer(arg);
            if (left.Kind == Kind.Reported || right.Kind == Kind.Reported)
                return;

            if (left.Kind == Kind.Known && right.Kind == Kind.Known)
            {
                if (!left.Dim.Equals(right.Dim))
                    Report(c, CompareRule, inv, Si(left.Dim), Si(right.Dim), inv.TargetMethod.Name);
                return;
            }

            // Only an UnknownUnit on either side can give a wrong answer; a typed Equals(object) checks the type at runtime
            if (inference.IsUnknown(inv.Instance.Type) || inference.IsUnknown(inference.Unwrap(arg).Type))
            {
                var unknownSide = left.Kind == Kind.Unknown ? left : right;
                var at = left.Kind == Kind.Unknown ? inv.Instance : arg;
                Report(c, UnverifiedRule, at, left.Kind == Kind.Known ? Si(left.Dim) : right.Kind == Kind.Known ? Si(right.Dim) : "?", unknownSide.Why!);
            }
        }

        // new ReportLine(value, unit) - [SameDimension] on constructor parameters
        public void AnalyzeObjectCreation(OperationAnalysisContext c)
        {
            var create = (IObjectCreationOperation)c.Operation;
            if (create.Constructor is null)
                return;

            var rules = inference.GetRules(create.Constructor);
            if (rules.HasSameDimensionGroups)
                CheckSameDimension(c, create.Constructor, create.Arguments, null, rules);
        }

        private void CheckSameDimension(OperationAnalysisContext c, IMethodSymbol method, ImmutableArray<IArgumentOperation> arguments, IOperation? instance, MethodRules rules)
        {
            var groups = new Dictionary<string, List<IOperation>>(StringComparer.Ordinal);

            foreach (var arg in arguments)
            {
                if (arg.Parameter is null || arg.ArgumentKind == ArgumentKind.DefaultValue)
                    continue;

                var group = rules.SameDimensionGroups[arg.Parameter.Ordinal];
                if (group is null)
                    continue;

                if (!groups.TryGetValue(group, out var items))
                {
                    items = [];
                    if (group.Length == 0 && instance is not null)
                        items.Add(instance);
                    groups.Add(group, items);
                }

                items.AddRange(inference.ExpandItems(arg.Value));
            }

            foreach (var items in groups.Values)
            {
                DimVector? first = null;
                foreach (var item in items)
                {
                    var r = inference.Infer(item);
                    if (r.Kind == Kind.Unknown)
                    {
                        Report(c, UnverifiedRule, item, first is null ? "?" : Si(first.Value), r.Why!);
                        continue;
                    }
                    if (r.Kind != Kind.Known)
                        continue;

                    if (first is null)
                        first = r.Dim;
                    else if (!r.Dim.Equals(first.Value))
                        Report(c, SameDimensionRule, item, method.Name == ".ctor" ? method.ContainingType.Name : method.Name, Si(first.Value), Si(r.Dim));
                }
            }
        }

        // ---------------- Writes into [UnitDimension] fields, properties, parameters, return values ----------------
        public void AnalyzeSimpleAssignment(OperationAnalysisContext c)
        {
            var asg = (ISimpleAssignmentOperation)c.Operation;
            if (inference.TryGetDeclaredDimension(asg.Target, out var expected))
                CheckValue(c, expected, asg.Value);
        }

        public void AnalyzeFieldInitializer(OperationAnalysisContext c)
        {
            var init = (IFieldInitializerOperation)c.Operation;
            foreach (var field in init.InitializedFields)
            {
                if (inference.IsUnknown(field.Type) && inference.TryGetAttributeDimension(field.GetAttributes(), out var expected))
                    CheckValue(c, expected, init.Value);
            }
        }

        public void AnalyzePropertyInitializer(OperationAnalysisContext c)
        {
            var init = (IPropertyInitializerOperation)c.Operation;
            foreach (var prop in init.InitializedProperties)
            {
                if (inference.IsUnknown(prop.Type) && inference.TryGetAttributeDimension(prop.GetAttributes(), out var expected))
                    CheckValue(c, expected, init.Value);
            }
        }

        public void AnalyzeArgument(OperationAnalysisContext c)
        {
            var arg = (IArgumentOperation)c.Operation;
            if (arg.Parameter is null || arg.ArgumentKind == ArgumentKind.DefaultValue || !inference.IsUnknown(arg.Parameter.Type))
                return;

            // Foo(ref _power): the callee can write any unit into a [UnitDimension] member
            if (arg.Parameter.RefKind is RefKind.Ref or RefKind.Out && inference.TryGetDeclaredDimension(arg.Value, out var member))
            {
                Report(c, UnverifiedRule, arg.Value, Si(member), "a [UnitDimension] value can't be passed by ref/out - the method could write any unit into it");
                return;
            }

            if (inference.TryGetAttributeDimension(arg.Parameter.GetAttributes(), out var expected))
                CheckValue(c, expected, arg.Value);
        }

        // (_power, _other) = (a, b): checked element by element when both sides are tuples
        public void AnalyzeDeconstruction(OperationAnalysisContext c)
        {
            var dec = (IDeconstructionAssignmentOperation)c.Operation;
            var targets = Flatten(dec.Target);
            var values = Flatten(inference.Unwrap(dec.Value));

            for (int i = 0; i < targets.Count; i++)
            {
                if (!inference.TryGetDeclaredDimension(targets[i], out var expected))
                    continue;

                if (values.Count == targets.Count)
                    CheckValue(c, expected, values[i]);
                else
                    Report(c, UnverifiedRule, targets[i], Si(expected), "the analyzer can't follow this deconstruction - assign the value directly");
            }

            List<IOperation> Flatten(IOperation op) => op is ITupleOperation t
                ? t.Elements.SelectMany(e => Flatten(inference.Unwrap(e))).ToList()
                : [op];
        }

        public void AnalyzeReturn(OperationAnalysisContext c)
        {
            var ret = (IReturnOperation)c.Operation;
            if (ret.ReturnedValue is null || ret.Kind == OperationKind.YieldReturn)
                return;

            // Which method does this return belong to? Lambdas can't be annotated, local functions can
            IMethodSymbol? method = c.ContainingSymbol as IMethodSymbol;
            for (var p = ret.Parent; p is not null; p = p.Parent)
            {
                if (p is IAnonymousFunctionOperation) return;
                if (p is ILocalFunctionOperation lf) { method = lf.Symbol; break; }
            }

            if (method is null || !inference.IsUnknown(method.ReturnType))
                return;

            if (inference.TryGetAttributeDimension(method.GetReturnTypeAttributes(), out var expected) ||
                (method.AssociatedSymbol is IPropertySymbol prop && inference.TryGetAttributeDimension(prop.GetAttributes(), out expected)))
                CheckValue(c, expected, ret.ReturnedValue);
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
    }

    // ======================================================================================================
    // Inference
    // ======================================================================================================
    internal enum Kind
    {
        /// <summary>The dimension is proven.</summary>
        Known,
        /// <summary>Can't be proven - the caller reports EUF0007 with <see cref="Inferred.Why"/>.</summary>
        Unknown,
        /// <summary>An error was already reported inside this expression - don't pile on.</summary>
        Reported,
    }

    internal readonly struct Inferred
    {
        private Inferred(Kind kind, DimVector dim, string? why) { Kind = kind; Dim = dim; Why = why; }
        public Kind Kind { get; }
        public DimVector Dim { get; }
        public string? Why { get; }

        public static Inferred Of(DimVector dim) => new(Kind.Known, dim, null);
        public static Inferred Unproven(string why) => new(Kind.Unknown, default, why);
        public static readonly Inferred AlreadyReported = new(Kind.Reported, default, null);
    }

    private sealed class MethodRules(ImmutableArray<string?> sameDimensionGroups, string? resultParameter, string? powerParameter, int root)
    {
        public static readonly MethodRules None = new(default, null, null, 1);
        public ImmutableArray<string?> SameDimensionGroups { get; } = sameDimensionGroups;
        public bool HasSameDimensionGroups => !SameDimensionGroups.IsDefault;
        public string? ResultParameter { get; } = resultParameter;
        public string? PowerParameter { get; } = powerParameter;
        public int Root { get; } = root;
    }

    private sealed class Inference
    {
        private readonly INamedTypeSymbol _unitDimension;
        private readonly INamedTypeSymbol _unknown;
        private readonly INamedTypeSymbol? _sameDimension;
        private readonly INamedTypeSymbol? _dimensionOf;

        private readonly ConcurrentDictionary<ITypeSymbol, DimVector?> _typeCache = new(SymbolEqualityComparer.Default);
        private readonly ConcurrentDictionary<IMethodSymbol, MethodRules> _methodCache = new(SymbolEqualityComparer.Default);
        private readonly ConditionalWeakTable<IOperation, ConcurrentDictionary<ILocalSymbol, Inferred>> _localCache = new();

        [ThreadStatic] private static HashSet<ILocalSymbol>? _visiting;

        public Inference(INamedTypeSymbol unitDimension, INamedTypeSymbol unknown, INamedTypeSymbol? sameDimension, INamedTypeSymbol? dimensionOf)
        {
            _unitDimension = unitDimension;
            _unknown = unknown;
            _sameDimension = sameDimension;
            _dimensionOf = dimensionOf;
        }

        // ---------- Types ----------
        private static ITypeSymbol UnwrapNullable(ITypeSymbol type)
            => type is INamedTypeSymbol { OriginalDefinition.SpecialType: SpecialType.System_Nullable_T } n ? n.TypeArguments[0] : type;

        public bool IsUnknown(ITypeSymbol? type)
            => type is not null && SymbolEqualityComparer.Default.Equals(UnwrapNullable(type), _unknown);

        public bool IsNullableUnknown(ITypeSymbol? type)
            => type is INamedTypeSymbol { OriginalDefinition.SpecialType: SpecialType.System_Nullable_T } n && IsUnknown(n.TypeArguments[0]);

        public bool IsFastType(ITypeSymbol? type)
            => type is not null && (IsUnknown(type) || TryGetTypeDimension(type, out _));

        public bool IsFastOperator(IMethodSymbol? method)
            => method is not null && IsFastType(method.ContainingType);

        // Duration > TimeSpan, DateTime + Duration: the other side is not a unit value - its type fixes what it is
        public bool TakesOnlyUnitValues(IMethodSymbol method)
            => method.Parameters.All(p => IsFastType(p.Type) || IsNumeric(p.Type));

        public bool TryGetTypeDimension(ITypeSymbol? type, out DimVector dim)
        {
            dim = default;
            if (type is null)
                return false;

            var cached = _typeCache.GetOrAdd(UnwrapNullable(type), ReadTypeDimension);
            dim = cached.GetValueOrDefault();
            return cached.HasValue;
        }

        // A quantity or unit class carries [UnitDimension]; QuantityInUnit<T> (what ToUnit gives) has T's dimension
        private DimVector? ReadTypeDimension(ITypeSymbol type)
        {
            if (type is INamedTypeSymbol { IsGenericType: true, TypeArguments.Length: 1 } g &&
                g.OriginalDefinition.ToDisplayString() == Namespace + ".QuantityInUnit<T>")
                return TryGetTypeDimension(g.TypeArguments[0], out var inner) ? inner : null;

            return ReadAttribute(type.GetAttributes());
        }

        public bool TryGetAttributeDimension(ImmutableArray<AttributeData> attributes, out DimVector dim)
        {
            var d = ReadAttribute(attributes);
            dim = d.GetValueOrDefault();
            return d.HasValue;
        }

        private DimVector? ReadAttribute(ImmutableArray<AttributeData> attributes)
        {
            foreach (var attr in attributes)
            {
                if (!SymbolEqualityComparer.Default.Equals(attr.AttributeClass, _unitDimension))
                    continue;

                // Flat pairs: (BaseunitType, exponent) repeated; none = dimensionless
                var args = attr.ConstructorArguments;
                var terms = new List<(int, int)>();
                for (int i = 0; i + 1 < args.Length; i += 2)
                {
                    if (args[i].Value is int baseUnit && args[i + 1].Value is int exp)
                        terms.Add((baseUnit, exp));
                }
                return DimVector.From(terms);
            }
            return null;
        }

        /// <summary>A write target that carries [UnitDimension]: an UnknownUnit field, property or parameter.</summary>
        public bool TryGetDeclaredDimension(IOperation target, out DimVector dim)
        {
            dim = default;
            ISymbol? symbol = target switch
            {
                IFieldReferenceOperation f => f.Field,
                IPropertyReferenceOperation p => p.Property,
                IParameterReferenceOperation p => p.Parameter,
                _ => null,
            };
            return symbol is not null && IsUnknown(target.Type) && TryGetAttributeDimension(symbol.GetAttributes(), out dim);
        }

        public static bool IsNumeric(ITypeSymbol type)
        {
            type = UnwrapNullable(type);
            return type.SpecialType is SpecialType.System_SByte or SpecialType.System_Byte
                or SpecialType.System_Int16 or SpecialType.System_UInt16
                or SpecialType.System_Int32 or SpecialType.System_UInt32
                or SpecialType.System_Int64 or SpecialType.System_UInt64
                or SpecialType.System_Single or SpecialType.System_Double
                or SpecialType.System_Decimal;
        }

        // ---------- Expressions ----------
        public Inferred Infer(IOperation op)
        {
            op = UnwrapImplicitConversions(op);

            if (op.Type is not null)
            {
                // A named quantity: the type says it all
                if (TryGetTypeDimension(op.Type, out var dim))
                    return Inferred.Of(dim);

                // Plain numbers are dimensionless
                if (IsNumeric(op.Type))
                    return Inferred.Of(DimVector.Dimensionless);
            }

            switch (op)
            {
                case IBinaryOperation bin:
                    return InferBinary(bin);

                case IUnaryOperation { OperatorKind: UnaryOperatorKind.Plus or UnaryOperatorKind.Minus } unary:
                    return Infer(unary.Operand);

                case IInvocationOperation { TargetMethod.Name: "GetValueOrDefault", Arguments.Length: 0, Instance: { } nullable } when IsNullableUnknown(nullable.Type):
                    return Infer(nullable);

                case IInvocationOperation inv:
                    return InferInvocation(inv);

                case ILocalReferenceOperation local:
                    return InferLocal(local);

                case IConversionOperation conv:
                    // Boxing, unboxing, nullable and our own quantity -> UnknownUnit conversions keep the value (and its unit)
                    if (conv.OperatorMethod is null || IsFastOperator(conv.OperatorMethod))
                        return Infer(conv.Operand);
                    return Inferred.Unproven($"the user-defined conversion '{conv.OperatorMethod.ToDisplayString()}' hides the unit");

                case IConditionalOperation { WhenFalse: not null } cond:
                    return Common([cond.WhenTrue, cond.WhenFalse], "the branches of ?: have different units");

                case ISwitchExpressionOperation sw:
                    return Common(sw.Arms.Select(a => a.Value), "the arms of the switch have different units");

                case ICoalesceOperation co:
                    return Common([co.Value, co.WhenNull], "the two sides of ?? have different units");

                case IFieldReferenceOperation f:
                    return TryGetAttributeDimension(f.Field.GetAttributes(), out var fd)
                        ? Inferred.Of(fd)
                        : Inferred.Unproven(NoUnit("field", f.Field.Name, f.Field.Type));

                // (a / b).Value and .GetValueOrDefault() on an UnknownUnit? keep the value - and its unit
                case IPropertyReferenceOperation { Property.Name: "Value", Instance: { } nullable } when IsNullableUnknown(nullable.Type):
                    return Infer(nullable);

                case IPropertyReferenceOperation p:
                    return TryGetAttributeDimension(p.Property.GetAttributes(), out var pd)
                        ? Inferred.Of(pd)
                        : Inferred.Unproven(NoUnit("property", p.Property.Name, p.Property.Type));

                case IParameterReferenceOperation p:
                    if (TryGetAttributeDimension(p.Parameter.GetAttributes(), out var ad))
                        return Inferred.Of(ad);
                    // The implicit 'value' of a [UnitDimension] property's setter has the property's unit
                    if (p.Parameter is { IsImplicitlyDeclared: true, ContainingSymbol: IMethodSymbol { MethodKind: MethodKind.PropertySet, AssociatedSymbol: IPropertySymbol prop } }
                        && TryGetAttributeDimension(prop.GetAttributes(), out var vd))
                        return Inferred.Of(vd);
                    return Inferred.Unproven(NoUnit("parameter", p.Parameter.Name, p.Parameter.Type));

                case IDefaultValueOperation or IObjectCreationOperation:
                    return Inferred.Unproven("this UnknownUnit is created without any unit information");

                case IDynamicInvocationOperation or IDynamicMemberReferenceOperation or IDynamicIndexerAccessOperation:
                    return Inferred.Unproven("'dynamic' hides the unit");
            }

            return Inferred.Unproven("the analyzer can't follow the unit through this expression - use a named quantity");
        }

        // "the property X is an UnknownUnit - ..." or, for a unit typed as the base class, "... is a UnitTypebase, which could be any unit"
        private string NoUnit(string kind, string name, ITypeSymbol type)
            => IsUnknown(type)
                ? $"the {kind} '{name}' is an UnknownUnit - declare it as a named quantity or add [UnitDimension]"
                : $"the {kind} '{name}' is a {type.Name}, which could be any unit - use a named quantity or unit type (PowerUnit, ...)";

        private Inferred InferBinary(IBinaryOperation bin)
        {
            var left = Infer(bin.LeftOperand);
            var right = Infer(bin.RightOperand);

            switch (bin.OperatorKind)
            {
                case BinaryOperatorKind.Multiply or BinaryOperatorKind.Divide:
                    if (left.Kind == Kind.Reported || right.Kind == Kind.Reported) return Inferred.AlreadyReported;
                    if (left.Kind == Kind.Unknown) return left;
                    if (right.Kind == Kind.Unknown) return right;
                    return Inferred.Of(bin.OperatorKind == BinaryOperatorKind.Multiply ? left.Dim.Multiply(right.Dim) : left.Dim.Divide(right.Dim));

                case BinaryOperatorKind.Add or BinaryOperatorKind.Subtract:
                    if (left.Kind == Kind.Known && right.Kind == Kind.Known && left.Dim.Equals(right.Dim))
                        return left;
                    // A mismatch or an unproven side is reported on this binary itself (EUF0002/EUF0007)
                    return IsFastOperator(bin.OperatorMethod) ? Inferred.AlreadyReported : Inferred.Unproven("unsupported operator");

                default:
                    return Inferred.Unproven("unsupported operator");
            }
        }

        private Inferred Common(IEnumerable<IOperation> values, string mismatchWhy) => Common(values, out _, mismatchWhy);

        private Inferred Common(IEnumerable<IOperation> values, out bool mismatch, string mismatchWhy)
        {
            mismatch = false;
            DimVector? first = null;
            foreach (var v in values)
            {
                // flag ? a / b : null - a null has no value, so it can't have the wrong unit
                if (UnwrapImplicitConversions(v) is ILiteralOperation { ConstantValue: { HasValue: true, Value: null } })
                    continue;

                var r = Infer(v);
                if (r.Kind != Kind.Known) return r;
                if (first is null) first = r.Dim;
                else if (!first.Value.Equals(r.Dim))
                {
                    mismatch = true;
                    return Inferred.Unproven(mismatchWhy);
                }
            }
            return first is null ? Inferred.Unproven(mismatchWhy) : Inferred.Of(first.Value);
        }

        private Inferred InferInvocation(IInvocationOperation inv)
        {
            // [return: UnitDimension(...)] UnknownUnit M()
            if (TryGetAttributeDimension(inv.TargetMethod.GetReturnTypeAttributes(), out var declared))
                return Inferred.Of(declared);

            var rules = GetRules(inv.TargetMethod);
            if (rules.ResultParameter is null)
                return Inferred.Unproven($"'{inv.TargetMethod.Name}' returns an UnknownUnit - return a named quantity or add [return: UnitDimension]");

            var source = InferResultSource(inv, rules);
            if (source.Kind != Kind.Known)
                return source;

            if (rules.Root <= 1)
                return source;

            return source.Dim.TryRoot(rules.Root, out var rooted)
                ? Inferred.Of(rooted)
                : Inferred.AlreadyReported; // EUF0006
        }

        /// <summary>The unit a [DimensionOf] method's result is based on, before any root is taken.</summary>
        public Inferred InferResultSource(IInvocationOperation inv, MethodRules rules)
        {
            if (rules.ResultParameter is null)
                return Inferred.Unproven("no [DimensionOf]");

            var arg = FindArgument(inv, rules.ResultParameter);
            if (arg is null)
            {
                // [return: DimensionOf(nameof(T))] - the dimension of the type argument: x.AddUnit<PowerUnit>(uom)
                var index = inv.TargetMethod.TypeParameters.IndexOf(
                    inv.TargetMethod.TypeParameters.FirstOrDefault(t => t.Name == rules.ResultParameter)!);
                if (index < 0)
                    return Inferred.Unproven("no [DimensionOf] argument");

                var typeArgument = inv.TargetMethod.TypeArguments[index];
                return TryGetTypeDimension(typeArgument, out var fromType)
                    ? Inferred.Of(fromType)
                    : Inferred.Unproven($"'{inv.TargetMethod.Name}<{typeArgument.Name}>' - {typeArgument.Name} could be any unit here; call it with a named unit type (PowerUnit, ...) or add [return: DimensionOf(nameof({typeArgument.Name}))] to this method");
            }

            // Mixed units in a [SameDimension] argument are reported as EUF0005 by the invocation check
            var r = Common(ExpandItems(arg.Value), out var mismatch, $"the values passed to '{inv.TargetMethod.Name}' have different units");
            if (mismatch && rules.HasSameDimensionGroups)
                return Inferred.AlreadyReported;
            if (r.Kind != Kind.Known)
                return r;

            if (rules.PowerParameter is null)
                return r;

            var power = FindArgument(inv, rules.PowerParameter);
            if (power?.Value.ConstantValue is not { HasValue: true, Value: int exponent })
                return Inferred.Unproven($"the power passed to '{inv.TargetMethod.Name}' is not a constant, so the unit of the result is unknown");

            return Inferred.Of(r.Dim.Pow(exponent));
        }

        // ---------- Locals ----------
        // A local's unit = the unit of every value written to it; all writes must agree (flow-insensitive on purpose).
        // Any write the analyzer can't see (ref, out, foreach, patterns, deconstruction, compound) makes it unproven.
        private Inferred InferLocal(ILocalReferenceOperation reference)
        {
            var root = (IOperation)reference;
            while (root.Parent is not null)
                root = root.Parent;

            var local = reference.Local;
            _visiting ??= new HashSet<ILocalSymbol>(SymbolEqualityComparer.Default);
            var topLevel = _visiting.Count == 0;

            var cache = _localCache.GetValue(root, _ => new ConcurrentDictionary<ILocalSymbol, Inferred>(SymbolEqualityComparer.Default));
            if (cache.TryGetValue(local, out var cached))
                return cached;

            if (!_visiting.Add(local))
                return Inferred.Unproven($"'{local.Name}' is assigned from itself, so its unit may change - use one typed variable per unit");

            Inferred result;
            try
            {
                result = InferLocalCore(root, local);
            }
            finally
            {
                _visiting.Remove(local);
            }

            // Results found half-way through a cycle depend on what was being visited - only cache complete ones
            if (topLevel)
                cache.TryAdd(local, result);

            return result;
        }

        private Inferred InferLocalCore(IOperation root, ILocalSymbol local)
        {
            bool Is(IOperation? op) => op is ILocalReferenceOperation r && SymbolEqualityComparer.Default.Equals(r.Local, local)
                || op is IVariableDeclaratorOperation v && SymbolEqualityComparer.Default.Equals(v.Symbol, local);
            bool Mentions(IOperation op) => Is(op) || op.Descendants().Any(Is);
            var untracked = $"'{local.Name}' is written in a way the analyzer can't follow (ref/out/foreach/pattern/deconstruction/compound assignment)";

            var writes = new List<IOperation>();
            foreach (var d in root.DescendantsAndSelf())
            {
                switch (d)
                {
                    // Before the declarator case: the loop variable's declarator sits inside the loop
                    case IForEachLoopOperation loop when Mentions(loop.LoopControlVariable):
                        return Inferred.Unproven(untracked);

                    case IVariableDeclaratorOperation decl when SymbolEqualityComparer.Default.Equals(decl.Symbol, local):
                        if (decl.Symbol.RefKind != RefKind.None)
                            return Inferred.Unproven(untracked);
                        if (decl.Initializer is not null)
                            writes.Add(decl.Initializer.Value);
                        break;

                    case IVariableDeclaratorOperation refDecl when refDecl.Symbol.RefKind != RefKind.None && refDecl.Initializer is not null && Mentions(refDecl.Initializer.Value):
                        return Inferred.Unproven(untracked); // ref alias to our local

                    case ISimpleAssignmentOperation asg when Is(asg.Target):
                        if (asg.IsRef)
                            return Inferred.Unproven(untracked);
                        writes.Add(asg.Value);
                        break;

                    case ICompoundAssignmentOperation ca when Is(ca.Target):
                        return Inferred.Unproven(untracked);
                    case IIncrementOrDecrementOperation inc when Is(inc.Target):
                        return Inferred.Unproven(untracked);
                    case ICoalesceAssignmentOperation coa when Is(coa.Target):
                        return Inferred.Unproven(untracked);

                    case IDeconstructionAssignmentOperation dec when Mentions(dec.Target):
                        return Inferred.Unproven(untracked);

                    case IDeclarationPatternOperation pat when SymbolEqualityComparer.Default.Equals(pat.DeclaredSymbol, local):
                        return Inferred.Unproven(untracked);

                    case IRecursivePatternOperation rpat when SymbolEqualityComparer.Default.Equals(rpat.DeclaredSymbol, local):
                        return Inferred.Unproven(untracked);

                    case IArgumentOperation { Parameter.RefKind: RefKind.Ref or RefKind.Out } arg when Mentions(arg.Value):
                        return Inferred.Unproven(untracked);

                    case IAddressOfOperation addr when Mentions(addr.Reference):
                        return Inferred.Unproven(untracked);
                }
            }

            if (writes.Count == 0)
                return Inferred.Unproven(untracked);

            DimVector? first = null;
            foreach (var w in writes)
            {
                var r = Infer(w);
                if (r.Kind == Kind.Reported) return Inferred.AlreadyReported;
                if (r.Kind == Kind.Unknown) return r;
                if (first is null) first = r.Dim;
                else if (!first.Value.Equals(r.Dim))
                    return Inferred.Unproven($"'{local.Name}' is assigned values with different units - use one typed variable per unit");
            }

            return Inferred.Of(first!.Value);
        }

        // ---------- [SameDimension] / [DimensionOf] ----------
        public MethodRules GetRules(IMethodSymbol method) => _methodCache.GetOrAdd(method.OriginalDefinition, ReadRules);

        private MethodRules ReadRules(IMethodSymbol method)
        {
            string? resultParameter = null;
            string? powerParameter = null;
            var root = 1;

            if (_dimensionOf is not null)
            {
                foreach (var attr in method.GetReturnTypeAttributes())
                {
                    if (!SymbolEqualityComparer.Default.Equals(attr.AttributeClass, _dimensionOf) || attr.ConstructorArguments.Length != 1)
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
            if (_sameDimension is not null)
            {
                foreach (var parameter in method.Parameters)
                {
                    foreach (var attr in parameter.GetAttributes())
                    {
                        if (!SymbolEqualityComparer.Default.Equals(attr.AttributeClass, _sameDimension))
                            continue;
                        groups ??= new string?[method.Parameters.Length];
                        groups[parameter.Ordinal] = attr.ConstructorArguments.Length == 1 ? attr.ConstructorArguments[0].Value as string ?? "" : "";
                    }
                }
            }

            if (resultParameter is null && groups is null)
                return MethodRules.None;

            return new MethodRules(groups is null ? default : groups.ToImmutableArray(), resultParameter, powerParameter, root);
        }

        /// <summary>The values an argument stands for: elements of params arrays, array initializers and tuples, otherwise the value itself.</summary>
        public IEnumerable<IOperation> ExpandItems(IOperation value)
        {
            value = UnwrapImplicitConversions(value);
            return value switch
            {
                IArrayCreationOperation { Initializer: { } initializer } => (IEnumerable<IOperation>)initializer.ElementValues,
                ITupleOperation tuple => tuple.Elements,
                _ => new[] { value },
            };
        }

        private static IArgumentOperation? FindArgument(IInvocationOperation inv, string parameterName)
            => inv.Arguments.FirstOrDefault(a => a.Parameter?.Name == parameterName);

        // Implicit conversions keep the value: quantity -> UnknownUnit, int -> double, T -> T?, boxing.
        // Stop at a conversion INTO a named quantity: that one has its own check (EUF0001) and its type is the truth.
        public IOperation Unwrap(IOperation op) => UnwrapImplicitConversions(op);

        private IOperation UnwrapImplicitConversions(IOperation op)
        {
            while (op is IConversionOperation { IsImplicit: true } c && !TryGetTypeDimension(c.Type, out _))
                op = c.Operand;
            return op;
        }
    }
}
