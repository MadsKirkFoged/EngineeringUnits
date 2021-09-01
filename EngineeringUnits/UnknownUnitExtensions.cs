
namespace EngineeringUnits
{
    public static class UnknownUnitExtensions
    {
        static UnitSystem power = Power.FromWatts(1).Unit;
        static UnitSystem frequency = Frequency.FromHertz(1).Unit;
        public static BaseUnit IntelligentCast(this UnknownUnit toCast)
        {
            BaseUnit output = (BaseUnit) toCast;
            UnitSystem unit = output.Unit;
            if (unit == power)
            {
                return (Power) toCast;
            }
            if (unit == frequency)
            {
                return (Frequency) toCast;
            }
            return output;
        }
    }
}
