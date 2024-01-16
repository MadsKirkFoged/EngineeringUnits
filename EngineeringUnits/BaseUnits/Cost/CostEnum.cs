using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public record CostUnit : UnitTypebase
{
    public static readonly CostUnit SI = new CostUnit("USD", "$", 1);
    public static readonly CostUnit USDollar = new CostUnit("USD", "$", 1);
    public static readonly CostUnit Euro = new CostUnit("Euro", "€", 0.915873m);
    public static readonly CostUnit BritishPound = new CostUnit("GBP", "£", 0.789326m);


    public CostUnit(string code, string Symbol, decimal Rate)
    {
        var unit = new RawUnit()
        {
            Symbol=Symbol,
            A = (Fraction)Rate,
            UnitType = BaseunitType.Cost,
            B = 0,
            Count = 1,

        };

        Unit = new UnitSystem(unit);
    }



}
