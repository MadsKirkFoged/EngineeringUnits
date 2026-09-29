using static EngineeringUnits.Analyzers.Tests.Fast.AnalyzerVerifier;

namespace EngineeringUnits.Analyzers.Tests.Fast;

[TestClass]
public class ConversionTests // EUF0001
{
    [TestMethod]
    public Task MatchingDimension_NoDiagnostic() => VerifyBodyAsync("""
        Energy e = power * time;
        Area a = length * length2;
        Power q = massFlow * cp * (t2 - t1);
        Power p = massFlow * enthalpy;
        Speed v = length / time;
        Ratio r = length / length2;
        """);

    [TestMethod]
    public Task WrongDimension_Reported() => VerifyBodyAsync("""
        Energy e = {|EUF0001:power / time|};
        Power q = {|EUF0001:massFlow * cp|};
        """);

    [TestMethod]
    public Task WrongDimensionWithScalar_Reported() => VerifyBodyAsync("""
        Area a = {|EUF0001:2 * length * 1.0 / length2 * length2 / length|};
        """);

    [TestMethod]
    public Task ExplicitCast_Checked() => VerifyBodyAsync("""
        var ok = (Power)(massFlow * enthalpy);
        var bad = (Power)({|EUF0001:massFlow * cp|});
        """);

    [TestMethod]
    public Task Nullable_Checked() => VerifyBodyAsync("""
        Power? ok = massFlow * enthalpy;
        Power? bad = {|EUF0001:massFlow * cp|};
        """);

    [TestMethod]
    public Task TernaryBranch_Checked() => VerifyBodyAsync("""
        Power q = flag ? {|EUF0001:massFlow * cp|} : power;
        """);

