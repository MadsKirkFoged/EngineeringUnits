using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricAdmittanceUnit : Enumeration
    {

        public static readonly ElectricAdmittanceUnit SI = new ElectricAdmittanceUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI, "S");
        public static readonly ElectricAdmittanceUnit Siemens = new ElectricAdmittanceUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "S");
        public static readonly ElectricAdmittanceUnit Microsiemens = new ElectricAdmittanceUnit(PreFix.micro, Siemens);
        public static readonly ElectricAdmittanceUnit Millisiemens = new ElectricAdmittanceUnit(PreFix.milli, Siemens);
        public static readonly ElectricAdmittanceUnit Nanosiemens = new ElectricAdmittanceUnit(PreFix.nano, Siemens);


        public ElectricAdmittanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty", decimal correction = 1)
        {
            //kg−1⋅m−2⋅s3⋅A2
            Unit = (duration.Pow(3) *  electricCurrent.Pow(2)) / (mass * Length.Pow(2));
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }



        public ElectricAdmittanceUnit(PreFix SI, ElectricAdmittanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }



    }




}