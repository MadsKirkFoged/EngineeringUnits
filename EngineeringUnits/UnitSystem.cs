using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System;
using System.Collections.Concurrent;

namespace EngineeringUnits
{

    // A unitsystem is list of RawUnits
    // It represent how a unit of measure is defined
    // --> It does not know the value of the unit!
    // --> Combined with a value you get the BaseUnit class..
    // ex if you have a list of {length+1, duration-1} that could represent a speed [m/s] 

    public class UnitSystem 
    {      
        public static readonly UnitSystem UnitsystemForDouble = new();

        public string Symbol { get; init; }     

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public readonly IReadOnlyList<RawUnit> ListOfUnits = new List<RawUnit>();


        public UnitSystem() {}

        public UnitSystem(List<RawUnit> LocalUnitList, string symbol = null)
        {
            ListOfUnits = ReduceUnits(LocalUnitList);
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

            ListOfUnits = new List<RawUnit>() {dimensionless};
        }

        public UnitSystem(UnitSystem unit, string symbol)
        {
            ListOfUnits = new List<RawUnit>(unit.ListOfUnits);
            Symbol = symbol;
        }

        public List<(BaseunitType Key, int Value)> UnitsCount()
        {
            //Exemple of output:
            //Mass - 2
            //Length - 1
            //Duration - 3


            if (_UnitsCount is null)
            {
                _UnitsCount = ListOfUnits
                                .Where(x => x.UnitType != BaseunitType.CombinedUnit)
                                .GroupBy(x => x.UnitType)
                                .Select(x => (x.Key, x.Sum(x => x.Count)))
                                .Where(x => x.Item2 != 0)
                                .ToList();
            }

            return _UnitsCount;
        }

        public static bool operator ==(UnitSystem a, UnitSystem b)
        {
            return a.GetHashCodeForUnitCompare() == b.GetHashCodeForUnitCompare();
        }
        public static bool operator !=(UnitSystem a, UnitSystem b)
        {
            return !(a == b);
        }

        
        public Fraction SumConstant()
        {
            if (_sumConstant == Fraction.Zero)            
                _sumConstant = ListOfUnits.Aggregate(Fraction.One, (x, y) => x * y.TotalConstant);            

            return _sumConstant;
        }
        public Fraction SumOfBConstants()
        {
            return ListOfUnits.Aggregate(Fraction.Zero, (x, y) => x + (Fraction)y.B);
        }

