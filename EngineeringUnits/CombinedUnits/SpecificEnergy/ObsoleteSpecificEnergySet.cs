using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class SpecificEnergy
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.SI);
        //}


        /// <summary>
        ///     Get SpecificEnergy from BtuPerPound.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static SpecificEnergy FromBtuPerPound(double btuperpound)
        //{
        //    double value = (double)btuperpound;
        //    return new SpecificEnergy(value, SpecificEnergyUnit.BtuPerPound);
        //}
        /// <summary>
        ///     Get SpecificEnergy from CaloriesPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCaloriesPerGram->FromCaloriePerGram")]
        public static SpecificEnergy FromCaloriesPerGram(double caloriespergram)
        {
            double value = (double)caloriespergram;
            return new SpecificEnergy(value, SpecificEnergyUnit.CaloriePerGram);
        }
        /// <summary>
        ///     Get SpecificEnergy from GigawattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGigawattDaysPerKilogram->FromGigawattDayPerKilogram")]
        public static SpecificEnergy FromGigawattDaysPerKilogram(double gigawattdaysperkilogram)
        {
            double value = (double)gigawattdaysperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from GigawattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGigawattDaysPerShortTon->FromGigawattDayPerShortTon")]
        public static SpecificEnergy FromGigawattDaysPerShortTon(double gigawattdayspershortton)
        {
            double value = (double)gigawattdayspershortton;
            return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerShortTon);
        }
        /// <summary>
        ///     Get SpecificEnergy from GigawattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGigawattDaysPerTonne->FromGigawattDayPerTonne")]
        public static SpecificEnergy FromGigawattDaysPerTonne(double gigawattdayspertonne)
        {
            double value = (double)gigawattdayspertonne;
            return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerTonne);
        }
        /// <summary>
        ///     Get SpecificEnergy from GigawattHoursPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGigawattHoursPerKilogram->FromGigawattHourPerKilogram")]
        public static SpecificEnergy FromGigawattHoursPerKilogram(double gigawatthoursperkilogram)
        {
            double value = (double)gigawatthoursperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.GigawattHourPerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from JoulesPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromJoulesPerKilogram->FromJoulePerKilogram")]
        public static SpecificEnergy FromJoulesPerKilogram(double joulesperkilogram)
        {
            double value = (double)joulesperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.JoulePerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from KilocaloriesPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilocaloriesPerGram->FromKilocaloriePerGram")]
        public static SpecificEnergy FromKilocaloriesPerGram(double kilocaloriespergram)
        {
            double value = (double)kilocaloriespergram;
            return new SpecificEnergy(value, SpecificEnergyUnit.KilocaloriePerGram);
        }
        /// <summary>
        ///     Get SpecificEnergy from KilojoulesPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilojoulesPerKilogram->FromKilojoulePerKilogram")]
        public static SpecificEnergy FromKilojoulesPerKilogram(double kilojoulesperkilogram)
        {
            double value = (double)kilojoulesperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.KilojoulePerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from KilowattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilowattDaysPerKilogram->FromKilowattDayPerKilogram")]
        public static SpecificEnergy FromKilowattDaysPerKilogram(double kilowattdaysperkilogram)
        {
            double value = (double)kilowattdaysperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from KilowattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilowattDaysPerShortTon->FromKilowattDayPerShortTon")]
        public static SpecificEnergy FromKilowattDaysPerShortTon(double kilowattdayspershortton)
        {
            double value = (double)kilowattdayspershortton;
            return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerShortTon);
        }
        /// <summary>
        ///     Get SpecificEnergy from KilowattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilowattDaysPerTonne->FromKilowattDayPerTonne")]
        public static SpecificEnergy FromKilowattDaysPerTonne(double kilowattdayspertonne)
        {
            double value = (double)kilowattdayspertonne;
            return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerTonne);
        }
        /// <summary>
        ///     Get SpecificEnergy from KilowattHoursPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilowattHoursPerKilogram->FromKilowattHourPerKilogram")]
        public static SpecificEnergy FromKilowattHoursPerKilogram(double kilowatthoursperkilogram)
        {
            double value = (double)kilowatthoursperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.KilowattHourPerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from MegajoulesPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegajoulesPerKilogram->FromMegajoulePerKilogram")]
        public static SpecificEnergy FromMegajoulesPerKilogram(double megajoulesperkilogram)
        {
            double value = (double)megajoulesperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.MegajoulePerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from MegawattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegawattDaysPerKilogram->FromMegawattDayPerKilogram")]
        public static SpecificEnergy FromMegawattDaysPerKilogram(double megawattdaysperkilogram)
        {
            double value = (double)megawattdaysperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from MegawattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegawattDaysPerShortTon->FromMegawattDayPerShortTon")]
        public static SpecificEnergy FromMegawattDaysPerShortTon(double megawattdayspershortton)
        {
            double value = (double)megawattdayspershortton;
            return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerShortTon);
        }
        /// <summary>
        ///     Get SpecificEnergy from MegawattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegawattDaysPerTonne->FromMegawattDayPerTonne")]
        public static SpecificEnergy FromMegawattDaysPerTonne(double megawattdayspertonne)
        {
            double value = (double)megawattdayspertonne;
            return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerTonne);
        }
        /// <summary>
        ///     Get SpecificEnergy from MegawattHoursPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegawattHoursPerKilogram->FromMegawattHourPerKilogram")]
        public static SpecificEnergy FromMegawattHoursPerKilogram(double megawatthoursperkilogram)
        {
            double value = (double)megawatthoursperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.MegawattHourPerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from TerawattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTerawattDaysPerKilogram->FromTerawattDayPerKilogram")]
        public static SpecificEnergy FromTerawattDaysPerKilogram(double terawattdaysperkilogram)
        {
            double value = (double)terawattdaysperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from TerawattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTerawattDaysPerShortTon->FromTerawattDayPerShortTon")]
        public static SpecificEnergy FromTerawattDaysPerShortTon(double terawattdayspershortton)
        {
            double value = (double)terawattdayspershortton;
            return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerShortTon);
        }
        /// <summary>
        ///     Get SpecificEnergy from TerawattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTerawattDaysPerTonne->FromTerawattDayPerTonne")]
        public static SpecificEnergy FromTerawattDaysPerTonne(double terawattdayspertonne)
        {
            double value = (double)terawattdayspertonne;
            return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerTonne);
        }
        /// <summary>
        ///     Get SpecificEnergy from WattDaysPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromWattDaysPerKilogram->FromWattDayPerKilogram")]
        public static SpecificEnergy FromWattDaysPerKilogram(double wattdaysperkilogram)
        {
            double value = (double)wattdaysperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerKilogram);
        }
        /// <summary>
        ///     Get SpecificEnergy from WattDaysPerShortTon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromWattDaysPerShortTon->FromWattDayPerShortTon")]
        public static SpecificEnergy FromWattDaysPerShortTon(double wattdayspershortton)
        {
            double value = (double)wattdayspershortton;
            return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerShortTon);
        }
        /// <summary>
        ///     Get SpecificEnergy from WattDaysPerTonne.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromWattDaysPerTonne->FromWattDayPerTonne")]
        public static SpecificEnergy FromWattDaysPerTonne(double wattdayspertonne)
        {
            double value = (double)wattdayspertonne;
            return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerTonne);
        }
        /// <summary>
        ///     Get SpecificEnergy from WattHoursPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromWattHoursPerKilogram->FromWattHourPerKilogram")]
        public static SpecificEnergy FromWattHoursPerKilogram(double watthoursperkilogram)
        {
            double value = (double)watthoursperkilogram;
            return new SpecificEnergy(value, SpecificEnergyUnit.WattHourPerKilogram);
        }

    }
}
