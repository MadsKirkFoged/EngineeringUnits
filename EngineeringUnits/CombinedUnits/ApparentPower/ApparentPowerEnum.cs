using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ApparentPowerUnit : Enumeration
    {

        public static readonly ApparentPowerUnit SI = new ApparentPowerUnit(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere);
        public static readonly ApparentPowerUnit Voltampere = new ApparentPowerUnit(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, "VA");
        public static readonly ApparentPowerUnit Megavoltampere = new ApparentPowerUnit(PreFix.mega, Voltampere);
        public static readonly ApparentPowerUnit Kilovoltampere = new ApparentPowerUnit(PreFix.kilo, Voltampere);
        public static readonly ApparentPowerUnit Gigavoltampere = new ApparentPowerUnit(PreFix.giga, Voltampere);


        public ApparentPowerUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrentUnit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricPotential * electricCurrentUnit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

     

        public ApparentPowerUnit(PreFix SI, ApparentPowerUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }



    }




}