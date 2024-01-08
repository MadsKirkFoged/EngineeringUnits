using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public partial class Ratio : BaseUnit
{

    public static explicit operator Ratio(int Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static explicit operator Ratio(decimal Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static explicit operator Ratio(double Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }


}
