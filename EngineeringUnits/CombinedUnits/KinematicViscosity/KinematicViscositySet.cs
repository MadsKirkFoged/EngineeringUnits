
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class KinematicViscosity
    {

 

            /// <summary>
            ///     Get KinematicViscosity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromSI(double SI)
            {
                double value= (double)SI;
                return new KinematicViscosity(value, KinematicViscosityUnit.SI);
            }
            /// <summary>
            ///     Get KinematicViscosity from SquareMeterPerSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromSquareMeterPerSecond(double SquareMeterPerSecond)
            {
                double value= (double)SquareMeterPerSecond;
                return new KinematicViscosity(value, KinematicViscosityUnit.SquareMeterPerSecond);
            }
            /// <summary>
            ///     Get KinematicViscosity from Stokes.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromStokes(double Stokes)
            {
                double value= (double)Stokes;
                return new KinematicViscosity(value, KinematicViscosityUnit.Stokes);
            }
            /// <summary>
            ///     Get KinematicViscosity from Centistokes.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromCentistokes(double Centistokes)
            {
                double value= (double)Centistokes;
                return new KinematicViscosity(value, KinematicViscosityUnit.Centistokes);
            }
            /// <summary>
            ///     Get KinematicViscosity from Decistokes.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromDecistokes(double Decistokes)
            {
                double value= (double)Decistokes;
                return new KinematicViscosity(value, KinematicViscosityUnit.Decistokes);
            }
            /// <summary>
            ///     Get KinematicViscosity from Kilostokes.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromKilostokes(double Kilostokes)
            {
                double value= (double)Kilostokes;
                return new KinematicViscosity(value, KinematicViscosityUnit.Kilostokes);
            }
            /// <summary>
            ///     Get KinematicViscosity from Microstokes.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromMicrostokes(double Microstokes)
            {
                double value= (double)Microstokes;
                return new KinematicViscosity(value, KinematicViscosityUnit.Microstokes);
            }
            /// <summary>
            ///     Get KinematicViscosity from Millistokes.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromMillistokes(double Millistokes)
            {
                double value= (double)Millistokes;
                return new KinematicViscosity(value, KinematicViscosityUnit.Millistokes);
            }
            /// <summary>
            ///     Get KinematicViscosity from Nanostokes.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static KinematicViscosity FromNanostokes(double Nanostokes)
            {
                double value= (double)Nanostokes;
                return new KinematicViscosity(value, KinematicViscosityUnit.Nanostokes);
            }
    }
}


