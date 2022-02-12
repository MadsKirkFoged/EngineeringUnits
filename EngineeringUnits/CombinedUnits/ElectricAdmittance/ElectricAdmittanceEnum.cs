using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricAdmittanceUnit : Enumeration
    {

        public static readonly ElectricAdmittanceUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI, "S");
        public static readonly ElectricAdmittanceUnit Siemens = new(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "S");
        public static readonly ElectricAdmittanceUnit Microsiemens = new(PreFix.micro, Siemens);
        public static readonly ElectricAdmittanceUnit Millisiemens = new(PreFix.milli, Siemens);
        public static readonly ElectricAdmittanceUnit Nanosiemens = new(PreFix.nano, Siemens);


        public ElectricAdmittanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty")
        {
            //kg−1⋅m−2⋅s3⋅A2
            Unit = (duration.Pow(3) *  electricCurrent.Pow(2)) / (mass * Length.Pow(2));
            SetNewSymbol(NewSymbol);
        }



        public ElectricAdmittanceUnit(PreFix SI, ElectricAdmittanceUnit unit)
        {
            Unit = unit.Unit.Copy() * PrefixSISize(SI);
            //SetCombined(SI);
            SetNewSymbol(SI);
        }



    }




}