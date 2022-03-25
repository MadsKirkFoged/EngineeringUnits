using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MagneticFieldUnit : UnitEnumbase
    {

        public static readonly MagneticFieldUnit SI = new(MassUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI, "T");
        public static readonly MagneticFieldUnit Tesla = new(MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere,"T");

        public static readonly MagneticFieldUnit Gauss = new(Tesla, "G", 1e-4m);
        public static readonly MagneticFieldUnit Milligauss = new(PreFix.milli, Gauss);


        public static readonly MagneticFieldUnit Microtesla = new(PreFix.micro, Tesla);
        public static readonly MagneticFieldUnit Millitesla = new(PreFix.milli, Tesla);
        public static readonly MagneticFieldUnit Nanotesla = new(PreFix.nano, Tesla);


        public MagneticFieldUnit(MassUnit mass, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol)
        {
            Unit = new UnitSystem( mass / (duration * duration * electricCurrent), NewSymbol);
        }

        public MagneticFieldUnit(PreFix SI, MagneticFieldUnit unit) : base(SI, unit) {}
        public MagneticFieldUnit(MagneticFieldUnit unit, string NewSymbol = "Empty", decimal correction = 1) : base(unit, NewSymbol, correction) {}


    }




}