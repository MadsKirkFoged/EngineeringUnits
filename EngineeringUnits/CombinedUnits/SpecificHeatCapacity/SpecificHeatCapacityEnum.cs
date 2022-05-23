using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public record SpecificHeatCapacityUnit : UnitTypebase
    {

        public static readonly SpecificHeatCapacityUnit SI =                       new(EnergyUnit.SI, MassUnit.SI);
        public static readonly SpecificHeatCapacityUnit JoulePerKilogram =         new(EnergyUnit.Joule, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit KilojoulePerKilogram =     new(EnergyUnit.Kilojoule, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit MegajoulePerKilogram =     new(EnergyUnit.Megajoule, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit BtuPerPound =              new(EnergyUnit.BritishThermalUnit, MassUnit.Pound);
        public static readonly SpecificHeatCapacityUnit CaloriePerGram =           new(EnergyUnit.Calorie, MassUnit.Gram);
        public static readonly SpecificHeatCapacityUnit KilocaloriePerGram =       new(EnergyUnit.Kilocalorie, MassUnit.Gram);
        public static readonly SpecificHeatCapacityUnit WattDayPerKilogram =       new(EnergyUnit.WattDay, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit KilowattDayPerKilogram =   new(EnergyUnit.KilowattDay, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit MegawattDayPerKilogram =   new(EnergyUnit.MegawattDay, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit GigawattDayPerKilogram =   new(EnergyUnit.GigawattDay, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit TerawattDayPerKilogram =   new(EnergyUnit.TerawattDay, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit WattHourPerKilogram =      new(EnergyUnit.WattHour, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit KilowattHourPerKilogram =  new(EnergyUnit.KilowattHour, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit MegawattHourPerKilogram =  new(EnergyUnit.MegawattHour, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit GigawattHourPerKilogram =  new(EnergyUnit.GigawattHour, MassUnit.Kilogram);
        public static readonly SpecificHeatCapacityUnit WattDayPerTonne =          new(EnergyUnit.WattDay, MassUnit.Tonne);
        public static readonly SpecificHeatCapacityUnit KilowattDayPerTonne =      new(EnergyUnit.KilowattDay, MassUnit.Tonne);
        public static readonly SpecificHeatCapacityUnit MegawattDayPerTonne =      new(EnergyUnit.MegawattDay, MassUnit.Tonne);
        public static readonly SpecificHeatCapacityUnit GigawattDayPerTonne =      new(EnergyUnit.GigawattDay, MassUnit.Tonne);
        public static readonly SpecificHeatCapacityUnit TerawattDayPerTonne =      new(EnergyUnit.TerawattDay, MassUnit.Tonne);
        public static readonly SpecificHeatCapacityUnit WattDayPerShortTon =       new(EnergyUnit.WattDay, MassUnit.ShortTon);
        public static readonly SpecificHeatCapacityUnit KilowattDayPerShortTon =   new(EnergyUnit.KilowattDay, MassUnit.ShortTon);
        public static readonly SpecificHeatCapacityUnit MegawattDayPerShortTon =   new(EnergyUnit.MegawattDay, MassUnit.ShortTon);
        public static readonly SpecificHeatCapacityUnit GigawattDayPerShortTon =   new(EnergyUnit.GigawattDay, MassUnit.ShortTon);
        public static readonly SpecificHeatCapacityUnit TerawattDayPerShortTon =   new(EnergyUnit.TerawattDay, MassUnit.ShortTon);


        public SpecificHeatCapacityUnit(EnergyUnit energy, MassUnit mass)
        {
            Unit = new UnitSystem( energy / mass, 
                                $"{energy}/{mass}");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }



}