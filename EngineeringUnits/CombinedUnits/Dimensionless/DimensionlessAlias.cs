namespace EngineeringUnits;
//This class is auto-generated, changes to the file will be overwritten!
public partial class Dimensionless : BaseUnit
{
    public static implicit operator Dimensionless?(Ratio? Unit)
    {
        if (Unit is null)
            return null;

        return Unit;
    }

    public static implicit operator Ratio?(Dimensionless? Unit)
    {
        if (Unit is null)
            return null;

        return Unit;
    }
}

