using System;
using System.Diagnostics;

namespace EngineeringUnits
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO Lav sådan at samme enhed nemt kan have flere navne
            //TODO Lav egen Enum class
            //TODO hvis man ganger en double på, skal vi huske at regne tilbage til SI først (mest pga temperature..)


            Length L1 = new Length(LengthUnits.);


            Length L1 = new Length(1, LengthUnits.Meter);

            Length L2 = new Length(1, LengthUnits.Centimeter);


            var L3 = L2 + L1;
            var L4 =  L1 - L2;

            Area A1 = L1 * L1 * 10.992;
            Area A2 = L2 * L2;

            //Area A3 = (A1 * A2) / (L1 * L1);

            var L7 = L1 / L2;

            Debug.WriteLine($"{L2} + {L1} = {L2 + L1}");
            Debug.WriteLine($"{L2} - {L1} = {L2 - L1}");
            Debug.WriteLine($"{L2} * {L1} = {L2 * L1}");
            Debug.WriteLine($"{L2} / {L1} = {L2 / L1}");

            Debug.WriteLine($"{L1} * {L1} = {L1 * L1}");
            Debug.WriteLine($"{L2} * {L2} = {L2 * L2}");
            Debug.WriteLine($"{A1} - {A2} = {A1 - A2}");
        }
    }
}
