
using EngineeringUnits.Units;
using Newtonsoft.Json.Linq;
using System;

namespace EngineeringUnits
{

    public enum PressureReference
    {
        Undefined = 0,
        Absolute,
        Gauge,
        //Vacuum,
    }

    public partial class Pressure : BaseUnit
    {

        public PressureReference Reference { get; private set; }


        public Pressure(decimal value, PressureUnit selectedUnit, PressureReference reference) : this(value, selectedUnit) 
        {
            //Turn into Absolute
            Reference = reference;

            //NEWValue = ConvertComingIn(reference)
            //          .GetValueAs(Unit);
        }
        public Pressure(double value, PressureUnit selectedUnit, PressureReference reference) : this(value, selectedUnit) 
        {
            Reference = reference;
        }
        public Pressure(int value, PressureUnit selectedUnit, PressureReference reference) : this(value, selectedUnit) 
        {
            Reference = reference;
        }

        public static Pressure From(double value, PressureUnit unit, PressureReference reference) => new(value, unit, reference);
        public static Pressure From(double? value, PressureUnit unit, PressureReference reference)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit, reference);

        }

        //public Pressure ToUnit(PressureUnit selectedUnit, PressureReference reference)
        //{




        //    throw new System.NotImplementedException();
        //}

        public Pressure ToUnit(PressureReference ConvertingTo)
        {
     
            if (ConvertingTo == Reference)
            {
                return this;
            }
            else if (Reference is PressureReference.Undefined)
            {
                Reference = ConvertingTo;
                return this;
            }
            else if (Reference is PressureReference.Absolute && ConvertingTo is PressureReference.Gauge)
            {
                Pressure local = this - FromAtmosphere(1);
                local.Reference = ConvertingTo;

                return local;
            }
            else if (Reference is PressureReference.Gauge && ConvertingTo is PressureReference.Absolute)
            {
                Pressure local = this + FromAtmosphere(1);
                local.Reference = ConvertingTo;

                return local;
            }

            return this;
        }

        public override string GetStandardSymbol(UnitSystem _unit)
        {
            return GetStandardSymbol<PressureUnit>(_unit) + GetSymbol(Reference);
        }


        //public override string ToString(string format, IFormatProvider provider)
        //{

        //    if (Reference is not PressureReference.Undefined)            
        //        return ConvertGoingOut(Reference).ToString(format, provider) + GetSymbol(Reference);
            

        //    return base.ToString(format, provider);

        //}


        private Pressure ConvertComingIn(PressureReference reference) => reference switch
        {
            PressureReference.Absolute => this + FromAtmosphere(0),
            PressureReference.Gauge => this + FromAtmosphere(1),
            PressureReference.Undefined => this,
            //PressureReference.Vacuum => this,
            _ => throw new System.NotImplementedException(),
        };

        private Pressure ConvertGoingOut(PressureReference reference) => reference switch
        {
            PressureReference.Absolute => this - FromAtmosphere(0),
            PressureReference.Gauge => this - FromAtmosphere(1),
            //PressureReference.Vacuum => this,
            _ => throw new System.NotImplementedException(),
        };


        private string GetSymbol(PressureReference reference) => reference switch
        {
            PressureReference.Absolute => "ₐ",
            PressureReference.Gauge => "ᶢ",
            PressureReference.Undefined => "",
            //PressureReference.Vacuum => "TODO",
            _ => throw new System.NotImplementedException(),
        };



    }
}