    [TestMethod]
    public Task MethodArgumentAndReturn_Checked() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public static class Snippet
        {
            static void TakesEnergy(Energy e) { }
            static Energy Gives(Power power, Duration time) => {|EUF0001:power / time|};

            public static void Run(Power power, Duration time)
            {
                TakesEnergy(power * time);
                TakesEnergy({|EUF0001:power / time|});
            }
        }
        """);

    [TestMethod]
    public Task Aliases_AreTheSameDimension() => VerifyBodyAsync("""
        SpecificEnergy a = (SpecificEnergy)enthalpy;
        Enthalpy b = enthalpy + specificEnergy;       // the left type wins
        Enthalpy c = (Enthalpy)(specificEnergy + enthalpy);
        Power p = massFlow * specificEnergy;
        """);
}

[TestClass]
public class AddSubtractTests // EUF0002
{
    [TestMethod]
    public Task Mismatch_Reported() => VerifyBodyAsync("""
        Length x = {|EUF0002:length + massFlow * enthalpy|};
        """);

    [TestMethod]
    public Task SameDimension_NoDiagnostic() => VerifyBodyAsync("""
        Power p = power + massFlow * enthalpy - massFlow * specificEnergy;
        """);

    [TestMethod]
    public Task Compound_Checked() => VerifyBodyAsync("""
        Power q = power;
        q += massFlow * enthalpy;
        {|EUF0002:q += massFlow * cp|};
        {|EUF0002:q -= massFlow * cp|};
        """);

    [TestMethod]
    public Task CompoundMultiply_MustBeDimensionless() => VerifyBodyAsync("""
        Power q = power;
        q *= 2;
        q /= length / length2;
        {|EUF0001:q *= length|};
        """);

    [TestMethod]
    public void DifferentNamedTypes_AreACompilerError()
        => VerifyCompileError("var x = length + mass;", "CS0034", "CS9342");

    [TestMethod]
    public void NumberIntoQuantity_IsACompilerError()
        => VerifyCompileError("Power p = 5;", "CS0029");
}

[TestClass]
public class CompareTests // EUF0003
{
    [TestMethod]
    public Task Mismatch_Reported() => VerifyBodyAsync("""
        bool a = {|EUF0003:power > massFlow * cp|};
        bool b = {|EUF0003:massFlow * cp == power|};
        bool ok = power < massFlow * enthalpy;
        """);

    [TestMethod]
    public void DifferentNamedTypes_AreACompilerError()
        => VerifyCompileError("var x = length == mass;", "CS0034", "CS9342", "CS0019");
}

[TestClass]
public class NumberCastTests // EUF0004
{
    [TestMethod]
    public Task WithUnit_Reported() => VerifyBodyAsync("""
        double ok = (double)(length / length2);
        double bad = {|EUF0004:(double)(length / time)|};
        """);
}

[TestClass]
public class SameDimensionTests // EUF0005
{
    [TestMethod]
    public Task Mismatch_Reported() => VerifyBodyAsync("""
        UnknownUnit ok = UnitMath.Max(power * 1.0 / 1.0 * time / time, massFlow * enthalpy);
        UnknownUnit bad = UnitMath.Max(length * length2 / length2, {|EUF0005:mass * length / length|});
        """);
}

[TestClass]
public class RootTests // EUF0006
{
    [TestMethod]
    public Task FractionalRoot_Reported() => VerifyBodyAsync("""
        Length ok = area.Sqrt();
        var bad = {|EUF0006:volume.Sqrt()|};
        Volume v = length.Pow(3);
        Area a = (length * length2).Abs();
        """);

    [TestMethod]
    public Task NonConstantPower_CantBeVerified() => VerifyBodyAsync("""
        Area a = {|EUF0007:length.Pow(count)|};
        """);
}

[TestClass]
public class FailClosedTests // EUF0007 - what the EngineeringUnits analyzer left to the runtime
{
    [TestMethod]
    public Task VarLocal_IsTracked() => VerifyBodyAsync("""
        var x = massFlow * cp;
        var q = x * (t2 - t1);
        Power ok = q;
        Power bad = {|EUF0001:x|};
        """);

    [TestMethod]
    public Task LocalWithSameUnitTwice_IsTracked() => VerifyBodyAsync("""
        UnknownUnit x = massFlow * enthalpy;
        if (flag) x = power * 2;
        Power ok = x;
        """);

    [TestMethod]
    public Task LocalThatChangesUnit_IsRejected() => VerifyBodyAsync("""
        UnknownUnit x = massFlow * cp;
        x = x * (t2 - t1);
        Power q = {|EUF0007:x|};
        """);

    [TestMethod]
    public Task LoopThatChangesUnit_IsRejected() => VerifyBodyAsync("""
        UnknownUnit acc = length;
        for (int i = 0; i < 3; i++) acc = acc * length;
        Volume v = {|EUF0007:acc|};
        """);

    [TestMethod]
    public Task CompoundOnUnknownLocal_IsRejected() => VerifyBodyAsync("""
        UnknownUnit x = massFlow * enthalpy;
        x += power;
        Power q = {|EUF0007:x|};
        """);

    [TestMethod]
    public Task Field_IsRejected() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public class Snippet
        {
            private UnknownUnit _stored;
            public void Save(MassFlow m, Enthalpy h) => _stored = m * h;
            public Power Load() => {|EUF0007:_stored|};
        }
        """);

    [TestMethod]
    public Task MethodReturningUnknown_IsRejected() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public static class Snippet
        {
            static UnknownUnit Helper(MassFlow m, Enthalpy h) => m * h;
            public static Power Run(MassFlow m, Enthalpy h) => {|EUF0007:Helper(m, h)|};
        }
        """);

    [TestMethod]
    public Task Parameter_IsRejected() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public static class Snippet
        {
            public static Power Run(UnknownUnit u) => {|EUF0007:u|};
        }
        """);

    [TestMethod]
    public Task LambdaLinqTupleDeconstruction_AreRejected() => VerifyBodyAsync("""
        Func<UnknownUnit> f = () => massFlow * enthalpy;
        Power a = {|EUF0007:f()|};
        var list = new List<UnknownUnit> { massFlow * enthalpy };
        Power b = {|EUF0007:list.First()|};
        var tuple = (massFlow * enthalpy, length);
        Power c = {|EUF0007:tuple.Item1|};
        var (d1, d2) = (massFlow * enthalpy, length);
        Power d = {|EUF0007:d1|};
        """);

    [TestMethod]
    public Task ForeachAndPattern_AreRejected() => VerifyBodyAsync("""
        foreach (UnknownUnit u in new UnknownUnit[] { massFlow * enthalpy })
        {
            Power p = {|EUF0007:u|};
        }
        object o = massFlow * enthalpy;
        if (o is UnknownUnit v) { Power p = {|EUF0007:v|}; }
        """);

    [TestMethod]
    public Task OutParameter_IsRejected() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public static class Snippet
        {
            static void Make(MassFlow m, Enthalpy h, out UnknownUnit u) => u = m * h;
            public static Power Run(MassFlow m, Enthalpy h)
            {
                Make(m, h, out var u);
                return {|EUF0007:u|};
            }
        }
        """);

    [TestMethod]
    public Task DefaultUnknown_IsRejected() => VerifyBodyAsync("""
        Power a = {|EUF0007:default(UnknownUnit)|};
        Power b = {|EUF0007:new UnknownUnit()|};
        """);

    [TestMethod]
    public Task BoxingInTheSameMethod_IsTracked() => VerifyBodyAsync("""
        object o = massFlow * enthalpy;
        Power ok = (UnknownUnit)o;
        Length bad = {|EUF0001:(UnknownUnit)o|};
        """);

    [TestMethod]
    public Task SwitchAndCoalesce() => VerifyBodyAsync("""
        UnknownUnit s = count switch { 1 => massFlow * enthalpy, _ => power * 1 };
        Power ok = s;
        UnknownUnit mixed = count switch { 1 => massFlow * enthalpy, _ => length * 1 };
        Power bad = {|EUF0007:mixed|};
        """);

    [TestMethod]
    public Task LambdaWritingLocal_IsSeen() => VerifyBodyAsync("""
        UnknownUnit x = massFlow * enthalpy;
        Action a = () => x = length * 1.0 / 1.0 * 1.0;
        Power q = {|EUF0007:x|};
        """);

    [TestMethod]
    public Task UnknownPlusUnknownField_IsRejected() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public class Snippet
        {
            private UnknownUnit _a;
            public Power Run(Power p) => p + {|EUF0007:_a|};
        }
        """);

    [TestMethod]
    public async Task Message_ExplainsWhy()
    {
        var diagnostics = await GetDiagnosticsAsync("UnknownUnit x = massFlow * cp; x = x * (t2 - t1); Power q = x;");
        var message = diagnostics.Single().GetMessage();
        StringAssert.Contains(message, "expected [m²*kg/s³]");
        StringAssert.Contains(message, "'x'");
    }
}

