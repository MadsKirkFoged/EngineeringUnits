using EngineeringUnits.Units;                     

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Cost
{  

/// <summary>
/// Get Cost from SI.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Cost FromSI(double? SI)
{
    if (SI is null)
        return null;

    return new Cost((double)SI, CostUnit.SI);
}

/// <summary>
/// Get Cost from USDollar.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Cost FromUSDollar(double? USDollar)
{
    if (USDollar is null)
        return null;

    return new Cost((double)USDollar, CostUnit.USDollar);
}

/// <summary>
/// Get Cost from MillionUSDollar.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Cost FromMillionUSDollar(double? MillionUSDollar)
{
    if (MillionUSDollar is null)
        return null;

    return new Cost((double)MillionUSDollar, CostUnit.MillionUSDollar);
}

/// <summary>
/// Get Cost from Euro.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Cost FromEuro(double? Euro)
{
    if (Euro is null)
        return null;

    return new Cost((double)Euro, CostUnit.Euro);
}

/// <summary>
/// Get Cost from BritishPound.
/// </summary>
/// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
public static Cost FromBritishPound(double? BritishPound)
{
    if (BritishPound is null)
        return null;

    return new Cost((double)BritishPound, CostUnit.BritishPound);
}


}                     