using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringUnits
{
    public class UnitStore
    {

        public int LengthCount { get; set;}
        public LengthUnits? SelectedLengthUnit { get; set; }

        public int MassCount { get; set; }
        public int TimeCount { get; set; }
        public int ElectriccurrentCount { get; set; }
        public int TemperatureCount { get; set; }
        public int MoleCount { get; set; }
        public int LuminousIntensityCount { get; set; }


        public UnitStore()
        {
            LengthCount = 0;
            MassCount = 0;
            TimeCount = 0;
            ElectriccurrentCount = 0;
            TemperatureCount = 0;
            MoleCount = 0;
            LuminousIntensityCount = 0;
        }


        public static bool operator ==(UnitStore a, UnitStore b)
        {
            if (a.LengthCount == b.LengthCount &&
                a.MassCount == b.MassCount &&
                a.TimeCount == b.TimeCount &&
                a.ElectriccurrentCount == b.ElectriccurrentCount &&
                a.TemperatureCount == b.TemperatureCount &&
                a.MoleCount == b.MoleCount &&
                a.LuminousIntensityCount == b.LuminousIntensityCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(UnitStore a, UnitStore b)
        {
            return !(a == b);
        }

        public static UnitStore Add(UnitStore a, UnitStore b)
        {
            return new UnitStore
            {
                //Unit math
                LengthCount = a.LengthCount,
                MassCount = a.MassCount,
                TimeCount = a.TimeCount,
                ElectriccurrentCount = a.ElectriccurrentCount,
                TemperatureCount = a.TemperatureCount,
                MoleCount = a.MoleCount,
                LuminousIntensityCount = a.LuminousIntensityCount,

                //If different unitsystems we use a, as the 'Master'
                SelectedLengthUnit = a.SelectedLengthUnit,

            };

        }

        public static UnitStore Subtract(UnitStore a, UnitStore b)
        {
            return new UnitStore
            {
                //Unit math
                LengthCount = a.LengthCount,
                MassCount = a.MassCount,
                TimeCount = a.TimeCount,
                ElectriccurrentCount = a.ElectriccurrentCount,
                TemperatureCount = a.TemperatureCount,
                MoleCount = a.MoleCount,
                LuminousIntensityCount = a.LuminousIntensityCount,

                //If different unitsystems we use a, as the 'Master'
                SelectedLengthUnit = a.SelectedLengthUnit,

            };

        }

        public static UnitStore Multiply(UnitStore a, UnitStore b)
        {
            return new UnitStore
            {
                //Unit math
                LengthCount = a.LengthCount + b.LengthCount,
                MassCount = a.MassCount + b.MassCount,
                TimeCount = a.TimeCount + b.TimeCount,
                ElectriccurrentCount = a.ElectriccurrentCount + b.ElectriccurrentCount,
                TemperatureCount = a.TemperatureCount + b.TemperatureCount,
                MoleCount = a.MoleCount + b.MoleCount,
                LuminousIntensityCount = a.LuminousIntensityCount + b.LuminousIntensityCount,

                //If different unitsystems we use a, as the 'Master'
                SelectedLengthUnit = a.SelectedLengthUnit,

            };

        }

        public static UnitStore Divide(UnitStore a, UnitStore b)
        {
            return new UnitStore
            {
                //Unit math
                LengthCount = a.LengthCount - b.LengthCount,
                MassCount = a.MassCount - b.MassCount,
                TimeCount = a.TimeCount - b.TimeCount,
                ElectriccurrentCount = a.ElectriccurrentCount - b.ElectriccurrentCount,
                TemperatureCount = a.TemperatureCount - b.TemperatureCount,
                MoleCount = a.MoleCount - a.MoleCount,
                LuminousIntensityCount = a.LuminousIntensityCount - b.LuminousIntensityCount,

                //If different unitsystems we use a, as the 'Master'
                SelectedLengthUnit = a.SelectedLengthUnit,

            };

        }




        public static double VectorDifferent(UnitStore a, UnitStore b)
        {
            double LocalLenght = Math.Pow(UnitStore.VectorDifferent(a.SelectedLengthUnit, b.SelectedLengthUnit), a.LengthCount);
            double LocalMass = 1;
            double LocalTime = 1;
            double LocalElectriccurrent = 1;
            double LocalTemperature = 1;
            double LocalMole = 1;
            double LocalLuminousIntensity = 1;

            return LocalLenght * LocalMass * LocalTime * LocalElectriccurrent * LocalTemperature * LocalMole * LocalLuminousIntensity;
        }



        public static double VectorDifferent(LengthUnits? FromUnit, LengthUnits? ToUnit)
        {
            return (Vector(FromUnit).Factor / Vector(ToUnit).Factor) * (Vector(FromUnit).ToSIFactor / Vector(ToUnit).ToSIFactor);
        }
        private static Vector Vector(LengthUnits? Type)
        {
            //This Converts LengthSI object to Vector object

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
                if (local != "")                
                    local += " * ";                

                local += Vector(SelectedLengthUnit).Name;

                if (LengthCount > 1)
                    local += $"{ToSuperScript(LengthCount)}";

                

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

        public UnitStore Copy()
        {
            return new UnitStore
            {
                LengthCount = this.LengthCount,
                MassCount = this.MassCount,
                TimeCount = this.TimeCount,
                ElectriccurrentCount = this.ElectriccurrentCount,
                TemperatureCount = this.TemperatureCount,
                MoleCount = this.MoleCount,
                LuminousIntensityCount = this.LuminousIntensityCount,

                SelectedLengthUnit = this.SelectedLengthUnit,
                
            };

        }



        

    }




}
