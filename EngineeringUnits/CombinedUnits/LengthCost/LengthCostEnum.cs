using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public record LengthCostUnit : UnitTypebase
{
    public static readonly LengthCostUnit SI = new(CostUnit.SI, LengthUnit.SI);

    private LengthCostUnit(CostUnit cost, LengthUnit length)
    {
        var localUnit = cost / length;
        var localSymbol = $"{cost}/{length}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
