using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class HeatTransferCoefficient
{
    /// <summary>
    ///     Get HeatTransferCoefficient in BtusPerSquareFootDegreeFahrenheit.
    /// </summary>
    [Obsolete("Use without the 's' - BtusPerSquareFootDegreeFahrenheit->BtuPerSquareFootDegreeFahrenheit")]
    public double BtusPerSquareFootDegreeFahrenheit => As(HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);

    /// <summary>
    ///     Get HeatTransferCoefficient in WattsPerSquareMeterCelsius.
    /// </summary>
    [Obsolete("Use without the 's' - WattsPerSquareMeterCelsius->WattPerSquareMeterCelsius")]
    public double WattsPerSquareMeterCelsius => As(HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);

    /// <summary>
    ///     Get HeatTransferCoefficient in WattsPerSquareMeterKelvin.
    /// </summary>
    [Obsolete("Use without the 's' - WattsPerSquareMeterKelvin->WattPerSquareMeterKelvin")]
    public double WattsPerSquareMeterKelvin => As(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);

    /// <summary>
    ///     Get HeatTransferCoefficient in SI Unit (WattsPerSquareMeterKelvin).
    /// </summary>
    //public double SI => As(HeatTransferCoefficientUnit.SI);
}
