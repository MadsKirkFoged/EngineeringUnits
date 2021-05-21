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

        //public int LengthCount { get; set;}
        //public LengthUnit? SelectedLengthUnit { get; set; }

        //public int MassCount { get; set; }
        //public MassUnit? SelectedMassUnit { get; set; }

        //public int DurationCount { get; set; }
        //public DurationUnit? SelectedDurationUnit { get; set; }


        //public int ElectriccurrentCount { get; set; }
        //public ElectriccurrentUnit? SelectedElectriccurrentUnit { get; set; }



        //public int TemperatureCount { get; set; }
        //public TemperatureUnit? SelectedTemperatureUnit { get; set; }


        //public int AmountCount { get; set; }
        //public AmountUnit? SelectedAmountUnit { get; set; }


        //public int LuminousIntensityCount { get; set; }
        //public LuminousIntensityUnit? SelectedLuminousIntensityUnit { get; set; }


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


        public static UnknownUnit Add(BaseUnit To, BaseUnit From)
        {

            //Samle konstanter
            decimal a2 = SumOfAConstants(From.unitsystem);
            decimal b2 = SumOfBConstants(From.unitsystem);
            decimal y2 = (decimal)From.Value;

            decimal a1 = SumOfAConstants(To.unitsystem);
            decimal b1 = SumOfBConstants(To.unitsystem);
            decimal y1 = (decimal)To.Value;

            decimal factor = a2 / a1;

            //I Left's system..
            decimal y3 = y1 + (y2 - b2) * factor;

           

            return new BaseUnit
            {
                unitsystem = UnitSystem.Add(To.unitsystem, From.unitsystem),
                Value = (double)y3
            };


        }

        public static UnknownUnit Subtract(BaseUnit Left, BaseUnit Right)
        {

            double y3 = 0;

            double y1 = Left.Value;
            double y2 = Right.Value;

            decimal a1 = SumOfAConstants(Left.unitsystem);
            decimal b1 = SumOfBConstants(Left.unitsystem);

            decimal a2 = SumOfAConstants(Right.unitsystem);
            decimal b2 = SumOfBConstants(Right.unitsystem);

            decimal factor = a2 / a1;


            y3 = y1 - (y2 - (double)b2) * (double)factor;



            return new BaseUnit
            {
                unitsystem = UnitSystem.Subtract(Left.unitsystem, Right.unitsystem),
                Value = y3
            };            


        }

        public static UnknownUnit Multiply(BaseUnit Left, BaseUnit Right)
        {
            decimal y1 = (decimal)Left.Value;
            decimal a1 = SumOfAConstants(Left.unitsystem);
            decimal b1 = SumOfBConstants(Left.unitsystem);

            decimal y2 = (decimal)Right.Value;
            decimal a2 = SumOfAConstants(Right.unitsystem);
            decimal b2 = SumOfBConstants(Right.unitsystem);


            //We have to convert to baseunit first
            //double otherunit = Convert(Right.Value, Right.unitsystem, Left.unitsystem);

            //double y333 = Left.Value / otherunit;


            decimal left1 = ((y1 - b1) / (1 / a1));

            decimal right1 = ((y2 - b2) / (1 / a2));

            decimal y3 = left1 * right1;


            return new BaseUnit
            {
                unitsystem = UnitSystem.Multiply(Left.unitsystem, Right.unitsystem),
                Value = (double)y3
            };


        }

        public static UnknownUnit Divide(BaseUnit Left, BaseUnit Right)
        {


            decimal y1 = (decimal)Left.Value;
            decimal a1 = SumOfAConstants(Left.unitsystem);
            decimal b1 = SumOfBConstants(Left.unitsystem);

            decimal y2 = (decimal)Right.Value;
            decimal a2 = SumOfAConstants(Right.unitsystem);
            decimal b2 = SumOfBConstants(Right.unitsystem);


            //We have to convert to baseunit first
            //double otherunit = Convert(Right.Value, Right.unitsystem, Left.unitsystem);

            //double y333 = Left.Value / otherunit;


            decimal left1 = ((y1 - b1) / (1/a1));

            decimal right1 = ((y2 - b2) / (1/a2));

            decimal y3 = left1 / right1;



            return new BaseUnit
                {
                    unitsystem = UnitSystem.Divide(Left.unitsystem, Right.unitsystem),
                    Value = (double)y3
                };



            


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


        //public static double Convert(double ValueFrom ,Enum From, Enum To)
        //{

        //    double y2 = ValueFrom;

        //    double a1 = UnitSystem.Vector(To).AFactor;
        //    double a2 = UnitSystem.Vector(From).AFactor;

        //    double b1 = UnitSystem.Vector(To).BFactor;
        //    double b2 = UnitSystem.Vector(From).BFactor;

        //    double factor = a1 / a2;

        //    //I Left's system..
        //   return (y2 - b2) * factor + b1;

        //}

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



        private static BaseUnitClass GetMatchingBaseType(BaseUnitClass from, UnitSystem In)
        {
            foreach (var item in In.UnitList)
            {

                if (from.BaseUnitType == item.BaseUnitType)
                {
                    return item;
                }

            }

            return null;
        }

        //This convert a whole system into another system

        //public static double ValueConvert(double value, UnitSystem From, UnitSystem To)
        //{
        //    double Local = 0;

        //    foreach (var FromBaseUnit in From.UnitList)
        //    {
        //        if (FromBaseUnit.SelectedUnit is object)
        //        {
                    
        //            BaseUnitClass ToBaseUnit = GetMatchingBaseType(FromBaseUnit, To);
        //            Local += Convert(value, FromBaseUnit.SelectedUnit, ToBaseUnit.SelectedUnit);


        //        }
        //    }

        //    return Local;

        //    //double LocalLenght = 0;
        //    //double LocalTime = 0;
        //    //double LocalMass = 0;
        //    //double LocalElectriccurrent = 0;
        //    //double LocalTemperature = 0;
        //    //double LocalMole = 0;
        //    //double LocalLuminousIntensity = 0;

        //    //if (From.SelectedLengthUnit is object && To.SelectedLengthUnit is object)            
        //    //    LocalLenght = Math.Pow(UnitSystem.VectorDifferent(From.SelectedLengthUnit, To.SelectedLengthUnit), From.LengthCount) * value;


        //    //if (From.SelectedDurationUnit is object && To.SelectedDurationUnit is object)            
        //    //    LocalTime = Math.Pow(UnitSystem.VectorDifferent(From.SelectedDurationUnit, To.SelectedDurationUnit), From.DurationCount) * value;


        //    //if (From.SelectedMassUnit is object && To.SelectedMassUnit is object)            
        //    //    LocalMass = Math.Pow(UnitSystem.VectorDifferent(From.SelectedMassUnit, To.SelectedMassUnit), From.MassCount) * value;


        //    //if (From.SelectedElectriccurrentUnit is object && To.SelectedElectriccurrentUnit is object)            
        //    //    LocalElectriccurrent = Math.Pow(UnitSystem.VectorDifferent(From.SelectedElectriccurrentUnit, To.SelectedElectriccurrentUnit), From.ElectriccurrentCount) * value;


        //    //if (From.SelectedTemperatureUnit is object && To.SelectedTemperatureUnit is object)
        //    //{

        //    //    //LocalTemperature = Math.Pow(UnitSystem.VectorDifferent(From.SelectedTemperatureUnit, To.SelectedTemperatureUnit), From.TemperatureCount) + UnitSystem.VectorFixed(From.SelectedTemperatureUnit, To.SelectedTemperatureUnit) * value;

        //    //}

        //    //if (From.SelectedAmountUnit is object && To.SelectedAmountUnit is object)            
        //    //    LocalMole = Math.Pow(UnitSystem.VectorDifferent(From.SelectedAmountUnit, To.SelectedAmountUnit), From.AmountCount) * value;


        //    //if (From.SelectedLuminousIntensityUnit is object && To.SelectedLuminousIntensityUnit is object)            
        //    //    LocalLuminousIntensity = Math.Pow(UnitSystem.VectorDifferent(From.SelectedLuminousIntensityUnit, To.SelectedLuminousIntensityUnit), From.LuminousIntensityCount) * value;




        //    //return LocalLenght + LocalMass + LocalTime + LocalElectriccurrent + LocalTemperature + LocalMole + LocalLuminousIntensity;
        //}
        //public static double VectorDifferent(Enum FromUnit, Enum ToUnit)
        //{

        //    //TODO Check that they are same kind!


        //    double factor = (Vector(FromUnit).AFactor / Vector(ToUnit).AFactor);
        //    double SIfactor = (Vector(FromUnit).BFactor / Vector(ToUnit).BFactor);


        //    double result = factor * SIfactor;
        //    Debug.Print($"{Vector(FromUnit).AFactor} / {Vector(ToUnit).AFactor} = {factor}");
        //    Debug.Print($"{Vector(FromUnit).BFactor} / {Vector(ToUnit).BFactor} = {SIfactor}");
        //    Debug.Print($"{result}");


        //    return (double)result;
        //}

        //public static double VectorFixed(Enum FromUnit, Enum ToUnit)
        //{

        //    //TODO Check that they are same kind!
        //    return Vector(FromUnit).BFactor - Vector(ToUnit).BFactor;   
        //}


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

                    a *= item.SelectedUnit.A;

                    //a *= Math.Pow(Vector(item.SelectedUnit).AFactor1, item.Count);               

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
            return new UnitSystem
            {
                Length = this.Length,
                Mass = this.Mass,
                Duration = this.Duration,
                Electriccurrent = this.Electriccurrent,
                Temperature = this.Temperature,
                Amount = this.Amount,
                LuminousIntensity = this.LuminousIntensity,                
            };

        }



        

    }




}
