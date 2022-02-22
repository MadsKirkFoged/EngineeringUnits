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
        public string Symbol { get; init; }

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public readonly IReadOnlyList<Enumeration> ListOfUnits = new List<Enumeration>();


        public UnitSystem() {}

        public UnitSystem(List<Enumeration> LocalUnitList, string symbol = null)
        {
            ListOfUnits = ReduceUnits(LocalUnitList);
            Symbol = symbol;
        }


        public UnitSystem(Enumeration unit, string symbol): this(new List<Enumeration>() { unit }, symbol) {}
        public UnitSystem(Enumeration unit) :               this(unit, null) { }
        public UnitSystem(decimal unit, string symbol) :    this(new CombinedUnit(unit), symbol) { }


        public UnitSystem(UnitSystem unit, string symbol)
        {
            ListOfUnits = new List<Enumeration>(unit.ListOfUnits);
            Symbol = symbol;
        }

        public List<Tuple<string,int>> UnitsCount()
        {
            //This returns <typeOfUnit,Unit Count of the specifig type>

            return ListOfUnits
                    .Where(x => x.TypeOfUnit != "CombinedUnit")
                    .GroupBy(x => x.TypeOfUnit)
                    .Select(x => new Tuple<string, int>(x.Key, x.Sum(x => x.Count)))
                    .Where(x=> x.Item2 != 0)
                    .ToList();
        }

        public static bool operator ==(UnitSystem a, UnitSystem b)
        {
            return a.UnitsCount().All(b.UnitsCount().Contains) && 
                   a.UnitsCount().Count == b.UnitsCount().Count;         
        }
        public static bool operator !=(UnitSystem a, UnitSystem b)
        {
            return !(a == b);
        }


        public Fraction SumConstant()
        {
            return ListOfUnits.Aggregate(Fraction.One, (x, y) => x * y.TotalConstant);            
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
            return new UnitSystem(
                        new List<Enumeration>(
                            a.ListOfUnits.Concat(
                            b.ListOfUnits)));
        }
        public static UnitSystem Multiply(UnitSystem a, decimal constant)
        {
            if (constant == 1)            
                return a;
            


            List<Enumeration> LocalUnitList = new List<Enumeration>();

            LocalUnitList.AddRange(a.ListOfUnits);
            LocalUnitList.Add(new CombinedUnit(constant));

            return new UnitSystem(LocalUnitList, a.Symbol);

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            List<Enumeration> LocalUnitList = new(a.ListOfUnits);

            foreach (var item in b.ListOfUnits)            
                LocalUnitList.Add(item.CloneAndReverseCount());        


            return new UnitSystem(LocalUnitList);

        }

        

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


        public List<Enumeration> ReduceUnits(List<Enumeration> ListToBeReduced)
        {

           var test = ListToBeReduced.GroupBy(x => x.TypeOfUnit);

            var NewUnitList = new List<Enumeration>();

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
                        .GroupBy(x => x.NewC);

     
                    foreach (var item in groupOfSameConstant)
                    {

                        Enumeration NewUnit = new Enumeration(item.First(), 
                                                              item.Sum(x => x.Count));

                        NewUnitList.Add(NewUnit);

                    }
                }           

            }

            return NewUnitList;
        }


        public List<Enumeration> ReduceUnits2(List<Enumeration> ListToBeReduced)
        {
            //This reduces units of the same baseunit-type but with different types 

            var test = ListToBeReduced.GroupBy(x => x.TypeOfUnit);

            var NewUnitList = new List<Enumeration>();

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
                        .GroupBy(x => x.NewC);


                    
                }

            }

            return NewUnitList;




        }


       


        //public UnitSystem Sqrt()
        //{

        //    UnitSystem local = new();


        //    local.Length = (LengthUnit)SqrtBaseUnit(Length);
        //    local.Mass = (MassUnit)SqrtBaseUnit(Mass);
        //    local.Duration = (DurationUnit)SqrtBaseUnit(Duration);
        //    local.Electriccurrent = (ElectricCurrentUnit)SqrtBaseUnit(Electriccurrent);
        //    local.Temperature = (TemperatureUnit)SqrtBaseUnit(Temperature);
        //    local.LuminousIntensity = (LuminousIntensityUnit)SqrtBaseUnit(LuminousIntensity);
        //    local.Amount = (AmountOfSubstanceUnit)SqrtBaseUnit(Amount);


        //    if (Combined is object)
        //    {
        //        local.Combined = (CombinedUnit)Combined.Clone();
        //        local.Combined.SetNewGlobalC(Sqrt((decimal)Combined.NewC));
        //    }




        //    return local;

        //    static Enumeration SqrtBaseUnit(Enumeration me)
        //    {
        //        if (me is object)
        //        {
        //            Enumeration local = new Enumeration();

        //            if (me.Count % 2 != 0)
        //            {
        //                throw new WrongUnitException($"We can't handle taking the square root of your unit! If the resulting unit ends in ex. [meter^0.5] you get this error.");
        //            }

        //            local = (Enumeration)me.Clone();
        //            local.Count = (int)(local.Count / 2);

        //            return local;

        //        }

        //        return null;
        //    }


        //}

        // x - a number, from which we need to calculate the square root
        // epsilon - an accuracy of calculation of the root from our number.
        // The result of the calculations will differ from an actual value
        // of the root on less than epslion.
       


        public override int GetHashCode()
        {
            HashCode hashCode = new();
            hashCode.Add(Symbol);
            hashCode.Add(ListOfUnits);         

            return hashCode.ToHashCode();
        }

        public UnitSystem Clone()
        {
            return new UnitSystem(new List<Enumeration>(ListOfUnits), Symbol);
        }


    }
}
