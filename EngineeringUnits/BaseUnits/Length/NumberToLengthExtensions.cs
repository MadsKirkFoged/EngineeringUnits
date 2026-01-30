using EngineeringUnits;
using EngineeringUnits.Units;

namespace EngineeringUnits.NumberExtensions.NumberToLength;

public static class NumberToLengthExtensions
{


    // double receiver
    extension(double value)
    {
        public Length Meter => Length.FromMeter(value);
        public Length Centimeter => Length.FromCentimeter(value);
    }

    // int receiver
    extension(int value)
    {
        public Length Meter => Length.FromMeter(value);
        public Length Centimeter => Length.FromCentimeter(value);
    }

    // decimal receiver (convert as needed)
    extension(decimal value)
    {
        public Length Meter => Length.FromMeter((double)value);
        public Length Centimeter => Length.FromCentimeter((double)value);

    }
}