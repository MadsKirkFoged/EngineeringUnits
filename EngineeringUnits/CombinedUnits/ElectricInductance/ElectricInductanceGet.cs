using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricInductance
    {
        /// <summary>
        ///     Get ElectricInductance in Henries.
        /// </summary>
        public double Henries => As(ElectricInductanceUnit.Henry);

        /// <summary>
        ///     Get ElectricInductance in Microhenries.
        /// </summary>
        public double Microhenries => As(ElectricInductanceUnit.Microhenry);

        /// <summary>
        ///     Get ElectricInductance in Millihenries.
        /// </summary>
        public double Millihenries => As(ElectricInductanceUnit.Millihenry);

        /// <summary>
        ///     Get ElectricInductance in Nanohenries.
        /// </summary>
        public double Nanohenries => As(ElectricInductanceUnit.Nanohenry);

    }
}
