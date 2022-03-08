
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Information
    {

 

            /// <summary>
            ///     Get Information from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromSI(double SI)
            {
                double value= (double)SI;
                return new Information(value, InformationUnit.SI);
            }
            /// <summary>
            ///     Get Information from Byte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromByte(double Byte)
            {
                double value= (double)Byte;
                return new Information(value, InformationUnit.Byte);
            }
            /// <summary>
            ///     Get Information from Bit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromBit(double Bit)
            {
                double value= (double)Bit;
                return new Information(value, InformationUnit.Bit);
            }
            /// <summary>
            ///     Get Information from Kibibit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromKibibit(double Kibibit)
            {
                double value= (double)Kibibit;
                return new Information(value, InformationUnit.Kibibit);
            }
            /// <summary>
            ///     Get Information from Mebibit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromMebibit(double Mebibit)
            {
                double value= (double)Mebibit;
                return new Information(value, InformationUnit.Mebibit);
            }
            /// <summary>
            ///     Get Information from Gibibit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromGibibit(double Gibibit)
            {
                double value= (double)Gibibit;
                return new Information(value, InformationUnit.Gibibit);
            }
            /// <summary>
            ///     Get Information from Tebibit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromTebibit(double Tebibit)
            {
                double value= (double)Tebibit;
                return new Information(value, InformationUnit.Tebibit);
            }
            /// <summary>
            ///     Get Information from Pebibit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromPebibit(double Pebibit)
            {
                double value= (double)Pebibit;
                return new Information(value, InformationUnit.Pebibit);
            }
            /// <summary>
            ///     Get Information from Exbibit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromExbibit(double Exbibit)
            {
                double value= (double)Exbibit;
                return new Information(value, InformationUnit.Exbibit);
            }
            /// <summary>
            ///     Get Information from Kibibyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromKibibyte(double Kibibyte)
            {
                double value= (double)Kibibyte;
                return new Information(value, InformationUnit.Kibibyte);
            }
            /// <summary>
            ///     Get Information from Mebibyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromMebibyte(double Mebibyte)
            {
                double value= (double)Mebibyte;
                return new Information(value, InformationUnit.Mebibyte);
            }
            /// <summary>
            ///     Get Information from Gibibyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromGibibyte(double Gibibyte)
            {
                double value= (double)Gibibyte;
                return new Information(value, InformationUnit.Gibibyte);
            }
            /// <summary>
            ///     Get Information from Tebibyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromTebibyte(double Tebibyte)
            {
                double value= (double)Tebibyte;
                return new Information(value, InformationUnit.Tebibyte);
            }
            /// <summary>
            ///     Get Information from Pebibyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromPebibyte(double Pebibyte)
            {
                double value= (double)Pebibyte;
                return new Information(value, InformationUnit.Pebibyte);
            }
            /// <summary>
            ///     Get Information from Exbibyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromExbibyte(double Exbibyte)
            {
                double value= (double)Exbibyte;
                return new Information(value, InformationUnit.Exbibyte);
            }
            /// <summary>
            ///     Get Information from Kilobyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromKilobyte(double Kilobyte)
            {
                double value= (double)Kilobyte;
                return new Information(value, InformationUnit.Kilobyte);
            }
            /// <summary>
            ///     Get Information from Megabyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromMegabyte(double Megabyte)
            {
                double value= (double)Megabyte;
                return new Information(value, InformationUnit.Megabyte);
            }
            /// <summary>
            ///     Get Information from Gigabyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromGigabyte(double Gigabyte)
            {
                double value= (double)Gigabyte;
                return new Information(value, InformationUnit.Gigabyte);
            }
            /// <summary>
            ///     Get Information from Terabyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromTerabyte(double Terabyte)
            {
                double value= (double)Terabyte;
                return new Information(value, InformationUnit.Terabyte);
            }
            /// <summary>
            ///     Get Information from Petabyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromPetabyte(double Petabyte)
            {
                double value= (double)Petabyte;
                return new Information(value, InformationUnit.Petabyte);
            }
            /// <summary>
            ///     Get Information from Exabyte.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromExabyte(double Exabyte)
            {
                double value= (double)Exabyte;
                return new Information(value, InformationUnit.Exabyte);
            }
            /// <summary>
            ///     Get Information from Kilobit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromKilobit(double Kilobit)
            {
                double value= (double)Kilobit;
                return new Information(value, InformationUnit.Kilobit);
            }
            /// <summary>
            ///     Get Information from Megabit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromMegabit(double Megabit)
            {
                double value= (double)Megabit;
                return new Information(value, InformationUnit.Megabit);
            }
            /// <summary>
            ///     Get Information from Gigabit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromGigabit(double Gigabit)
            {
                double value= (double)Gigabit;
                return new Information(value, InformationUnit.Gigabit);
            }
            /// <summary>
            ///     Get Information from Terabit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromTerabit(double Terabit)
            {
                double value= (double)Terabit;
                return new Information(value, InformationUnit.Terabit);
            }
            /// <summary>
            ///     Get Information from Petabit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromPetabit(double Petabit)
            {
                double value= (double)Petabit;
                return new Information(value, InformationUnit.Petabit);
            }
            /// <summary>
            ///     Get Information from Exabit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Information FromExabit(double Exabit)
            {
                double value= (double)Exabit;
                return new Information(value, InformationUnit.Exabit);
            }
    }
}


