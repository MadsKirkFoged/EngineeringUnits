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
    //[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UnitSystem
    {
        //[JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Symbol { get; set; }       

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public readonly IReadOnlyList<Enumeration> ListOfUnits = new List<Enumeration>();
        //public List<Enumeration> ListOfUnits = new List<Enumeration>();

        public UnitSystem()
        {
        }

        public UnitSystem(string symbol)
        {
            Symbol = symbol;
        }

        public UnitSystem(List<Enumeration> LocalUnitList)
        {
            ListOfUnits = ReduceUnits(LocalUnitList);
        }

        public UnitSystem(List<Enumeration> LocalUnitList, string symbol)
        {
            ListOfUnits = ReduceUnits(LocalUnitList);
            Symbol = symbol;
        }

        public UnitSystem(Enumeration unit)
        {
            List<Enumeration> LocalUnitList = new();

            LocalUnitList.Add(unit);

            ListOfUnits = LocalUnitList;
        }

        public UnitSystem(Enumeration unit, string symbol)
        {
            List<Enumeration> LocalUnitList = new();

            LocalUnitList.Add(unit);

            ListOfUnits = LocalUnitList;

            Symbol = symbol;
        }

        public UnitSystem(decimal unit, string symbol)
        {
            List<Enumeration> LocalUnitList = new();

            LocalUnitList.Add(new CombinedUnit("", (Fraction)unit));

            ListOfUnits = LocalUnitList;

            Symbol = symbol;
        }

        public UnitSystem(UnitSystem unit, string symbol)
        {
            List<Enumeration> LocalUnitList = new List<Enumeration>();
            LocalUnitList.AddRange(unit.ListOfUnits);

            ListOfUnits = LocalUnitList;
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
            List<Enumeration> LocalUnitList = new List<Enumeration>();

            LocalUnitList.AddRange(a.ListOfUnits);
            LocalUnitList.AddRange(b.ListOfUnits);

            return new UnitSystem(LocalUnitList);

        }
        public static UnitSystem Multiply(UnitSystem a, decimal constant)
        {
            if (constant == 1)            
                return a;
            


            List<Enumeration> LocalUnitList = new List<Enumeration>();

            LocalUnitList.AddRange(a.ListOfUnits);
            LocalUnitList.Add(new CombinedUnit("", (Fraction)constant));

            return new UnitSystem(LocalUnitList, a.Symbol);

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            List<Enumeration> LocalUnitList = new List<Enumeration>();

            LocalUnitList.AddRange(a.ListOfUnits);


            foreach (var item in b.ListOfUnits)
            {
                Enumeration test = (Enumeration)item.Clone();
                test.Count *= -1;

                LocalUnitList.Add(test);
            }

           

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
            {
                return Symbol;
            }


             string local = "";

            //New Way
            foreach (var unit in ListOfUnits)
            {

                if (unit is object && unit.Count > 0)
                {

                    if (unit is object)
                        local += unit.Symbol;

                    if (unit.Count > 1)
                        local += $"{ToSuperScript(unit.Count)}";
                }
            }



            //If any negative values
            if (ListOfUnits.Any(x => x.Count < 0))            
                local += "/";



            foreach (var unit in ListOfUnits)
            {

                if (unit is object && unit.Count < 0)
                {
                    local += unit.Symbol;

                    if (unit.Count < -1)
                        local += $"{ToSuperScript(unit.Count * -1)}";

                }


            }

                return local;
        }

        private static string ToSuperScript(int number)
        {
            const string SuperscriptDigits =
                "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

            string superscript = new(number.ToString().Select(x => SuperscriptDigits[x - '0'])
                                    .ToArray());

            return superscript;

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

                        Enumeration NewUnit = (Enumeration)item.First().Clone();

                        NewUnit.Count = item.Sum(x => x.Count);

                        NewUnitList.Add(NewUnit);

                    }
                }           

            }

            return NewUnitList;
        }

       
        public UnitSystem Pow(int toPower)
        {

            if (toPower == 1)
                return this;

            UnitSystem local = new();

            if (toPower == 0)
                return local;


            if (toPower > 1)
                for (int i = 0; i < toPower; i++)
                    local *= this;


            if (toPower < 0)
                for (int i = 0; i > toPower; i--)
                    local /= this;



            return local;
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
        public static decimal Sqrt(decimal x, decimal epsilon = 0.0M)
        {
            if (x < 0) throw new OverflowException("Cannot calculate square root from a negative number");

            decimal current = (decimal)Math.Sqrt((double)x), previous;
            do
            {
                previous = current;
                if (previous == 0.0M) return 0;
                current = (previous + x / previous) / 2;
            }
            while (Math.Abs(previous - current) > epsilon);
            return current;
        }


        public override int GetHashCode()
        {


            HashCode hashCode = new();
            hashCode.Add(Symbol);
            hashCode.Add(ListOfUnits);         

            return hashCode.ToHashCode();
        }

        public UnitSystem Clone()
        {
            List<Enumeration> LocalUnitList = new List<Enumeration>();
            LocalUnitList.AddRange(ListOfUnits);

            return new UnitSystem(LocalUnitList, Symbol);
        }


    }
}
