using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record ThermalConductanceUnit : UnitTypebase
{
    public static readonly ThermalConductanceUnit SI = new(PowerUnit.SI, TemperatureUnit.SI);
    public static readonly ThermalConductanceUnit WattPerKelvin = new(PowerUnit.Watt, TemperatureUnit.Kelvin);
    public static readonly ThermalConductanceUnit KilowattPerKelvin = new(PowerUnit.Kilowatt, TemperatureUnit.Kelvin);
    public static readonly ThermalConductanceUnit MegawattPerKelvin = new(PowerUnit.Megawatt, TemperatureUnit.Kelvin);
    public static readonly ThermalConductanceUnit MilliwattPerKelvin = new(PowerUnit.Milliwatt, TemperatureUnit.Kelvin);
    public static readonly ThermalConductanceUnit MicrowattPerKelvin = new(PowerUnit.Microwatt, TemperatureUnit.Kelvin);
    public static readonly ThermalConductanceUnit WattPerDegreeCelsius = new(PowerUnit.Watt, TemperatureUnit.DegreeCelsius, "W/°C");
    public static readonly ThermalConductanceUnit KilowattPerDegreeCelsius = new(PowerUnit.Kilowatt, TemperatureUnit.DegreeCelsius, "kW/°C");
    public static readonly ThermalConductanceUnit BtuPerHourDegreeFahrenheit = new(PowerUnit.BritishThermalUnitPerHour, TemperatureUnit.DegreeRankine, "BTU/h·°F");

    public ThermalConductanceUnit(PowerUnit power, TemperatureUnit temperature)
    {
        Unit = new UnitSystem(power / temperature,
                           $"{power}/{temperature}");
    }

    public ThermalConductanceUnit(PowerUnit power, TemperatureUnit temperature, string NewSymbol)
    {
        Unit = new UnitSystem(power / temperature, NewSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
