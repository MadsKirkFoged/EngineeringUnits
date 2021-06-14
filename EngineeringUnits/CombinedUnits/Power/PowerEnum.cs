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
        public static PowerUnit Megawatt = new PowerUnit(EnergyUnit.Megajoule, DurationUnit.SI, "MW");
        public static PowerUnit Gigawatt = new PowerUnit(EnergyUnit.Gigajoule, DurationUnit.SI, "GW");
        //public static PowerUnit Terawatt = new PowerUnit(EnergyUnit., DurationUnit.SI, "GW");


        public static PowerUnit BritishThermalUnitPerHour = new PowerUnit(EnergyUnit.BritishThermalUnit, DurationUnit.Hour);
        public static PowerUnit BritishThermalUnitPerSecond = new PowerUnit(EnergyUnit.BritishThermalUnit, DurationUnit.Second);

        public PowerUnit(EnergyUnit Energy, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Power";

            //kg*m2*s-3
            Unit = Energy.Unit / duration.Unit;


            if (NewSymbol != "")
                Unit.Symbol = NewSymbol;
            else
                Unit.Symbol = $"{Energy}/{duration}";


            if (correction != 1)            
                Unit.Combined = new CombinedUnit("", correction, 1);            

        }


        public static IEnumerable<PowerUnit> List()
        {
            return new[] { SI, Watt, Kilowatt, BritishThermalUnitPerHour, BritishThermalUnitPerSecond };
        }
        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }


    }



}