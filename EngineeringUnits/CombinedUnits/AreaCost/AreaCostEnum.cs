using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public partial record AreaCostUnit : UnitTypebase
{

    public static readonly AreaCostUnit SI = new(CostUnit.SI, AreaUnit.SI);

    public AreaCostUnit(CostUnit cost, AreaUnit area)
    {
        var localUnit = cost / area;
        var localSymbol = $"{cost}/{area}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
