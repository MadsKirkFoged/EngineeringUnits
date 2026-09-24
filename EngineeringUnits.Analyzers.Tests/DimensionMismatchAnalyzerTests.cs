using static EngineeringUnits.Analyzers.Tests.AnalyzerVerifier;

namespace EngineeringUnits.Analyzers.Tests;

[TestClass]
public class ConversionTests // EU0001
{
    [TestMethod]
    public Task MatchingDimension_NoDiagnostic() => VerifyBodyAsync("""
        Energy e = power * time;
        Area a = length * length2;
        Ratio r = length / length2;
        """);

    [TestMethod]
    public Task WrongDimension_Reported() => VerifyBodyAsync("""
        Energy e = {|EU0001:power / time|};
        """);

    [TestMethod]
    public Task WrongDimensionWithScalar_Reported() => VerifyBodyAsync("""
        Area a = {|EU0001:2 * length|};
        """);

    [TestMethod]
    public Task UnknownOperand_NoDiagnostic() => VerifyBodyAsync("""
        Energy e = unknown;
        Energy e2 = unknown * time;
        """);

    [TestMethod]
    public Task MethodArgument_Reported() => VerifyAsync("""
        using EngineeringUnits;

        public static class Snippet
        {
            static void TakesEnergy(Energy e) { }

            public static void Run(Power power, Duration time)
            {
                TakesEnergy(power * time);
                TakesEnergy({|EU0001:power / time|});
            }
        }
        """);

    [TestMethod]
    public Task ReturnValue_Reported() => VerifyAsync("""
        using EngineeringUnits;

        public static class Snippet
        {
            static Energy Good(Power p, Duration t) => p * t;
            static Energy Bad(Power p, Duration t) => {|EU0001:p / t|};

            static Energy BadBlock(Power p, Duration t)
            {
                return {|EU0001:p / t|};
            }
        }
        """);
}

[TestClass]
public class AddSubtractTests // EU0002
{
    [TestMethod]
    public Task SameDimension_NoDiagnostic() => VerifyBodyAsync("""
        var a = length + length2;
        var b = length - length2;
        var c = area + length * length2;
        var d = length * 2 + length2;
        var e = energy - power * time;
        """);

    [TestMethod]
    public Task DifferentQuantities_Reported() => VerifyBodyAsync("""
        var a = {|EU0002:length + area|};
        var b = {|EU0002:length - time|};
        var c = {|EU0002:energy + power|};
        """);

    [TestMethod]
    public Task DerivedDimension_Reported() => VerifyBodyAsync("""
        var a = {|EU0002:length * length2 + length|};
        var b = {|EU0002:energy - power / time|};
        """);

    [TestMethod]
    public Task NumberLiteral_Reported() => VerifyBodyAsync("""
        var a = {|EU0002:length + 5|};
        var b = {|EU0002:2.5 - length|};
        """);

    [TestMethod]
    public Task NumberVariable_Reported() => VerifyBodyAsync("""
        var a = {|EU0002:length + number|};
        var b = {|EU0002:length - count|};
        var c = {|EU0002:length + maybeNumber|};
        var d = {|EU0002:length + length.As(EngineeringUnits.Units.LengthUnit.Meter)|};
        """);

    [TestMethod]
    public Task UnaryMinus_IsTracked() => VerifyBodyAsync("""
        var ok = -length + length2;
        var bad = {|EU0002:-length + time|};
        """);

    [TestMethod]
    public Task NestedMismatch_ReportedOnlyOnce() => VerifyBodyAsync("""
        var a = {|EU0002:length + time|} + area;
        Area b = {|EU0002:length + time|};
        """);

    [TestMethod]
    public Task UnknownOperand_NoDiagnostic() => VerifyBodyAsync("""
        var a = length + unknown;
        var b = unknown - time;
        """);

    [TestMethod]
    public Task PlainNumberMath_NoDiagnostic() => VerifyBodyAsync("""
        var a = number + count;
        var b = number - 1;
        var s = "a" + count;
        """);
}

[TestClass]
public class CompareTests // EU0003
{
    [TestMethod]
    public Task SameDimension_NoDiagnostic() => VerifyBodyAsync("""
        bool a = length < length2;
        bool b = energy == power * time;
        bool c = area >= length * length2;
        """);

    [TestMethod]
    public Task DifferentDimension_Reported() => VerifyBodyAsync("""
        bool a = {|EU0003:length < time|};
        bool b = {|EU0003:energy == power|};
        bool c = {|EU0003:energy != power|};
        bool d = {|EU0003:area >= length|};
        bool e = {|EU0003:mass <= length / time|};
        """);

    [TestMethod]
    public Task NullComparison_NoDiagnostic() => VerifyBodyAsync("""
        bool a = energy == null;
        bool b = null != length;
        """);
}

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public Task ProjectWithoutEngineeringUnits_NoDiagnostic() => VerifyAsync("""
        public static class Snippet
        {
            public static double Run(double a, int b) => a + b * 2;
        }
        """, referenceEngineeringUnits: false);

    [TestMethod]
    public async Task Messages_UseSiUnits()
    {
        var diagnostics = await GetDiagnosticsAsync("""
            Energy e = power / time;
            var a = length + area;
            bool b = energy != power;
            var c = cost + length;
            """);

        var messages = diagnostics
            .OrderBy(d => d.Location.SourceSpan.Start)
            .Select(d => d.GetMessage())
            .ToArray();

        CollectionAssert.AreEqual(new[]
        {
            "This is NOT a [m²*kg/s²] as expected, your unit is a [m²*kg/s⁴]",
            "Trying to do [m] + [m²], can't add/subtract two different units",
            "Trying to compare [m²*kg/s²] != [m²*kg/s³], can't compare two different units",
            "Trying to do [$] + [m], can't add/subtract two different units",
        }, messages);
    }
}
