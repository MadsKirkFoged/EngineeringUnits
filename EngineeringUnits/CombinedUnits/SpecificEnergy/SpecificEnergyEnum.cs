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

        public static readonly SpecificEnergyUnit SI =                       new SpecificEnergyUnit(EnergyUnit.SI, MassUnit.SI);
        public static readonly SpecificEnergyUnit JoulePerKilogram =         new SpecificEnergyUnit(EnergyUnit.Joule, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit KilojoulePerKilogram =     new SpecificEnergyUnit(EnergyUnit.Kilojoule, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit MegajoulePerKilogram =     new SpecificEnergyUnit(EnergyUnit.Megajoule, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit BtuPerPound =              new SpecificEnergyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound);
        public static readonly SpecificEnergyUnit CaloriePerGram =           new SpecificEnergyUnit(EnergyUnit.Calorie, MassUnit.Gram);
        public static readonly SpecificEnergyUnit KilocaloriePerGram =       new SpecificEnergyUnit(EnergyUnit.Kilocalorie, MassUnit.Gram);
        public static readonly SpecificEnergyUnit WattDayPerKilogram =       new SpecificEnergyUnit(EnergyUnit.WattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit KilowattDayPerKilogram =   new SpecificEnergyUnit(EnergyUnit.KilowattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit MegawattDayPerKilogram =   new SpecificEnergyUnit(EnergyUnit.MegawattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit GigawattDayPerKilogram =   new SpecificEnergyUnit(EnergyUnit.GigawattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit TerawattDayPerKilogram =   new SpecificEnergyUnit(EnergyUnit.TerawattDay, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit WattHourPerKilogram =      new SpecificEnergyUnit(EnergyUnit.WattHour, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit KilowattHourPerKilogram =  new SpecificEnergyUnit(EnergyUnit.KilowattHour, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit MegawattHourPerKilogram =  new SpecificEnergyUnit(EnergyUnit.MegawattHour, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit GigawattHourPerKilogram =  new SpecificEnergyUnit(EnergyUnit.GigawattHour, MassUnit.Kilogram);
        public static readonly SpecificEnergyUnit WattDayPerTonne =          new SpecificEnergyUnit(EnergyUnit.WattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit KilowattDayPerTonne =      new SpecificEnergyUnit(EnergyUnit.KilowattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit MegawattDayPerTonne =      new SpecificEnergyUnit(EnergyUnit.MegawattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit GigawattDayPerTonne =      new SpecificEnergyUnit(EnergyUnit.GigawattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit TerawattDayPerTonne =      new SpecificEnergyUnit(EnergyUnit.TerawattDay, MassUnit.Tonne);
        public static readonly SpecificEnergyUnit WattDayPerShortTon =       new SpecificEnergyUnit(EnergyUnit.WattDay, MassUnit.ShortTon);
        public static readonly SpecificEnergyUnit KilowattDayPerShortTon =   new SpecificEnergyUnit(EnergyUnit.KilowattDay, MassUnit.ShortTon);
        public static readonly SpecificEnergyUnit MegawattDayPerShortTon =   new SpecificEnergyUnit(EnergyUnit.MegawattDay, MassUnit.ShortTon);
        public static readonly SpecificEnergyUnit GigawattDayPerShortTon =   new SpecificEnergyUnit(EnergyUnit.GigawattDay, MassUnit.ShortTon);
        public static readonly SpecificEnergyUnit TerawattDayPerShortTon =   new SpecificEnergyUnit(EnergyUnit.TerawattDay, MassUnit.ShortTon);


        public SpecificEnergyUnit(EnergyUnit energy, MassUnit mass, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy / mass;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{mass}");
        }


    }



}