using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class PowerUnit : Enumeration
    {


        public static PowerUnit SI = new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "W");
        public static PowerUnit Watt = new PowerUnit(EnergyUnit.Joule, DurationUnit.SI, "W");
        public static PowerUnit Kilowatt = new PowerUnit(EnergyUnit.Kilojoule, DurationUnit.SI, "kW");
        public static PowerUnit BritishThermalUnitPerHour = new PowerUnit(EnergyUnit.BritishThermalUnit, DurationUnit.Hour, "");


        public PowerUnit(EnergyUnit Energy, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Energy";

            //kg*m2*s-3
            Unit = Energy.Unit / duration.Unit;

            if (NewSymbol != "")
            {
                Unit.Symbol = NewSymbol;
            }

            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", correction, 1);
            }


            //Unit.EkstraCorrection = correction;
        }


        public static IEnumerable<PowerUnit> List()
        {
            return new[] { Watt };
        }
        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }
    }



}