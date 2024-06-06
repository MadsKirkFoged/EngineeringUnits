using Fractions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace EngineeringUnits;

// A unitsystem is list of RawUnits
// It represent how a unit of measure is defined
// --> It does not know the value of the unit!
// --> Combined with a value you get the BaseUnit class..
// ex if you have a list of {length+1, duration-1} that could represent a speed [m/s] 

public class UnitSystem
{
    public string? Symbol { get; init; }

    //[JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
    public IEnumerable<RawUnit> ListOfUnits { get; init; }

    public UnitSystem()
    {
        ListOfUnits = [];
    }

    public UnitSystem(List<RawUnit> LocalUnitList, string? symbol = null)
    {
        ListOfUnits = LocalUnitList.ReduceUnits();
        Symbol = symbol;
    }

    public UnitSystem(RawUnit unit) : this([unit]) { }
    public UnitSystem(decimal unit, string? symbol)
    {
        //Adding just a dimensionless unit
        var dimensionless = new RawUnit()
        {
            Symbol=symbol,
            A = new(unit),
            UnitType = BaseunitType.CombinedUnit,
            B = 0,
            Count = 1,
        };

        ListOfUnits = [dimensionless];
    }

    public UnitSystem(UnitSystem unit, string? symbol)
    {
        ListOfUnits = new List<RawUnit>(unit.ListOfUnits);
        Symbol = symbol;
    }

    public static bool operator ==(UnitSystem a, UnitSystem b)
    {
        return a.GetHashCodeForUnitTypeCompare() == b.GetHashCodeForUnitTypeCompare();
    }
    public static bool operator !=(UnitSystem a, UnitSystem b)
    {
        return !(a == b);
    }

    public override bool Equals(object? obj)
    {
        //Check for null and compare run-time types.
        if ((obj is null) || !GetType().Equals(obj.GetType()))
            return false;
        else
            return this == (UnitSystem)obj;
    }

    public bool Equals(UnitSystem other) => this == other;

    public static UnitSystem operator +(UnitSystem left, UnitSystem right)
    {
        if (left != right)
            throw new WrongUnitException($"Failed to do: {left} + {right}. Expected both units to be the same!");

        //Using left unitsystem as the final system
        return left;
    }
    public static UnitSystem operator -(UnitSystem left, UnitSystem right)
    {
        if (left != right)
            throw new WrongUnitException($"Failed to do: {left} - {right}. Expected both units to be the same!");

        //Using left unitsystem as the final system
        return left;

    }

    private static readonly ConcurrentDictionary<int, UnitSystem> CacheMultiply = new();
    public static UnitSystem operator *(UnitSystem left, UnitSystem right)
    {
        var Hashes = (left.GetHashCode() * 512265997) ^ right.GetHashCode();

        if (CacheMultiply.TryGetValue(Hashes, out UnitSystem? local))
            return local;

        var test2 = new UnitSystem(new List<RawUnit>(left.ListOfUnits.Concat(right.ListOfUnits)));

        //test2 = test2.ReduceUnitsHard();

        _ = CacheMultiply.TryAdd(Hashes, test2);

        return test2;
    }

    public static UnitSystem operator *(decimal left, UnitSystem right)
    {
        return right * left;
    }
    public static UnitSystem operator *(UnitSystem left, decimal right)
    {
        if (right == 1)
            return left;

        List<RawUnit> LocalUnitList = [.. left.ListOfUnits];
        //LocalUnitList.Add(new CombinedUnit(constant));

        var dimensionless = new RawUnit()
        {
            Symbol=null,
            A = new(right),
            UnitType = BaseunitType.CombinedUnit,
            B = 0,
            Count = 1,

        };
        LocalUnitList.Add(dimensionless);

        return new UnitSystem(LocalUnitList, left.Symbol);

    }

