using EngineeringUnits.Fast;

public static class Pump
{
    public static Power Heat(MassFlow m, Enthalpy h) => m * h;
}

// Nullable quantities from another project, e.g. database models
public class PumpReading
{
    public Pressure? Discharge { get; set; } = Pressure.FromBar(10);
    public MassFlow? Flow { get; set; } = MassFlow.FromKilogramPerHour(3600);
}
