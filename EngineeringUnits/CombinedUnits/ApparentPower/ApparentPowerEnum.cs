using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ApparentPowerUnit : Enumeration
    {

        public static readonly ApparentPowerUnit SI = new(ElectricPotentialUnit.SI, ElectricCurrentUnit.SI);
        public static readonly ApparentPowerUnit Voltampere = new(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, "VA");
        public static readonly ApparentPowerUnit Megavoltampere = new(PreFix.mega, Voltampere);
        public static readonly ApparentPowerUnit Kilovoltampere = new(PreFix.kilo, Voltampere);
        public static readonly ApparentPowerUnit Gigavoltampere = new(PreFix.giga, Voltampere);


        public ApparentPowerUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrentUnit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricPotential * electricCurrentUnit * correction;
            //SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

     

        public ApparentPowerUnit(PreFix SI, ApparentPowerUnit unit)
        {
            Unit = unit.Unit.Copy() * PrefixSISize(SI);
            SetNewSymbol(SI);
        }



    }




}