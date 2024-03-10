namespace EngineeringUnits.Units;

public partial record BitRateUnit : UnitTypebase
{

    public static readonly BitRateUnit SI = new("", 1m);
    public static readonly BitRateUnit BytePerSecond = new("B/s", 8m);
    public static readonly BitRateUnit BitPerSecond = new("bit/s", 1m);

    public static readonly BitRateUnit KibibitPerSecond = new(BitPerSecond, "Kibit/s", 1024m);
    public static readonly BitRateUnit MebibitPerSecond = new(BitPerSecond, "Mibit/s", 1024m * 1024);
    public static readonly BitRateUnit GibibitPerSecond = new(BitPerSecond, "Gibit/s", 1024m * 1024 * 1024);
    public static readonly BitRateUnit TebibitPerSecond = new(BitPerSecond, "Tibit/s", 1024m * 1024 * 1024 * 1024);
    public static readonly BitRateUnit PebibitPerSecond = new(BitPerSecond, "Pibit/s", 1024m * 1024 * 1024 * 1024 * 1024);
    public static readonly BitRateUnit ExbibitPerSecond = new(BitPerSecond, "Eibit/s", 1024m * 1024 * 1024 * 1024 * 1024 * 1024);

    public static readonly BitRateUnit KibibytePerSecond = new(BytePerSecond, "KiB/s", 1024m);
    public static readonly BitRateUnit MebibytePerSecond = new(BytePerSecond, "MiB/s", 1024m * 1024);
    public static readonly BitRateUnit GibibytePerSecond = new(BytePerSecond, "GiB/s", 1024m * 1024 * 1024);
    public static readonly BitRateUnit TebibytePerSecond = new(BytePerSecond, "TiB/s", 1024m * 1024 * 1024 * 1024);
    public static readonly BitRateUnit PebibytePerSecond = new(BytePerSecond, "PiB/s", 1024m * 1024 * 1024 * 1024 * 1024);
    public static readonly BitRateUnit ExbibytePerSecond = new(BytePerSecond, "EiB/s", 1024m * 1024 * 1024 * 1024 * 1024 * 1024);

    public static readonly BitRateUnit KilobytePerSecond = new(PreFix.kilo, BytePerSecond);
    public static readonly BitRateUnit MegabytePerSecond = new(PreFix.mega, BytePerSecond);
    public static readonly BitRateUnit GigabytePerSecond = new(PreFix.giga, BytePerSecond);
    public static readonly BitRateUnit TerabytePerSecond = new(PreFix.tera, BytePerSecond);
    public static readonly BitRateUnit PetabytePerSecond = new(PreFix.peta, BytePerSecond);
    public static readonly BitRateUnit ExabytePerSecond = new(PreFix.exa, BytePerSecond);

    public static readonly BitRateUnit KilobitPerSecond = new(PreFix.kilo, BitPerSecond);
    public static readonly BitRateUnit MegabitPerSecond = new(PreFix.mega, BitPerSecond);
    public static readonly BitRateUnit GigabitPerSecond = new(PreFix.giga, BitPerSecond);
    public static readonly BitRateUnit TerabitPerSecond = new(PreFix.tera, BitPerSecond);
    public static readonly BitRateUnit PetabitPerSecond = new(PreFix.peta, BitPerSecond);
    public static readonly BitRateUnit ExabitPerSecond = new(PreFix.exa, BitPerSecond);

    public BitRateUnit(string NewSymbol, decimal correction)
    {
        Unit = new UnitSystem(correction, NewSymbol);
    }

    public BitRateUnit(PreFix SI, BitRateUnit unit) : base(SI, unit) { }

    public BitRateUnit(BitRateUnit unit, string NewSymbol, decimal correction) : base(unit, NewSymbol, correction) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}