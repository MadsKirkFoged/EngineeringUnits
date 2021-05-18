using System;
using System.Diagnostics;

namespace EngineeringUnits
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO Lav sådan at samme enhed nemt kan have flere navne


            //Lav special case til temperature
            //TODO hvis man ganger en double på, skal vi huske at regne tilbage til SI først (mest pga temperature..)

            //TODO Lav egen Enum class -> bliver ikke helt det samme...


            //TODO length > length?


            //Kan man lave beregningerne i et mere præcist format og så regne tilbage til Double tilsidst?


            //Kunne være sjovt at lave ingeniør konstanter som standard


            Temperature T1 = new Temperature(10, TemperatureUnit.DegreeCelsius);
            //Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);
            //Temperature T3 = new Temperature(10, TemperatureUnit.DegreeFahrenheit);


            //Debug.WriteLine($"{T1}");
            //Debug.WriteLine($"{T2}");
            //Debug.WriteLine($"{T3}");

            T1.PermanentChangeUnitTo(TemperatureUnit.DegreeFahrenheit);
            //T2.PermanentChangeUnitTo(TemperatureUnit.DegreeFahrenheit);
            //T3.PermanentChangeUnitTo(TemperatureUnit.DegreeFahrenheit);


            Debug.WriteLine($"{T1}");
            //Debug.WriteLine($"{T2}");
            //Debug.WriteLine($"{T3}");









            Length L1 = new Length(5, LengthUnit.Meter);
            Length L2 = new Length(2, LengthUnit.Inch);

            Length L3 = L1;

            //if (L1 == L3)
            //{
            //    Debug.Print("Ja");
            //}

            //if (L3 == L1)
            //{
            //    Debug.Print("Ja");
            //}

            //if (L1 > L2)
            //{
            //    Debug.Print("Ja");
            //}
            //if (L1 >= L2)
            //{
            //    Debug.Print("Ja");
            //}
            //if (L1 < L2)
            //{
            //    Debug.Print("Ja");
            //}
            //if (L1 <= L2)
            //{
            //    Debug.Print("Ja");
            //}

            var A1 = L1 * L1;
            var A2 = L3 * L3;


            if (A1 == A2)
            {
                Debug.Print("Ja");
            }
            if (L3 * L3 == L1 * L1)
            {
                Debug.Print("Ja");
            }

            if (L1 * L1 > L2 * L2)
            {
                Debug.Print("Ja");
            }
            if (L1 * L1 >= L2 * L2)
            {
                Debug.Print("Ja");
            }
            if (L1 * L1 < L2 * L2)
            {
                Debug.Print("Ja");
            }

            if (L1 * L1 <= L2 * L2)
            {
                Debug.Print("Ja");
            }







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
