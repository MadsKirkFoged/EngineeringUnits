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

        public List<BaseUnitClass> UnitList { get; set; }

        
        public UnitSystem()
        {

            Length = new BaseUnitClass(BaseUnits.length);
            Mass = new BaseUnitClass(BaseUnits.mass);
            Duration = new BaseUnitClass(BaseUnits.time);
            Electriccurrent = new BaseUnitClass(BaseUnits.electricCurrent);
            Temperature = new BaseUnitClass(BaseUnits.temperature);
            Amount = new BaseUnitClass(BaseUnits.amountOfSubstance);
            LuminousIntensity = new BaseUnitClass(BaseUnits.luminousIntensity);

            UnitList = new List<BaseUnitClass>();

            UnitList.Add(Length);
            UnitList.Add(Mass);
            UnitList.Add(Duration);
            UnitList.Add(Electriccurrent);
            UnitList.Add(Temperature);
            UnitList.Add(Amount);
            UnitList.Add(LuminousIntensity);
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


        public static UnknownUnit Add(BaseUnit left, BaseUnit right)
        {

            //Samle konstanter

            decimal a1 = SumOfAConstants(left.unitsystem);
            decimal b1 = SumOfBConstants(left.unitsystem);
            decimal y1 = (decimal)left.Value;

            decimal a2 = SumOfAConstants(right.unitsystem);
            decimal b2 = SumOfBConstants(right.unitsystem);
            decimal y2 = (decimal)right.Value;




            decimal x1 = (y1 - b1) / a1;
            decimal x2 = (y2 - b2) / a2;

            decimal x3 = x1 + x2;



            //Sæt tilbage i lefts units

            decimal y3 = a1 * x3 + b1;





            return new BaseUnit
            {
                unitsystem = UnitSystem.Add(left.unitsystem, right.unitsystem),
                Value = (double)y3
            };


        }

        public static UnknownUnit Subtract(BaseUnit left, BaseUnit right)
        {

            //Samle konstanter

            decimal a1 = SumOfAConstants(left.unitsystem);
            decimal b1 = SumOfBConstants(left.unitsystem);
            decimal y1 = (decimal)left.Value;

            decimal a2 = SumOfAConstants(right.unitsystem);
            decimal b2 = SumOfBConstants(right.unitsystem);
            decimal y2 = (decimal)right.Value;




            decimal x1 = (y1 - b1) / a1;
            decimal x2 = (y2 - b2) / a2;

            decimal x3 = x1 - x2;



            //Sæt tilbage i lefts units

            decimal y3 = a1 * x3 + b1;





            return new BaseUnit
            {
                unitsystem = UnitSystem.Subtract(left.unitsystem, right.unitsystem),
                Value = (double)y3
            };


        }

        public static UnknownUnit Multiply(BaseUnit left, BaseUnit right)
        {
            //Samle konstanter

            decimal a1 = SumOfAConstants(left.unitsystem);
            decimal b1 = SumOfBConstants(left.unitsystem);
            decimal y1 = (decimal)left.Value;

            decimal a2 = SumOfAConstants(right.unitsystem);
            decimal b2 = SumOfBConstants(right.unitsystem);
            decimal y2 = (decimal)right.Value;




            decimal x1 = (y1 - b1) / a1;
            decimal x2 = (y2 - b2) / a2;

            decimal x3 = x1 * x2;




            BaseUnit ReturnUnit = new BaseUnit
            {
                unitsystem = UnitSystem.Multiply(left.unitsystem, right.unitsystem),
            };


            SetValueAsSI(x3, ReturnUnit);


            return ReturnUnit;

        }

        public static UnknownUnit Multiply(BaseUnit left, double right)
        {
            //Samle konstanter

            decimal a1 = SumOfAConstants(left.unitsystem);
            decimal b1 = SumOfBConstants(left.unitsystem);
            decimal y1 = (decimal)left.Value;


            decimal x1 = (y1 - b1) / a1;
            decimal x3 = x1 * (decimal)right;


            BaseUnit ReturnUnit = new BaseUnit
            {
                unitsystem = UnitSystem.Add(left.unitsystem, left.unitsystem),
            };


            SetValueAsSI(x3, ReturnUnit);


            return ReturnUnit;

        }

        public static UnknownUnit Divide(BaseUnit left, BaseUnit right)
        {


            //Samle konstanter

            decimal a1 = SumOfAConstants(left.unitsystem);
            decimal b1 = SumOfBConstants(left.unitsystem);
            decimal y1 = (decimal)left.Value;

            decimal a2 = SumOfAConstants(right.unitsystem);
            decimal b2 = SumOfBConstants(right.unitsystem);
            decimal y2 = (decimal)right.Value;




            decimal x1 = (y1 - b1) / a1;
            decimal x2 = (y2 - b2) / a2;

            decimal x3 = x1 / x2;



            BaseUnit ReturnUnit = new BaseUnit
            {
                unitsystem = UnitSystem.Divide(left.unitsystem, right.unitsystem),
            };


            SetValueAsSI(x3, ReturnUnit);


            return ReturnUnit;
        }

        public static UnknownUnit Divide(BaseUnit left, double right)
        {
            //Samle konstanter

            decimal a1 = SumOfAConstants(left.unitsystem);
            decimal b1 = SumOfBConstants(left.unitsystem);
            decimal y1 = (decimal)left.Value;


            decimal x1 = (y1 - b1) / a1;
            decimal x3 = x1 / (decimal)right;


            BaseUnit ReturnUnit = new BaseUnit
            {
                unitsystem = UnitSystem.Add(left.unitsystem, left.unitsystem),
            };


            SetValueAsSI(x3, ReturnUnit);


            return ReturnUnit;

        }

        public static UnknownUnit Divide(double left, BaseUnit right)
        {
            //Samle konstanter

            decimal a1 = SumOfAConstants(right.unitsystem);
            decimal b1 = SumOfBConstants(right.unitsystem);
            decimal y1 = (decimal)right.Value;


            decimal x1 = (y1 - b1) / a1;
            decimal x3 =  (decimal)left / x1;


            BaseUnit ReturnUnit = new BaseUnit
            {
                unitsystem = UnitSystem.Add(right.unitsystem, right.unitsystem),
            };


            SetValueAsSI(x3, ReturnUnit);


            return ReturnUnit;

        }

        public static void SetValueAsSI(decimal SIValue, BaseUnit Unit)
        {
            //Samle konstanter

            decimal a1 = SumOfAConstants(Unit.unitsystem);
            decimal b1 = SumOfBConstants(Unit.unitsystem);
            decimal x1 = (decimal)SIValue;


            Unit.Value = (double)(x1 * a1 + b1);
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


            //if ()
            //{

            //}




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


       

        public static double Convert(double ValueFrom, UnitSystem From, UnitSystem To)
        {

            //Samle konstanter
            decimal a1 = SumOfAConstants(From);
            decimal b1 = SumOfBConstants(From);

            decimal a2 = SumOfAConstants(To);
            decimal b2 = SumOfBConstants(To);

            decimal y1 = (decimal)ValueFrom;
            decimal y2 = 0;





            y2 = (a2 / a1) * (y1 - b1) + b2;


            return (double)y2;

        }





        public void SetUnit(LengthUnit x) => Length.SelectedUnit = x;
        //public void SetUnit(MassUnit? x) => Mass.SelectedUnit = x;
        //public void SetUnit(DurationUnit? x) => Duration.SelectedUnit = x;

        //public void SetUnit(ElectriccurrentUnit? x) => Electriccurrent.SelectedUnit = x;
        public void SetUnit(TemperatureUnit x) => Temperature.SelectedUnit = x;
        //public void SetUnit(AmountUnit? x) => Amount.SelectedUnit = x;
        //public void SetUnit(LuminousIntensityUnit? x) => LuminousIntensity.SelectedUnit = x;





        public static Vector Vector(Enum Type)
        {
            //This Converts Enum object to Vector object

            var type = Type.GetType();
            var memInfo = type.GetMember(Type.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(Vector), false);
            return (attributes.Length > 0) ? (Vector)attributes[0] : null;
        }


        public static decimal SumOfAConstants(UnitSystem unitsystem)
        {
            decimal a = 1;

            foreach (var item in unitsystem.UnitList)
            {
                if (item.SelectedUnit is object)
                {

                    //a *= item.SelectedUnit.A;

                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A, item.Count);               

                }
            }


            return a;

        }

        public static decimal SumOfBConstants(UnitSystem unitsystem)
        {
            decimal b = 0;

            foreach (var item in unitsystem.UnitList)
            {
                if (item.SelectedUnit is object)
                    b += item.SelectedUnit.B;

            }


            return b;

        }


        public override string ToString()
        {

             string local = "";



            foreach (var unit in UnitList)
            {

                if (unit is object && unit.Count > 0)
                {
                    local += unit.SelectedUnit.Symbol;

                    if (unit.Count > 1)
                        local += $"{ToSuperScript(unit.Count)}";

                }


            }




            //If any negative values
            if (UnitList.Any(x => x.Count < 0))            
                local += "/";




            foreach (var unit in UnitList)
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

        public UnitSystem Copy()
        {
            UnitSystem local = new UnitSystem
            {
                Length = this.Length,
                Mass = this.Mass,
                Duration = this.Duration,
                Electriccurrent = this.Electriccurrent,
                Temperature = this.Temperature,
                Amount = this.Amount,
                LuminousIntensity = this.LuminousIntensity,                
            };

            local.UnitList = new List<BaseUnitClass>();

            local.UnitList.Add(Length);
            local.UnitList.Add(Mass);
            local.UnitList.Add(Duration);
            local.UnitList.Add(Electriccurrent);
            local.UnitList.Add(Temperature);
            local.UnitList.Add(Amount);
            local.UnitList.Add(LuminousIntensity);


            return local;

        }



        

    }




}
