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

        internal string Symbol { get; init; }     

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
                                .Where(x => x.UnitType is not BaseunitType.CombinedUnit)
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

        private static readonly object FactorLock = new object();
        public Fraction ConvertionFactor(UnitSystem To)
        {
            lock (FactorLock)
            {
                var Hashes = (GetHashCode(), To.GetHashCode());

                if (CacheFactor.TryGetValue(Hashes, out Fraction local))
                    return local;

                var test = To.SumConstant() / SumConstant();
                var AlreadyAdded = CacheFactor.TryAdd(Hashes, test);
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


        private static readonly object MultiplyLock = new object();
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

        private static readonly object DivideLock = new object();

        public static UnitSystem operator /(UnitSystem left, UnitSystem right)
        {
            lock (DivideLock)
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

            var equal = false;


            if (a.ListOfUnits.Count != b.ListOfUnits.Count)
            {
                equal = false;
            }
            else
            {
                for (var i = 0; i < a.ListOfUnits.Count; i++)
                {
                    aCount = a.ListOfUnits[i].Count;
                    var aB = a.ListOfUnits[i].B;
                    aNewC = a.ListOfUnits[i].A;
                    aType = a.ListOfUnits[i].UnitType;
                    for (var j = 0; j <b.ListOfUnits.Count; j++)
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


            return (bool)isSIUnit;
        }

        //Cache
        internal static readonly ConcurrentDictionary<(int,int), UnitSystem> CacheDivide = new();
        internal static readonly ConcurrentDictionary<(int,int), UnitSystem> CacheMultiply = new();
        internal static readonly ConcurrentDictionary<(int,int), Fraction> CacheFactor = new();

        internal List<(BaseunitType Key, int Value)> _UnitsCount;
        internal int HashCode;
        internal Fraction _sumConstant;
        internal int HashCodeForUnitCompare;
        internal bool? isSIUnit = null;

    }
}
