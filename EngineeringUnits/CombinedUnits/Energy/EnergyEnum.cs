using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public partial record EnergyUnit : UnitTypebase
    {


        public static readonly EnergyUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "J");
        public static readonly EnergyUnit Millijoule =   new(PreFix.milli, SI);
        public static readonly EnergyUnit Joule =        new(PreFix.SI, SI);
        public static readonly EnergyUnit Kilojoule =    new(PreFix.kilo, SI);
        public static readonly EnergyUnit Megajoule =    new(PreFix.mega, SI);
        public static readonly EnergyUnit Gigajoule =    new(PreFix.giga, SI);
        public static readonly EnergyUnit Terajoule =    new(PreFix.tera, SI);
        public static readonly EnergyUnit BritishThermalUnit =       new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);
        public static readonly EnergyUnit KilobritishThermalUnit =   new(PreFix.kilo, BritishThermalUnit);
        public static readonly EnergyUnit MegabritishThermalUnit =   new(PreFix.mega, BritishThermalUnit);
        public static readonly EnergyUnit GigabritishThermalUnit =   new(PreFix.giga, BritishThermalUnit);
        public static readonly EnergyUnit ElectronVolt =     new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m);
        public static readonly EnergyUnit KiloelectronVolt = new(PreFix.kilo, ElectronVolt);
        public static readonly EnergyUnit MegaelectronVolt = new(PreFix.mega, ElectronVolt);
        public static readonly EnergyUnit GigaelectronVolt = new(PreFix.giga, ElectronVolt);
        public static readonly EnergyUnit TeraelectronVolt = new(PreFix.tera, ElectronVolt);
        public static readonly EnergyUnit Calorie =      new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);
        public static readonly EnergyUnit Kilocalorie =  new(PreFix.kilo, Calorie);
        public static readonly EnergyUnit Megacalorie =  new(PreFix.mega, Calorie);
        public static readonly EnergyUnit WattDay =      new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, DurationUnit.Day, "W");
        public static readonly EnergyUnit KilowattDay =  new(PreFix.kilo, WattDay);
        public static readonly EnergyUnit MegawattDay =  new(PreFix.mega, WattDay);
        public static readonly EnergyUnit GigawattDay =  new(PreFix.giga, WattDay);
        public static readonly EnergyUnit TerawattDay =  new(PreFix.tera, WattDay);
        public static readonly EnergyUnit WattHour =     new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, DurationUnit.Hour, "W");
        public static readonly EnergyUnit KilowattHour = new(PreFix.kilo, WattHour);
        public static readonly EnergyUnit MegawattHour = new(PreFix.mega, WattHour);
        public static readonly EnergyUnit GigawattHour = new(PreFix.giga, WattHour);
        public static readonly EnergyUnit TerawattHour = new(PreFix.tera, WattHour);
        public static readonly EnergyUnit FootPound =            new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "ft·lb", 1.3558179483314004m);
        public static readonly EnergyUnit DecathermEc =          new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (E.C.)", 1055055852.62m);
        public static readonly EnergyUnit DecathermImperial =    new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (imp.)", 1055055852.57348m);
        public static readonly EnergyUnit DecathermUs =          new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (U.S.)", 1054804000.0m);
        public static readonly EnergyUnit ThermEc =              new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (E.C.)",  105506000m);
        public static readonly EnergyUnit ThermImperial =        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (imp.)",  105505585.257348m);
        public static readonly EnergyUnit ThermUs =              new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (U.S.)",  105480400.00m);
        public static readonly EnergyUnit Erg =                  new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "erg", 1e-7m);
        public static readonly EnergyUnit HorsepowerHour =       new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "hp·h", 2.6845195377e6m);




        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol, decimal correction = 1)
        {
            Unit = new UnitSystem((mass * Length.Pow(2)) / duration.Pow(2) * correction, NewSymbol);     
        }


        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, DurationUnit duration2, string NewSymbol)
        {
            Unit = new UnitSystem(((mass * Length.Pow(2)) / (duration.Pow(3)))* duration2.Unit, 
                                    $"{NewSymbol}{duration2}");
        }


        public EnergyUnit(PreFix SI, EnergyUnit unit) : base(SI, unit) {}

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }



}