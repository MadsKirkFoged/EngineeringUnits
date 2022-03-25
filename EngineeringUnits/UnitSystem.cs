using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System;
//using System.Text.Json.Serialization;

namespace EngineeringUnits
{

    



    public class UnitSystem 
    {      
        public static readonly UnitSystem UnitsystemForDouble = new();


        //private bool SI { get; init; }

        public string Symbol { get; init; }
     

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public readonly IReadOnlyList<UnitEnumbase> ListOfUnits = new List<UnitEnumbase>();


        public UnitSystem() {}

        public UnitSystem(List<UnitEnumbase> LocalUnitList, string symbol = null)
        {
            ListOfUnits = ReduceUnits(LocalUnitList);
            Symbol = symbol;
        }


        public UnitSystem(UnitEnumbase unit, string symbol): this(new List<UnitEnumbase>() { unit }, symbol) {}
        public UnitSystem(UnitEnumbase unit) :               this(unit, null) { }
        public UnitSystem(decimal unit, string symbol) :    this(new CombinedUnit(unit), symbol) { }


        public UnitSystem(UnitSystem unit, string symbol)
        {
            ListOfUnits = new List<UnitEnumbase>(unit.ListOfUnits);
            Symbol = symbol;
        }


        private List<(BaseunitType Key, int Value)> _UnitsCount;
        public List<(BaseunitType Key, int Value)> UnitsCount()
        {
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

            //return ListOfUnits
            //        .Where(x => x.TypeOfUnit != "CombinedUnit")
            //        .GroupBy(x => x.TypeOfUnit)
            //        .Select(x => (x.Key, x.Sum(x => x.Count)))
            //        .Where(x => x.Item2 != 0)
            //        .ToList();
        }

        public static bool operator ==(UnitSystem a, UnitSystem b)
        {
            //var aUnitsCount = a.UnitsCount();
            //var bUnitsCount = b.UnitsCount();


            //var test = aUnitsCount.All(bUnitsCount.Contains) &&
            //           aUnitsCount.Count == bUnitsCount.Count;

            //var test2 = a.GetHashCodeForUnitCompare();
            //var test3 = b.GetHashCodeForUnitCompare();

            return a.GetHashCodeForUnitCompare() == b.GetHashCodeForUnitCompare();
        }
        public static bool operator !=(UnitSystem a, UnitSystem b)
        {
            return !(a == b);
        }

        private Fraction _sumConstant;
        public Fraction SumConstant()
        {
            if (_sumConstant == Fraction.Zero)
            {
                _sumConstant = ListOfUnits.Aggregate(Fraction.One, (x, y) => x * y.TotalConstant);
            }

            return _sumConstant;
        }

        public Fraction SumOfBConstants()
        {
            return ListOfUnits.Aggregate(Fraction.Zero, (x, y) => x + (Fraction)y.B);
        }
        public Fraction ConvertionFactor(UnitSystem To)
        {
            return To.SumConstant() / SumConstant();
        }


