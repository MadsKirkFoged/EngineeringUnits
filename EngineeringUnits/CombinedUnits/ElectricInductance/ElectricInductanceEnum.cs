using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricInductanceUnit : Enumeration
    {

        public static readonly ElectricInductanceUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, ElectricCurrentUnit.SI);
        public static readonly ElectricInductanceUnit Henry = new(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "H");
        public static readonly ElectricInductanceUnit Microhenry = new(PreFix.micro, Henry);
        public static readonly ElectricInductanceUnit Millihenry = new(PreFix.milli, Henry);
        public static readonly ElectricInductanceUnit Nanohenry = new(PreFix.nano, Henry);


        public ElectricInductanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration,ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty")
        {
            //kg⋅m2⋅s−2⋅A−2
            Unit = (mass * Length.Pow(2))/(duration.Pow(2)  * electricCurrent.Pow(2));
            SetNewSymbol(NewSymbol);
        }


        public ElectricInductanceUnit(PreFix SI, ElectricInductanceUnit unit) : base(SI, unit)
        {
        }

  

    }




}