using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MagneticField
    {
        /// <summary>
        ///     Get MagneticField in Gausses.
        /// </summary>
        public double Gausses => As(MagneticFieldUnit.Gauss);

        /// <summary>
        ///     Get MagneticField in Microteslas.
        /// </summary>
        public double Microteslas => As(MagneticFieldUnit.Microtesla);

        /// <summary>
        ///     Get MagneticField in Milligausses.
        /// </summary>
        public double Milligausses => As(MagneticFieldUnit.Milligauss);

        /// <summary>
        ///     Get MagneticField in Milliteslas.
        /// </summary>
        public double Milliteslas => As(MagneticFieldUnit.Millitesla);

        /// <summary>
        ///     Get MagneticField in Nanoteslas.
        /// </summary>
        public double Nanoteslas => As(MagneticFieldUnit.Nanotesla);

        /// <summary>
        ///     Get MagneticField in Teslas.
        /// </summary>
        public double Teslas => As(MagneticFieldUnit.Tesla);

    }
}
