using System;

namespace EngineeringUnits.Parsing
{
    public static class UnitParserTUnit<TUnit> where TUnit : UnitTypebase
    {
        public static bool TryParse(string token, out TUnit unit)
        {
            unit = default!;
            if (string.IsNullOrWhiteSpace(token))
                return false;

            token = UnitTokenRegistry<TUnit>.NormalizeToken(token);
            return UnitTokenRegistry<TUnit>.TryResolve(token, out unit);
        }

        public static TUnit Parse(string token)
        {
            if (!TryParse(token, out var unit))
                throw new FormatException($"Could not parse {typeof(TUnit).Name} from '{token}'.");
            return unit;
        }
    }
}