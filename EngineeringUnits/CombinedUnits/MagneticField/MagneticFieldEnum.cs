using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MagneticFieldUnit : Enumeration
    {

        public static readonly MagneticFieldUnit SI = new(MassUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI);
        public static readonly MagneticFieldUnit Tesla = new(MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere,"T");

        public static readonly MagneticFieldUnit Gauss = new(Tesla, "G", 1e-4m);
        public static readonly MagneticFieldUnit Milligauss = new(PreFix.milli, Gauss);


        public static readonly MagneticFieldUnit Microtesla = new(PreFix.micro, Tesla);
        public static readonly MagneticFieldUnit Millitesla = new(PreFix.milli, Tesla);
        public static readonly MagneticFieldUnit Nanotesla = new(PreFix.nano, Tesla);




        public MagneticFieldUnit(MassUnit mass, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty", decimal correction = 1)
        {
            //kg⋅s−2⋅A−1
            Unit = mass / (duration * duration * electricCurrent);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }



        public MagneticFieldUnit(PreFix SI, MagneticFieldUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }
        public MagneticFieldUnit(MagneticFieldUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


    }




}