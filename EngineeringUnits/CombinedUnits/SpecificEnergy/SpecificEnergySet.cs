using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class SpecificEnergy
    {
        //public static SpecificEnergy FromBtuPerPound(QuantityValue btuperpound)
        //{
        //    double value = (double)btuperpound;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.BtuPerPound);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from CaloriesPerGram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromCaloriesPerGram(QuantityValue caloriespergram)
        //{
        //    double value = (double)caloriespergram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.CaloriePerGram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from GigawattDaysPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromGigawattDaysPerKilogram(QuantityValue gigawattdaysperkilogram)
        //{
        //    double value = (double)gigawattdaysperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from GigawattDaysPerShortTon.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromGigawattDaysPerShortTon(QuantityValue gigawattdayspershortton)
        //{
        //    double value = (double)gigawattdayspershortton;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerShortTon);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from GigawattDaysPerTonne.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromGigawattDaysPerTonne(QuantityValue gigawattdayspertonne)
        //{
        //    double value = (double)gigawattdayspertonne;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerTonne);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from GigawattHoursPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromGigawattHoursPerKilogram(QuantityValue gigawatthoursperkilogram)
        //{
        //    double value = (double)gigawatthoursperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.GigawattHourPerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from JoulesPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromJoulesPerKilogram(QuantityValue joulesperkilogram)
        //{
        //    double value = (double)joulesperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.JoulePerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from KilocaloriesPerGram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromKilocaloriesPerGram(QuantityValue kilocaloriespergram)
        //{
        //    double value = (double)kilocaloriespergram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.KilocaloriePerGram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from KilojoulesPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromKilojoulesPerKilogram(QuantityValue kilojoulesperkilogram)
        //{
        //    double value = (double)kilojoulesperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.KilojoulePerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from KilowattDaysPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromKilowattDaysPerKilogram(QuantityValue kilowattdaysperkilogram)
        //{
        //    double value = (double)kilowattdaysperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from KilowattDaysPerShortTon.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromKilowattDaysPerShortTon(QuantityValue kilowattdayspershortton)
        //{
        //    double value = (double)kilowattdayspershortton;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerShortTon);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from KilowattDaysPerTonne.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromKilowattDaysPerTonne(QuantityValue kilowattdayspertonne)
        //{
        //    double value = (double)kilowattdayspertonne;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerTonne);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from KilowattHoursPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromKilowattHoursPerKilogram(QuantityValue kilowatthoursperkilogram)
        //{
        //    double value = (double)kilowatthoursperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.KilowattHourPerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from MegajoulesPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromMegajoulesPerKilogram(QuantityValue megajoulesperkilogram)
        //{
        //    double value = (double)megajoulesperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.MegajoulePerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from MegawattDaysPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromMegawattDaysPerKilogram(QuantityValue megawattdaysperkilogram)
        //{
        //    double value = (double)megawattdaysperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from MegawattDaysPerShortTon.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromMegawattDaysPerShortTon(QuantityValue megawattdayspershortton)
        //{
        //    double value = (double)megawattdayspershortton;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerShortTon);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from MegawattDaysPerTonne.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromMegawattDaysPerTonne(QuantityValue megawattdayspertonne)
        //{
        //    double value = (double)megawattdayspertonne;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerTonne);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from MegawattHoursPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromMegawattHoursPerKilogram(QuantityValue megawatthoursperkilogram)
        //{
        //    double value = (double)megawatthoursperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.MegawattHourPerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from TerawattDaysPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromTerawattDaysPerKilogram(QuantityValue terawattdaysperkilogram)
        //{
        //    double value = (double)terawattdaysperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from TerawattDaysPerShortTon.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromTerawattDaysPerShortTon(QuantityValue terawattdayspershortton)
        //{
        //    double value = (double)terawattdayspershortton;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerShortTon);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from TerawattDaysPerTonne.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromTerawattDaysPerTonne(QuantityValue terawattdayspertonne)
        //{
        //    double value = (double)terawattdayspertonne;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerTonne);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from WattDaysPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromWattDaysPerKilogram(QuantityValue wattdaysperkilogram)
        //{
        //    double value = (double)wattdaysperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerKilogram);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from WattDaysPerShortTon.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromWattDaysPerShortTon(QuantityValue wattdayspershortton)
        //{
        //    double value = (double)wattdayspershortton;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerShortTon);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from WattDaysPerTonne.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromWattDaysPerTonne(QuantityValue wattdayspertonne)
        //{
        //    double value = (double)wattdayspertonne;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerTonne);
        //}
        ///// <summary>
        /////     Get SpecificEnergy from WattHoursPerKilogram.
        ///// </summary>
        ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromWattHoursPerKilogram(QuantityValue watthoursperkilogram)
        //{
        //    double value = (double)watthoursperkilogram;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.WattHourPerKilogram);
        //}

    }
}
