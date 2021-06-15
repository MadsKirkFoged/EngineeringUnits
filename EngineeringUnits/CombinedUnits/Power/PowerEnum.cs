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

        public static PowerUnit Watt = new PowerUnit(PreFix.SI, SI);
        public static PowerUnit Kilowatt = new PowerUnit(PreFix.kilo, SI);
        public static PowerUnit Megawatt = new PowerUnit(PreFix.mega, SI);
        public static PowerUnit Gigawatt = new PowerUnit(PreFix.giga, SI);
        public static PowerUnit Terawatt = new PowerUnit(PreFix.tera, SI);

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

        public PowerUnit(PreFix SI, PowerUnit unit)
        {
            Unit = unit.Unit.Copy();


            if (Unit.Combined is null)
                Unit.Combined = new CombinedUnit("", 1, PrefixSISize(SI));
            else
                Unit.Combined.GlobalC *= PrefixSISize(SI);




            Unit.Symbol = PrefixSISymbol(SI) + Unit.Symbol;
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