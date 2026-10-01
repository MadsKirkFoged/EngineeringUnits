using EngineeringUnits.Fast;
using EU = global::EngineeringUnits;

namespace UnitTests.Fast;

/// <summary>The implicit EngineeringUnits -> EngineeringUnits.Fast conversion that EngineeringUnits declares (FastConversions.g.cs).</summary>
[TestClass]
public class ImplicitConversionTests
{
    [TestMethod]
    public void EveryQuantityConvertsImplicitlyToNullableFast()
    {
        foreach (var q in Quantities.All)
        {
            var classic = Original.QuantityType(q.Name);
            var op = classic.GetMethods().SingleOrDefault(m => m.Name == "op_Implicit" && m.ReturnType == typeof(Nullable<>).MakeGenericType(q.Type));
            Assert.IsNotNull(op, $"{classic.Name} has no implicit conversion to {q.Type.FullName}?");
            Assert.AreEqual(classic, op.GetParameters().Single().ParameterType, q.Name);
        }
    }

    [TestMethod]
    public void ValueInAnotherUnit_ArrivesInSI()
    {
        Temperature? t = EU.Temperature.FromDegreeCelsius(21.5);
        Assert.AreEqual(294.65, t!.Value.Kelvin, 1e-12);

        Length? l = EU.Length.FromFoot(3);
        Assert.AreEqual(0.9144, l!.Value.Meter, 1e-15);
    }

    [TestMethod]
    public void SameBitsAsToFast()
    {
        EU.MassFlow m = EU.MassFlow.FromKilogramPerHour(1234.5678);
        MassFlow? implicitly = m;
        Assert.AreEqual(BitConverter.DoubleToInt64Bits(m.ToFast().SI), BitConverter.DoubleToInt64Bits(implicitly!.Value.SI));
    }

    [TestMethod]
    public void NullStaysNull()
    {
        EU.Pressure? none = null;
        Pressure? p = none;
        Assert.IsNull(p);
        Assert.IsNull(Temperature.FromKelvin(300) - (EU.Temperature?)null);
    }

    [TestMethod]
    public void MixedArithmetic_UsesFastOperators()
    {
        var fast = Temperature.FromKelvin(300);
        EU.Temperature classic = EU.Temperature.FromKelvin(290);

        Temperature? d1 = fast - classic;
        Temperature? d2 = classic - fast;
        Assert.AreEqual(10, d1!.Value.Kelvin, 1e-12);
        Assert.AreEqual(-10, d2!.Value.Kelvin, 1e-12);
        Assert.IsTrue(fast > classic);
        Assert.IsTrue(Temperature.FromKelvin(290) == classic);

        Temperature? dT = fast - classic;
        Power q = MassFlow.FromKilogramPerSecond(2) * SpecificEntropy.FromJoulePerKilogramKelvin(4180) * dT.Value;
        Assert.AreEqual(83600, q.Watt, 1e-9);
    }

    [TestMethod]
    public void IntoNullableFastParameter()
    {
        static double? Kelvin(Temperature? t) => t?.Kelvin;
        Assert.AreEqual(273.15, Kelvin(EU.Temperature.FromDegreeCelsius(0))!.Value, 1e-12);
    }
}
