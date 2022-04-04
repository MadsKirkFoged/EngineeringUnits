using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record ApparentPowerUnit : UnitTypebase
    {

        public static readonly ApparentPowerUnit SI = new(ElectricPotentialUnit.SI, ElectricCurrentUnit.SI);
        public static readonly ApparentPowerUnit Voltampere = new(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, "VA");
        public static readonly ApparentPowerUnit Megavoltampere = new(PreFix.mega, Voltampere);
        public static readonly ApparentPowerUnit Kilovoltampere = new(PreFix.kilo, Voltampere);
        public static readonly ApparentPowerUnit Gigavoltampere = new(PreFix.giga, Voltampere);


        public ApparentPowerUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrentUnit, string NewSymbol = null)
        {
            Unit = new UnitSystem(electricPotential * electricCurrentUnit, NewSymbol);
        }

     

        public ApparentPowerUnit(PreFix SI, ApparentPowerUnit unit) : base(SI, unit) {}

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}