[TestClass]
public class UnitDimensionAttributeTests // [UnitDimension] lets UnknownUnit cross boundaries - checked on write, trusted on read
{
    [TestMethod]
    public Task Field() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public class Snippet
        {
            [UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)]
            private UnknownUnit _power;

            [UnitDimension(BaseunitType.length, 1)]
            private UnknownUnit _length = {|EUF0001:Mass.FromKilogram(1) * 1.0|};

            public void Save(MassFlow m, Enthalpy h, SpecificEntropy cp)
            {
                _power = m * h;
                _power = {|EUF0001:m * cp|};
            }

            public Power Load() => _power;
            public Length Wrong() => {|EUF0001:_power|};
        }
        """);

    [TestMethod]
    public Task ParameterAndReturn() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public static class Snippet
        {
            [return: UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)]
            static UnknownUnit Heat(MassFlow m, Enthalpy h) => m * h;

            [return: UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)]
            static UnknownUnit Wrong(MassFlow m, SpecificEntropy cp) => {|EUF0001:m * cp|};

            static Energy Times([UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)] UnknownUnit power, Duration t) => power * t;

            public static void Run(MassFlow m, Enthalpy h, SpecificEntropy cp, Duration t)
            {
                Power p = Heat(m, h);
                Energy e = Times(m * h, t);
                Energy bad = Times({|EUF0001:m * cp|}, t);
            }
        }
        """);

    [TestMethod]
    public Task Property_SetterValueHasThePropertysUnit() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public class Snippet
        {
            [UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)]
            private UnknownUnit _raw;

            [UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)]
            public UnknownUnit Heat { get => _raw; set => _raw = value; }

            public void Run(MassFlow m, Enthalpy h, SpecificEntropy cp)
            {
                Heat = m * h;
                Heat = {|EUF0001:m * cp|};
                Power p = Heat;
                var s = new Snippet { Heat = {|EUF0001:m * cp|} };
            }
        }
        """);

    [TestMethod]
    public Task WritesTheAnalyzerCantSee_AreRejected() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public class Snippet
        {
            [UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3)]
            private UnknownUnit _power;
            private UnknownUnit _other;

            static void Overwrite(ref UnknownUnit u) { }

            public void Run(MassFlow m, Enthalpy h, SpecificEntropy cp)
            {
                Overwrite(ref {|EUF0007:_power|});
                System.Threading.Interlocked.Exchange(ref {|EUF0007:_power|}, m * h);
                (_power, _other) = (m * h, m * cp);
                (_power, _other) = ({|EUF0001:m * cp|}, m * h);
            }
        }
        """);

    [TestMethod]
    public void UnknownSI_IsNotPublic()
        => VerifyCompileError("double raw = (massFlow * cp).SI;", "CS0122", "CS1061");

    [TestMethod]
    public Task DimensionTaggedConstants_AreTrusted() => VerifyBodyAsync("""
        Force f = Constants.GravitationalConstant * mass * mass / (length * length);
        Length bad = {|EUF0001:Constants.GravitationalConstant * mass|};
        """);
}

