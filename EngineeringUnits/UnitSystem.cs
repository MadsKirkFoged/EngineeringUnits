using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EngineeringUnits
{
    public class UnitSystem
    {

        public BaseUnitClass Length { get; set; }
        public BaseUnitClass Mass { get; set; }
        public BaseUnitClass Duration { get; set; }
        public BaseUnitClass Electriccurrent { get; set; }
        public BaseUnitClass Temperature { get; set; }
        public BaseUnitClass Amount { get; set; }
        public BaseUnitClass LuminousIntensity { get; set; }


        
        public UnitSystem()
        {
            Length = new BaseUnitClass(BaseUnits.length);
            Mass = new BaseUnitClass(BaseUnits.mass);
            Duration = new BaseUnitClass(BaseUnits.time);
            Electriccurrent = new BaseUnitClass(BaseUnits.electricCurrent);
            Temperature = new BaseUnitClass(BaseUnits.temperature);
            Amount = new BaseUnitClass(BaseUnits.amountOfSubstance);
            LuminousIntensity = new BaseUnitClass(BaseUnits.luminousIntensity);            
        }


        public static bool operator ==(UnitSystem a, UnitSystem b)
        {
            return  a.Length.Count == b.Length.Count &&
                    a.Mass.Count == b.Mass.Count &&
                    a.Duration.Count == b.Duration.Count &&
                    a.Electriccurrent.Count == b.Electriccurrent.Count &&
                    a.Temperature.Count == b.Temperature.Count &&
                    a.Amount.Count == b.Amount.Count &&
                    a.LuminousIntensity.Count == b.LuminousIntensity.Count;
   
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

            local.Length.Count = a.Length.Count;
            local.Mass.Count = a.Mass.Count;
            local.Duration.Count = a.Duration.Count;
            local.Electriccurrent.Count = a.Electriccurrent.Count;
            local.Temperature.Count = a.Temperature.Count;
            local.Amount.Count = a.Amount.Count;
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
            local.Length.Count = a.Length.Count + b.Length.Count;
            local.Mass.Count = a.Mass.Count + b.Mass.Count;
            local.Duration.Count = a.Duration.Count + b.Duration.Count;
            local.Electriccurrent.Count = a.Electriccurrent.Count + b.Electriccurrent.Count;
            local.Temperature.Count = a.Temperature.Count + b.Temperature.Count;
            local.Amount.Count = a.Amount.Count + a.Amount.Count;
            local.LuminousIntensity.Count = a.LuminousIntensity.Count + b.LuminousIntensity.Count;


            return local;

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            UnitSystem local = Merge(a, b);

            ////Unit math
            local.Length.Count = a.Length.Count - b.Length.Count;
            local.Mass.Count = a.Mass.Count - b.Mass.Count;
            local.Duration.Count = a.Duration.Count - b.Duration.Count;
            local.Electriccurrent.Count = a.Electriccurrent.Count - b.Electriccurrent.Count;
            local.Temperature.Count = a.Temperature.Count - b.Temperature.Count;
            local.Amount.Count = a.Amount.Count - a.Amount.Count;
            local.LuminousIntensity.Count = a.LuminousIntensity.Count - b.LuminousIntensity.Count;


            return local;

        }
        private static UnitSystem Merge(UnitSystem a, UnitSystem b)
        {

            UnitSystem local = new UnitSystem();


            //a has priority!


            if (a.Length.SelectedUnit is object)
                local.Length.SelectedUnit = a.Length.SelectedUnit;
            else if (b.Length.SelectedUnit is object)
                local.Length.SelectedUnit = b.Length.SelectedUnit;

            if (a.Mass.SelectedUnit is object)
                local.Mass.SelectedUnit = a.Mass.SelectedUnit;
            else if (b.Mass.SelectedUnit is object)
                local.Mass.SelectedUnit = b.Mass.SelectedUnit;


            if (a.Duration.SelectedUnit is object)
                local.Duration.SelectedUnit = a.Duration.SelectedUnit;
            else if (b.Duration.SelectedUnit is object)
                local.Duration.SelectedUnit = b.Duration.SelectedUnit;



            if (a.Electriccurrent.SelectedUnit is object)
                local.Electriccurrent.SelectedUnit = a.Electriccurrent.SelectedUnit;
            else if (b.Electriccurrent.SelectedUnit is object)
                local.Electriccurrent.SelectedUnit = b.Electriccurrent.SelectedUnit;


            if (a.Temperature.SelectedUnit is object)
                local.Temperature.SelectedUnit = a.Temperature.SelectedUnit;
            else if (b.Temperature.SelectedUnit is object)
                local.Temperature.SelectedUnit = b.Temperature.SelectedUnit;


            if (a.Amount.SelectedUnit is object)
                local.Amount.SelectedUnit = a.Amount.SelectedUnit;
            else if (b.Amount.SelectedUnit is object)
                local.Amount.SelectedUnit = b.Amount.SelectedUnit;


            if (a.LuminousIntensity.SelectedUnit is object)
                local.LuminousIntensity.SelectedUnit = a.LuminousIntensity.SelectedUnit;
            else if (b.LuminousIntensity.SelectedUnit is object)
                local.LuminousIntensity.SelectedUnit = b.LuminousIntensity.SelectedUnit;


            return local;

        }




        public decimal GetAFactorGlobal()
        {

            decimal a = 1;

            foreach (var item in UnitList())
            {
                if (item.SelectedUnit is object)                
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A2, item.Count);
                
            }


            return a;
        }

        public decimal SumOfA1Constants()
        {
            decimal a = 1;

            foreach (var item in UnitList())
            {
                if (item.SelectedUnit is object)
                {
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A1, 1);
                }
            }


            return a;

        }

        public decimal SumOfA1ConstantsWithPow()
        {
            decimal a = 1;

            foreach (var item in UnitList())
            {
                if (item.SelectedUnit is object)
                {
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A1, item.Count);
                }
            }


            return a;

        }


        public decimal SumOfA2ConstantsWithPow()
        {
            decimal a = 1;

            foreach (var item in UnitList())
            {
                if (item.SelectedUnit is object)
                {
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A2, item.Count);
                }
            }


            return a;

        }

        public decimal SumOfBConstants()
        {
            decimal b = 0;

            foreach (var item in UnitList())
            {
                if (item.SelectedUnit is object)
                    b += item.SelectedUnit.B;

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

                    if (unit.SelectedUnit is object)                    
                        local += unit.SelectedUnit.Symbol;
                    



                    if (unit.Count > 1)
                        local += $"{ToSuperScript(unit.Count)}";

                }


            }




            //If any negative values
            if (UnitList().Any(x => x.Count < 0))            
                local += "/";




            foreach (var unit in UnitList())
            {

                if (unit.SelectedUnit is object && unit.Count < 0)
                {
                    local += unit.SelectedUnit.Symbol;

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


        public IEnumerable<BaseUnitClass> UnitList()
        {
            return new[] { Length, Mass, Duration, Electriccurrent, Temperature, Amount, LuminousIntensity };
        }




    }




}
