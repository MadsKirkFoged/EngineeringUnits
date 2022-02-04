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
        [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty(PropertyName = "L", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LengthUnit Length { get; set; } //Length

        [JsonProperty(PropertyName = "M", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MassUnit Mass { get; set; } //Mass

        [JsonProperty(PropertyName = "D", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DurationUnit Duration { get; set; } //Duration

        [JsonProperty(PropertyName = "E", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ElectricCurrentUnit Electriccurrent { get; set; } //Electriccurrent

        [JsonProperty(PropertyName = "T", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TemperatureUnit Temperature { get; set; } //Temperature

        [JsonProperty(PropertyName = "A", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AmountOfSubstanceUnit Amount { get; set; } //Amount

        [JsonProperty(PropertyName = "LI", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LuminousIntensityUnit LuminousIntensity { get; set; } //LuminousIntensity

        [JsonProperty(PropertyName = "C", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CombinedUnit Combined { get; set; } //Combined

        public List<Enumeration> ListOfUnits = new List<Enumeration>();


        public UnitSystem()
        {
        }

        public UnitSystem(string symbol)
        {
            Symbol = symbol;
        }


        public static bool operator ==(UnitSystem a, UnitSystem b)
        {


            if (!Compareunits(a.Length, b.Length) ||
                !Compareunits(a.Mass, b.Mass) ||
                !Compareunits(a.Duration, b.Duration) ||
                !Compareunits(a.Electriccurrent, b.Electriccurrent) ||
                !Compareunits(a.Temperature, b.Temperature) ||
                !Compareunits(a.Amount, b.Amount) ||
                !Compareunits(a.LuminousIntensity, b.LuminousIntensity))
            { 
                return false;            
            }


            return true;


            //Local function
            static bool Compareunits(Enumeration a1, Enumeration b1)
            {

                if (a1 is object && b1 is object)
                {
                    if (a1.Count != b1.Count)                    
                        return false;                    
                }
                else if (a1 is object)
                {
                    if (a1.Count != 0)                    
                        return false;                    
                }
                else if (b1 is object)
                {
                    if (b1.Count != 0)                    
                        return false;                    
                }

                return true;

            }
        }
        public static bool operator !=(UnitSystem a, UnitSystem b)
        {
            return !(a == b);
        }


        public Fraction SumConstant()
        {
            Fraction test = 1;

            foreach (var item in ListOfUnits)
            {
                test *= item.TotalConstant;
            }

            return test;
        }

        public Fraction ConvertionFactor(UnitSystem To)
        {
            return To.SumConstant() / SumConstant();
        }


        public static UnitSystem Add(UnitSystem a, UnitSystem b)
        {
            if (a != b)
            {
                throw new WrongUnitException($"Failed to do: {a} + {b}. Expected both units to be the same!");
            }

            //Using a unitsystem as the final system
            return a;
        }
        public static UnitSystem Subtract(UnitSystem a, UnitSystem b)
        {
            if (a != b)
            {
                throw new WrongUnitException($"Failed to do: {a} - {b}. Expected both units to be the same!");
            }

            //Using a unitsystem as the final system
            return a;

        }
        public static UnitSystem Multiply(UnitSystem a, UnitSystem b)
        {

            UnitSystem local = new();

            local.Length = (LengthUnit)MultiplyLocal(a.Length, b.Length);
            local.Mass = (MassUnit)MultiplyLocal(a.Mass, b.Mass);
            local.Duration = (DurationUnit)MultiplyLocal(a.Duration, b.Duration);
            local.Electriccurrent = (ElectricCurrentUnit)MultiplyLocal(a.Electriccurrent, b.Electriccurrent);
            local.Temperature = (TemperatureUnit)MultiplyLocal(a.Temperature, b.Temperature);
            local.Amount = (AmountOfSubstanceUnit)MultiplyLocal(a.Amount, b.Amount);
            local.LuminousIntensity = (LuminousIntensityUnit)MultiplyLocal(a.LuminousIntensity, b.LuminousIntensity);


            //Testing a new way to store units

            foreach (var item in a.ListOfUnits)
            {
                local.ListOfUnits.Add(item);
            }

            foreach (var item in b.ListOfUnits)
            {
                local.ListOfUnits.Add(item);
            }



            if (a.Combined is object && b.Combined is object)
            {
                local.Combined = (CombinedUnit)a.Combined.Clone();
                local.Combined.SetNewGlobalC(local.Combined.NewC * b.Combined.NewC);
                local.Combined.Count += b.Combined.Count;
            }
            else if (a.Combined is object)
            {
                //local.C = (CombinedUnit)a.C.Clone();
                local.Combined = a.Combined;
            }
            else if (b.Combined is object)
            {
                //local.C = (CombinedUnit)b.C.Clone();
                local.Combined = b.Combined;
            }


            return local;

            static Enumeration MultiplyLocal(Enumeration a, Enumeration b)
            {
                Enumeration local = new Enumeration();


                if (a is object && b is object)
                {
                    local = (Enumeration)a.Clone();
                    local.Count += b.Count;

                    Fraction CombinedFraction = a.NewC / b.NewC;

                    CombinedFraction = Fraction.Pow(CombinedFraction, b.Count);
                    local.ActualC *= CombinedFraction * b.ActualC;
                    return local;
                }
                else if (a is object)
                {
                    //local.L = (LengthUnit)a.L.Clone();
                    local = a;
                    return local;
                }
                else if (b is object)
                {
                    //local.L = (LengthUnit)b.L.Clone();
                    local = b;
                    return local;
                }

                return null;

            }


        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            UnitSystem local = new();

            local.Length = (LengthUnit)DivideLocal(a.Length, b.Length);
            local.Mass = (MassUnit)DivideLocal(a.Mass, b.Mass);
            local.Duration = (DurationUnit)DivideLocal(a.Duration, b.Duration);
            local.Electriccurrent = (ElectricCurrentUnit)DivideLocal(a.Electriccurrent, b.Electriccurrent);
            local.Temperature = (TemperatureUnit)DivideLocal(a.Temperature, b.Temperature);
            local.Amount = (AmountOfSubstanceUnit)DivideLocal(a.Amount, b.Amount);
            local.LuminousIntensity = (LuminousIntensityUnit)DivideLocal(a.LuminousIntensity, b.LuminousIntensity);



            //Testing a new way to store units

            foreach (var item in a.ListOfUnits)
            {
                local.ListOfUnits.Add(item);
            }

            foreach (var item in b.ListOfUnits)
            {
                Enumeration test = (Enumeration)item.Clone();

                test.Count *= -1; 

                local.ListOfUnits.Add(test);
            }







            //COMBINED
            if (a.Combined is object && b.Combined is object)
            {
                local.Combined = (CombinedUnit)a.Combined.Clone();

                local.Combined.SetNewGlobalC(local.Combined.NewC / b.Combined.NewC);
                local.Combined.Count -= b.Combined.Count;
            }
            else if (a.Combined is object)
            {
                //local.C = (CombinedUnit)a.C.Clone();
                local.Combined = a.Combined;
            }
            else if (b.Combined is object)
            {
                local.Combined = (CombinedUnit)b.Combined.Clone();
                local.Combined.SetNewGlobalC(1 / b.Combined.NewC);
                local.Combined.Count *= -1;
            }


            return local;

            static Enumeration DivideLocal(Enumeration a, Enumeration b)
            {
                Enumeration local = new Enumeration();


                if (a is object && b is object)
                {
                    local = (Enumeration)a.Clone();
                    local.Count -= b.Count;

                    Fraction CombinedFraction = a.NewC / b.NewC;

                    CombinedFraction = Fraction.Pow(CombinedFraction, b.Count);
                    local.ActualC *= (1 / CombinedFraction) * b.ActualC;
                    return local;
                }
                else if (a is object)
                {
                    //local.L = (LengthUnit)a.L.Clone();
                    local = a;
                    return local;
                }
                else if (b is object)
                {
                    local = (Enumeration)b.Clone();
                    local.ActualC = 1 / local.ActualC;
                    local.Count *= -1;
                    return local;
                }

                return null;

            }

        }

        public static Fraction Convert(UnitSystem From, UnitSystem To)
        {

            Fraction CombinedFraction2 = 1;


            foreach (var ToUnit in To.UnitList())
            {
                foreach (var FromUnit in From.UnitList())
                {
                    if (ToUnit is object && FromUnit is object)
                    {

                        if (ToUnit.GetType() == FromUnit.GetType()  && ToUnit.GetType() != typeof(CombinedUnit))
                        {
                            Fraction CombinedFraction = FromUnit.NewC / ToUnit.NewC;

                            CombinedFraction = Fraction.Pow(CombinedFraction, FromUnit.Count);

                            CombinedFraction2 *= CombinedFraction;

                        }
                    }
                }
            }


            foreach (var FromUnit in From.UnitList())
            {
                CombinedFraction2 /= (Fraction)FromUnit.ActualC;                
            }

            foreach (var ToUnit in To.UnitList())
            {
                CombinedFraction2 *= (Fraction)ToUnit.ActualC;
            }


            foreach (var FromUnit in From.UnitList())
            {

                if (FromUnit.GetType() == typeof(CombinedUnit))
                {
                    CombinedFraction2 *= FromUnit.NewC;
                }
            }

            foreach (var ToUnit in To.UnitList())
            {

                if (ToUnit.GetType() == typeof(CombinedUnit))
                {
                    CombinedFraction2 /= ToUnit.NewC;
                }
            }

            return CombinedFraction2;
        }


        public static UnitSystem operator +(UnitSystem left, UnitSystem right) => Add(left, right);
        public static UnitSystem operator -(UnitSystem left, UnitSystem right) => Subtract(left, right);

        public static UnitSystem operator *(UnitSystem left, UnitSystem right) => Multiply(left, right);
        public static UnitSystem operator /(UnitSystem left, UnitSystem right) => Divide(left, right);


        public Fraction GetCombi()
        {
            Fraction CombinedFraction = 1;

            foreach (var Unit in UnitList())
            {
                if (Unit.GetType() == typeof(CombinedUnit))                
                    CombinedFraction *= Unit.NewC;                
            }

            return CombinedFraction;
        }

        public Fraction GetActualC()
        {
            Fraction a = 1;

            foreach (var item in UnitList())            
                if (item is object)                
                    a *= item.ActualC;
                
            


            return a;
        }

        public Fraction SumOfBConstants()
        {
            Fraction b = 0;

            foreach (var item in UnitList())
            {
                if (item is object)                
                    b += (Fraction)item.B;              
            }
            return b;
        }

        public decimal ConvertToBaseUnit() => (decimal)(GetCombi() / GetActualC());

        public override string ToString()
        {

             string local = "";

            

            foreach (var unit in UnitList())
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
            if (UnitList().Any(x => x.Count < 0))            
                local += "/";




            foreach (var unit in UnitList())
            {

                if (unit is object && unit.Count < 0)
                {
                    local += unit.Symbol;

                    if (unit.Count < -1)
                        local += $"{ToSuperScript(unit.Count * -1)}";

                }


            }

            

            //if (Symbol is object)
            //{
            //    return Symbol;
            //}
            //else
            //{
                return local;
            //}

        }

        private static string ToSuperScript(int number)
        {
            const string SuperscriptDigits =
                "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

            string superscript = new(number.ToString().Select(x => SuperscriptDigits[x - '0'])
                                    .ToArray());

            return superscript;

        }


        public IEnumerable<Enumeration> UnitList()
        {

            if (Length is object)
                yield return Length;

            if (Mass is object)
                yield return Mass;

            if (Duration is object)
                yield return Duration;

            if (Electriccurrent is object)
                yield return Electriccurrent;

            if (Temperature is object)
                yield return Temperature;

            if (Amount is object)
                yield return Amount;

            if (LuminousIntensity is object)
                yield return LuminousIntensity;

            if (Combined is object)
                yield return Combined;

        }

        public UnitSystem Copy()
        {

            UnitSystem local = new();

            if (Symbol is object)
                local.Symbol = Symbol;

            if (Length is object)
                local.Length = (LengthUnit)Length.Clone();

            if (Mass is object)
                local.Mass = (MassUnit)Mass.Clone();

            if (Duration is object)
                local.Duration = (DurationUnit)Duration.Clone();

            if (Electriccurrent is object)
                local.Electriccurrent = (ElectricCurrentUnit)Electriccurrent.Clone();

            if (Temperature is object)
                local.Temperature = (TemperatureUnit)Temperature.Clone();

            if (Amount is object)
                local.Amount = (AmountOfSubstanceUnit)Amount.Clone();

            if (LuminousIntensity is object)
                local.LuminousIntensity = (LuminousIntensityUnit)LuminousIntensity.Clone();

            if (Combined is object)
                local.Combined = (CombinedUnit)Combined.Clone();


            return local;
        }

        public UnitSystem BaseUnitSystem()
        {
            UnitSystem local = Copy();

            //Remove combi and acutalC
            local.Combined = new CombinedUnit("",1m);

            foreach (var item in local.UnitList())
            {
                item.ActualC = 1;
            }

            return local;
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


        public UnitSystem Sqrt()
        {

            UnitSystem local = new();


            local.Length = (LengthUnit)SqrtBaseUnit(Length);
            local.Mass = (MassUnit)SqrtBaseUnit(Mass);
            local.Duration = (DurationUnit)SqrtBaseUnit(Duration);
            local.Electriccurrent = (ElectricCurrentUnit)SqrtBaseUnit(Electriccurrent);
            local.Temperature = (TemperatureUnit)SqrtBaseUnit(Temperature);
            local.LuminousIntensity = (LuminousIntensityUnit)SqrtBaseUnit(LuminousIntensity);
            local.Amount = (AmountOfSubstanceUnit)SqrtBaseUnit(Amount);


            if (Combined is object)
            {
                local.Combined = (CombinedUnit)Combined.Clone();
                local.Combined.SetNewGlobalC(Sqrt((decimal)Combined.NewC));
            }




            return local;

            static Enumeration SqrtBaseUnit(Enumeration me)
            {
                if (me is object)
                {
                    Enumeration local = new Enumeration();

                    if (me.Count % 2 != 0)
                    {
                        throw new WrongUnitException($"We can't handle taking the square root of your unit! If the resulting unit ends in ex. [meter^0.5] you get this error.");
                    }

                    local = (Enumeration)me.Clone();
                    local.Count = (int)(local.Count / 2);

                    return local;

                }

                return null;
            }


        }

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
            hashCode.Add(Length);
            hashCode.Add(Mass);
            hashCode.Add(Duration);
            hashCode.Add(Electriccurrent);
            hashCode.Add(Temperature);
            hashCode.Add(Amount);
            hashCode.Add(LuminousIntensity);
            hashCode.Add(Combined);

            return hashCode.ToHashCode();


        }

    }
}
