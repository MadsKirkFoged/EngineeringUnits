using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EngineeringUnits
{
    public class UnitSystem
    {

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
            LengthCount = 0;
            MassCount = 0;
            DurationCount = 0;
            ElectriccurrentCount = 0;
            TemperatureCount = 0;
            AmountCount = 0;
            LuminousIntensityCount = 0;
        }


        public static bool operator ==(UnitSystem a, UnitSystem b)
        {
            if (a.LengthCount == b.LengthCount &&
                a.MassCount == b.MassCount &&
                a.DurationCount == b.DurationCount &&
                a.ElectriccurrentCount == b.ElectriccurrentCount &&
                a.TemperatureCount == b.TemperatureCount &&
                a.AmountCount == b.AmountCount &&
                a.LuminousIntensityCount == b.LuminousIntensityCount)
            {
                return true;
            }
            else
            {
                return false;
            }
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
          

            if (a.SelectedLengthUnit is object)
                local.SelectedLengthUnit = a.SelectedLengthUnit;
            else if (b.SelectedLengthUnit is object)
                local.SelectedLengthUnit = b.SelectedLengthUnit;

            if (a.SelectedMassUnit is object)
                local.SelectedMassUnit = a.SelectedMassUnit;
            else if (b.SelectedMassUnit is object)
                local.SelectedMassUnit = b.SelectedMassUnit;


            if (a.SelectedDurationUnit is object)
                local.SelectedDurationUnit = a.SelectedDurationUnit;
            else if (b.SelectedDurationUnit is object)
                local.SelectedDurationUnit = b.SelectedDurationUnit;



            if (a.SelectedElectriccurrentUnit is object)
                local.SelectedElectriccurrentUnit = a.SelectedElectriccurrentUnit;
            else if (b.SelectedElectriccurrentUnit is object)
                local.SelectedElectriccurrentUnit = b.SelectedElectriccurrentUnit;


            if (a.SelectedTemperatureUnit is object)
                local.SelectedTemperatureUnit = a.SelectedTemperatureUnit;
            else if (b.SelectedTemperatureUnit is object)
                local.SelectedTemperatureUnit = b.SelectedTemperatureUnit;


            if (a.SelectedAmountUnit is object)
                local.SelectedAmountUnit = a.SelectedAmountUnit;
            else if (b.SelectedAmountUnit is object)
                local.SelectedAmountUnit = b.SelectedAmountUnit;


            if (a.SelectedLuminousIntensityUnit is object)
                local.SelectedLuminousIntensityUnit = a.SelectedLuminousIntensityUnit;
            else if (b.SelectedLuminousIntensityUnit is object)
                local.SelectedLuminousIntensityUnit = b.SelectedLuminousIntensityUnit;


            return local;

        }


        public static double Convert(BaseUnit To, BaseUnit From)
        {



            double y1 = To.Value;
            double y2 = From.Value;

            double a1 = UnitSystem.Vector(To.unitsystem.SelectedLengthUnit).AFactor;
            double a2 = UnitSystem.Vector(From.unitsystem.SelectedLengthUnit).AFactor;

            double b1 = UnitSystem.Vector(To.unitsystem.SelectedLengthUnit).BFactor;
            double b2 = UnitSystem.Vector(From.unitsystem.SelectedLengthUnit).BFactor;

            double factor = a1 / a2;

            //I Left's system..
           return (y2 - b2) * factor + b1;


        }


        public void SetUnit(LengthUnit? x) => SelectedLengthUnit = x;
        public void SetUnit(MassUnit? x) => SelectedMassUnit = x;
        public void SetUnit(DurationUnit? x) => SelectedDurationUnit = x;

        public void SetUnit(ElectriccurrentUnit? x) => SelectedElectriccurrentUnit = x;
        public void SetUnit(TemperatureUnit? x) => SelectedTemperatureUnit = x;
        public void SetUnit(AmountUnit? x) => SelectedAmountUnit = x;
        public void SetUnit(LuminousIntensityUnit? x) => SelectedLuminousIntensityUnit = x;


        public static double ValueConvert(double value, UnitSystem From, UnitSystem To)
        {

            double LocalLenght = 0;
            double LocalTime = 0;
            double LocalMass = 0;
            double LocalElectriccurrent = 0;
            double LocalTemperature = 0;
            double LocalMole = 0;
            double LocalLuminousIntensity = 0;

            if (From.SelectedLengthUnit is object && To.SelectedLengthUnit is object)            
                LocalLenght = Math.Pow(UnitSystem.VectorDifferent(From.SelectedLengthUnit, To.SelectedLengthUnit), From.LengthCount) * value;
            

            if (From.SelectedDurationUnit is object && To.SelectedDurationUnit is object)            
                LocalTime = Math.Pow(UnitSystem.VectorDifferent(From.SelectedDurationUnit, To.SelectedDurationUnit), From.DurationCount) * value;
            

            if (From.SelectedMassUnit is object && To.SelectedMassUnit is object)            
                LocalMass = Math.Pow(UnitSystem.VectorDifferent(From.SelectedMassUnit, To.SelectedMassUnit), From.MassCount) * value;
            

            if (From.SelectedElectriccurrentUnit is object && To.SelectedElectriccurrentUnit is object)            
                LocalElectriccurrent = Math.Pow(UnitSystem.VectorDifferent(From.SelectedElectriccurrentUnit, To.SelectedElectriccurrentUnit), From.ElectriccurrentCount) * value;
            

            if (From.SelectedTemperatureUnit is object && To.SelectedTemperatureUnit is object)
            {

                //LocalTemperature = Math.Pow(UnitSystem.VectorDifferent(From.SelectedTemperatureUnit, To.SelectedTemperatureUnit), From.TemperatureCount) + UnitSystem.VectorFixed(From.SelectedTemperatureUnit, To.SelectedTemperatureUnit) * value;

            }
            
            if (From.SelectedAmountUnit is object && To.SelectedAmountUnit is object)            
                LocalMole = Math.Pow(UnitSystem.VectorDifferent(From.SelectedAmountUnit, To.SelectedAmountUnit), From.AmountCount) * value;
            

            if (From.SelectedLuminousIntensityUnit is object && To.SelectedLuminousIntensityUnit is object)            
                LocalLuminousIntensity = Math.Pow(UnitSystem.VectorDifferent(From.SelectedLuminousIntensityUnit, To.SelectedLuminousIntensityUnit), From.LuminousIntensityCount) * value;
            



            return LocalLenght + LocalMass + LocalTime + LocalElectriccurrent + LocalTemperature + LocalMole + LocalLuminousIntensity;
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
