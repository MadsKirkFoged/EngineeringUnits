using System.Collections.Generic;
using System.Linq;

namespace EngineeringUnits.Parsing
{
    internal static class OffsetUnitNormalizer
    {
        internal static (UnitSystem unit, List<ParseWarning> warnings) Normalize(UnitSystem unit)
        {
            var warnings = new List<ParseWarning>();

            // Detect offset terms: RawUnit.B != 0 indicates affine conversion y=a*x+b. [1](https://linuxvox.com/blog/wget-a-raw-file-from-github-from-a-private-repo/)
            // We only care when the unit system is compound (not a pure temperature quantity).
            bool hasOffset = unit.ListOfUnits.Any(u => u.B != 0);
            if (!hasOffset)
                return (unit, warnings);

            bool isPureTemperature =
                unit.ListOfUnits.All(u => u.UnitType == BaseunitType.temperature) &&
                unit.ListOfUnits.Count() == 1;

            if (isPureTemperature)
                return (unit, warnings);

            // Option A: auto-rewrite to "without offset" (delta interpretation).
            // This uses UnitSystemExtensions.GetWithOutOffset(). [2](https://github.com/MadsKirkFoged/)
            var rewritten = unit.GetWithOutOffset();

            warnings.Add(new ParseWarning
            {
                Code = "OFFSET_UNIT_IN_COMPOUND",
                Message = "Offset temperature units (°C/°F) in compound expressions are ambiguous. Interpreting as temperature difference (offset removed). Consider using Kelvin (K) in compound units.",
                SuggestedUnitExpression = rewritten.ToString()
            });

            return (rewritten, warnings);
        }
    }
}