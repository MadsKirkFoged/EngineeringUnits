
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricConductivity
    {

 

            /// <summary>
            ///     Get ElectricConductivity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricConductivity FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricConductivity(value, ElectricConductivityUnit.SI);
            }
            /// <summary>
            ///     Get ElectricConductivity from SiemensPerMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricConductivity FromSiemensPerMeter(double SiemensPerMeter)
            {
                double value= (double)SiemensPerMeter;
                return new ElectricConductivity(value, ElectricConductivityUnit.SiemensPerMeter);
            }
            /// <summary>
            ///     Get ElectricConductivity from SiemensPerInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricConductivity FromSiemensPerInch(double SiemensPerInch)
            {
                double value= (double)SiemensPerInch;
                return new ElectricConductivity(value, ElectricConductivityUnit.SiemensPerInch);
            }
            /// <summary>
            ///     Get ElectricConductivity from SiemensPerFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricConductivity FromSiemensPerFoot(double SiemensPerFoot)
            {
                double value= (double)SiemensPerFoot;
                return new ElectricConductivity(value, ElectricConductivityUnit.SiemensPerFoot);
            }
    }
}


