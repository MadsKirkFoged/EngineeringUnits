using EngineeringUnits.Fast;
using System.Reflection;
using System.Text;

using EngineeringUnits.Units.Fast;

namespace UnitTests.Fast;

/// <summary>Every Fast unit against the original EngineeringUnits: factors, offsets, symbols and the generated members.</summary>
[TestClass]
public class CrossValidationTests
{
    private static readonly double[] Samples = [0, 1, -3.7, 21.5, 123.456, 1e-6, 5e5, 1234567.891];

    public static IEnumerable<object[]> AllQuantities() => Quantities.All.Select(q => new object[] { q.Name });

    [TestMethod]
    public void EveryOriginalQuantityIsTransferred()
    {
        // Every quantity that has units - with or without [UnitDimension] - except the ones knowingly left out
        string[] knowinglyLeftOut = ["ElectricConductance", "ElectricAdmittance"];   // a copy of Volume, and a stub, in EngineeringUnits

        var original = typeof(global::EngineeringUnits.BaseUnit).Assembly.GetExportedTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(global::EngineeringUnits.BaseUnit)))
            .Where(t => t != typeof(global::EngineeringUnits.UnknownUnit) && t != typeof(global::EngineeringUnits.Constants))
            .Where(t => t.GetCustomAttribute<ObsoleteAttribute>() is null)
            .Where(t => t.Assembly.GetType($"EngineeringUnits.Units.{t.Name}Unit") is not null)
            .Select(t => t.Name)
            .Except(knowinglyLeftOut)
            .ToHashSet();

        var fast = Quantities.All.Select(q => q.Name).ToHashSet();

        CollectionAssert.AreEquivalent(original.ToList(), fast.ToList());
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void ToSI_MatchesOriginal(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);
        var errors = new StringBuilder();

        foreach (var unit in info.Units)
        {
            foreach (var x in Samples)
            {
                var expected = OriginalExact.As(Original.Create(quantity, x, unit.Name), quantity, "SI");
                var actual = unit.ToSI(x);
                if (!Close.Enough(expected, actual))
                    errors.AppendLine($"{quantity}.{unit.Name} ToSI({x}): original {expected:R}, fast {actual:R}");
            }
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void FromSI_MatchesOriginal(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);
        var errors = new StringBuilder();

        foreach (var unit in info.Units)
        {
            foreach (var si in Samples)
            {
                var expected = OriginalExact.As(Original.Create(quantity, si, "SI"), quantity, unit.Name);
                var actual = unit.FromSI(si);
                if (!Close.Enough(expected, actual))
                    errors.AppendLine($"{quantity}.{unit.Name} FromSI({si}): original {expected:R}, fast {actual:R}");
            }
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void Symbols_MatchOriginal(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);
        foreach (var unit in info.Units)
            Assert.AreEqual(Original.Unit(quantity, unit.Name).ToString(), unit.Symbol, $"{quantity}.{unit.Name}");
    }

    /// <summary>FromKilowatt(x) / .Kilowatt use inlined constants - they must give exactly what the unit objects give.</summary>
    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void GeneratedMembers_BitIdenticalToUnitInfo(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);
        var errors = new StringBuilder();

        foreach (var unit in info.Units.Where(u => u.Name != "SI"))
        {
            var from = info.Type.GetMethod($"From{unit.Name}", [typeof(double)])!;
            var get = info.Type.GetProperty(unit.Name)!;

            foreach (var x in Samples)
            {
                var q = (IQuantity)from.Invoke(null, [x])!;
                if (q.SI != unit.ToSI(x))
                    errors.AppendLine($"From{unit.Name}({x}) = {q.SI:R}, unit.ToSI = {unit.ToSI(x):R}");

                var back = (double)get.GetValue(info.FromSI(x))!;
                if (!back.Equals(unit.FromSI(x)))
                    errors.AppendLine($".{unit.Name} of {x} = {back:R}, unit.FromSI = {unit.FromSI(x):R}");
            }
        }

        Assert.AreEqual("", errors.ToString());
    }

    /// <summary>The extra names (FromKelvins, ...) give what the same-named original member gives.</summary>
    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void ForwardedMembers_MatchOriginal(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);
        var unitNames = info.Units.Select(u => u.Name).ToHashSet();
        var original = Original.QuantityType(quantity);
        var siUnit = (global::EngineeringUnits.UnitTypebase)Original.Unit(quantity, "SI");
        var errors = new StringBuilder();

        var factories = info.Type.GetMethods(BindingFlags.Public | BindingFlags.Static)
            .Where(m => m.Name.StartsWith("From") && !unitNames.Contains(m.Name[4..]) && m.Name is not ("From" or "FromSI"))
            .Where(m => m.GetParameters() is [{ ParameterType: var t }] && t == typeof(double));

        foreach (var m in factories)
        {
            var o = original.GetMethods().First(x => x.Name == m.Name && x.GetParameters().Length == 1);
            foreach (var x in new[] { 1.0, 42.5 })
            {
                var arg = o.GetParameters()[0].ParameterType == typeof(double?) ? (object)(double?)x : x;
                var expected = global::EngineeringUnits.BaseUnitExtensions.GetValueAs((global::EngineeringUnits.BaseUnit)o.Invoke(null, [arg])!, siUnit.Unit).ToDouble();
                var actual = ((IQuantity)m.Invoke(null, [x])!).SI;
                if (!Close.Enough(expected, actual))
                    errors.AppendLine($"{quantity}.{m.Name}({x}): original {expected:R}, fast {actual:R}");
            }
        }

        var getters = info.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.PropertyType == typeof(double) && !unitNames.Contains(p.Name) && p.Name is not ("SI" or "AsSI"));   // AsSI: decimal in EngineeringUnits, tested on its own

        foreach (var p in getters)
        {
            var o = original.GetProperty(p.Name)!;
            // Pick an SI value that is ~42.5 in this unit: the original's getters go through decimal and lose digits
            // on tiny results (1 kg in Earth masses is 1.7e-25)
            var perSI = (double)p.GetValue(info.FromSI(1))!;
            var si = perSI == 0 ? 42.5 : 42.5 / perSI;
            var expected = (double)o.GetValue(Original.Create(quantity, si, "SI"))!;
            var actual = (double)p.GetValue(info.FromSI(si))!;
            if (!Close.Enough(expected, actual, 1e-9))
                errors.AppendLine($"{quantity}.{p.Name}: original {expected:R}, fast {actual:R}");
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void DefaultToString_MatchesOriginal(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);
        var errors = new StringBuilder();

        foreach (var x in Samples)
        {
            var expected = Original.ToString(Original.Create(quantity, x, "SI"));
            var actual = info.FromSI(x).ToString();
            if (expected != actual)
                errors.AppendLine($"{quantity} {x}: original '{expected}', fast '{actual}'");
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void DimensionAttribute_MatchesOriginal(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);
        var original = Original.QuantityType(quantity).GetCustomAttribute<global::EngineeringUnits.UnitDimensionAttribute>();

        // Without [UnitDimension] (Level, Dimensionless, ...) the dimension comes from the original's SI unit
        var expected = original is not null
            ? original.Types.Zip(original.Exponents).Where(p => p.Second != 0).ToDictionary(p => p.First.ToString(), p => p.Second)
            : ((global::EngineeringUnits.UnitTypebase)Original.Unit(quantity, "SI")).Unit.ListOfUnits
                .Where(r => r.UnitType != global::EngineeringUnits.BaseunitType.CombinedUnit)
                .GroupBy(r => r.UnitType.ToString())
                .Select(g => (g.Key, g.Sum(r => r.Count)))
                .Where(p => p.Item2 != 0)
                .ToDictionary(p => p.Key, p => p.Item2);

        var data = info.Type.GetCustomAttributesData().Single(a => a.AttributeType == typeof(UnitDimensionAttribute));
        var args = data.ConstructorArguments;
        var actual = new Dictionary<string, int>();
        for (int i = 0; i + 1 < args.Count; i += 2)
            actual[((BaseunitType)args[i].Value!).ToString()] = (int)args[i + 1].Value!;

        CollectionAssert.AreEquivalent(expected.ToList(), actual.ToList());
    }
}
