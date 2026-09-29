// No "using EngineeringUnits.Fast;" in this file - the members of a Pressure? still work, like with EngineeringUnits' classes
// (e.g. db.Input.Pressure!.Bar in a file that never names a quantity type)
public static class NoUsings
{
    public static double Bar(PumpReading r) => r.Discharge!.Bar;
    public static double KilogramPerHour(PumpReading r) => r.Flow!.KilogramPerHour;
    public static string Text(PumpReading r) => r.Discharge.ToString(System.Globalization.CultureInfo.InvariantCulture);
}
