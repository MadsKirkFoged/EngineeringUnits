namespace EngineeringUnits
{
    public static class UnknownUnitExtensions
    {
       public static BaseUnit IntelligentCast(this UnknownUnit toCast)
        {
            BaseUnit output = (BaseUnit) toCast;
            UnitSystem unit = output.Unit;
			
            return output;
        }
    }
}
