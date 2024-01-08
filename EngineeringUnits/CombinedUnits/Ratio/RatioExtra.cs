using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public partial class Ratio : BaseUnit
{

    public static implicit operator Ratio(int Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static implicit operator Ratio(decimal Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static implicit operator Ratio(double Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }


}
