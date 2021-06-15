using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class EnergyUnit : Enumeration
    {


        public static EnergyUnit SI = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "J");

        public static EnergyUnit Millijoule = new EnergyUnit(PreFix.milli, SI);
        public static EnergyUnit Joule = new EnergyUnit(PreFix.SI, SI);
        public static EnergyUnit Kilojoule = new EnergyUnit(PreFix.kilo, SI);
        public static EnergyUnit Megajoule = new EnergyUnit(PreFix.mega, SI);
        public static EnergyUnit Gigajoule = new EnergyUnit(PreFix.giga, SI);
        public static EnergyUnit Terajoule = new EnergyUnit(PreFix.tera, SI);

        public static EnergyUnit BritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);
        public static EnergyUnit KilobritishThermalUnit = new EnergyUnit(PreFix.kilo, BritishThermalUnit);
        public static EnergyUnit MegabritishThermalUnit = new EnergyUnit(PreFix.mega, BritishThermalUnit);
        public static EnergyUnit GigabritishThermalUnit = new EnergyUnit(PreFix.giga, BritishThermalUnit);

        public static EnergyUnit ElectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m);
        public static EnergyUnit KiloelectronVolt = new EnergyUnit(PreFix.kilo, ElectronVolt);
        public static EnergyUnit MegaelectronVolt = new EnergyUnit(PreFix.mega, ElectronVolt);
        public static EnergyUnit GigaelectronVolt = new EnergyUnit(PreFix.giga, ElectronVolt);
        public static EnergyUnit TeraelectronVolt = new EnergyUnit(PreFix.tera, ElectronVolt);

        public static EnergyUnit Calorie = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);
        public static EnergyUnit Kilocalorie = new EnergyUnit(PreFix.kilo, Calorie);
        public static EnergyUnit Megacalorie = new EnergyUnit(PreFix.mega, Calorie);


        public static EnergyUnit WattDay = new EnergyUnit(PowerUnit.Watt, DurationUnit.Day);
        public static EnergyUnit KilowattDay = new EnergyUnit(PowerUnit.Kilowatt, DurationUnit.Day);
        public static EnergyUnit MegawattDay = new EnergyUnit(PowerUnit.Megawatt, DurationUnit.Day);
        public static EnergyUnit GigawattDay = new EnergyUnit(PowerUnit.Gigawatt, DurationUnit.Day);
        public static EnergyUnit TerawattDay = new EnergyUnit(PowerUnit.Terawatt, DurationUnit.Day);
       
        
        
        public static EnergyUnit WattHour = new EnergyUnit(PowerUnit.Watt, DurationUnit.Hour);
        public static EnergyUnit KilowattHour = new EnergyUnit(PowerUnit.Kilowatt, DurationUnit.Hour);
        public static EnergyUnit MegawattHour = new EnergyUnit(PowerUnit.Megawatt, DurationUnit.Hour);
        public static EnergyUnit GigawattHour = new EnergyUnit(PowerUnit.Gigawatt, DurationUnit.Hour);
        public static EnergyUnit TerawattHour = new EnergyUnit(PowerUnit.Terawatt, DurationUnit.Hour);





        public static EnergyUnit FootPound = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "ft·lb", 1.3558179483314004m);

        public static EnergyUnit DecathermEc = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (E.C.)", 1055055852.62m);
        public static EnergyUnit DecathermImperial = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (imp.)",  1055055852.57348m);
        public static EnergyUnit DecathermUs = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (U.S.)",        1054804000.0m);

        public static EnergyUnit ThermEc = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (E.C.)", 105506000m);
        public static EnergyUnit ThermImperial = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (imp.)", 105505585.257348m);
        public static EnergyUnit ThermUs = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (U.S.)", 105480400.00m);

        public static EnergyUnit Erg = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "erg", 1e-7m);
        public static EnergyUnit HorsepowerHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "hp·h", 2.6845195377e6m);




        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Energy";

            //kg*m2*s-2
            Unit = (mass.Unit * Length.Unit * Length.Unit) / (duration.Unit * duration.Unit);

            if (NewSymbol != "")
            {
                Unit.Symbol = NewSymbol;
            }

            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", 1, correction);
            }


        }

        public EnergyUnit(PreFix SI, EnergyUnit energyunit) 
        {
            Unit = energyunit.Unit.Copy();


            if (Unit.Combined is null)
                Unit.Combined = new CombinedUnit("", 1, PrefixSISize(SI));
            else
                Unit.Combined.GlobalC *= PrefixSISize(SI);




            Unit.Symbol = PrefixSISymbol(SI) + Unit.Symbol;
        }


        public EnergyUnit(PowerUnit power, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Energy";

            Unit = power.Unit * duration.Unit;
            //Unit.Duration.ActualC = (Fraction)(1/3600m);

            if (NewSymbol != "")
            {
                Unit.Symbol = NewSymbol;
            }
            else
            {
                Unit.Symbol = $"{power}{duration}";
            }



            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", 1, correction);
            }


        }


        public static IEnumerable<EnergyUnit> List()
        {
            return new[] { BritishThermalUnit, Calorie, DecathermEc, DecathermImperial, DecathermUs, ElectronVolt, Erg, FootPound, GigabritishThermalUnit, GigaelectronVolt, Gigajoule, GigawattDay, GigawattHour, HorsepowerHour, Joule, KilobritishThermalUnit, Kilocalorie, KiloelectronVolt, Kilojoule, KilowattDay, KilowattHour, MegabritishThermalUnit, Megacalorie, MegaelectronVolt, Megajoule, MegawattDay, MegawattHour, Millijoule, TeraelectronVolt, TerawattDay, TerawattHour, ThermEc, ThermImperial, ThermUs, WattDay, WattHour, };
        }
        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }
    }



}