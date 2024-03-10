using System.Collections.Generic;
using System.Linq;

namespace EngineeringUnits;

public static class GuardAgainst
{

    public static void DifferentUnits(UnitSystem a, UnitSystem b)
    {
        if (a != b)
            throw new WrongUnitException($"This is NOT a [{b}] as expected! Your Unit is a [{a}]");
    }

    public static void DifferentUnits(UnitSystem a, UnitSystem b, UnitSystem c)
    {
        DifferentUnits(a, b);
        DifferentUnits(a, c);
    }

    public static void DifferentUnits(List<UnitSystem> ListOfUnitSystems)
    {
        if (ListOfUnitSystems is null)
            return;

        if (ListOfUnitSystems.Count is 0 or 1)
            return;

        ListOfUnitSystems.Skip(1)
                         .ToList()
                         .ForEach(unitSystem => DifferentUnits(ListOfUnitSystems[0], unitSystem));

    }
}
