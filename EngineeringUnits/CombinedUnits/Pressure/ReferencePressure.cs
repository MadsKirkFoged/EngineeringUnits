
using EngineeringUnits.Units;
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

        PressureReference Reference { get; set; }


        public Pressure(decimal value, PressureUnit selectedUnit, PressureReference reference) : this(value, selectedUnit) 
        {
            //Turn into Absolute
            Reference = reference;

            NEWValue = ConvertComingIn(reference)
                      .GetValueAs(Unit);
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

        public Pressure ToUnit(PressureUnit selectedUnit, PressureReference reference)
        {
            Pressure test = new(GetValueAs(selectedUnit.Unit), selectedUnit);

            test.Reference = reference;

            return test;


        }

        public Pressure ToUnit(PressureReference reference)
        {

            //What if it is changing type?

            return new Pressure(this)
            {
                Reference = reference
            };
        }


        public override string ToString(string format, IFormatProvider provider)
        {

            if (Reference is not PressureReference.Undefined)            
                return ConvertGoingOut(Reference).ToString(format, provider) + GetSymbol(Reference);
            

            return base.ToString(format, provider);

        }


        private Pressure ConvertComingIn(PressureReference reference) => reference switch
        {
            PressureReference.Absolute => this + FromAtmosphere(0),
            PressureReference.Gauge => this + FromAtmosphere(1),
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
            PressureReference.Absolute => "a",
            PressureReference.Gauge => "g",
            //PressureReference.Vacuum => "TODO",
            _ => throw new System.NotImplementedException(),
        };



    }
}
