using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class PowerUnit : UnitEnumbase
    {


        public static readonly PowerUnit SI = new(EnergyUnit.SI, DurationUnit.SI, "W");
        public static readonly PowerUnit Femtowatt = new(PreFix.femto, SI);
        public static readonly PowerUnit Picowatt =  new(PreFix.pico, SI);
        public static readonly PowerUnit Nanowatt =  new(PreFix.nano, SI);
        public static readonly PowerUnit Microwatt = new(PreFix.micro, SI);
        public static readonly PowerUnit Milliwatt = new(PreFix.milli, SI);
        public static readonly PowerUnit Deciwatt =  new(PreFix.deci, SI);
        public static readonly PowerUnit Watt =      new(PreFix.SI, SI);
        public static readonly PowerUnit Decawatt =  new(PreFix.deka, SI);
        public static readonly PowerUnit Kilowatt =  new(PreFix.kilo, SI);
        public static readonly PowerUnit Megawatt =  new(PreFix.mega, SI);
        public static readonly PowerUnit Gigawatt =  new(PreFix.giga, SI);
        public static readonly PowerUnit Terawatt =  new(PreFix.tera, SI);
        public static readonly PowerUnit Petawatt =  new(PreFix.peta, SI);
        public static readonly PowerUnit MillijoulePerHour = new(EnergyUnit.Millijoule, DurationUnit.Hour);
        public static readonly PowerUnit JoulePerHour =      new(EnergyUnit.Joule, DurationUnit.Hour);
        public static readonly PowerUnit KilojoulePerHour =  new(EnergyUnit.Kilojoule, DurationUnit.Hour);
        public static readonly PowerUnit MegajoulePerHour =  new(EnergyUnit.Megajoule, DurationUnit.Hour);
        public static readonly PowerUnit GigajoulePerHour =  new(EnergyUnit.Gigajoule, DurationUnit.Hour);
        public static readonly PowerUnit BritishThermalUnitPerHour =     new(EnergyUnit.BritishThermalUnit, DurationUnit.Hour);
        public static readonly PowerUnit BritishThermalUnitPerMinute =     new(EnergyUnit.BritishThermalUnit, DurationUnit.Minute);
        public static readonly PowerUnit BritishThermalUnitPerSecond =   new(EnergyUnit.BritishThermalUnit, DurationUnit.Second);
        public static readonly PowerUnit KilobritishThermalUnitPerHour = new(EnergyUnit.KilobritishThermalUnit, DurationUnit.Hour);
        public static readonly PowerUnit BoilerHorsepower =      new(EnergyUnit.SI, DurationUnit.SI, "hp(S)", 9812.5m);
        public static readonly PowerUnit ElectricalHorsepower =  new(EnergyUnit.SI, DurationUnit.SI, "hp(E)", 746m);
        public static readonly PowerUnit HydraulicHorsepower =   new(EnergyUnit.SI, DurationUnit.SI, "hp(H)", 745.69988145m);
        public static readonly PowerUnit MechanicalHorsepower =  new(EnergyUnit.SI, DurationUnit.SI, "hp(I)", 745.69m);
        public static readonly PowerUnit MetricHorsepower =      new(EnergyUnit.SI, DurationUnit.SI, "hp(M)", 735.49875m);


        public static readonly PowerUnit CaloriePerSecond = new(EnergyUnit.Calorie, DurationUnit.Second);
        public static readonly PowerUnit KilocaloriePerHour = new(EnergyUnit.Kilocalorie, DurationUnit.Hour);
        public static readonly PowerUnit KilocaloriePerSecond = new(EnergyUnit.Kilocalorie, DurationUnit.Second);

        public static readonly PowerUnit SolarLuminosity = new(EnergyUnit.SI, DurationUnit.SI, "L⊙", 3.846e26m);


        public PowerUnit(EnergyUnit Energy, DurationUnit duration, string NewSymbol, decimal correction = 1)
        {
            Unit = new UnitSystem((Energy / duration) * correction, NewSymbol);
        }

        public PowerUnit(EnergyUnit Energy, DurationUnit duration)
        {
            Unit = new UnitSystem((Energy / duration), 
                                $"{Energy}/{duration}");
        }

        public PowerUnit(PreFix SI, PowerUnit unit) : base(SI, unit) {}

    }
}