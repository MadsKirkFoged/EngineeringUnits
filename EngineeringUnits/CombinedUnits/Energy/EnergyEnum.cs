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

        public static EnergyUnit Millijoule = new EnergyUnit(MassUnit.Gram, LengthUnit.SI, DurationUnit.SI, "kJ");
        public static EnergyUnit Joule = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "J");
        public static EnergyUnit Kilojoule = new EnergyUnit(MassUnit.Tonne, LengthUnit.SI, DurationUnit.SI, "kJ");
        public static EnergyUnit Megajoule = new EnergyUnit(MassUnit.Kilotonne, LengthUnit.SI, DurationUnit.SI, "MJ");
        public static EnergyUnit Gigajoule = new EnergyUnit(MassUnit.Megatonne, LengthUnit.SI, DurationUnit.SI, "GJ");

        public static EnergyUnit WattHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.Hour, "GJ");
        public static EnergyUnit WattDay = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.Day, "GJ");

        public static EnergyUnit KilowattHour = new EnergyUnit(MassUnit.Tonne, LengthUnit.SI, DurationUnit.Hour, "GJ");
        public static EnergyUnit KilowattDay = new EnergyUnit(MassUnit.Tonne, LengthUnit.SI, DurationUnit.Day, "GJ");
        public static EnergyUnit MegawattDay = new EnergyUnit(MassUnit.Kilotonne, LengthUnit.SI, DurationUnit.Day, "MJ");
        public static EnergyUnit MegawattHour = new EnergyUnit(MassUnit.Kilotonne, LengthUnit.SI, DurationUnit.Hour, "GJ");
        public static EnergyUnit GigawattHour = new EnergyUnit(MassUnit.Megatonne, LengthUnit.SI, DurationUnit.Hour, "GJ");
        public static EnergyUnit GigawattDay = new EnergyUnit(MassUnit.Megatonne, LengthUnit.SI, DurationUnit.Day, "GJ");

        public static EnergyUnit TerawattDay = new EnergyUnit(MassUnit.Megatonne, LengthUnit.SI, DurationUnit.Day, "GJ", 1000);
        public static EnergyUnit TerawattHour = new EnergyUnit(MassUnit.Megatonne, LengthUnit.SI, DurationUnit.Hour, "GJ", 1000);

        public static EnergyUnit BritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);
        public static EnergyUnit KilobritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m * 1e3m);
        public static EnergyUnit MegabritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m * 1e6m);
        public static EnergyUnit GigabritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m * 1e9m);

        public static EnergyUnit Calorie = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);
        public static EnergyUnit Kilocalorie = new EnergyUnit(MassUnit.Tonne, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);
        public static EnergyUnit Megacalorie = new EnergyUnit(MassUnit.Tonne, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);

        public static EnergyUnit ElectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m);
        public static EnergyUnit KiloelectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m * 1e3m);
        public static EnergyUnit MegaelectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m * 1e6m);
        public static EnergyUnit GigaelectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m * 1e9m);
        public static EnergyUnit TeraelectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m * 1e12m);

        public static EnergyUnit FootPound = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "", 1.3558m);


        public static EnergyUnit DecathermEc = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 105506000m);
        public static EnergyUnit DecathermImperial = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);
        public static EnergyUnit DecathermUs = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 105505585.257348m);

        public static EnergyUnit ThermEc = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 105506000m);
        public static EnergyUnit ThermImperial = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);
        public static EnergyUnit ThermUs = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 105505585.257348m);

        public static EnergyUnit Erg = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1e-7m);


        public static EnergyUnit HorsepowerHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "", 2.6845195377e6m);




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


        public static IEnumerable<EnergyUnit> List()
        {
            return new[] { SI, Joule, Kilojoule, BritishThermalUnit, Calorie, ElectronVolt, FootPound, KilowattHour, WattHour };
        }
        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }
    }



}