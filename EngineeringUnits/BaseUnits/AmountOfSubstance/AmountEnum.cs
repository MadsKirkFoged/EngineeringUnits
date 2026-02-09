using EngineeringUnits.Parsing;
using Fractions;

namespace EngineeringUnits.Units;

public partial record AmountOfSubstanceUnit : UnitTypebase
{
    public static readonly AmountOfSubstanceUnit SI = new(PreFix.SI);

    [Synonyms("mole", "moles", "mol")]
    public static readonly AmountOfSubstanceUnit Mole = new(PreFix.SI);

    [Synonyms("centimole", "centimoles", "cmol")]
    public static readonly AmountOfSubstanceUnit Centimole = new(PreFix.centi);

    [Synonyms("decimole", "decimoles", "dmol")]
    public static readonly AmountOfSubstanceUnit Decimole = new(PreFix.deci);

    [Synonyms("kilomole", "kilomoles", "kmol")]
    public static readonly AmountOfSubstanceUnit Kilomole = new(PreFix.kilo);

    [Synonyms("megamole", "megamoles", "Mmol")]
    public static readonly AmountOfSubstanceUnit Megamole = new(PreFix.mega);

    [Synonyms("micromole", "micromoles", "µmol")]
    public static readonly AmountOfSubstanceUnit Micromole = new(PreFix.micro);

    [Synonyms("millimole", "millimoles", "mmol")]
    public static readonly AmountOfSubstanceUnit Millimole = new(PreFix.milli);

    [Synonyms("nanomole", "nanomoles", "nmol")]
    public static readonly AmountOfSubstanceUnit Nanomole = new(PreFix.nano);

    [Synonyms("picomole", "picomoles", "pmol")]
    public static readonly AmountOfSubstanceUnit Picomole = new(PreFix.pico);


    [Synonyms("nanopoundmole", "nanopoundmoles")]
    public static readonly AmountOfSubstanceUnit NanopoundMole = new("nlbmol", 1e-9m * 453.59237m);

    [Synonyms("micropoundmole", "micropoundmoles")]
    public static readonly AmountOfSubstanceUnit MicropoundMole = new("µlbmol", 1e-6m * 453.59237m);

    [Synonyms("millipoundmole", "millipoundmoles")]
    public static readonly AmountOfSubstanceUnit MillipoundMole = new("mlbmol", 1e-3m * 453.59237m);

    [Synonyms("poundmole", "poundmoles", "pound-mole", "pound-moles")]
    public static readonly AmountOfSubstanceUnit PoundMole = new("lbmol", 1 * 453.59237m);

    [Synonyms("kilopoundmole", "kilopoundmoles")]
    public static readonly AmountOfSubstanceUnit KilopoundMole = new("klbmol", 1e3m * 453.59237m);

    [Synonyms("decipoundmole", "decipoundmoles")]
    public static readonly AmountOfSubstanceUnit DecipoundMole = new("dlbmol", 1e-1m * 453.59237m);

    [Synonyms("centipoundmole", "centipoundmoles")]
    public static readonly AmountOfSubstanceUnit CentipoundMole = new("clbmol", 1e-2m * 453.59237m);

    public AmountOfSubstanceUnit() { }

    public AmountOfSubstanceUnit(string symbol, decimal Constant)
    {
        var amountOfSubstance = new RawUnit()
        {
            Symbol=symbol,
            A = new Fraction(Constant),
            UnitType = BaseunitType.amountOfSubstance,
            B = 0,
            Count = 1,
        };

        Unit = new UnitSystem(amountOfSubstance);

    }

    public AmountOfSubstanceUnit(PreFix SI)
    {
        var amountOfSubstance = new RawUnit()
        {
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.amountOfSubstance),
            A = new Fraction(PrefixSISize(SI)),
            B = 0,
            Count = 1,
            UnitType = BaseunitType.amountOfSubstance,

        };

        Unit = new UnitSystem(amountOfSubstance);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}