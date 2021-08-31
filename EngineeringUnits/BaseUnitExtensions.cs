
namespace EngineeringUnits
{
    public static class BaseUnitExtensions
    {
        static UnitSystem power = Power.FromWatts(1).Unit;
        static UnitSystem frequency = Frequency.FromHertz(1).Unit;
        public static dynamic ToSimple(this BaseUnit toCast)
        {
            UnitSystem unit = toCast.Unit;
            if (unit == power)
            {
                return (Power) (UnknownUnit) toCast;
            }
            if (unit == frequency)
            {
                return (Frequency) (UnknownUnit) toCast;
            }
            return toCast;
        }
    }
}
