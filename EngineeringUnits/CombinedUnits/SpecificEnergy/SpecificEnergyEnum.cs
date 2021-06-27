using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class SpecificEnergyUnit : Enumeration
    {

        public static SpecificEnergyUnit SI = new SpecificEnergyUnit(EnergyUnit.Joule, MassUnit.SI);
        public static SpecificEnergyUnit JoulePerKilogram = new SpecificEnergyUnit(EnergyUnit.Joule, MassUnit.SI);
        public static SpecificEnergyUnit KilojoulePerKilogram = new SpecificEnergyUnit(EnergyUnit.Kilojoule, MassUnit.SI);
        public static SpecificEnergyUnit MegajoulePerKilogram = new SpecificEnergyUnit(EnergyUnit.Megajoule, MassUnit.SI);

        public static SpecificEnergyUnit BtuPerPound = new SpecificEnergyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound);

        public static SpecificEnergyUnit CaloriePerGram = new SpecificEnergyUnit(EnergyUnit.Calorie, MassUnit.Gram);
        public static SpecificEnergyUnit KilocaloriePerGram = new SpecificEnergyUnit(EnergyUnit.Kilocalorie, MassUnit.Gram);

        public static SpecificEnergyUnit WattDayPerKilogram = new SpecificEnergyUnit(EnergyUnit.WattDay, MassUnit.SI);
        public static SpecificEnergyUnit KilowattDayPerKilogram = new SpecificEnergyUnit(EnergyUnit.KilowattDay, MassUnit.SI);
        public static SpecificEnergyUnit MegawattDayPerKilogram = new SpecificEnergyUnit(EnergyUnit.MegawattDay, MassUnit.SI);
        public static SpecificEnergyUnit GigawattDayPerKilogram = new SpecificEnergyUnit(EnergyUnit.GigawattDay, MassUnit.SI);
        public static SpecificEnergyUnit TerawattDayPerKilogram = new SpecificEnergyUnit(EnergyUnit.TerawattDay, MassUnit.SI);

        public static SpecificEnergyUnit WattHourPerKilogram = new SpecificEnergyUnit(EnergyUnit.WattHour, MassUnit.Kilogram);
        public static SpecificEnergyUnit KilowattHourPerKilogram = new SpecificEnergyUnit(EnergyUnit.KilowattHour, MassUnit.Kilogram);
        public static SpecificEnergyUnit MegawattHourPerKilogram = new SpecificEnergyUnit(EnergyUnit.MegawattHour, MassUnit.Kilogram);
        public static SpecificEnergyUnit GigawattHourPerKilogram = new SpecificEnergyUnit(EnergyUnit.GigawattHour, MassUnit.Kilogram);

        public static SpecificEnergyUnit WattDayPerTonne = new SpecificEnergyUnit(EnergyUnit.WattDay, MassUnit.Tonne);
        public static SpecificEnergyUnit KilowattDayPerTonne = new SpecificEnergyUnit(EnergyUnit.KilowattDay, MassUnit.Tonne);
        public static SpecificEnergyUnit MegawattDayPerTonne = new SpecificEnergyUnit(EnergyUnit.MegawattDay, MassUnit.Tonne);
        public static SpecificEnergyUnit GigawattDayPerTonne = new SpecificEnergyUnit(EnergyUnit.GigawattDay, MassUnit.Tonne);
        public static SpecificEnergyUnit TerawattDayPerTonne = new SpecificEnergyUnit(EnergyUnit.TerawattDay, MassUnit.Tonne);

        public static SpecificEnergyUnit WattDayPerShortTon = new SpecificEnergyUnit(EnergyUnit.WattDay, MassUnit.ShortTon);
        public static SpecificEnergyUnit KilowattDayPerShortTon = new SpecificEnergyUnit(EnergyUnit.KilowattDay, MassUnit.ShortTon);
        public static SpecificEnergyUnit MegawattDayPerShortTon = new SpecificEnergyUnit(EnergyUnit.MegawattDay, MassUnit.ShortTon);
        public static SpecificEnergyUnit GigawattDayPerShortTon = new SpecificEnergyUnit(EnergyUnit.GigawattDay, MassUnit.ShortTon);
        public static SpecificEnergyUnit TerawattDayPerShortTon = new SpecificEnergyUnit(EnergyUnit.TerawattDay, MassUnit.ShortTon);


        public SpecificEnergyUnit(EnergyUnit energy, MassUnit mass, string NewSymbol = "Empty", decimal correction = 1)
        {
            //Name = "SpecificEnergy";

            //  J/kg
            Unit = energy.Unit / mass.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{mass}");
        }

        public static IEnumerable<SpecificEnergyUnit> List()
        {
            return new[] { BtuPerPound, CaloriePerGram, GigawattDayPerKilogram, GigawattDayPerShortTon, GigawattDayPerTonne, GigawattHourPerKilogram, JoulePerKilogram, KilocaloriePerGram, KilojoulePerKilogram, KilowattDayPerKilogram, KilowattDayPerShortTon, KilowattDayPerTonne, KilowattHourPerKilogram, MegajoulePerKilogram, MegawattDayPerKilogram, MegawattDayPerShortTon, MegawattDayPerTonne, MegawattHourPerKilogram, TerawattDayPerKilogram, TerawattDayPerShortTon, TerawattDayPerTonne, WattDayPerKilogram, WattDayPerShortTon, WattDayPerTonne, WattHourPerKilogram, };
        }



    }



}