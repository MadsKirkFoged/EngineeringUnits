using EngineeringUnits;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace UnitNetcomparing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            //var etssets =  AreaUnit.List().Where(x => nameof(x) == "Acre").Single();


            AreaUnit test12 = AreaUnit.GetUnitByString<AreaUnit>("SquareNanometer");


            var test123 = AreaUnit.ListOf();



            var testset = typeof(AreaUnit)
            .GetFields(BindingFlags.Static | BindingFlags.Public)
            .ToList();








            foreach (var item in testset)
            {





            }








            foreach (var item in AreaUnit.List())
            {

               var etstset = item.GetType();
                

                Debug.Print(nameof(item));

                if (nameof(item) == "Acre")
                {

                }

            }



            var testte = UnitsNet.Area.Units;

            var testte2 = AreaUnit.List();

            var estsetes = AreaUnit.Acre;

  
            var name = nameof(AreaUnit.Acre);


            Volume test3 = new Volume(5.4, VolumeUnit.UsGallon);


            string jsonstring2 = JsonConvert.SerializeObject(test3);
            Volume JSON1 = JsonConvert.DeserializeObject<Volume>(jsonstring2);




            Area test = new Area(1, AreaUnit.SI);
            string jsonstring = JsonConvert.SerializeObject(test);
            Area JSON = JsonConvert.DeserializeObject<Area>(jsonstring);


            AmountOfSubstance A2 = new AmountOfSubstance(10, EngineeringUnits.AmountOfSubstanceUnit.Mole);


            string test1 = JsonConvert.SerializeObject(A2);

            AmountOfSubstance A244 = JsonConvert.DeserializeObject<AmountOfSubstance>(test1);


            AmountOfSubstance A3 = AmountOfSubstance.FromCentimoles(123123165767567567567567231231231312123123d);




            string json = JsonConvert.SerializeObject(A2);

            AmountOfSubstance test2 = JsonConvert.DeserializeObject<AmountOfSubstance>(json);




            UnitsNet.AmountOfSubstance A1 = new UnitsNet.AmountOfSubstance(65.743, UnitsNet.Units.AmountOfSubstanceUnit.Mole);
            


            //A2.ToUnit(AmountOfSubstanceUnit.);



            Debug.Print(A1.ToString("a"));


            

            UnitsNet.MassFlow L1 = new UnitsNet.MassFlow(45442, UnitsNet.Units.MassFlowUnit.PoundPerMinute);
            EngineeringUnits.MassFlow L2 = new EngineeringUnits.MassFlow(45442, EngineeringUnits.MassFlowUnit.PoundPerMinute);






            //Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.SpecificHeatCapacityUnit.JoulePerKilogramKelvin)}");
            //Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)}");


            //Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.SpecificHeatCapacityUnit.BtuPerPoundFahrenheit)}");
            //Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit)}");


            Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.MassFlowUnit.PoundPerHour)}");
            Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.MassFlowUnit.PoundPerHour)}");

            Debug.Print($"EngineeringUnits: {((L2.As(EngineeringUnits.MassFlowUnit.PoundPerHour) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerHour)) / L2.As(EngineeringUnits.MassFlowUnit.PoundPerHour))*100}");

            //Debug.Print($"{L2.As(EngineeringUnits.EnergyUnit.Joule) - L1.As(UnitsNet.Units.EnergyUnit.Joule)}");






            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Millimeter) - L1.As(UnitsNet.Units.LengthUnit.Millimeter), 4);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Micrometer) - L1.As(UnitsNet.Units.LengthUnit.Micrometer), 4000);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Nanometer) - L1.As(UnitsNet.Units.LengthUnit.Nanometer), 4000001);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Inch) - L1.As(UnitsNet.Units.LengthUnit.Inch), 0.16);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Hand) - L1.As(UnitsNet.Units.LengthUnit.Hand), 5281);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Foot) - L1.As(UnitsNet.Units.LengthUnit.Foot), 0.014);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Yard) - L1.As(UnitsNet.Units.LengthUnit.Yard), 0.0044);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Chain) - L1.As(UnitsNet.Units.LengthUnit.Chain), 0.0002);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Mile) - L1.As(UnitsNet.Units.LengthUnit.Mile), 0);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.NauticalMile) - L1.As(UnitsNet.Units.LengthUnit.NauticalMile), 2.2E-06);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.LightYear) - L1.As(UnitsNet.Units.LengthUnit.LightYear), 4.3E-19);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit) - L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit), 2.74E-14);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Parsec) - L1.As(UnitsNet.Units.LengthUnit.Parsec), 1.3E-19);



        }
    }
}