[TestClass]
public class DynamicTests // EUF0008
{
    [TestMethod]
    public Task Dynamic_Reported() => VerifyBodyAsync("""
        dynamic d = {|EUF0008:massFlow * cp|};
        Power q = {|EUF0008:d|};
        """);
}

[TestClass]
public class ScopeTests
{
    [TestMethod]
    public Task GeneratedCode_IsAnalyzedToo() => VerifyAsync("""
        // <auto-generated/>
        using EngineeringUnits.Fast;

        public static class Snippet
        {
            public static Power Run(MassFlow m, SpecificEntropy cp) => {|EUF0001:m * cp|};
        }
        """, path: "Snippet.g.cs");

    [TestMethod]
    public Task WithoutFast_NoDiagnostics() => VerifyAsync("""
        public static class Snippet
        {
            public static double Run(double a, double b) => a * b + a;
        }
        """, referenceFast: false);

    [TestMethod]
    public Task PlainDoubles_AreIgnored() => VerifyBodyAsync("""
        double a = number * number + count;
        dynamic d = number;
        double b = d;
        """);
}

[TestClass]
public class AliasTests
{
    // Torque and Energy have the same dimension but are different things - explicit, like in EngineeringUnits
    [TestMethod]
    public void AliasConversion_IsExplicit()
        => VerifyCompileError("Torque t = energy;", "CS0266");

    // EngineeringUnits converts implicitly between these three pairs, so they do here too (using swap)
    [TestMethod]
    public Task AliasConversion_ImplicitLikeEngineeringUnits() => VerifyBodyAsync("""
        Enthalpy h = specificEnergy;
        SpecificEnergy e = enthalpy;
        SpecificHeatCapacity c = cp;
        Dimensionless d = Ratio.FromPercent(50);
        SpecificEnergy? nullable = (Enthalpy?)enthalpy;
        Power p = massFlow * (h - e);
        // -(water.Enthalpy - offset) * massFlow with a SpecificEnergy? and an Enthalpy - not ambiguous
        SpecificEnergy? maybe = specificEnergy;
        SpecificEnergy? d1 = maybe - enthalpy;
        Enthalpy? d2 = enthalpy - maybe;
        Power? p2 = -(maybe - enthalpy) * massFlow;
        bool below = maybe < enthalpy && enthalpy >= maybe && maybe != enthalpy;
        """);

