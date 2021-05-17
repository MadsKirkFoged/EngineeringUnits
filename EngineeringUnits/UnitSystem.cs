using System;
using System.Collections.Generic;
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



        public void SetUnit(LengthUnit? x) => SelectedLengthUnit = x;
        public void SetUnit(MassUnit? x) => SelectedMassUnit = x;
        public void SetUnit(DurationUnit? x) => SelectedDurationUnit = x;

        public void SetUnit(ElectriccurrentUnit? x) => SelectedElectriccurrentUnit = x;
        public void SetUnit(TemperatureUnit? x) => SelectedTemperatureUnit = x;
        public void SetUnit(AmountUnit? x) => SelectedAmountUnit = x;
        public void SetUnit(LuminousIntensityUnit? x) => SelectedLuminousIntensityUnit = x;


        public static Decimal VectorDifferent(UnitSystem a, UnitSystem b)
        {

            Decimal LocalLenght = 1;
            Decimal LocalTime = 1;
            Decimal LocalMass = 1;
            Decimal LocalElectriccurrent = 1;
            Decimal LocalTemperature = 1;
            Decimal LocalMole = 1;
            Decimal LocalLuminousIntensity = 1;

            if (a.SelectedLengthUnit is object && b.SelectedLengthUnit is object)            
                LocalLenght = (Decimal)Math.Pow(UnitSystem.VectorDifferent(a.SelectedLengthUnit, b.SelectedLengthUnit), a.LengthCount);
            

            if (a.SelectedDurationUnit is object && b.SelectedDurationUnit is object)            
                LocalTime = (Decimal)Math.Pow(UnitSystem.VectorDifferent(a.SelectedDurationUnit, b.SelectedDurationUnit), a.DurationCount);
            

            if (a.SelectedMassUnit is object && b.SelectedMassUnit is object)            
                LocalMass = (Decimal)Math.Pow(UnitSystem.VectorDifferent(a.SelectedMassUnit, b.SelectedMassUnit), a.MassCount);
            

            if (a.SelectedElectriccurrentUnit is object && b.SelectedElectriccurrentUnit is object)            
                LocalElectriccurrent = (Decimal)Math.Pow(UnitSystem.VectorDifferent(a.SelectedElectriccurrentUnit, b.SelectedElectriccurrentUnit), a.ElectriccurrentCount);
            

            if (a.SelectedTemperatureUnit is object && b.SelectedTemperatureUnit is object)            
                LocalTemperature = (Decimal)Math.Pow(UnitSystem.VectorDifferent(a.SelectedTemperatureUnit, b.SelectedTemperatureUnit), a.TemperatureCount);
            
            if (a.SelectedAmountUnit is object && b.SelectedAmountUnit is object)            
                LocalMole = (Decimal)Math.Pow(UnitSystem.VectorDifferent(a.SelectedAmountUnit, b.SelectedAmountUnit), a.AmountCount);
            

            if (a.SelectedLuminousIntensityUnit is object && b.SelectedLuminousIntensityUnit is object)            
                LocalLuminousIntensity = (Decimal)Math.Pow(UnitSystem.VectorDifferent(a.SelectedLuminousIntensityUnit, b.SelectedLuminousIntensityUnit), a.LuminousIntensityCount);
            



            return LocalLenght * LocalMass * LocalTime * LocalElectriccurrent * LocalTemperature * LocalMole * LocalLuminousIntensity;
        }
        public static double VectorDifferent(Enum FromUnit, Enum ToUnit)
        {

            //TODO Check that they are same kind!

            Decimal factor = ((Decimal)Vector(FromUnit).Factor / (Decimal)Vector(ToUnit).Factor);
            Decimal SIfactor = ((Decimal)Vector(FromUnit).ToSIFactor / (Decimal)Vector(ToUnit).ToSIFactor);

            Decimal result = factor * SIfactor;


            return (double)result;
        }
        private static Vector Vector(Enum Type)
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

                local += Vector(SelectedLengthUnit).Name;

                if (LengthCount > 1)
                    local += $"{ToSuperScript(LengthCount)}";

                

            }

            if (SelectedDurationUnit is object && DurationCount > 0)
            {
                //if (local != "")
                    //local += " * ";

                local += Vector(SelectedDurationUnit).Name;

                if (DurationCount > 1)
                    local += $"{ToSuperScript(DurationCount)}";



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

                local += Vector(SelectedLengthUnit).Name;

                if (LengthCount < -1)
                    local += $"{ToSuperScript(LengthCount * -1)}";



            }

            if (SelectedDurationUnit is object && DurationCount < 0)
            {
                //if (local != "" && local.Last() != '/')
                    //local += " * ";

                local += Vector(SelectedDurationUnit).Name;

                if (DurationCount < -1)
                    local += $"{ToSuperScript(DurationCount * -1)}";



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
