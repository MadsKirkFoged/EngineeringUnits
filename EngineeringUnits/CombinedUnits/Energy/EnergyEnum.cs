using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class EnergyUnit : Enumeration
    {


        public static readonly EnergyUnit SI = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "J");
        public static readonly EnergyUnit Millijoule =   new EnergyUnit(PreFix.milli, SI);
        public static readonly EnergyUnit Joule =        new EnergyUnit(PreFix.SI, SI);
        public static readonly EnergyUnit Kilojoule =    new EnergyUnit(PreFix.kilo, SI);
        public static readonly EnergyUnit Megajoule =    new EnergyUnit(PreFix.mega, SI);
        public static readonly EnergyUnit Gigajoule =    new EnergyUnit(PreFix.giga, SI);
        public static readonly EnergyUnit Terajoule =    new EnergyUnit(PreFix.tera, SI);
        public static readonly EnergyUnit BritishThermalUnit =       new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);
        public static readonly EnergyUnit KilobritishThermalUnit =   new EnergyUnit(PreFix.kilo, BritishThermalUnit);
        public static readonly EnergyUnit MegabritishThermalUnit =   new EnergyUnit(PreFix.mega, BritishThermalUnit);
        public static readonly EnergyUnit GigabritishThermalUnit =   new EnergyUnit(PreFix.giga, BritishThermalUnit);
        public static readonly EnergyUnit ElectronVolt =     new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m);
        public static readonly EnergyUnit KiloelectronVolt = new EnergyUnit(PreFix.kilo, ElectronVolt);
        public static readonly EnergyUnit MegaelectronVolt = new EnergyUnit(PreFix.mega, ElectronVolt);
        public static readonly EnergyUnit GigaelectronVolt = new EnergyUnit(PreFix.giga, ElectronVolt);
        public static readonly EnergyUnit TeraelectronVolt = new EnergyUnit(PreFix.tera, ElectronVolt);
        public static readonly EnergyUnit Calorie =      new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);
        public static readonly EnergyUnit Kilocalorie =  new EnergyUnit(PreFix.kilo, Calorie);
        public static readonly EnergyUnit Megacalorie =  new EnergyUnit(PreFix.mega, Calorie);
        public static readonly EnergyUnit WattDay =      new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, DurationUnit.Day, "W");
        public static readonly EnergyUnit KilowattDay =  new EnergyUnit(PreFix.kilo, WattDay);
        public static readonly EnergyUnit MegawattDay =  new EnergyUnit(PreFix.mega, WattDay);
        public static readonly EnergyUnit GigawattDay =  new EnergyUnit(PreFix.giga, WattDay);
        public static readonly EnergyUnit TerawattDay =  new EnergyUnit(PreFix.tera, WattDay);
        public static readonly EnergyUnit WattHour =     new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, DurationUnit.Hour, "W");
        public static readonly EnergyUnit KilowattHour = new EnergyUnit(PreFix.kilo, WattHour);
        public static readonly EnergyUnit MegawattHour = new EnergyUnit(PreFix.mega, WattHour);
        public static readonly EnergyUnit GigawattHour = new EnergyUnit(PreFix.giga, WattHour);
        public static readonly EnergyUnit TerawattHour = new EnergyUnit(PreFix.tera, WattHour);
        public static readonly EnergyUnit FootPound =            new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "ft·lb", 1.3558179483314004m);
        public static readonly EnergyUnit DecathermEc =          new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (E.C.)", 1055055852.62m);
        public static readonly EnergyUnit DecathermImperial =    new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (imp.)", 1055055852.57348m);
        public static readonly EnergyUnit DecathermUs =          new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (U.S.)", 1054804000.0m);
        public static readonly EnergyUnit ThermEc =              new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (E.C.)",  105506000m);
        public static readonly EnergyUnit ThermImperial =        new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (imp.)",  105505585.257348m);
        public static readonly EnergyUnit ThermUs =              new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (U.S.)",  105480400.00m);
        public static readonly EnergyUnit Erg =                  new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "erg", 1e-7m);
        public static readonly EnergyUnit HorsepowerHour =       new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "hp·h", 2.6845195377e6m);




        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = (mass * Length.Pow(2)) / duration.Pow(2);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);         
        }

        public EnergyUnit(PreFix SI, EnergyUnit energyunit) 
        {
            Unit = energyunit.Unit.Copy();
            //Unit = energyunit.Unit;
            SetCombined(SI);
            SetNewSymbol(SI);          
        }

        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, DurationUnit duration2, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = ((mass * Length.Pow(2)) / (duration.Pow(3)))* duration2.Unit;
            SetCombined(correction);
            //SetNewSymbol($"{NewSymbol}{duration2}");
            SetNewSymbol("Empty", $"{NewSymbol}{duration2}");
        }

    }



}