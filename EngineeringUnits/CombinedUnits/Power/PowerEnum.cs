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

        public static PowerUnit Femtowatt = new PowerUnit(PreFix.femto, SI);
        public static PowerUnit Picowatt = new PowerUnit(PreFix.pico, SI);
        public static PowerUnit Nanowatt = new PowerUnit(PreFix.nano, SI);
        public static PowerUnit Microwatt = new PowerUnit(PreFix.micro, SI);
        public static PowerUnit Milliwatt = new PowerUnit(PreFix.milli, SI);
        public static PowerUnit Deciwatt = new PowerUnit(PreFix.deci, SI);
        public static PowerUnit Watt = new PowerUnit(PreFix.SI, SI);
        public static PowerUnit Decawatt = new PowerUnit(PreFix.deka, SI);
        public static PowerUnit Kilowatt = new PowerUnit(PreFix.kilo, SI);
        public static PowerUnit Megawatt = new PowerUnit(PreFix.mega, SI);
        public static PowerUnit Gigawatt = new PowerUnit(PreFix.giga, SI);
        public static PowerUnit Terawatt = new PowerUnit(PreFix.tera, SI);
        public static PowerUnit Petawatt = new PowerUnit(PreFix.peta, SI);

        public static PowerUnit MillijoulePerHour = new PowerUnit(EnergyUnit.Millijoule, DurationUnit.Hour);
        public static PowerUnit JoulePerHour = new PowerUnit(EnergyUnit.Joule, DurationUnit.Hour);
        public static PowerUnit KilojoulePerHour = new PowerUnit(EnergyUnit.Kilojoule, DurationUnit.Hour);
        public static PowerUnit MegajoulePerHour = new PowerUnit(EnergyUnit.Megajoule, DurationUnit.Hour);
        public static PowerUnit GigajoulePerHour = new PowerUnit(EnergyUnit.Gigajoule, DurationUnit.Hour);


        public static PowerUnit BritishThermalUnitPerHour = new PowerUnit(EnergyUnit.BritishThermalUnit, DurationUnit.Hour);
        public static PowerUnit KilobritishThermalUnitPerHour = new PowerUnit(EnergyUnit.KilobritishThermalUnit, DurationUnit.Hour);
        public static PowerUnit BritishThermalUnitPerSecond = new PowerUnit(EnergyUnit.BritishThermalUnit, DurationUnit.Second);

        public static PowerUnit BoilerHorsepower = new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(S)", 9812.5m);
        public static PowerUnit ElectricalHorsepower = new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(E)", 746m);
        public static PowerUnit HydraulicHorsepower = new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(H)", 745.69988145m);
        public static PowerUnit MechanicalHorsepower = new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(I)", 745.69m);
        public static PowerUnit MetricHorsepower = new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(M)", 735.49875m);


        public PowerUnit(EnergyUnit Energy, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "Power";

            //kg*m2*s-3
            Unit = Energy.Unit / duration.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Energy}/{duration}");    

        }

        public PowerUnit(PreFix SI, PowerUnit unit)
        {
            Name = "Power";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }


        public static IEnumerable<PowerUnit> List()
        {
            return new[] { BoilerHorsepower, BritishThermalUnitPerHour, Decawatt, Deciwatt, ElectricalHorsepower, Femtowatt, GigajoulePerHour, Gigawatt, HydraulicHorsepower, JoulePerHour, KilobritishThermalUnitPerHour, KilojoulePerHour, Kilowatt, MechanicalHorsepower, MegajoulePerHour, Megawatt, MetricHorsepower, Microwatt, MillijoulePerHour, Milliwatt, Nanowatt, Petawatt, Picowatt, Terawatt, Watt, };
        }


    }
}