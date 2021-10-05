using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class SpecificEnergyUnit : Enumeration
    {

        public static readonly SpecificEnergyUnit SI =                       new(EnergyUnit.SI, MassUnit.SI);
        public static readonly SpecificEnergyUnit JoulePerKilogram =         new(EnergyUnit.Joule, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit KilojoulePerKilogram =     new(EnergyUnit.Kilojoule, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit MegajoulePerKilogram =     new(EnergyUnit.Megajoule, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit BtuPerPound =              new(EnergyUnit.BritishThermalUnit, MassUnit.Pound);
        public static readonly SpecificEnergyUnit CaloriePerGram =           new(EnergyUnit.Calorie, MassUnit.Gram);
        public static readonly SpecificEnergyUnit KilocaloriePerGram =       new(EnergyUnit.Kilocalorie, MassUnit.Gram);
        public static readonly SpecificEnergyUnit WattDayPerKilogram =       new(EnergyUnit.WattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit KilowattDayPerKilogram =   new(EnergyUnit.KilowattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit MegawattDayPerKilogram =   new(EnergyUnit.MegawattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit GigawattDayPerKilogram =   new(EnergyUnit.GigawattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit TerawattDayPerKilogram =   new(EnergyUnit.TerawattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit WattHourPerKilogram =      new(EnergyUnit.WattHour, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit KilowattHourPerKilogram =  new(EnergyUnit.KilowattHour, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit MegawattHourPerKilogram =  new(EnergyUnit.MegawattHour, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit GigawattHourPerKilogram =  new(EnergyUnit.GigawattHour, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit WattDayPerTonne =          new(EnergyUnit.WattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit KilowattDayPerTonne =      new(EnergyUnit.KilowattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit MegawattDayPerTonne =      new(EnergyUnit.MegawattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit GigawattDayPerTonne =      new(EnergyUnit.GigawattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit TerawattDayPerTonne =      new(EnergyUnit.TerawattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit WattDayPerShortTon =       new(EnergyUnit.WattDay, MassUnit.ShortTon);
        public static readonly SpecificEnergyUnit KilowattDayPerShortTon =   new(EnergyUnit.KilowattDay, MassUnit.ShortTon);
        public static readonly SpecificEnergyUnit MegawattDayPerShortTon =   new(EnergyUnit.MegawattDay, MassUnit.ShortTon);
        public static readonly SpecificEnergyUnit GigawattDayPerShortTon =   new(EnergyUnit.GigawattDay, MassUnit.ShortTon);
        public static readonly SpecificEnergyUnit TerawattDayPerShortTon =   new(EnergyUnit.TerawattDay, MassUnit.ShortTon);


        public SpecificEnergyUnit(EnergyUnit energy, MassUnit mass, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy / mass;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{mass}");
        }


    }



}