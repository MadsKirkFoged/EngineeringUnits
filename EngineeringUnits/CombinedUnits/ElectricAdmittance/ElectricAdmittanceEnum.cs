using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record ElectricAdmittanceUnit : UnitTypebase
    {

        public static readonly ElectricAdmittanceUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI, "S");
        public static readonly ElectricAdmittanceUnit Siemens = new(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "S");
        public static readonly ElectricAdmittanceUnit Microsiemens = new(PreFix.micro, Siemens);
        public static readonly ElectricAdmittanceUnit Millisiemens = new(PreFix.milli, Siemens);
        public static readonly ElectricAdmittanceUnit Nanosiemens = new(PreFix.nano, Siemens);


        public ElectricAdmittanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, ElectricCurrentUnit electricCurrent, string NewSymbol)
        {
            Unit = new UnitSystem((duration.Pow(3) *  electricCurrent.Pow(2)) / (mass * Length.Pow(2)), NewSymbol);
        }



        public ElectricAdmittanceUnit(PreFix SI, ElectricAdmittanceUnit unit) : base(SI, unit) {}

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}