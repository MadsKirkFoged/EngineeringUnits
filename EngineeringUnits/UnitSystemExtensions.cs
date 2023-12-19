using Fractions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace EngineeringUnits
{
    public static class UnitSystemExtensions
    {
        public static readonly UnitSystem UnitsystemForDouble = new();

        public static Fraction SumOfBConstants(this IEnumerable<RawUnit> me)
        {
            return me.Aggregate(Fraction.Zero, (x, y) => x + (Fraction)y.B);
        }

        public static Fraction SumOfBConstants(this UnitSystem me)
        {
            return me.ListOfUnits.SumOfBConstants();
        }

        public static UnitSystem Sqrt(this UnitSystem local)
        {

            var NewUnitList = new List<RawUnit>();

            foreach (var item in local.ListOfUnits.Where(x => x.UnitType is not BaseunitType.CombinedUnit))
            {
                if (item.Count % 2 != 0)
                    throw new WrongUnitException($"We can't handle taking the square root of your unit! If the resulting unit ends in ex. [meter^0.5] you get this error.");

                NewUnitList.Add(item.CloneWithNewCount(item.Count/2));
            }

            var combinedUnit = local.ListOfUnits.Where(x => x.UnitType is BaseunitType.CombinedUnit).FirstOrDefault();

            if (combinedUnit is not null)
            {

                var dimensionless = new RawUnit()
                {
                    Symbol=null,
                    A = combinedUnit.A.Sqrt(),
                    UnitType = BaseunitType.CombinedUnit,
                    B = 0,
                    Count = 1,
                };

                NewUnitList.Add(dimensionless);
            }
            return new(NewUnitList);
        }


        public static UnitSystem GetSIUnitsystem(this UnitSystem local)
        {

            var SIUnitList = new List<RawUnit>();

            var test = local.ListOfUnits
                            .Select(x => x.CloneAsSI())
                            .ToList();

            return new UnitSystem(test);
        }



        static readonly ConcurrentDictionary<(int, int), Fraction> CacheFactor = new();
        static readonly object FactorLock = new object();
        public static Fraction ConvertionFactor(this UnitSystem From, UnitSystem To)
        {
            lock (FactorLock)
            {
                var Hashes = (From.GetHashCode(), To.GetHashCode());

                if (CacheFactor.TryGetValue(Hashes, out Fraction local))
                    return local;

                var test = To.SumConstant() / From.SumConstant();
                var AlreadyAdded = CacheFactor.TryAdd(Hashes, test);
                return test;
            }
        }


        static readonly ConcurrentDictionary<int, Fraction> SumConstantCache = new();
        public static Fraction SumConstant(this UnitSystem From)
        {
            var Hash = From.GetHashCode();

            if (SumConstantCache.TryGetValue(From.GetHashCode(), out Fraction local))
                return local;

            var test = From.ListOfUnits.Aggregate(Fraction.One, (x, y) => x * y.TotalConstant);
            var AlreadyAdded = SumConstantCache.TryAdd(Hash, test);
            return test;

        }


    }
}