    // Angle, Information, Ratio... are all "dimensionless" but unrelated - no direct conversion or mixing
    [TestMethod]
    public void DimensionlessQuantities_DontMix()
    {
        VerifyCompileError("Angle a = Angle.FromRadian(1); Information i = Information.FromBit(1); var x = a + i;", "CS0034", "CS9342", "CS0019");
        VerifyCompileError("Information i = Information.FromBit(1); Angle a = (Angle)i;", "CS0030");
    }

    [TestMethod]
    public Task DimensionlessQuantities_ThroughUnknown() => VerifyBodyAsync("""
        Angle a = (UnknownUnit)Information.FromBit(1);
        Ratio r = length / length2;
        """);
}

[TestClass]
public class UsingSwapCompatibilityRuleTests
{
    // No conversion from UnknownUnit? on purpose: null would silently become a throwing quantity
    [TestMethod]
    public void NullIsNotAQuantity()
    {
        VerifyCompileError("Power p = null;", "CS0037");
        VerifyCompileError("Power p = flag ? power : null;", "CS0173", "CS0037", "CS8957");
    }

    [TestMethod]
    public void RemovedMembers_AreCompileErrors()
    {
        // No parsing in Fast
        VerifyCompileError("var x = Power.Parse(\"10 kW\");", "CS0117");
        // AsSI is fine on a named quantity (a double), but an UnknownUnit has none: it would strip the unit unchecked
        VerifyCompileError("var x = (massFlow * enthalpy).AsSI;", "CS1061");
        VerifyCompileError("MassFlow? m = massFlow; var x = (m * enthalpy).AsSI;", "CS1061");
        // ToUnit is for display: math on it needs the quantity first
        VerifyCompileError("var x = power.ToUnit(PowerUnit.Kilowatt) - power.ToUnit(PowerUnit.Kilowatt);", "CS0019");
    }

    [TestMethod]
    public Task NullableMath_ValueIsFollowed() => VerifyBodyAsync("""
        MassFlow? a = massFlow, b = massFlow;
        Ratio ok = (a / (a + b))!.Value;
        Ratio alsoOk = (a / b).GetValueOrDefault();
        Ratio bad = {|EUF0001:(a * b)!.Value|};
        """);

    // A TimeSpan or DateTime on the other side is not a unit value - its type says what it is
    [TestMethod]
    public Task DurationWithTimeSpanAndDateTime_NoDiagnostics() => VerifyBodyAsync("""
        var start = new System.DateTime(2026, 1, 1);
        System.DateTime end = start + time;
        bool longer = time > System.TimeSpan.FromHours(1) && System.TimeSpan.FromHours(2) >= time;
        System.TimeSpan span = (System.TimeSpan)time;
        Duration back = (Duration)span;
        Length bad = {|EUF0001:(UnknownUnit)(Duration)span|};
        """);

    // dropRatio = portDrop is not null ? portDrop / totalDrop : null
    [TestMethod]
    public Task NullableMath_InConditionalWithNull() => VerifyBodyAsync("""
        Length? a = length;
        Ratio? r1 = flag ? a / length2 : null;
        Ratio? r2 = flag ? length / length2 : null;
        Ratio? r3 = flag ? null : a / a;
        Ratio? r4 = (flag ? a / length2 : null) ?? null;
        Ratio? bad = {|EUF0001:flag ? a * length2 : null|};
        """);

    [TestMethod]
    public Task NumberMinusUnknown_OnlyWhenDimensionless() => VerifyBodyAsync("""
        Ratio ok = 1 - length / length2;
        Ratio bad = {|EUF0002:1 - length / time|};
        """);

    [TestMethod]
    public Task NullableQuantityHelpers_KeepTheUnit() => VerifyBodyAsync("""
        Length? l = length;
        Area? a = l.Pow(2);
        Length? back = a.Sqrt();
        Area? bad = {|EUF0001:l.Pow(3)|};
        """);
}

