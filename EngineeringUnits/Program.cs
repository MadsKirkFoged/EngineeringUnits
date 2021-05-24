using System;
using System.Diagnostics;

namespace EngineeringUnits
{
    class Program
    {
        static void Main(string[] args)
        {



            //Begynd at lave speed som den første sammensatte unit

            //Temperature T1 = new Temperature(10, TemperatureUnit.Kelvin);

            Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);
            Temperature T2 = new Temperature(293.15, TemperatureUnit.Kelvin);
            Temperature T3 = new Temperature(0, TemperatureUnit.DegreeFahrenheit);




            //Debug.WriteLine($"{T1}");
            Debug.WriteLine($"{T3} * {T3} = {T3 * T3}");
            //Debug.WriteLine($"{T2}");
            //Debug.WriteLine($"{T3}");








            //Debug.Print($"{T1}");
            Debug.WriteLine($"{T1.As(TemperatureUnit.Kelvin)} = 293,15");
            Debug.WriteLine($"{T1.As(TemperatureUnit.DegreeCelsius)} = 20");
            Debug.WriteLine($"{T1.As(TemperatureUnit.DegreeFahrenheit)} = 68");

            Debug.WriteLine($"{T2.As(TemperatureUnit.Kelvin)} = 293,15");
            Debug.WriteLine($"{T2.As(TemperatureUnit.DegreeCelsius)} = 20");
            Debug.WriteLine($"{T2.As(TemperatureUnit.DegreeFahrenheit)} = 68");

            Debug.WriteLine($"{T3.As(TemperatureUnit.Kelvin)} = 293,15");
            Debug.WriteLine($"{T3.As(TemperatureUnit.DegreeCelsius)} = 20");
            Debug.WriteLine($"{T3.As(TemperatureUnit.DegreeFahrenheit)} = 68");


            Length L1 = new Length(2, LengthUnit.Yard);
            Length L2 = new Length(2, LengthUnit.Meter);


            Length L3 = L1 + L2;
            Length L4 = L2 + L1;

            Debug.WriteLine($"{L3}");


            Debug.WriteLine($"{L4}");
            Debug.WriteLine($"{L3.As(LengthUnit.Meter)}");
            Debug.WriteLine($"{L3.As(LengthUnit.Centimeter)}");
            Debug.WriteLine($"{L4.As(LengthUnit.Meter)}");
            Debug.WriteLine($"{L4.As(LengthUnit.Centimeter)}");



            Debug.WriteLine($".....");



            //TODO Lav sådan at samme enhed nemt kan have flere navne


            //Lav special case til temperature
            //TODO hvis man ganger en double på, skal vi huske at regne tilbage til SI først (mest pga temperature..)

            //TODO Lav egen Enum class -> bliver ikke helt det samme...


            //TODO length > length?


            //Kan man lave beregningerne i et mere præcist format og så regne tilbage til Double tilsidst?


            //Kunne være sjovt at lave ingeniør konstanter som standard


            //Mangler at kunne Devide
            //Her bliver vi vist nød til at regne om i SI før vi gør det


            //Temperature T1 = new Temperature(0, TemperatureUnit.Kelvin);



            //Debug.WriteLine($"{T1.As(TemperatureUnit.DegreeFahrenheit)} == -459.67");









            //Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);





           // var T3 = T1 + T2;


            //Debug.WriteLine($"{T1}");
            //Debug.WriteLine($"{T2}");
            //Debug.WriteLine($"{T3}");

            //T1.PermanentChangeUnitTo(TemperatureUnit.DegreeCelsius);
            //T2.PermanentChangeUnitTo(TemperatureUnit.DegreeFahrenheit);
            //T3.PermanentChangeUnitTo(TemperatureUnit.DegreeFahrenheit);

            //Debug.WriteLine($"{T1}");
            //Debug.WriteLine($"{T1} / {T2} = {T3}");
            //Debug.WriteLine($"{T2}");
            //Debug.WriteLine($"{T3}");


            //Length L1 = new Length(5, LengthUnit.Meter);
            //Length L2 = new Length(1, LengthUnit.Yard);


            //var L3 = L2 + L1;



            Debug.Print($"{L3}");





            Debug.Print($"{T3}");

            




            




            //Length L1 = new Length(100, LengthUnit.Meter);
            //Length L2 = new Length(100, LengthUnit.Foot);



            Area test1 = L1 * L1;

            var test2 = L1 * L1 * L1;

            var test3 = L1 * L1 * L1 * L1;

            var test4 = L1 * L1 * L1 * L1 * L1;

            var test5 = L1 * L1 * L1 * L1 * L1 * 50;

            var test6 = L1 * L1 * L1 * L1 * L1 / 100;

            var test7 = L1 / 100;

            var test8 = 100 / L1;

            var test9 = 100 * L1;

            var test10 = L1 * 100;




            Debug.WriteLine($"{L2} + {L1} = {L2 + L1}");
            Debug.WriteLine($"{L2} - {L1} = {L2 - L1}");
            Debug.WriteLine($"{L2} * {L1} = {L2 * L1}");
            Debug.WriteLine($"{L2} / {L1} = {L2 / L1}");

            Debug.WriteLine($"{test1}");
            Debug.WriteLine($"{test2}");
            Debug.WriteLine($"{test3}");
            Debug.WriteLine($"{test4}");
            Debug.WriteLine($"{test5}");
            Debug.WriteLine($"{test6}");
            Debug.WriteLine($"{test7}");
            Debug.WriteLine($"{test8}");
            Debug.WriteLine($"{test9}");
            Debug.WriteLine($"{test10}");

        }
    }
}
