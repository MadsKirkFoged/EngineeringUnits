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

        public int LengthCount { get; set;}
        public LengthUnit? SelectedLengthUnit { get; set; }

        public int MassCount { get; set; }
        public MassUnit? SelectedMassUnit { get; set; }

        public int DurationCount { get; set; }
        public DurationUnit? SelectedDurationUnit { get; set; }


        public int ElectriccurrentCount { get; set; }
        public ElectriccurrentUnit? SelectedElectriccurrentUnit { get; set; }



        public int TemperatureCount { get; set; }
        public TemperatureUnit? SelectedTemperatureUnit { get; set; }


        public int AmountCount { get; set; }
        public AmountUnit? SelectedAmountUnit { get; set; }


        public int LuminousIntensityCount { get; set; }
        public LuminousIntensityUnit? SelectedLuminousIntensityUnit { get; set; }


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
            return  a.Length == b.Length &&
                    a.Mass == b.Mass &&
                    a.Duration == b.Duration &&
                    a.Electriccurrent == b.Electriccurrent &&
                    a.Temperature == b.Temperature &&
                    a.Amount == b.Amount &&
                    a.LuminousIntensity == b.LuminousIntensity;
   
        }

        public static bool operator !=(UnitSystem a, UnitSystem b)
        {
            return !(a == b);
        }


        public static UnknownUnit Add(BaseUnit Left, BaseUnit Right)
        {



            double y1 = Left.Value;
            double y2 = Right.Value;

            double a1 = UnitSystem.Vector(Left.unitsystem.SelectedLengthUnit).AFactor;
            double a2 = UnitSystem.Vector(Right.unitsystem.SelectedLengthUnit).AFactor;

            double b1 = UnitSystem.Vector(Left.unitsystem.SelectedLengthUnit).BFactor;
            double b2 = UnitSystem.Vector(Right.unitsystem.SelectedLengthUnit).BFactor;

            double factor = a1 / a2;

            //I Left's system..
            double y3 = y1 + (y2 - b2) * factor;



            return new BaseUnit
            {
                unitsystem = UnitSystem.Add(Left.unitsystem, Right.unitsystem),
                Value = y3
            };






        }

        public static UnknownUnit Subtract(BaseUnit Left, BaseUnit Right)
        {

            if (Left.unitsystem.SelectedTemperatureUnit is null)
            {
                return new BaseUnit
                {
                    unitsystem = UnitSystem.Add(Left.unitsystem, Right.unitsystem),
                    Value = Left.Value + UnitSystem.ValueConvert(Right.Value, Right.unitsystem, Left.unitsystem)
                };

            }
            else
            {

                //special case for temperature

                double y1 = Left.Value;
                double y2 = Right.Value;

                double a1 = UnitSystem.Vector(Left.unitsystem.SelectedTemperatureUnit).AFactor;
                double a2 = UnitSystem.Vector(Right.unitsystem.SelectedTemperatureUnit).AFactor;

                double b1 = UnitSystem.Vector(Left.unitsystem.SelectedTemperatureUnit).BFactor;
                double b2 = UnitSystem.Vector(Right.unitsystem.SelectedTemperatureUnit).BFactor;

                double factor = a1 / a2;

                //I Left's system..
                double y3 = y1 - (y2 - b2) * factor;



                return new BaseUnit
                {
                    unitsystem = UnitSystem.Subtract(Left.unitsystem, Right.unitsystem),
                    Value = y3
                };



            }


        }

        public static UnknownUnit Multiply(BaseUnit Left, BaseUnit Right)
        {

            if (Left.unitsystem.SelectedTemperatureUnit is null)
            {
                return new BaseUnit
                {
                    unitsystem = UnitSystem.Add(Left.unitsystem, Right.unitsystem),
                    Value = Left.Value + UnitSystem.ValueConvert(Right.Value, Right.unitsystem, Left.unitsystem)
                };

            }
            else
            {

                //special case for temperature

                double y1 = Left.Value;
                double y2 = Right.Value;

                double a1 = UnitSystem.Vector(Left.unitsystem.SelectedTemperatureUnit).AFactor;
                double a2 = UnitSystem.Vector(Right.unitsystem.SelectedTemperatureUnit).AFactor;

                double b1 = UnitSystem.Vector(Left.unitsystem.SelectedTemperatureUnit).BFactor;
                double b2 = UnitSystem.Vector(Right.unitsystem.SelectedTemperatureUnit).BFactor;

                double factor = a1 / a2;

                //I Left's system..
                double y3 = (y1 - b1) * ((y2-b2)/a2) + b1;



                return new BaseUnit
                {
                    unitsystem = UnitSystem.Multiply(Left.unitsystem, Right.unitsystem),
                    Value = y3
                };



            }


        }

        public static UnknownUnit Divide(BaseUnit Left, BaseUnit Right)
        {

            if (Left.unitsystem.SelectedTemperatureUnit is null)
            {
                return new BaseUnit
                {
                    unitsystem = UnitSystem.Add(Left.unitsystem, Right.unitsystem),
                    Value = Left.Value + UnitSystem.ValueConvert(Right.Value, Right.unitsystem, Left.unitsystem)
                };

            }
            else
            {

                //special case for temperature

                //double y1 = Left.Value;
                //double y2 = Right.Value;

                //double a1 = UnitSystem.Vector(Left.unitsystem.SelectedTemperatureUnit).Factor;
                //double a2 = UnitSystem.Vector(Right.unitsystem.SelectedTemperatureUnit).Factor;

                //double b1 = UnitSystem.Vector(Left.unitsystem.SelectedTemperatureUnit).ToSIFactor;
                //double b2 = UnitSystem.Vector(Right.unitsystem.SelectedTemperatureUnit).ToSIFactor;

                //double factor = a1 / a2;

                ////I Left's system..
                //double y3 = a2 * ((y1 - b1)/(y2 - b2)) + b2;


                //Left.As()



                return new BaseUnit
                {
                    unitsystem = UnitSystem.Divide(Left.unitsystem, Right.unitsystem),
                    //Value = y3
                };



            }


        }

        public static UnitSystem Add(UnitSystem a, UnitSystem b)
        {

            if (a != b)
            {
                throw new InvalidOperationException($"Trying to add two UnitSystem that are not the same!");
            }


            UnitSystem local = Merge(a, b);

            //Unit math
            local.LengthCount = a.LengthCount;
            local.MassCount = a.MassCount;
            local.DurationCount = a.DurationCount;
            local.ElectriccurrentCount = a.ElectriccurrentCount;
            local.TemperatureCount = a.TemperatureCount;
            local.AmountCount = a.AmountCount;
            local.LuminousIntensityCount = a.LuminousIntensityCount;


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

            //Unit math
            local.LengthCount = a.LengthCount + b.LengthCount;
            local.MassCount = a.MassCount + b.MassCount;
            local.DurationCount = a.DurationCount + b.DurationCount;
            local.ElectriccurrentCount = a.ElectriccurrentCount + b.ElectriccurrentCount;
            local.TemperatureCount = a.TemperatureCount + b.TemperatureCount;
            local.AmountCount = a.AmountCount + a.AmountCount;
            local.LuminousIntensityCount = a.LuminousIntensityCount + b.LuminousIntensityCount;        
           

            return local;

        }

        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            UnitSystem local = Merge(a, b);

            //Unit math
            local.LengthCount = a.LengthCount - b.LengthCount;
            local.MassCount = a.MassCount - b.MassCount;
            local.DurationCount = a.DurationCount - b.DurationCount;
            local.ElectriccurrentCount = a.ElectriccurrentCount - b.ElectriccurrentCount;
            local.TemperatureCount = a.TemperatureCount - b.TemperatureCount;
            local.AmountCount = a.AmountCount - a.AmountCount;
            local.LuminousIntensityCount = a.LuminousIntensityCount - b.LuminousIntensityCount;


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


        public static double Convert(double ValueFrom ,Enum From, Enum To)
        {


            double y2 = ValueFrom;

            double a1 = UnitSystem.Vector(To).AFactor;
            double a2 = UnitSystem.Vector(From).AFactor;

            double b1 = UnitSystem.Vector(To).BFactor;
            double b2 = UnitSystem.Vector(From).BFactor;

            double factor = a1 / a2;

            //I Left's system..
           return (y2 - b2) * factor + b1;

        }


        public void SetUnit(LengthUnit? x) => Length.SelectedUnit = x;
        public void SetUnit(MassUnit? x) => Mass.SelectedUnit = x;
        public void SetUnit(DurationUnit? x) => Duration.SelectedUnit = x;

        public void SetUnit(ElectriccurrentUnit? x) => Electriccurrent.SelectedUnit = x;
        public void SetUnit(TemperatureUnit? x) => Temperature.SelectedUnit = x;
        public void SetUnit(AmountUnit? x) => Amount.SelectedUnit = x;
        public void SetUnit(LuminousIntensityUnit? x) => LuminousIntensity.SelectedUnit = x;



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


        public static double ValueConvert(double value, UnitSystem From, UnitSystem To)
        {
            double Local = 0;

            foreach (var FromBaseUnit in From.UnitList)
            {
                if (FromBaseUnit.SelectedUnit is object)
                {
                    
                    BaseUnitClass ToBaseUnit = GetMatchingBaseType(FromBaseUnit, To);
                    Local += Convert(value, FromBaseUnit.SelectedUnit, ToBaseUnit.SelectedUnit);


                }
            }

            return Local;

            //double LocalLenght = 0;
            //double LocalTime = 0;
            //double LocalMass = 0;
            //double LocalElectriccurrent = 0;
            //double LocalTemperature = 0;
            //double LocalMole = 0;
            //double LocalLuminousIntensity = 0;

            //if (From.SelectedLengthUnit is object && To.SelectedLengthUnit is object)            
            //    LocalLenght = Math.Pow(UnitSystem.VectorDifferent(From.SelectedLengthUnit, To.SelectedLengthUnit), From.LengthCount) * value;


            //if (From.SelectedDurationUnit is object && To.SelectedDurationUnit is object)            
            //    LocalTime = Math.Pow(UnitSystem.VectorDifferent(From.SelectedDurationUnit, To.SelectedDurationUnit), From.DurationCount) * value;


            //if (From.SelectedMassUnit is object && To.SelectedMassUnit is object)            
            //    LocalMass = Math.Pow(UnitSystem.VectorDifferent(From.SelectedMassUnit, To.SelectedMassUnit), From.MassCount) * value;


            //if (From.SelectedElectriccurrentUnit is object && To.SelectedElectriccurrentUnit is object)            
            //    LocalElectriccurrent = Math.Pow(UnitSystem.VectorDifferent(From.SelectedElectriccurrentUnit, To.SelectedElectriccurrentUnit), From.ElectriccurrentCount) * value;


            //if (From.SelectedTemperatureUnit is object && To.SelectedTemperatureUnit is object)
            //{

            //    //LocalTemperature = Math.Pow(UnitSystem.VectorDifferent(From.SelectedTemperatureUnit, To.SelectedTemperatureUnit), From.TemperatureCount) + UnitSystem.VectorFixed(From.SelectedTemperatureUnit, To.SelectedTemperatureUnit) * value;

            //}

            //if (From.SelectedAmountUnit is object && To.SelectedAmountUnit is object)            
            //    LocalMole = Math.Pow(UnitSystem.VectorDifferent(From.SelectedAmountUnit, To.SelectedAmountUnit), From.AmountCount) * value;


            //if (From.SelectedLuminousIntensityUnit is object && To.SelectedLuminousIntensityUnit is object)            
            //    LocalLuminousIntensity = Math.Pow(UnitSystem.VectorDifferent(From.SelectedLuminousIntensityUnit, To.SelectedLuminousIntensityUnit), From.LuminousIntensityCount) * value;




            //return LocalLenght + LocalMass + LocalTime + LocalElectriccurrent + LocalTemperature + LocalMole + LocalLuminousIntensity;
        }
        public static double VectorDifferent(Enum FromUnit, Enum ToUnit)
        {

            //TODO Check that they are same kind!


            double factor = (Vector(FromUnit).AFactor / Vector(ToUnit).AFactor);
            double SIfactor = (Vector(FromUnit).BFactor / Vector(ToUnit).BFactor);


            double result = factor * SIfactor;
            Debug.Print($"{Vector(FromUnit).AFactor} / {Vector(ToUnit).AFactor} = {factor}");
            Debug.Print($"{Vector(FromUnit).BFactor} / {Vector(ToUnit).BFactor} = {SIfactor}");
            Debug.Print($"{result}");


            return (double)result;
        }

        public static double VectorFixed(Enum FromUnit, Enum ToUnit)
        {

            //TODO Check that they are same kind!
            return Vector(FromUnit).BFactor - Vector(ToUnit).BFactor;   
        }


        public static Vector Vector(Enum Type)
        {
            //This Converts Enum object to Vector object

            var type = Type.GetType();
            var memInfo = type.GetMember(Type.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(Vector), false);
            return (attributes.Length > 0) ? (Vector)attributes[0] : null;
        }

        public override string ToString()
        {

             string local = "";

            if (SelectedLengthUnit is object && LengthCount > 0)
            {
                //if (local != "")                
                    //local += " * ";                

                local += Vector(SelectedLengthUnit).Symbol;

                if (LengthCount > 1)
                    local += $"{ToSuperScript(LengthCount)}";

                

            }

            if (SelectedDurationUnit is object && DurationCount > 0)
            {
                //if (local != "")
                    //local += " * ";

                local += Vector(SelectedDurationUnit).Symbol;

                if (DurationCount > 1)
                    local += $"{ToSuperScript(DurationCount)}";



            }

            if (SelectedTemperatureUnit is object && TemperatureCount > 0)
            {
                //if (local != "")
                //local += " * ";

                local += Vector(SelectedTemperatureUnit).Symbol;

                if (TemperatureCount > 1)
                    local += $"{ToSuperScript(TemperatureCount)}";



            }



            //If any negative values


            if (LengthCount < 0 || MassCount < 0 || DurationCount < 0 || ElectriccurrentCount < 0 || TemperatureCount < 0 || AmountCount < 0 || LuminousIntensityCount < 0)
            {
                local += "/";
            }


            if (SelectedLengthUnit is object && LengthCount < 0)
            {
                //if (local != "" && local.Last() != '/')
                    //local += " * ";

                local += Vector(SelectedLengthUnit).Symbol;

                if (LengthCount < -1)
                    local += $"{ToSuperScript(LengthCount * -1)}";



            }

            if (SelectedDurationUnit is object && DurationCount < 0)
            {
                //if (local != "" && local.Last() != '/')
                    //local += " * ";

                local += Vector(SelectedDurationUnit).Symbol;

                if (DurationCount < -1)
                    local += $"{ToSuperScript(DurationCount * -1)}";



            }


            if (SelectedTemperatureUnit is object && TemperatureCount < 0)
            {
                //if (local != "" && local.Last() != '/')
                //local += " * ";

                local += Vector(SelectedTemperatureUnit).Symbol;

                if (TemperatureCount < -1)
                    local += $"{ToSuperScript(TemperatureCount * -1)}";



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
                LengthCount = this.LengthCount,
                MassCount = this.MassCount,
                DurationCount = this.DurationCount,
                ElectriccurrentCount = this.ElectriccurrentCount,
                TemperatureCount = this.TemperatureCount,
                AmountCount = this.AmountCount,
                LuminousIntensityCount = this.LuminousIntensityCount,

                SelectedLengthUnit = this.SelectedLengthUnit,
                
            };

        }



        

    }




}
