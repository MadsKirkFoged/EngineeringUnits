using System.Collections.Immutable;

namespace EngineeringUnits.Analyzers.Fast;

// Sorted (base unit, exponent) terms without zero exponents - same as in the EngineeringUnits analyzer
internal readonly struct DimVector : IEquatable<DimVector>
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
