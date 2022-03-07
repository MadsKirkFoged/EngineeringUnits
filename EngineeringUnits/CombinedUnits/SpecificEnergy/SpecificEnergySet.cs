
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class SpecificEnergy
    {

 

            /// <summary>
            ///     Get SpecificEnergy from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromSI(double SI)
            {
                double value= (double)SI;
                return new SpecificEnergy(value, SpecificEnergyUnit.SI);
            }
            /// <summary>
            ///     Get SpecificEnergy from JoulePerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromJoulePerKilogram(double JoulePerKilogram)
            {
                double value= (double)JoulePerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.JoulePerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from KilojoulePerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromKilojoulePerKilogram(double KilojoulePerKilogram)
            {
                double value= (double)KilojoulePerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.KilojoulePerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from MegajoulePerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromMegajoulePerKilogram(double MegajoulePerKilogram)
            {
                double value= (double)MegajoulePerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.MegajoulePerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from BtuPerPound.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromBtuPerPound(double BtuPerPound)
            {
                double value= (double)BtuPerPound;
                return new SpecificEnergy(value, SpecificEnergyUnit.BtuPerPound);
            }
            /// <summary>
            ///     Get SpecificEnergy from CaloriePerGram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromCaloriePerGram(double CaloriePerGram)
            {
                double value= (double)CaloriePerGram;
                return new SpecificEnergy(value, SpecificEnergyUnit.CaloriePerGram);
            }
            /// <summary>
            ///     Get SpecificEnergy from KilocaloriePerGram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromKilocaloriePerGram(double KilocaloriePerGram)
            {
                double value= (double)KilocaloriePerGram;
                return new SpecificEnergy(value, SpecificEnergyUnit.KilocaloriePerGram);
            }
            /// <summary>
            ///     Get SpecificEnergy from WattDayPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromWattDayPerKilogram(double WattDayPerKilogram)
            {
                double value= (double)WattDayPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from KilowattDayPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromKilowattDayPerKilogram(double KilowattDayPerKilogram)
            {
                double value= (double)KilowattDayPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from MegawattDayPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromMegawattDayPerKilogram(double MegawattDayPerKilogram)
            {
                double value= (double)MegawattDayPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from GigawattDayPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromGigawattDayPerKilogram(double GigawattDayPerKilogram)
            {
                double value= (double)GigawattDayPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from TerawattDayPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromTerawattDayPerKilogram(double TerawattDayPerKilogram)
            {
                double value= (double)TerawattDayPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from WattHourPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromWattHourPerKilogram(double WattHourPerKilogram)
            {
                double value= (double)WattHourPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.WattHourPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from KilowattHourPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromKilowattHourPerKilogram(double KilowattHourPerKilogram)
            {
                double value= (double)KilowattHourPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.KilowattHourPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from MegawattHourPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromMegawattHourPerKilogram(double MegawattHourPerKilogram)
            {
                double value= (double)MegawattHourPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.MegawattHourPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from GigawattHourPerKilogram.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromGigawattHourPerKilogram(double GigawattHourPerKilogram)
            {
                double value= (double)GigawattHourPerKilogram;
                return new SpecificEnergy(value, SpecificEnergyUnit.GigawattHourPerKilogram);
            }
            /// <summary>
            ///     Get SpecificEnergy from WattDayPerTonne.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromWattDayPerTonne(double WattDayPerTonne)
            {
                double value= (double)WattDayPerTonne;
                return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerTonne);
            }
            /// <summary>
            ///     Get SpecificEnergy from KilowattDayPerTonne.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromKilowattDayPerTonne(double KilowattDayPerTonne)
            {
                double value= (double)KilowattDayPerTonne;
                return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerTonne);
            }
            /// <summary>
            ///     Get SpecificEnergy from MegawattDayPerTonne.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromMegawattDayPerTonne(double MegawattDayPerTonne)
            {
                double value= (double)MegawattDayPerTonne;
                return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerTonne);
            }
            /// <summary>
            ///     Get SpecificEnergy from GigawattDayPerTonne.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromGigawattDayPerTonne(double GigawattDayPerTonne)
            {
                double value= (double)GigawattDayPerTonne;
                return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerTonne);
            }
            /// <summary>
            ///     Get SpecificEnergy from TerawattDayPerTonne.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromTerawattDayPerTonne(double TerawattDayPerTonne)
            {
                double value= (double)TerawattDayPerTonne;
                return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerTonne);
            }
            /// <summary>
            ///     Get SpecificEnergy from WattDayPerShortTon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromWattDayPerShortTon(double WattDayPerShortTon)
            {
                double value= (double)WattDayPerShortTon;
                return new SpecificEnergy(value, SpecificEnergyUnit.WattDayPerShortTon);
            }
            /// <summary>
            ///     Get SpecificEnergy from KilowattDayPerShortTon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromKilowattDayPerShortTon(double KilowattDayPerShortTon)
            {
                double value= (double)KilowattDayPerShortTon;
                return new SpecificEnergy(value, SpecificEnergyUnit.KilowattDayPerShortTon);
            }
            /// <summary>
            ///     Get SpecificEnergy from MegawattDayPerShortTon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromMegawattDayPerShortTon(double MegawattDayPerShortTon)
            {
                double value= (double)MegawattDayPerShortTon;
                return new SpecificEnergy(value, SpecificEnergyUnit.MegawattDayPerShortTon);
            }
            /// <summary>
            ///     Get SpecificEnergy from GigawattDayPerShortTon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromGigawattDayPerShortTon(double GigawattDayPerShortTon)
            {
                double value= (double)GigawattDayPerShortTon;
                return new SpecificEnergy(value, SpecificEnergyUnit.GigawattDayPerShortTon);
            }
            /// <summary>
            ///     Get SpecificEnergy from TerawattDayPerShortTon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static SpecificEnergy FromTerawattDayPerShortTon(double TerawattDayPerShortTon)
            {
                double value= (double)TerawattDayPerShortTon;
                return new SpecificEnergy(value, SpecificEnergyUnit.TerawattDayPerShortTon);
            }
    }
}


