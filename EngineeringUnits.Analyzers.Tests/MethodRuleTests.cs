using static EngineeringUnits.Analyzers.Tests.AnalyzerVerifier;

namespace EngineeringUnits.Analyzers.Tests;

[TestClass]
public class NumberCastTests // EU0004
{
    [TestMethod]
    public Task UnitlessValue_NoDiagnostic() => VerifyBodyAsync("""
        double a = (double)(length / length2);
        int b = (int)(power * time / energy);
        decimal c = (decimal)(area / (length * length2));
        double d = (double)ratio;
        """);

    [TestMethod]
    public Task ValueWithUnit_Reported() => VerifyBodyAsync("""
        double a = {|EU0004:(double)(length / time)|};
        int b = {|EU0004:(int)(length * 2)|};
        decimal c = {|EU0004:(decimal)(energy / time)|};
        """);

    [TestMethod]
    public Task UnknownValue_NoDiagnostic() => VerifyBodyAsync("""
        double a = (double)unknown;
        """);
}

[TestClass]
public class SameDimensionTests // EU0005
{
    [TestMethod]
    public Task SameUnits_NoDiagnostic() => VerifyBodyAsync("""
        var a = length.Clamp(length2, length2);
        var b = UnitMath.Sum(length, length2, length * 2);
        var c = length.UpperLimitAt(length2);
        bool d = energy.Equals(power * time);
        var e = UnitMath.LinearInterpolation(time, time, time, length, length2);
        """);

    [TestMethod]
    public Task ExtensionArguments_Reported() => VerifyBodyAsync("""
        var a = length.Clamp({|EU0005:time|}, length2);
        var b = length.UpperLimitAt({|EU0005:area|});
        var c = length.LowerLimitAt({|EU0005:time|});
        var d = length.RoundTo<BaseUnit>({|EU0005:time|});
        """);

    [TestMethod]
    public Task InstanceMethods_IncludeTheInstance() => VerifyBodyAsync("""
        bool a = energy.Equals({|EU0005:power|});
        int b = length.CompareTo({|EU0005:time|});
        """);

    [TestMethod]
    public Task ParamsArrayElements_Reported() => VerifyBodyAsync("""
        var a = UnitMath.Sum(length, length2, {|EU0005:time|});
        var b = UnitMath.Max(new BaseUnit[] { length, {|EU0005:area|} });
        var c = UnitMath.Average(energy, {|EU0005:power|}, {|EU0005:mass|});
        """);

    [TestMethod]
    public Task TupleElements_Reported() => VerifyBodyAsync("""
        var a = UnitMath.Min((length, length2));
        var b = UnitMath.Min((length, {|EU0005:time|}));
        """);

    [TestMethod]
    public Task Groups_AreCheckedSeparately() => VerifyBodyAsync("""
        var a = UnitMath.LinearInterpolation(time, time, {|EU0005:length|}, length, {|EU0005:area|});
        """);

    [TestMethod]
    public Task NullAndUnknown_Ignored() => VerifyBodyAsync("""
        var a = length.Clamp(null, length2);
        var b = length.Clamp(unknown, null);
        var c = UnitMath.Sum(length, unknown);
        """);
}

[TestClass]
public class RootTests // EU0006
{
    [TestMethod]
    public Task EvenExponents_NoDiagnostic() => VerifyBodyAsync("""
        var a = area.Sqrt();
        var b = (length * length2 * area).Sqrt();
        var c = ratio.Sqrt();
        var d = unknown.Sqrt();
        """);

    [TestMethod]
    public Task OddExponents_Reported() => VerifyBodyAsync("""
        var a = {|EU0006:length.Sqrt()|};
        var b = {|EU0006:energy.Sqrt()|};
        var c = {|EU0006:(area * length).Sqrt()|};
        """);
}

[TestClass]
public class MethodInferenceTests // results of [DimensionOf] methods feed EU0001-EU0003
{
    [TestMethod]
    public Task Pow_ConstantPower() => VerifyBodyAsync("""
        Area ok = length.Pow(2);
        var ok2 = length.Pow(2) + area;
        var ok3 = length.Pow(0) + number;
        Area a = {|EU0001:length.Pow(3)|};
        var b = {|EU0002:length.Pow(2) + length|};
        var c = {|EU0002:length.Pow(-1) + length|};
        """);

    [TestMethod]
    public Task Pow_VariablePower_Unknown() => VerifyBodyAsync("""
        var a = length.Pow(count) + time;
        """);

    [TestMethod]
    public Task Sqrt() => VerifyBodyAsync("""
        Length ok = area.Sqrt();
        var a = {|EU0002:area.Sqrt() + area|};
        """);

    [TestMethod]
    public Task SameUnitMethods() => VerifyBodyAsync("""
        var a = {|EU0002:energy + power.Abs()|};
        var b = {|EU0002:length.Clamp(length2, length2) + time|};
        bool c = {|EU0003:length.UpperLimitAt(length2) > time|};
        Area d = {|EU0001:UnitMath.Sum(length, length2)|};
        Length e = {|EU0001:(length * length2).ToUnit(EngineeringUnits.Units.AreaUnit.SI)|};
        var f = {|EU0002:length.ToUnknownUnit() + mass|};
        """);

    [TestMethod]
    public Task FailedCalls_DontCascade() => VerifyBodyAsync("""
        var a = UnitMath.Sum(length, {|EU0005:time|}) + area;
        var b = {|EU0006:length.Sqrt()|} + time;
        """);
}

[TestClass]
public class MethodRuleMessageTests
{
    [TestMethod]
    public async Task Messages_UseSiUnits()
    {
        var diagnostics = await GetDiagnosticsAsync("""
            double a = (double)(length / time);
            var b = length.Clamp(time, null);
            var c = length.Sqrt();
            """);

        var messages = diagnostics
            .OrderBy(d => d.Location.SourceSpan.Start)
            .Select(d => d.GetMessage())
            .ToArray();

        CollectionAssert.AreEqual(new[]
        {
            "Can't cast [m/s] to double, only values without a unit can be cast to a number",
            "All values passed to 'Clamp' must have the same unit, got [m] and [s]",
            "Can't take the square root of [m], the result would have fractional units",
        }, messages);
    }
}
