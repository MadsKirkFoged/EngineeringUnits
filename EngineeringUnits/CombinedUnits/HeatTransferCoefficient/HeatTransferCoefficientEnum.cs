namespace EngineeringUnits.Units;

public partial record HeatTransferCoefficientUnit : UnitTypebase
{

    public static readonly HeatTransferCoefficientUnit SI = new(PowerUnit.SI, AreaUnit.SI, TemperatureUnit.SI);
    public static readonly HeatTransferCoefficientUnit WattPerSquareMeterKelvin = new(PowerUnit.Watt, AreaUnit.SquareMeter, TemperatureUnit.Kelvin);
    public static readonly HeatTransferCoefficientUnit WattPerSquareMeterCelsius = new(PowerUnit.Watt, AreaUnit.SquareMeter, TemperatureUnit.Kelvin, "W/m²°C");
    public static readonly HeatTransferCoefficientUnit BtuPerSquareFootDegreeFahrenheit = new(PowerUnit.BritishThermalUnitPerHour, AreaUnit.SquareFoot, TemperatureUnit.DegreeRankine, "Btu/ft²hr°F");

    public HeatTransferCoefficientUnit(PowerUnit power, AreaUnit area, TemperatureUnit temperature)
    {
        Unit = new UnitSystem(power /(area* temperature),
                           $"{power}/{area}{temperature}");
    }

    public HeatTransferCoefficientUnit(PowerUnit power, AreaUnit area, TemperatureUnit temperature, string NewSymbol)
    {
        Unit = new UnitSystem(power / (area * temperature), NewSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}