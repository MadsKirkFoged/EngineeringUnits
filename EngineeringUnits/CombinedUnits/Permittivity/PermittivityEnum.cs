using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record PermittivityUnit : UnitTypebase
    {

        public static readonly PermittivityUnit SI = new(CapacitanceUnit.SI, LengthUnit.SI);
        public static readonly PermittivityUnit FaradPerMeter = new(CapacitanceUnit.Farad, LengthUnit.Meter);




        public PermittivityUnit(CapacitanceUnit capacitance, LengthUnit Length)
        {
            Unit = new UnitSystem(capacitance / Length, 
                               $"{capacitance}/{Length}");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }


    }




}