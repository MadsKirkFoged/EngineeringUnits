using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricConductivity
    {
        /// <summary>
        ///     Get ElectricConductivity in SiemensPerFoot.
        /// </summary>
        public double SiemensPerFoot => As(ElectricConductivityUnit.SiemensPerFoot);

        /// <summary>
        ///     Get ElectricConductivity in SiemensPerInch.
        /// </summary>
        public double SiemensPerInch => As(ElectricConductivityUnit.SiemensPerInch);

        /// <summary>
        ///     Get ElectricConductivity in SiemensPerMeter.
        /// </summary>
        public double SiemensPerMeter => As(ElectricConductivityUnit.SiemensPerMeter);

    }
}
