﻿using EngineeringUnits.Units;

namespace EngineeringUnits;

public partial class ElectricAdmittance
{

    /// <summary>
    ///     Get ElectricAdmittance in Microsiemens.
    /// </summary>
    public double Microsiemens => As(ElectricAdmittanceUnit.Microsiemens);

    /// <summary>
    ///     Get ElectricAdmittance in Millisiemens.
    /// </summary>
    public double Millisiemens => As(ElectricAdmittanceUnit.Millisiemens);

    /// <summary>
    ///     Get ElectricAdmittance in Nanosiemens.
    /// </summary>
    public double Nanosiemens => As(ElectricAdmittanceUnit.Nanosiemens);

    /// <summary>
    ///     Get ElectricAdmittance in Siemens.
    /// </summary>
    public double Siemens => As(ElectricAdmittanceUnit.Siemens);

    /// <summary>
    ///     Get ElectricAdmittance in SI Unit (Siemens).
    /// </summary>
    public double SI => As(ElectricAdmittanceUnit.SI);
}
