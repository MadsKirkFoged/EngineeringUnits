using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record MagnetizationUnit : UnitTypebase
    {

        public static readonly MagnetizationUnit SI = new(ElectricCurrentUnit.SI, LengthUnit.SI);
        public static readonly MagnetizationUnit AmperePerMeter = new(ElectricCurrentUnit.Ampere, LengthUnit.Meter);


        public MagnetizationUnit(ElectricCurrentUnit electricCurrent, LengthUnit Length)
        {
            Unit = electricCurrent / Length;
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}