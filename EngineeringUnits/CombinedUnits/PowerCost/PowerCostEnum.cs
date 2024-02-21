using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits.Units;
public partial record PowerCostUnit : UnitTypebase
{

    public static readonly PowerCostUnit SI = new(CostUnit.SI, PowerUnit.SI);
    public static readonly PowerCostUnit USDollarPerKilowatt = new(CostUnit.USDollar, PowerUnit.Kilowatt);
    public static readonly PowerCostUnit USDollarPerWatt = new(CostUnit.USDollar, PowerUnit.Watt);




    public PowerCostUnit(CostUnit cost, PowerUnit power)
    {
        var localUnit = cost / power;
        var localSymbol = $"{cost}/{power}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}    
