using Fractions;
using System;
using System.Diagnostics;

namespace EngineeringUnits
{
    class Program
    {
        static void Main(string[] args)
        {


            //Tilføj flere combi-units og test om vi kan sætte ligninger op

            //Lav test om denne ligning virker med forskellige enheder

            SpecificEnergy H1 = new SpecificEnergy(1, SpecificEnergyUnit.BtuPerPound);


            Debug.WriteLine($"{(double)H1.Unit.GetActualC()}");
            Debug.WriteLine($"{(double)H1.ValueLocalUnit * (double)H1.Unit.GetActualC()}");
            Debug.WriteLine($"{H1.As(SpecificEnergyUnit.BtuPerPound)}");





            //Q = m * Cp * dT

            SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);

            //MassFlow M1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);
            MassFlow M1 = new MassFlow(2.20462, MassFlowUnit.PoundPerSecond);
            Temperature T2 = new Temperature(10, TemperatureUnit.Kelvin);
            Temperature T1 = new Temperature(5, TemperatureUnit.Kelvin);


            Power Q1 = H1 * M1;


            Debug.WriteLine($"{(double)Q1.Unit.GetActualC()}");
            Debug.WriteLine($"{(double)Q1.ValueLocalUnit * (double)Q1.Unit.GetActualC()}");

            Debug.WriteLine($"{Q1.As(PowerUnit.Watt)}");




            //Power Q1 = M1 * P1 * (T2 - T1);

            //Debug.WriteLine($"{Q1} = {M1} * {P1} * ({T2} - {T1})");
            //Debug.WriteLine($"{Q1.As(PowerUnit.Watt)}");

            Debug.WriteLine($"");

            //Todo - Få styr på ActualC og combined-unit correction.
            //combined-unit correction, bruges når en combined unit f.eks. BTU skal oprettes, da den ikke kan laves udfra nogle baseunits.

            //ActualC bruges når kg/lb, så bliver enheden sat til 0, men en correction bliver husket



            //EngineeringUnits: 0,0009478133944988911
            //UnitsNet: 0,00042992260000007437



            //Length ltest1 = new Length(3.87, LengthUnit.Inch);
            //Length ltest2 = new Length(2.78, LengthUnit.Meter);


            ////Assert.AreEqual(0.0353589928057554, (double)(L1 / L2));

            //Debug.WriteLine($"{(double)(ltest1 / ltest2)}");


            //Mass m1 = new Mass(1, MassUnit.Kilogram);

            //Debug.WriteLine($"{m1.As(MassUnit.Pound)}");


            SpecificEnergy E1 = new SpecificEnergy(1, SpecificEnergyUnit.BtuPerPound);
            SpecificEnergy E2 = new SpecificEnergy(10, SpecificEnergyUnit.JoulePerKilogram);


            SpecificEnergy E3 = E2 - E1;

            Debug.WriteLine($"{E3.As(SpecificEnergyUnit.JoulePerKilogram)}");
            Debug.WriteLine($"{E3.As(SpecificEnergyUnit.BtuPerPound)}");


            //1
            //2326


            Length L1 = new Length(3, LengthUnit.Inch);
            var test564 = L1 * L1 * L1 * L1 * L1;



            //Lav Energy færdig
            //prefix på ikke-baseunits units? f.eks. GigaBTU og Gigajoule
            //transfer EkstraCorrection



            //EkstraCorrection - Skal den laves som sig egen unit?
            //-->Tænker det vil give bedst mening
            //--> alternativt bliver det lidt træls at føre EkstraCorrection med rundt..
            //Problemet opstår når en unit med EkstraCorrection bliver brugt til at lave en ny sammensat unit med

            //Length L1 = new Length(10, LengthUnit.Meter);


            //var d1 = (L1 / L2);


            Debug.WriteLine($"{L1.As(LengthUnit.Yard)}");

            Length L2 = new Length(1, LengthUnit.Yard);

            //SpecificEnergy E1 = new SpecificEnergy(1, SpecificEnergyUnit.JoulePerKilogram);


            //Debug.WriteLine($"{E1}");
            //Debug.WriteLine($"{E1.As(SpecificEnergyUnit.BtuPerPound)}");



            BigDecimal big1 = 5641231.546541;
            BigDecimal big2 = 165465987.545465448987631;
            BigDecimal big3 = (big1 / big2) + 54654654777d;

            Debug.WriteLine($"{big3}");
            Debug.WriteLine($"{(double)big3}");



            Fraction a = 3*3;  // int

            Fraction b = 1231231*3;  // int


            var c = a / b;




           // Energy E1 = new Energy(10,EnergyUnit.Joule);

            //Mass M1 = new Mass(5, MassUnit.SI);

            SpecificEnergy SE1 = E1 / M1;


            //Enthalpy H1 = E1 / M1;

            Debug.WriteLine($"{H1.Unit.ChangingUnitSymbols()}");







            Area A1 = L1 * L2;

            Debug.WriteLine($"{A1}");

            Debug.WriteLine($"{A1.As(AreaUnit.SI)}");
            Debug.WriteLine($"{A1.As(AreaUnit.Yard2)}");


            Debug.WriteLine($"{L1}");
            Debug.WriteLine($"{L2}");

            //Length A1 = L1 + L2;

            Debug.WriteLine($"{A1}");
            //Debug.WriteLine($"{A1.As(LengthUnit.Meter)}");
            //Debug.WriteLine($"{A1.As(LengthUnit.Centimeter)}");





            //Temperature T1 = new Temperature(10, TemperatureUnit.Kelvin);

            //Temperature T1 = new Temperature(20, TemperatureUnit.DegreeCelsius);
            //Temperature T2 = new Temperature(293.15, TemperatureUnit.Kelvin);
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


            //Length L1 = new Length(2, LengthUnit.Yard);
            //Length L2 = new Length(2, LengthUnit.Meter);


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