/// <summary>A value and a display unit chosen at runtime, e.g. a report line that stores both.</summary>
[TestClass]
public class DisplayUnitTests
{
    [TestMethod]
    public Task ToUnit_KeepsTheUnit() => VerifyBodyAsync("""
        Power ok = power.ToUnit(PowerUnit.Kilowatt);
        UnknownUnit u = power.ToUnit(PowerUnit.Kilowatt);
        Power alsoOk = u;
        Length bad = {|EUF0001:u|};
        """);

    [TestMethod]
    public Task UnknownToUnit_ValueAndUnitMustMatch() => VerifyBodyAsync("""
        var shown = (massFlow * enthalpy).ToUnit(PowerUnit.Kilowatt);
        var wrong = (massFlow * enthalpy).ToUnit({|EUF0005:LengthUnit.Meter|});
        """);

    [TestMethod]
    public Task RecordWithRuntimeDisplayUnit_IsCheckedWhereItIsCreated() => VerifyAsync("""
        using EngineeringUnits.Fast;
        using EngineeringUnits.Units.Fast;

        public class ReportLine
        {
            public UnknownUnit? Unit { get; }
            public UnitTypebase DisplayType { get; }

            // One attribute on the constructor: every "new ReportLine(value, unit)" is checked at compile time
            public ReportLine(string description, [SameDimension] UnknownUnit? unit, [SameDimension] UnitTypebase displayType)
            {
                Unit = unit;
                DisplayType = displayType;
            }

            // The one place a runtime unit meets a stored value: the analyzer can't prove it, so it asks
            public string Show() => $"{{|EUF0007:Unit|}.ToUnit({|EUF0007:DisplayType|}):V4}";
        }

        public static class Report
        {
            public static void Run(Power power, Pressure? pressure, Length length)
            {
                _ = new ReportLine("Capacity", power, PowerUnit.Kilowatt);
                _ = new ReportLine("Suction", pressure, PressureUnit.Bar);
                _ = new ReportLine("Wrong", power, {|EUF0005:LengthUnit.Meter|});
            }
        }
        """);
}

/// <summary>Database rows that store a number and its unit name: "public Power? XEntity => X.AddUnit&lt;PowerUnit&gt;(X_uom);".</summary>
[TestClass]
public class AddUnitTests
{
    [TestMethod]
    public Task DatabaseModel_EntityProperties_AreChecked() => VerifyAsync("""
        using EngineeringUnits.Fast;
        using EngineeringUnits.Units.Fast;

        public class PumpRow
        {
            public double? Capacity { get; set; }
            public string Capacity_uom { get; set; } = "";
            public double? Head { get; set; }
            public string Head_uom { get; set; } = "";

            public Power? CapacityEntity => Capacity.AddUnit<PowerUnit>(Capacity_uom);
            public Length? HeadEntity => Head.AddUnit<LengthUnit>(Head_uom);
            public Pressure? WrongEntity => {|EUF0001:Capacity.AddUnit<PowerUnit>(Capacity_uom)|};
        }
        """);

    [TestMethod]
    public Task GenericHelper_NeedsDimensionOfTypeParameter() => VerifyAsync("""
        using EngineeringUnits.Fast;
        using EngineeringUnits.Units.Fast;

        public class Requirement { public double Value; public string UoM = ""; }

        public static class CommonExtensions
        {
            // A typical helper: the analyzer can't know which unit T is at the call site
            public static UnknownUnit? ToUnit<T>(this Requirement? r) where T : UnitTypebase
                => r is null ? null : r.Value.AddUnit<T>(r.UoM);

            // With one attribute it can: the result has T's dimension
            [return: DimensionOf("T")]
            public static UnknownUnit? ToUnitChecked<T>(this Requirement? r) where T : UnitTypebase
                => r is null ? null : r.Value.AddUnit<T>(r.UoM);

            public static void Use(Requirement r)
            {
                Power? a = {|EUF0007:r.ToUnit<PowerUnit>()|};
                Power? b = r.ToUnitChecked<PowerUnit>();
                Length? c = {|EUF0001:r.ToUnitChecked<PowerUnit>()|};
            }
        }
        """);
}
