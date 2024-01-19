using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits.Units;
public partial record AreaCostUnit : UnitTypebase
{

    public static readonly AreaCostUnit SI =                     new(CostUnit.SI, AreaUnit.SI);
    public static readonly AreaCostUnit USDollarPerSquareMeter = new(CostUnit.USDollar, AreaUnit.SquareMeter);
    public static readonly AreaCostUnit EuroPerSquareMeter =     new(CostUnit.Euro, AreaUnit.SquareMeter);

    public AreaCostUnit(CostUnit cost, AreaUnit area)
    {
        var localUnit = cost / area;
        var localSymbol = $"{cost}/{area}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
