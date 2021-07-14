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


        public static readonly PowerUnit SI = new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "W");
        public static readonly PowerUnit Femtowatt = new PowerUnit(PreFix.femto, SI);
        public static readonly PowerUnit Picowatt =  new PowerUnit(PreFix.pico, SI);
        public static readonly PowerUnit Nanowatt =  new PowerUnit(PreFix.nano, SI);
        public static readonly PowerUnit Microwatt = new PowerUnit(PreFix.micro, SI);
        public static readonly PowerUnit Milliwatt = new PowerUnit(PreFix.milli, SI);
        public static readonly PowerUnit Deciwatt =  new PowerUnit(PreFix.deci, SI);
        public static readonly PowerUnit Watt =      new PowerUnit(PreFix.SI, SI);
        public static readonly PowerUnit Decawatt =  new PowerUnit(PreFix.deka, SI);
        public static readonly PowerUnit Kilowatt =  new PowerUnit(PreFix.kilo, SI);
        public static readonly PowerUnit Megawatt =  new PowerUnit(PreFix.mega, SI);
        public static readonly PowerUnit Gigawatt =  new PowerUnit(PreFix.giga, SI);
        public static readonly PowerUnit Terawatt =  new PowerUnit(PreFix.tera, SI);
        public static readonly PowerUnit Petawatt =  new PowerUnit(PreFix.peta, SI);
        public static readonly PowerUnit MillijoulePerHour = new PowerUnit(EnergyUnit.Millijoule, DurationUnit.Hour);
        public static readonly PowerUnit JoulePerHour =      new PowerUnit(EnergyUnit.Joule, DurationUnit.Hour);
        public static readonly PowerUnit KilojoulePerHour =  new PowerUnit(EnergyUnit.Kilojoule, DurationUnit.Hour);
        public static readonly PowerUnit MegajoulePerHour =  new PowerUnit(EnergyUnit.Megajoule, DurationUnit.Hour);
        public static readonly PowerUnit GigajoulePerHour =  new PowerUnit(EnergyUnit.Gigajoule, DurationUnit.Hour);
        public static readonly PowerUnit BritishThermalUnitPerHour =     new PowerUnit(EnergyUnit.BritishThermalUnit, DurationUnit.Hour);
        public static readonly PowerUnit BritishThermalUnitPerMinute =     new PowerUnit(EnergyUnit.BritishThermalUnit, DurationUnit.Minute);
        public static readonly PowerUnit BritishThermalUnitPerSecond =   new PowerUnit(EnergyUnit.BritishThermalUnit, DurationUnit.Second);
        public static readonly PowerUnit KilobritishThermalUnitPerHour = new PowerUnit(EnergyUnit.KilobritishThermalUnit, DurationUnit.Hour);
        public static readonly PowerUnit BoilerHorsepower =      new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(S)", 9812.5m);
        public static readonly PowerUnit ElectricalHorsepower =  new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(E)", 746m);
        public static readonly PowerUnit HydraulicHorsepower =   new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(H)", 745.69988145m);
        public static readonly PowerUnit MechanicalHorsepower =  new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(I)", 745.69m);
        public static readonly PowerUnit MetricHorsepower =      new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "hp(M)", 735.49875m);


        public static readonly PowerUnit CaloriePerSecond = new PowerUnit(EnergyUnit.Calorie, DurationUnit.Second);
        public static readonly PowerUnit KilocaloriePerHour = new PowerUnit(EnergyUnit.Kilocalorie, DurationUnit.Hour);
        public static readonly PowerUnit KilocaloriePerSecond = new PowerUnit(EnergyUnit.Kilocalorie, DurationUnit.Second);

        public static readonly PowerUnit SolarLuminosity = new PowerUnit(EnergyUnit.SI, DurationUnit.SI, "L⊙", 3.846e26m);


        public PowerUnit(EnergyUnit Energy, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Energy / duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Energy}/{duration}");    
        }

        public PowerUnit(PreFix SI, PowerUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

    }
}