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


        public static UnknownUnit DoMath(BaseUnit left, BaseUnit right, MathEnum math)
        {

            BaseUnit local = new BaseUnit();

            //Get constants
            decimal a1 = 1 / GetAFactorGlobal(left.Unit);
            decimal b1 = SumOfBConstants(left.Unit);
            decimal y1 = (decimal)left.ValueLocalUnit;

            decimal a2 = 1 / GetAFactorGlobal(right.Unit);
            decimal b2 = SumOfBConstants(right.Unit);
            decimal y2 = (decimal)right.ValueLocalUnit;


            //Turn to SI
            decimal x1 = (y1) / a1;
            decimal x2 = (y2) / a2;

            //Do math in SI
            decimal x3 = 0;



            switch (math)
            {
                case MathEnum.Add:
                    x3 = x1 + x2;
                    local.Unit = UnitSystem.Add(left.Unit, right.Unit);
                    local.ValueLocalUnit = a1 * x3;
                    break;
                case MathEnum.Subtract:
                    x3 = x1 - x2;
                    local.Unit = UnitSystem.Subtract(left.Unit, right.Unit);
                    local.ValueLocalUnit = a1 * x3;
                    break;
                case MathEnum.Multiply:
                    x3 = x1 * x2;
                    local.Unit = UnitSystem.Multiply(left.Unit, right.Unit);
                    a1 = 1 / GetAFactorGlobal(local.Unit);
                    b1 = SumOfBConstants(local.Unit);
                    local.ValueLocalUnit = (x3 * a1);
                    break;
                case MathEnum.Divide:
                    x3 = x1 / x2;
                    local.Unit = UnitSystem.Divide(left.Unit, right.Unit);
                    a1 = 1 / GetAFactorGlobal(local.Unit);
                    b1 = SumOfBConstants(local.Unit);
                    local.ValueLocalUnit = (x3 * a1);
                    break;
                default:
                    break;
            }

           

            return local;
        }




        //public static UnknownUnit Add(BaseUnit left, BaseUnit right)
        //{

        //    //Samle konstanter
        //    decimal a1 = 1/GetAFactorGlobal(left.unitsystem);
        //    decimal b1 = SumOfBConstants(left.unitsystem);
        //    decimal y1 = (decimal)left.ValueLocalUnit;

        //    decimal a2 = 1/GetAFactorGlobal(right.unitsystem);
        //    decimal b2 = SumOfBConstants(right.unitsystem);
        //    decimal y2 = (decimal)right.ValueLocalUnit;



        //    //omregn til SI
        //    decimal x1 = (y1 - b1) / a1;
        //    decimal x2 = (y2 - b2) / a2;

        //    //Læg sammen i SI
        //    decimal x3 = x1 + x2;


        //    //Sæt tilbage i lefts global-units
        //    decimal y3 = a1 * x3 + b1;


        //    return new BaseUnit
        //    {
        //        unitsystem = UnitSystem.Add(left.unitsystem, right.unitsystem),
        //        ValueLocalUnit = y3
        //    };


        //}

        //public static UnknownUnit Subtract(BaseUnit left, BaseUnit right)
        //{

        //    //Samle konstanter

        //    decimal a1 = 1 / GetAFactor(left.unitsystem);
        //    decimal b1 = SumOfBConstants(left.unitsystem);
        //    decimal y1 = (decimal)left.Value;

        //    decimal a2 = 1 / GetAFactor(right.unitsystem);
        //    decimal b2 = SumOfBConstants(right.unitsystem);
        //    decimal y2 = (decimal)right.Value;




        //    decimal x1 = (y1 - b1) / a1;
        //    decimal x2 = (y2 - b2) / a2;

        //    decimal x3 = x1 - x2;



        //    //Sæt tilbage i lefts units

        //    decimal y3 = a1 * x3 + b1;





        //    return new BaseUnit
        //    {
        //        unitsystem = UnitSystem.Subtract(left.unitsystem, right.unitsystem),
        //        ValueLocalUnit = y3
        //    };


        //}

        //public static UnknownUnit Multiply(BaseUnit left, BaseUnit right)
        //{
        //    //Samle konstanter

        //    decimal a1 = 1 / GetAFactor(left.unitsystem);
        //    decimal b1 = SumOfBConstants(left.unitsystem);
        //    decimal y1 = (decimal)left.Value;

        //    decimal a2 = 1 / GetAFactor(right.unitsystem);
        //    decimal b2 = SumOfBConstants(right.unitsystem);
        //    decimal y2 = (decimal)right.Value;




        //    decimal x1 = (y1 - b1) / a1;
        //    decimal x2 = (y2 - b2) / a2;

        //    decimal x3 = x1 * x2;




        //    BaseUnit ReturnUnit = new BaseUnit
        //    {
        //        unitsystem = UnitSystem.Multiply(left.unitsystem, right.unitsystem),
        //    };


        //    SetValueAsSI(x3, ReturnUnit);


        //    return ReturnUnit;

        //}

        //public static UnknownUnit Multiply(BaseUnit left, double right)
        //{
        //    //Samle konstanter

        //    decimal a1 = 1 / GetAFactor(left.unitsystem);
        //    decimal b1 = SumOfBConstants(left.unitsystem);
        //    decimal y1 = (decimal)left.Value;


        //    decimal x1 = (y1 - b1) / a1;
        //    decimal x3 = x1 * (decimal)right;


        //    BaseUnit ReturnUnit = new BaseUnit
        //    {
        //        unitsystem = UnitSystem.Add(left.unitsystem, left.unitsystem),
        //    };


        //    SetValueAsSI(x3, ReturnUnit);


        //    return ReturnUnit;

        //}

        //public static UnknownUnit Divide(BaseUnit left, BaseUnit right)
        //{


        //    //Samle konstanter

        //    decimal a1 = 1 / GetAFactor(left.unitsystem);
        //    decimal b1 = SumOfBConstants(left.unitsystem);
        //    decimal y1 = (decimal)left.Value;

        //    decimal a2 = 1 / GetAFactor(right.unitsystem);
        //    decimal b2 = SumOfBConstants(right.unitsystem);
        //    decimal y2 = (decimal)right.Value;




        //    decimal x1 = (y1 - b1) / a1;
        //    decimal x2 = (y2 - b2) / a2;

        //    decimal x3 = x1 / x2;



        //    BaseUnit ReturnUnit = new BaseUnit
        //    {
        //        unitsystem = UnitSystem.Divide(left.unitsystem, right.unitsystem),
        //    };


        //    SetValueAsSI(x3, ReturnUnit);


        //    return ReturnUnit;
        //}

        //public static UnknownUnit Divide(BaseUnit left, double right)
        //{
        //    //Samle konstanter

        //    decimal a1 = 1 / GetAFactor(left.unitsystem);
        //    decimal b1 = SumOfBConstants(left.unitsystem);
        //    decimal y1 = (decimal)left.Value;


        //    decimal x1 = (y1 - b1) / a1;
        //    decimal x3 = x1 / (decimal)right;


        //    BaseUnit ReturnUnit = new BaseUnit
        //    {
        //        unitsystem = UnitSystem.Add(left.unitsystem, left.unitsystem),
        //    };


        //    SetValueAsSI(x3, ReturnUnit);


        //    return ReturnUnit;

        //}

        //public static UnknownUnit Divide(double left, BaseUnit right)
        //{
        //    //Samle konstanter

        //    decimal a1 = 1 / GetAFactor(right.unitsystem);
        //    decimal b1 = SumOfBConstants(right.unitsystem);
        //    decimal y1 = (decimal)right.Value;


        //    decimal x1 = (y1 - b1) / a1;
        //    decimal x3 =  (decimal)left / x1;


        //    BaseUnit ReturnUnit = new BaseUnit
        //    {
        //        unitsystem = UnitSystem.Add(right.unitsystem, right.unitsystem),
        //    };


        //    SetValueAsSI(x3, ReturnUnit);


        //    return ReturnUnit;

        //}

        public static void SetValueAsSI(decimal SIValue, BaseUnit Unit)
        {
            //Samle konstanter

            decimal a1 = SumOfA1Constants(Unit.Unit);
            decimal b1 = SumOfBConstants(Unit.Unit);
            decimal x1 = (decimal)SIValue;


            Unit.ValueLocalUnit = (x1 * a1 + b1);
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
            decimal a11 = SumOfA1Constants(From);
            decimal a12 = SumOfA2Constants(From);
            decimal b1 = SumOfBConstants(From);

            decimal a21 = SumOfA1Constants(To);
            decimal a22 = SumOfA2Constants(To);
            decimal b2 = SumOfBConstants(To);

            decimal y1 = (decimal)ValueFrom;
            decimal y2 = 0;


            //decimal a1 = a21 / a11;
            //decimal a2 = a22 / a12;

            decimal Afactor = GetAFactor(From, To);

            y2 = (Afactor) * (y1 - b1) + b2;
            //y2 = (a2 / a1) * (y1 - b1) + b2;


            return (double)y2;

        }

        public decimal ToTheOutSide(decimal ValueFrom, UnitSystem To)
        {

            
            

            //Samle konstanter
            decimal leftA1 = 1;
            decimal leftA2 = SumOfA2ConstantsWithPow(this);
            decimal rightA1 = SumOfA1ConstantsWithPow(To);
            decimal rightA2 = SumOfA2ConstantsWithPow(To);


            decimal b1 = SumOfBConstants(this);
            decimal b2 = SumOfBConstants(To);

            decimal y1 = ValueFrom;
            decimal y2 = y1;



            //Trying to avoid small numeric error
            if (rightA1 >= leftA1)            
                y2 /= (rightA1 / leftA1);            
            else            
                y2 *= (leftA1 / rightA1);
            

            if (rightA2 >= leftA2)            
                y2 /= (rightA2 / leftA2);            
            else            
                y2 *= (leftA2 / rightA2);



            y2 = y2 + b2; // + b1;

            return y2 / 1.000000000000000000000000000000000m;

        }


        public static decimal GetLocalUnit(double ValueFrom, UnitSystem From)
        {

            //Samle konstanter
            decimal a11 = SumOfA1Constants(From);
            decimal b1 = SumOfBConstants(From);


            decimal y1 = (decimal)ValueFrom;


            decimal y2 = y1 - b1;
            y2 *= a11;

            return y2;

        }

        public decimal ReturnLocalValue(decimal ValueFrom)
        {

            //Samle konstanter
            decimal a11 = SumOfA1Constants(this);
            decimal b1 = SumOfBConstants(this);

            decimal y1 = ValueFrom;

            decimal y2 = y1 - b1;
            y2 *= a11;

            return y2;

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


        public static decimal GetAFactor(UnitSystem left, UnitSystem right)
        {

            decimal leftA1 = left.Length.SelectedUnit.A1;
            decimal leftA2 = left.Length.SelectedUnit.A2;
            decimal rightA1 = right.Length.SelectedUnit.A1;
            decimal rightA2 = right.Length.SelectedUnit.A2;


            //Gives not 99.999999% of the result
            //decimal test = (leftA1 * leftA2) * (1 / rightA1) * (1 / rightA2);

            //So fare this gives 100%
            //decimal test2 = (leftA1 / rightA1) * (leftA2 / rightA2);
            decimal test2 = (leftA1 / rightA1) * (leftA2 / rightA2);
            //Left er altid 1 i localunit...




            return test2;

        }

        public static decimal GetAFactor(UnitSystem left)
        {


            decimal leftA1 = left.Length.SelectedUnit.A1;
            decimal leftA2 = left.Length.SelectedUnit.A2;

            //So far this gives 100%
            decimal test2 = leftA1 * leftA2 ;






            return test2;

        }

        public static decimal GetAFactorGlobal(UnitSystem left)
        {
            //return left.Length.SelectedUnit.A2;

            decimal a = 1;

            foreach (var item in left.UnitList)
            {
                if (item.SelectedUnit is object)                
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A2, item.Count);
                
            }


            return a;


        }


        public static decimal SumOfA1Constants(UnitSystem unitsystem)
        {
            decimal a = 1;

            foreach (var item in unitsystem.UnitList)
            {
                if (item.SelectedUnit is object)
                {
                    //a *= (decimal)Math.Pow((double)item.SelectedUnit.A1, item.Count);
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A1, 1);
                }
            }


            return a;

        }

        public static decimal SumOfA1ConstantsWithPow(UnitSystem unitsystem)
        {
            decimal a = 1;

            foreach (var item in unitsystem.UnitList)
            {
                if (item.SelectedUnit is object)
                {
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A1, item.Count);
                    //a *= (decimal)Math.Pow((double)item.SelectedUnit.A1, 1);
                }
            }


            return a;

        }

        public static decimal SumOfA2ConstantsWithPow(UnitSystem unitsystem)
        {
            decimal a = 1;

            foreach (var item in unitsystem.UnitList)
            {
                if (item.SelectedUnit is object)
                {
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A2, item.Count);
                }
            }


            return a;

        }

        public static decimal SumOfA2Constants(UnitSystem unitsystem)
        {
            decimal a = 1;

            foreach (var item in unitsystem.UnitList)
            {
                if (item.SelectedUnit is object)
                {
                    a *= (decimal)Math.Pow((double)item.SelectedUnit.A2, item.Count);
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

                    if (unit.SelectedUnit is object)                    
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
