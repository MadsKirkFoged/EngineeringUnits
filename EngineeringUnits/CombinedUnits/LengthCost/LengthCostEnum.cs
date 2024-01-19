using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public partial record LengthCostUnit : UnitTypebase
{
    public static readonly LengthCostUnit SI = new(CostUnit.SI, LengthUnit.SI);
    public static readonly LengthCostUnit DollarPerMeter = new(CostUnit.USDollar, LengthUnit.Meter);
    public static readonly LengthCostUnit EuroPerMeter = new(CostUnit.Euro, LengthUnit.Meter);

    private LengthCostUnit(CostUnit cost, LengthUnit length)
    {
        var localUnit = cost / length;
        var localSymbol = $"{cost}/{length}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
