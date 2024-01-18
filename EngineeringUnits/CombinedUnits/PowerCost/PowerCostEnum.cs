using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public record PowerCostUnit : UnitTypebase
{

    public static readonly PowerCostUnit SI = new(CostUnit.SI, PowerUnit.SI);
    public static readonly PowerCostUnit DollarPerKilowatt = new(CostUnit.USDollar, PowerUnit.Kilowatt);
    public static readonly PowerCostUnit DollarPerWatt = new(CostUnit.USDollar, PowerUnit.Watt);




    private PowerCostUnit(CostUnit cost, PowerUnit power)
    {
        var localUnit = cost / power;
        var localSymbol = $"{cost}/{power}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }
}    
