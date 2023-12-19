using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace EngineeringUnits
{

    // A unitsystem is list of RawUnits
    // It represent how a unit of measure is defined
    // --> It does not know the value of the unit!
    // --> Combined with a value you get the BaseUnit class..
    // ex if you have a list of {length+1, duration-1} that could represent a speed [m/s] 

    public class UnitSystem 
    {      
        internal string Symbol { get; init; }     

        //[JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public ImmutableList<RawUnit> ListOfUnits { get; init; }

        public UnitSystem() 
        {
            ListOfUnits = ImmutableList<RawUnit>.Empty;
        }

        public UnitSystem(List<RawUnit> LocalUnitList, string symbol = null)
        {
            ListOfUnits = LocalUnitList.ReduceUnits().ToImmutableList();
            Symbol = symbol;
        }

        public UnitSystem(RawUnit unit) : this(new List<RawUnit>() {unit}) { }
        public UnitSystem(decimal unit, string symbol)
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

            ListOfUnits = new List<RawUnit>() {dimensionless}.ToImmutableList();
        }

        public UnitSystem(UnitSystem unit, string symbol)
        {
            ListOfUnits = new List<RawUnit>(unit.ListOfUnits).ToImmutableList();
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


        //static readonly object MultiplyLock = new object();
        static readonly ConcurrentDictionary<(int, int), UnitSystem> CacheMultiply = new();
        public static UnitSystem operator *(UnitSystem left, UnitSystem right)
        {
            //lock (MultiplyLock)
            {

            //if (!left.ListOfUnits.Any())            
            //    if (right.ListOfUnits.Any())                
            //        return right;

            //if (!right.ListOfUnits.Any())
            //    if (left.ListOfUnits.Any())
            //        return left;


            var Hashes = (left.GetHashCode(), right.GetHashCode());

            if (CacheMultiply.TryGetValue(Hashes, out UnitSystem local))
                return local;
                else if (CacheMultiply.TryGetValue((Hashes.Item2, Hashes.Item1), out UnitSystem local2))
                    return local2;



                var test2 = new UnitSystem(
                        new List<RawUnit>(
                            left.ListOfUnits.Concat(
                            right.ListOfUnits)));

                var AlreadyAdded = CacheMultiply.TryAdd(Hashes, test2);

                return test2;

            }



        }
        public static UnitSystem operator *(decimal left, UnitSystem right)
        {
            return right * left;
        }
        public static UnitSystem operator *(UnitSystem left, decimal right)
        {
            if (right == 1)
                return left;



            List<RawUnit> LocalUnitList = new();

            LocalUnitList.AddRange(left.ListOfUnits);
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


        //static readonly object DivideLock = new object();
        static readonly ConcurrentDictionary<(int, int), UnitSystem> CacheDivide = new();
        public static UnitSystem operator /(UnitSystem left, UnitSystem right)
        {
            //lock (DivideLock)
            {

            var Hashes = (left.GetHashCode(), right.GetHashCode());

            if (CacheDivide.TryGetValue(Hashes, out UnitSystem local))
                return local;


                List<RawUnit> LocalUnitList = new(left.ListOfUnits);

                foreach (var item in right.ListOfUnits)
                    LocalUnitList.Add(item.CloneAndReverseCount());

                var DividedUnit = new UnitSystem(LocalUnitList);

                var AlreadyAdded = CacheDivide.TryAdd(Hashes, DividedUnit);

                return DividedUnit;
            }

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


        int HashCodeCached;
        public override int GetHashCode()
        {
            if (HashCodeCached is not 0)
                return HashCodeCached;


            int TempHashCode;
            unchecked // Overflow is fine, just wrap
            {
                TempHashCode = 795945743;

                foreach (var item in ListOfUnits.OrderBy(x => x.UnitType))
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


            if (HashCodeForUnitCompare == 0)
            {

                //Exemple of output:
                //Mass - 2
                //Length - 1
                //Duration - 3

                var _UnitsCount = ListOfUnits
                                  .Where(x => x.UnitType is not BaseunitType.CombinedUnit)
                                  .GroupBy(x => x.UnitType)
                                  .Select(x => (x.Key, x.Sum(x => x.Count)))
                                  .Where(x => x.Item2 != 0)
                                  .OrderBy(x => x.Key)
                                  .ThenBy(x => x.Item2);


                HashCode hashCode = new();               

                foreach (var (Key, Value) in _UnitsCount)
                {
                    hashCode.Add(Key);
                    hashCode.Add(Value);
                }

                HashCodeForUnitCompare = hashCode.ToHashCode();
            }

            return HashCodeForUnitCompare;
        }


        bool? isSIUnit = null;
        public bool IsSIUnit()
        {
            if (isSIUnit is null)            
                isSIUnit = ListOfUnits.All(x => x.IsSI);           

            return (bool)isSIUnit;
        }



    }
}
