using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricConductivityUnit : Enumeration
    {

        public static readonly ElectricConductivityUnit SI = new ElectricConductivityUnit(ElectricAdmittanceUnit.Siemens, LengthUnit.Meter);
        public static readonly ElectricConductivityUnit SiemensPerMeter = new ElectricConductivityUnit(ElectricAdmittanceUnit.Siemens, LengthUnit.Meter);
        public static readonly ElectricConductivityUnit SiemensPerInch = new ElectricConductivityUnit(ElectricAdmittanceUnit.Siemens, LengthUnit.Inch);
        public static readonly ElectricConductivityUnit SiemensPerFoot = new ElectricConductivityUnit(ElectricAdmittanceUnit.Siemens, LengthUnit.Foot);



        public ElectricConductivityUnit(ElectricAdmittanceUnit electricAdmittance, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricAdmittance / Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricAdmittance}/{Length}");
        }


    }




}