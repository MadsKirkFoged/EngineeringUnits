using System;

namespace EngineeringUnits.Parsing
{
    public static class UnitParser<TUnit> where TUnit : UnitTypebase
    {
        public static bool TryParse(string token, out TUnit unit)
        {
            unit = default!;
            if (string.IsNullOrWhiteSpace(token))
                return false;

            token = UnitTokenRegistry<TUnit>.NormalizeToken(token);
            return UnitTokenRegistry<TUnit>.TryResolve(token, out unit);
        }

    }
}