        private static readonly Object FactorLock = new Object();
        public Fraction ConvertionFactor(UnitSystem To)
        {
            //int hashCode = 512265997;
            //unchecked
            //{
            //    hashCode = (hashCode * 18403087) ^ GetHashCode();
            //    hashCode = (hashCode * 11270411) ^ To.GetHashCode();
            //}
            lock (FactorLock)
            {

            var Hashes = (GetHashCode(), To.GetHashCode());

            if (CacheFactorTest.TryGetValue(Hashes, out Fraction local))
                return local;

                var test = To.SumConstant() / SumConstant();
                var AlreadyAdded = CacheFactorTest.TryAdd(Hashes, test);
                return test;
            }
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


        private static readonly Object MultiplyLock = new Object();
        public static UnitSystem operator *(UnitSystem left, UnitSystem right)
        {
            lock (MultiplyLock)
            {

            if (!left.ListOfUnits.Any())            
                if (right.ListOfUnits.Any())                
                    return right;

            if (!right.ListOfUnits.Any())
                if (left.ListOfUnits.Any())
                    return left;


            var Hashes = (left.GetHashCode(), right.GetHashCode());

            if (CacheMultiplyTest.TryGetValue(Hashes, out UnitSystem local))
                return local;
            else if (CacheMultiplyTest.TryGetValue((Hashes.Item2, Hashes.Item1), out UnitSystem local2))
                return local2;



                var test2 = new UnitSystem(
                        new List<RawUnit>(
                            left.ListOfUnits.Concat(
                            right.ListOfUnits)));

                var AlreadyAdded = CacheMultiplyTest.TryAdd(Hashes, test2);

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

        private static readonly Object DivideLock = new Object();

        public static UnitSystem operator /(UnitSystem left, UnitSystem right)
        {
            lock (DivideLock)
            {

            var Hashes = (left.GetHashCode(), right.GetHashCode());

            if (CacheDivideTest.TryGetValue(Hashes, out UnitSystem local))
                return local;


                List<RawUnit> LocalUnitList = new(left.ListOfUnits);

                foreach (var item in right.ListOfUnits)
                    LocalUnitList.Add(item.CloneAndReverseCount());

                var DividedUnit = new UnitSystem(LocalUnitList);

                var AlreadyAdded = CacheDivideTest.TryAdd(Hashes, DividedUnit);

                return DividedUnit;
            }

        }


        public override string ToString()
        {

            if (Symbol is not null)
                return Symbol;


            //Creates all positive symbols
            string local = ListOfUnits
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

        public static List<RawUnit> ReduceUnits(List<RawUnit> ListToBeReduced)
        {

           var test = ListToBeReduced.GroupBy(x => x.UnitType);

            var NewUnitList = new List<RawUnit>();

            foreach (var GroupOfTypes in test)
            {

                if (GroupOfTypes.Count() <= 1)
                {
                    //just add the unit
                    NewUnitList.Add(GroupOfTypes.First());
                }
                else
                {

                    var groupOfSameConstant = GroupOfTypes
                        .Select(x => x)
                        .GroupBy(x => x.A);

     
                    foreach (var item in groupOfSameConstant)
                    {

                        RawUnit NewUnit = item.First().CloneWithNewCount(item.Sum(x => x.Count));

                        NewUnitList.Add(NewUnit);

                    }
                }           

            }

            return NewUnitList;
        }
        public UnitSystem Sqrt()
        {

            var NewUnitList = new List<RawUnit>();

            foreach (var item in ListOfUnits.Where(x => x.UnitType is not BaseunitType.CombinedUnit))
            {
                if (item.Count % 2 != 0)                
                    throw new WrongUnitException($"We can't handle taking the square root of your unit! If the resulting unit ends in ex. [meter^0.5] you get this error.");

                NewUnitList.Add(item.CloneWithNewCount(item.Count/2));
            }

            var combinedUnit = ListOfUnits.Where(x => x.UnitType is BaseunitType.CombinedUnit).FirstOrDefault();

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
       
        public override int GetHashCode()
        {
            if (HashCode == 0)
            {
                HashCode = (int)795945743;              

                foreach (var item in ListOfUnits.OrderBy(x => x.UnitType))
                {
                    HashCode = (HashCode * 512265997) ^ item.GetHashCode();
                }
            }

            return HashCode;
        }
        public static bool EqualWithoutHash(UnitSystem a, UnitSystem b)
        { 
            int aCount;
            Fraction aNewC;
            BaseunitType aType;            

            bool equal = false;


            if (a.ListOfUnits.Count != b.ListOfUnits.Count)
            {
                equal = false;
            }
            else
            {
                for (int i = 0; i < a.ListOfUnits.Count; i++)
                {
                    aCount = a.ListOfUnits[i].Count;
                    decimal aB = a.ListOfUnits[i].B;
                    aNewC = a.ListOfUnits[i].A;
                    aType = a.ListOfUnits[i].UnitType;
                    for ( int j=0; j <b.ListOfUnits.Count; j++)
                    {

                        if (aCount == b.ListOfUnits[i].Count &&
                            aB == b.ListOfUnits[i].B &&
                            aNewC == b.ListOfUnits[i].A &&
                            aType == b.ListOfUnits[i].UnitType)
                        {
                            equal = true;
                        }

                    }
              
                }

            }
            
            return equal;

           
        }
        public int GetHashCodeForUnitCompare()
        {
            if (HashCodeForUnitCompare == 0)
            {
                var test = UnitsCount().OrderBy(x => x.Key)
                                       .ThenBy(x => x.Value);

                HashCode hashCode = new();                

                //Debug.Print(hashCode.ToHashCode().ToString()); 

                foreach (var (Key, Value) in test)
                {
                    hashCode.Add(Key);
                    hashCode.Add(Value);
                }

                HashCodeForUnitCompare = hashCode.ToHashCode();
            }

            return HashCodeForUnitCompare;
        }



        public bool IsSIUnit()
        {
            if (isSIUnit is null)            
                isSIUnit = ListOfUnits.All(x => x.IsSI);
            

            //return ListOfUnits.All(x=> x.IsSI);
            return (bool)isSIUnit;
        }

        //public bool DoesIncludeTemperature()
        //{
        //    return ListOfUnits.Any(x => x.UnitType is BaseunitType.temperature);
        //}

        public UnitSystem GetSIUnitsystem()
        {

            List<RawUnit> SIUnitList = new List<RawUnit>();

            var test  = ListOfUnits.Select(x => x.CloneAsSI());

            foreach (var item in ListOfUnits)
            {
                SIUnitList.Add(item.CloneAsSI());
            }

            return new UnitSystem(SIUnitList);
        }

        //Cache
        private static readonly ConcurrentDictionary<int, UnitSystem> CacheMultiply = new();
        private static readonly ConcurrentDictionary<int, UnitSystem> CacheDivide = new();
        private static readonly ConcurrentDictionary<int, Fraction> CacheFactor = new();

        private static readonly ConcurrentDictionary<(int,int), UnitSystem> CacheDivideTest = new();
        private static readonly ConcurrentDictionary<(int, int), UnitSystem> CacheMultiplyTest = new();
        private static readonly ConcurrentDictionary<(int, int), Fraction> CacheFactorTest = new();

        private List<(BaseunitType Key, int Value)> _UnitsCount;
        private int HashCode;
        private Fraction _sumConstant;
        private int HashCodeForUnitCompare;
        private bool? isSIUnit = null;

    }
}
