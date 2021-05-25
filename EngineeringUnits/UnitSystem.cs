using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EngineeringUnits
{
    public class UnitSystem
    {

        public LengthUnit Length { get; set; }
        public MassUnit Mass { get; set; }
        public DurationUnit Duration { get; set; }
        public ElectriccurrentUnit Electriccurrent { get; set; }
        public TemperatureUnit Temperature { get; set; }
        public AmountOfSubstanceUnit Amount { get; set; }
        public LuminousIntensityUnit LuminousIntensity { get; set; }


        
        public UnitSystem()
        {
            //Length = new BaseUnitClass(BaseUnits.length);
            //Mass = new BaseUnitClass(BaseUnits.mass);
            //Duration = new BaseUnitClass(BaseUnits.time);
            //Electriccurrent = new BaseUnitClass(BaseUnits.electricCurrent);
            //Temperature = new BaseUnitClass(BaseUnits.temperature);
            //Amount = new BaseUnitClass(BaseUnits.amountOfSubstance);
            //LuminousIntensity = new BaseUnitClass(BaseUnits.luminousIntensity);            
        }


        public static bool operator ==(UnitSystem a, UnitSystem b)
        {
            return  a.Length?.Count == b.Length?.Count &&
                    a.Mass?.Count == b.Mass?.Count &&
                    a.Duration?.Count == b.Duration?.Count &&
                    a.Electriccurrent?.Count == b.Electriccurrent?.Count &&
                    a.Temperature?.Count == b.Temperature?.Count &&
                    a.Amount?.Count == b.Amount?.Count &&
                    a.LuminousIntensity?.Count == b.LuminousIntensity?.Count;



   
        }
        public static bool operator !=(UnitSystem a, UnitSystem b)
        {
            return !(a == b);
        }



        public static UnitSystem Add(UnitSystem a, UnitSystem b)
        {

            if (a != b)
            {
                throw new InvalidOperationException($"Trying to add two UnitSystem that are not the same!");
            }


            UnitSystem local = Merge(a, b);

            if (local.Length is object)            
                local.Length.Count = a.Length.Count;

            if (local.Mass is object)
                local.Mass.Count = a.Mass.Count;

            if (local.Duration is object)
                local.Duration.Count = a.Duration.Count;

            if (local.Electriccurrent is object)
                local.Electriccurrent.Count = a.Electriccurrent.Count;

            if (local.Temperature is object)
                local.Temperature.Count = a.Temperature.Count;

            if (local.Amount is object)
                local.Amount.Count = a.Amount.Count;

            if (local.LuminousIntensity is object)
                local.LuminousIntensity.Count = a.LuminousIntensity.Count;


            return local;

        }
        public static UnitSystem Subtract(UnitSystem a, UnitSystem b)
        {
            //Subtract does the same to a unit as add
            return Add(a, b);

        }
        public static UnitSystem Multiply(UnitSystem a, UnitSystem b)
        {
            
            UnitSystem local = Merge(a, b);

            ////Unit math
            //local.Length.Count = a.Length.Count + b.Length.Count;
            //local.Mass.Count = a.Mass.Count + b.Mass.Count;
            //local.Duration.Count = a.Duration.Count + b.Duration.Count;
            //local.Electriccurrent.Count = a.Electriccurrent.Count + b.Electriccurrent.Count;
            //local.Temperature.Count = a.Temperature.Count + b.Temperature.Count;
            //local.Amount.Count = a.Amount.Count + a.Amount.Count;
            //local.LuminousIntensity.Count = a.LuminousIntensity.Count + b.LuminousIntensity.Count;


            if (local.Length is object)
                local.Length.Count = a.Length.Count + b.Length.Count;

            if (local.Mass is object)
                local.Mass.Count = a.Mass.Count + b.Mass.Count;

            if (local.Duration is object)
                local.Duration.Count = a.Duration.Count + b.Duration.Count;

            if (local.Electriccurrent is object)
                local.Electriccurrent.Count = a.Electriccurrent.Count + b.Electriccurrent.Count;

            if (local.Temperature is object)
                local.Temperature.Count = a.Temperature.Count + b.Temperature.Count;

            if (local.Amount is object)
                local.Amount.Count = a.Amount.Count + a.Amount.Count;

            if (local.LuminousIntensity is object)
                local.LuminousIntensity.Count = a.LuminousIntensity.Count + b.LuminousIntensity.Count;


            return local;

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            UnitSystem local = Merge(a, b);

            ////Unit math
            //local.Length.Count = a.Length.Count - b.Length.Count;
            //local.Mass.Count = a.Mass.Count - b.Mass.Count;
            //local.Duration.Count = a.Duration.Count - b.Duration.Count;
            //local.Electriccurrent.Count = a.Electriccurrent.Count - b.Electriccurrent.Count;
            //local.Temperature.Count = a.Temperature.Count - b.Temperature.Count;
            //local.Amount.Count = a.Amount.Count - a.Amount.Count;
            //local.LuminousIntensity.Count = a.LuminousIntensity.Count - b.LuminousIntensity.Count;


            if (local.Length is object)
                local.Length.Count = a.Length.Count - b.Length.Count;

            if (local.Mass is object)
                local.Mass.Count = a.Mass.Count - b.Mass.Count;

            if (local.Duration is object)
                local.Duration.Count = a.Duration.Count - b.Duration.Count;

            if (local.Electriccurrent is object)
                local.Electriccurrent.Count = a.Electriccurrent.Count - b.Electriccurrent.Count;

            if (local.Temperature is object)
                local.Temperature.Count = a.Temperature.Count - b.Temperature.Count;

            if (local.Amount is object)
                local.Amount.Count = a.Amount.Count - a.Amount.Count;

            if (local.LuminousIntensity is object)
                local.LuminousIntensity.Count = a.LuminousIntensity.Count - b.LuminousIntensity.Count;


            return local;

        }
        private static UnitSystem Merge(UnitSystem a, UnitSystem b)
        {

            UnitSystem local = new UnitSystem();

            //WE Need a copy function!!!

            //a has priority!


            if (a.Length is object)
                local.Length = a.Length;
            else if (b.Length is object)
                local.Length = b.Length;

            if (a.Mass is object)
                local.Mass = a.Mass;
            else if (b.Mass is object)
                local.Mass = b.Mass;


            if (a.Duration is object)
                local.Duration = a.Duration;
            else if (b.Duration is object)
                local.Duration = b.Duration;



            if (a.Electriccurrent is object)
                local.Electriccurrent = a.Electriccurrent;
            else if (b.Electriccurrent is object)
                local.Electriccurrent = b.Electriccurrent;


            if (a.Temperature is object)
                local.Temperature = a.Temperature;
            else if (b.Temperature is object)
                local.Temperature = b.Temperature;


            if (a.Amount is object)
                local.Amount = a.Amount;
            else if (b.Amount is object)
                local.Amount = b.Amount;


            if (a.LuminousIntensity is object)
                local.LuminousIntensity = a.LuminousIntensity;
            else if (b.LuminousIntensity is object)
                local.LuminousIntensity = b.LuminousIntensity;


            return local;

        }




        public decimal GetAFactorGlobal()
        {

            decimal a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)                
                    a *= (decimal)Math.Pow((double)item.A2, item.Count);
                
            }


            return a;
        }

        public decimal SumOfA1Constants()
        {
            decimal a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    a *= (decimal)Math.Pow((double)item.A1, 1);
                }
            }


            return a;

        }

        public decimal SumOfA1ConstantsWithPow()
        {
            decimal a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    a *= (decimal)Math.Pow((double)item.A1, item.Count);
                }
            }


            return a;

        }


        public decimal SumOfA2ConstantsWithPow()
        {
            decimal a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    a *= (decimal)Math.Pow((double)item.A2, item.Count);
                }
            }


            return a;

        }

        public decimal SumOfBConstants()
        {
            decimal b = 0;

            foreach (var item in UnitList())
            {
                if (item is object)
                    b += item.B;

            }


            return b;

        }


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



            return local;
        }

        private string ToSuperScript(int number)
        {
            const string SuperscriptDigits =
                "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

            string superscript = new string(number.ToString().Select(x => SuperscriptDigits[x - '0'])
                                    .ToArray());

            return superscript;

        }


        public IEnumerable<Enumeration> UnitList()
        {
            var local = new List<Enumeration>();

            if (Length is object)
                local.Add(Length);

            if (Mass is object)
                local.Add(Mass);

            if (Duration is object)
                local.Add(Duration);

            if (Electriccurrent is object)
                local.Add(Electriccurrent);

            if (Temperature is object)
                local.Add(Temperature);

            if (Amount is object)
                local.Add(Amount);

            if (LuminousIntensity is object)
                local.Add(LuminousIntensity);



            return local;
        }




    }




}