    private static readonly ConcurrentDictionary<int, UnitSystem> CacheDivide = new();
    public static UnitSystem operator /(UnitSystem left, UnitSystem right)
    {
        var Hashes = (left.GetHashCode() * 512265997) ^ right.GetHashCode();

        if (CacheDivide.TryGetValue(Hashes, out UnitSystem? local))
            return local;

        List<RawUnit> LocalUnitList = new(left.ListOfUnits);

        foreach (RawUnit item in right.ListOfUnits)
            LocalUnitList.Add(item.CloneAndReverseCount());

        var DividedUnit = new UnitSystem(LocalUnitList);

        ////Normalize the unit
        //var NewUnit = DividedUnit.ReduceUnitsHard();

        ////What is the diff between DividedUnit and NewUnit?
        //var factor = NewUnit.ConvertionFactor(DividedUnit);

        //if (factor != Fraction.One)
        //{

        //    RawUnit? combinedUnit = LocalUnitList.Where(x => x.UnitType is BaseunitType.CombinedUnit)
        //                                         .FirstOrDefault();


        //    if (combinedUnit is null)
        //    {

        //        var dimensionless = new RawUnit()
        //        {
        //            Symbol=null,
        //            A = factor,
        //            UnitType = BaseunitType.CombinedUnit,
        //            B = 0,
        //            Count = 1,
        //        };

        //        LocalUnitList.Add(dimensionless);
        //    }
        //    else
        //    {
        //        combinedUnit = combinedUnit with { A = combinedUnit.A  * factor };
        //    }
        //}


        //DividedUnit = new UnitSystem(LocalUnitList);

        _ = CacheDivide.TryAdd(Hashes, DividedUnit);

        return DividedUnit;

    }

    public override string ToString()
    {

        if (Symbol is not null)
            return Symbol;

        //Creates all positive symbols
        var local = ListOfUnits
            .Where(x => x.Count > 0)
            .Aggregate("", (x, y) => x += $"{y.Symbol}{y.Count.ToSuperScript()}");

        //If any negative values are present create a '/'
        if (ListOfUnits.Any(x => x.Count < 0))
            local += "/";

        //Creates all negative symbols
        local += ListOfUnits
            .Where(x => x.Count < 0)
            .Aggregate("", (x, y) => x += $"{y.Symbol}{(y.Count * -1).ToSuperScript()}");

        return local;
    }

    private int HashCodeCached;
    public override int GetHashCode()
    {
        if (HashCodeCached is not 0)
            return HashCodeCached;

        int TempHashCode;
        unchecked // Overflow is fine, just wrap
        {
            TempHashCode = 795945743;

            foreach (RawUnit item in ListOfUnits.OrderBy(x => x.UnitType))
            {
                TempHashCode = (TempHashCode * 512265997) ^ item.GetHashCode();
            }
        }

        HashCodeCached = TempHashCode;

        return TempHashCode;
    }

    internal int HashCodeForUnitCompare;
    public int GetHashCodeForUnitTypeCompare()
    {
        //This can tell if two units is of the same type
        //ex meter and feet is both length and would return the same hashcode

        if (HashCodeForUnitCompare is 0)
        {

            //Exemple of output:
            //Mass - 2
            //Length - 1
            //Duration - 3

            IOrderedEnumerable<(BaseunitType Key, int)> _UnitsCount = ListOfUnits
                              .Where(x => x.UnitType is not BaseunitType.CombinedUnit)
                              .GroupBy(x => x.UnitType)
                              .Select(x => (x.Key, x.Sum(x => x.Count)))
                              .Where(x => x.Item2 != 0)
                              .OrderBy(x => x.Key)
                              .ThenBy(x => x.Item2);

            HashCode hashCode = new();

            foreach ((BaseunitType Key, var Value) in _UnitsCount)
            {
                hashCode.Add(Key);
                hashCode.Add(Value);
            }

            HashCodeForUnitCompare = hashCode.ToHashCode();
        }

        return HashCodeForUnitCompare;
    }

    private bool? isSIUnit = null;
    public bool IsSIUnit()
    {
        if (isSIUnit is null)
            isSIUnit = ListOfUnits.All(x => x.IsSI);

        return (bool)isSIUnit;
    }
}
