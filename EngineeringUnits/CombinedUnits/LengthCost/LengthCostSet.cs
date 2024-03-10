
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class LengthCost
{

    /// <summary>
    ///     Get LengthCost from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    public static LengthCost FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new LengthCost((double)SI, LengthCostUnit.SI);
    }
    /// <summary>
    ///     Get LengthCost from DollarPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    public static LengthCost FromDollarPerMeter(double? DollarPerMeter)
    {
        if (DollarPerMeter is null)
            return null;

        return new LengthCost((double)DollarPerMeter, LengthCostUnit.DollarPerMeter);
    }
    /// <summary>
    ///     Get LengthCost from EuroPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    public static LengthCost FromEuroPerMeter(double? EuroPerMeter)
    {
        if (EuroPerMeter is null)
            return null;

        return new LengthCost((double)EuroPerMeter, LengthCostUnit.EuroPerMeter);
    }
}