        public static UnitSystem Add(UnitSystem a, UnitSystem b)
        {
            if (a != b)            
                throw new WrongUnitException($"Failed to do: {a} + {b}. Expected both units to be the same!");
            

            //Using 'a's unitsystem as the final system
            return a;
        }
        public static UnitSystem Subtract(UnitSystem a, UnitSystem b)
        {
            if (a != b)            
                throw new WrongUnitException($"Failed to do: {a} - {b}. Expected both units to be the same!");
            

            //Using a unitsystem as the final system
            return a;

        }
        public static UnitSystem Multiply(UnitSystem a, UnitSystem b)
        {
            int hashCode;
            unchecked 
            { 
                hashCode = a.GetHashCode() * 11270411 + b.GetHashCode() * 18403087;            
            }
            

            if (CacheMultiply.TryGetValue(hashCode, out UnitSystem local))
            {
                return local;
            } 

            var test2 = new UnitSystem(
                        new List<UnitEnumbase>(
                            a.ListOfUnits.Concat(
                            b.ListOfUnits)));

            CacheMultiply.Add(hashCode, test2);

            return test2;
        }
        public static UnitSystem Multiply(UnitSystem a, decimal constant)
        {
            if (constant == 1)            
                return a;
            


            List<UnitEnumbase> LocalUnitList = new();

            LocalUnitList.AddRange(a.ListOfUnits);
            LocalUnitList.Add(new CombinedUnit(constant));

            return new UnitSystem(LocalUnitList, a.Symbol);

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {

            int hashCode;
            unchecked
            {
                hashCode = a.GetHashCode() * 11270411 + b.GetHashCode() * 18403087;
            }




            if (CacheDivide.TryGetValue(hashCode, out UnitSystem local))
            {
                return local;
            }


            List<UnitEnumbase> LocalUnitList = new(a.ListOfUnits);

            foreach (var item in b.ListOfUnits)
                LocalUnitList.Add(item.CloneAndReverseCount());


            var test2 = new UnitSystem(LocalUnitList);

            CacheDivide.Add(hashCode, test2);

            return test2;



            //List<Enumeration> LocalUnitList = new(a.ListOfUnits);

            //foreach (var item in b.ListOfUnits)            
            //    LocalUnitList.Add(item.CloneAndReverseCount());        


            //return new UnitSystem(LocalUnitList);

        }


        //Cache unitsystem when multiply
        private static readonly Dictionary<int, UnitSystem> CacheMultiply = new();
        private static readonly Dictionary<int, UnitSystem> CacheDivide = new();



        public static UnitSystem operator +(UnitSystem left, UnitSystem right) => Add(left, right);
        public static UnitSystem operator -(UnitSystem left, UnitSystem right) => Subtract(left, right);

        public static UnitSystem operator *(UnitSystem left, UnitSystem right) => Multiply(left, right);
        public static UnitSystem operator *(decimal left, UnitSystem right) => Multiply(right, left);
        public static UnitSystem operator *(UnitSystem left, decimal right) => Multiply(left, right);
        public static UnitSystem operator /(UnitSystem left, UnitSystem right) => Divide(left, right);




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


        public static List<UnitEnumbase> ReduceUnits(List<UnitEnumbase> ListToBeReduced)
        {

           var test = ListToBeReduced.GroupBy(x => x.UnitType);

            var NewUnitList = new List<UnitEnumbase>();

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

                        UnitEnumbase NewUnit = new(item.First(), 
                                                              item.Sum(x => x.Count));

                        NewUnitList.Add(NewUnit);

                    }
                }           

            }

            return NewUnitList;
        }


        public UnitSystem Sqrt()
        {

            var NewUnitList = new List<UnitEnumbase>();

            foreach (var item in ListOfUnits.Where(x => x.UnitType is not BaseunitType.CombinedUnit))
            {
                if (item.Count % 2 != 0)                
                    throw new WrongUnitException($"We can't handle taking the square root of your unit! If the resulting unit ends in ex. [meter^0.5] you get this error.");

                NewUnitList.Add(new(item, item.Count/2));
            }

            var combinedUnit = ListOfUnits.Where(x => x.UnitType is BaseunitType.CombinedUnit).FirstOrDefault();

            if (combinedUnit is not null)            
                 NewUnitList.Add(new CombinedUnit("", combinedUnit.A.Sqrt()));
            


            return new(NewUnitList);       
        }
       


        private int HashCode;

        public override int GetHashCode()
        {
            if (HashCode == 0)
            {

                HashCode = (int)795945743;                


                foreach (var item in ListOfUnits.OrderBy(x => x.UnitType))
                {
                    //HashCode += item.GetHashCode();
                    HashCode = (HashCode * 512265997) ^ item.GetHashCode();
                }
            }

            return HashCode;
        }

        public static bool  EqualWithoutHash(UnitSystem a, UnitSystem b)
        { 
            int aCount;
            decimal aB = 0;
            Fraction aNewC;
            BaseunitType aType;            

            bool equal = false;


            if (a.ListOfUnits.Count != b.ListOfUnits.Count)
            {
                equal = false;
            }
            else
            {
                for (int i = 0; i < a.ListOfUnits.Count(); i++)
                {
                    aCount = a.ListOfUnits[i].Count;
                    aB = a.ListOfUnits[i].B;
                    aNewC = a.ListOfUnits[i].A;
                    aType = a.ListOfUnits[i].UnitType;
                    for ( int j=0; j <b.ListOfUnits.Count(); j++)
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

      



        private int HashCodeForUnitCompare;

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

        public UnitSystem Clone()
        {
            return new UnitSystem(new List<UnitEnumbase>(ListOfUnits), Symbol);
        }


        public bool IsSIUnit()
        {
          return ListOfUnits.All(x=> x.IsSI);
        }

      

    }
}
