using static EngineeringUnits.Analyzers.Tests.Fast.AnalyzerVerifier;

namespace EngineeringUnits.Analyzers.Tests.Fast;

/// <summary>
/// Port of UnitTests/HaveToFail/UnitsAreWrong.cs. Every case EngineeringUnits catches at runtime with a
/// WrongUnitException must be caught at COMPILE time here - by the analyzer or by the C# compiler itself.
/// </summary>
[TestClass]
public class PortedMustFailTests
{
    [TestMethod]
    public Task AreaCantBeVolume() => VerifyBodyAsync("""
        var l1 = Length.FromYard(1);
        var l2 = Length.FromMeter(5);
        Area area2 = {|EUF0001:l1 * l2 * l2|};
        """);

    [TestMethod]
    public Task EnergyCantBeDensity() => VerifyBodyAsync("""
        var m = Mass.FromGram(150);
        var v = Volume.FromLiter(3);
        Energy e = {|EUF0001:m / v|};
        """);

    [TestMethod]
    public Task EnergyCantBePower() => VerifyBodyAsync("""
        var m = Mass.FromCentigram(1);
        var l = Length.FromMeter(5);
        var d = Duration.FromHour(5);
        Power local = {|EUF0001:m * l.Pow(2) / d.Pow(2)|};
        """);

    [TestMethod]
    public void WrongBaseUnits_EqualityOperators_AreCompilerErrors()
    {
        foreach (var op in new[] { "==", "!=", ">", ">=", "<", "<=" })
            VerifyCompileError($"var l = Length.FromCentimeter(3); var m = Mass.FromKilogram(3); _ = l {op} m;", "CS0034", "CS9342", "CS0019");
    }

    [TestMethod]
    public void WrongUnitsToAddOrSubtract_AreCompilerErrors()
    {
        VerifyCompileError("var l = Length.FromCentimeter(3); var m = Mass.FromKilogram(3); _ = l + m;", "CS0034", "CS9342");
        VerifyCompileError("var l = Length.FromCentimeter(3); var m = Mass.FromKilogram(3); _ = l - m;", "CS0034", "CS9342");
        VerifyCompileError("var d = new Duration(1, DurationUnit.Minute); var l = new Length(1, LengthUnit.Chain); _ = d + l;", "CS0034", "CS9342");
    }

    [TestMethod]
    public Task WrongUnitCompareToAndEquals() => VerifyBodyAsync("""
        var l = Length.FromCentimeter(3);
        var m = Mass.FromKilogram(3);
        _ = {|EUF0003:l.CompareTo(m)|};
        _ = {|EUF0003:l.Equals(m)|};
        object boxed = m;
        _ = {|EUF0003:l.CompareTo(boxed)|};
        """);

    [TestMethod]
    public Task WrongUnknownUnitEquals() => VerifyBodyAsync("""
        UnknownUnit s = Length.FromCentimeter(7) / Duration.FromMinute(32);
        UnknownUnit d = Mass.FromCentigram(15) / Volume.FromCubicFoot(7);
        _ = {|EUF0003:s.Equals(d)|};
        object boxed = d;
        _ = {|EUF0003:s.Equals(boxed)|};
        UnknownUnit s2 = Length.FromMeter(1) / Duration.FromSecond(1);
        _ = s.Equals(s2);
        """);

    [TestMethod]
    public Task WrongUnitCastToNumber() => VerifyBodyAsync("""
        var a4 = new Length(10, LengthUnit.Kilometer);
        var a5 = new Duration(1, DurationUnit.Minute);
        var a6 = new Duration(1, DurationUnit.Hour);
        UnknownUnit res = a4 * (a5 * a6);
        _ = {|EUF0004:(double)res|};

        """);

    [TestMethod]
    public void ToUnitWithWrongUnit_IsACompilerError()
        => VerifyCompileError("var m = Mass.FromCentigram(1); _ = m.As(MassFlowUnit.KilogramPerSecond);", "CS1503");

    [TestMethod]
    public void UnknownListCompareTo_IsACompilerError()
        => VerifyCompileError("UnknownUnit a = length * 1.0; object b = a; _ = a.CompareTo(b);", "CS1061", "CS7036");

    [TestMethod]
    public void CastUnknownToDecimal_IsACompilerError()
        => VerifyCompileError("UnknownUnit res = length * time; _ = (decimal)res;", "CS0030");
}
