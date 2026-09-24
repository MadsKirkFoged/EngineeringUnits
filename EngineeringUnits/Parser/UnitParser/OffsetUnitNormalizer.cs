using EngineeringUnits.Parser.Objects;
using System.Collections.Generic;
using System.Linq;

namespace EngineeringUnits.Parser.UnitParser
{
    internal static class OffsetUnitNormalizer
    {
        /// <summary>
        /// Offset units (°C, °F; RawUnit.B != 0 in y = a·x + b) only make sense on their own.
        /// Inside a compound unit ("J/(kg·°C)", "°C/s") they are rewritten to their delta form (offset removed).
        /// </summary>
        internal static (UnitSystem unit, List<ParseWarning> warnings) Normalize(UnitSystem unit)
        {
            var warnings = new List<ParseWarning>();

            bool hasOffset = unit.ListOfUnits.Any(u => u.B != 0);
            if (!hasOffset)
                return (unit, warnings);

            bool isPureTemperature =
                unit.ListOfUnits.Count() == 1 &&
                unit.ListOfUnits.All(u => u.UnitType == BaseunitType.temperature && u.Count == 1);

            if (isPureTemperature)
                return (unit, warnings);

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
