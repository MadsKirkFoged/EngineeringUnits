using System;

namespace EngineeringUnits;

[Serializable]
public class WrongUnitException : Exception
{
    public WrongUnitException()
    { }

    public WrongUnitException(string message)
        : base(message)
    { }

    public WrongUnitException(string message, Exception innerException)
        : base(message, innerException)
    { }
}
