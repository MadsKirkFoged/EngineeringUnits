using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricInductanceUnit : Enumeration
    {

        public static readonly ElectricInductanceUnit SI = new ElectricInductanceUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere);
        public static readonly ElectricInductanceUnit Henry = new ElectricInductanceUnit(MassUnit.Kilogram, LengthUnit.Meter, DurationUnit.Second, ElectricCurrentUnit.Ampere, "H");
        public static readonly ElectricInductanceUnit Microhenry = new ElectricInductanceUnit(PreFix.micro, Henry);
        public static readonly ElectricInductanceUnit Millihenry = new ElectricInductanceUnit(PreFix.milli, Henry);
        public static readonly ElectricInductanceUnit Nanohenry = new ElectricInductanceUnit(PreFix.nano, Henry);


        public ElectricInductanceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration,ElectricCurrentUnit electricCurrent, string NewSymbol = "Empty", decimal correction = 1)
        {
            //kg⋅m2⋅s−2⋅A−2
            Unit = (mass * Length.Pow(2))/(duration.Pow(2)  * electricCurrent.Pow(2));
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        public ElectricInductanceUnit(PreFix SI, ElectricInductanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

  

    }




}