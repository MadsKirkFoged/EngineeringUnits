using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class ComparToUnitNetCombinedUnits
    {


        [TestMethod]
        public void Energycompare()
        {
            UnitsNet.Energy L1 = new UnitsNet.Energy(56239676, UnitsNet.Units.EnergyUnit.Joule);
            EngineeringUnits.Energy L2 = new EngineeringUnits.Energy(56239676, EngineeringUnits.EnergyUnit.Joule);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.BritishThermalUnit) - L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit), 0.21);
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.Calorie) - L1.As(UnitsNet.Units.EnergyUnit.Calorie), 1.9E-09);
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.ElectronVolt) - L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt), 0);


            //The %-error is still very small
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.FootPound) - L1.As(UnitsNet.Units.EnergyUnit.FootPound), 550);


            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.Joule) - L1.As(UnitsNet.Units.EnergyUnit.Joule), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.KilowattHour) - L1.As(UnitsNet.Units.EnergyUnit.KilowattHour), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.WattHour) - L1.As(UnitsNet.Units.EnergyUnit.WattHour), 0);

            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent( L2.As(EngineeringUnits.EnergyUnit.Joule),
                                                    L1.As(UnitsNet.Units.EnergyUnit.Joule)), 0);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EngineeringUnits.EnergyUnit.BritishThermalUnit),
                                                     L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EngineeringUnits.EnergyUnit.Calorie),
                                                    L1.As(UnitsNet.Units.EnergyUnit.Calorie)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EngineeringUnits.EnergyUnit.ElectronVolt),
                                                    L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt)), 0);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EngineeringUnits.EnergyUnit.FootPound),
                                                    L1.As(UnitsNet.Units.EnergyUnit.FootPound)), 0.002);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EngineeringUnits.EnergyUnit.KilowattHour),
                                                    L1.As(UnitsNet.Units.EnergyUnit.KilowattHour)), 0);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EngineeringUnits.EnergyUnit.WattHour),
                                                    L1.As(UnitsNet.Units.EnergyUnit.WattHour)), 0);
        }

        [TestMethod]
        public void Energycompare2()
        {
            UnitsNet.Energy L1 = new UnitsNet.Energy(56239676, UnitsNet.Units.EnergyUnit.BritishThermalUnit);
            EngineeringUnits.Energy L2 = new EngineeringUnits.Energy(56239676, EngineeringUnits.EnergyUnit.BritishThermalUnit);


      
            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.Joule),
                                                    L1.As(UnitsNet.Units.EnergyUnit.Joule)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.BritishThermalUnit),
                                                     L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.Calorie),
                                                    L1.As(UnitsNet.Units.EnergyUnit.Calorie)), 0.0004);

            //Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.ElectronVolt),
                                                   // L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt)), 0);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.FootPound),
                                                    L1.As(UnitsNet.Units.EnergyUnit.FootPound)), 0.002);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.KilowattHour),
                                                    L1.As(UnitsNet.Units.EnergyUnit.KilowattHour)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.WattHour),
                                                    L1.As(UnitsNet.Units.EnergyUnit.WattHour)), 0.0004);
        }

        [TestMethod]
        public void Enthalpycompare()
        {

            //Enthalpy is an alias for SpecificEnergy

            UnitsNet.SpecificEnergy L1 = new UnitsNet.SpecificEnergy(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
            EngineeringUnits.Enthalpy L2 = new EngineeringUnits.Enthalpy(10, EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram);



            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 1.9E-12);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 0);
        }

        [TestMethod]
        public void SpecificEnergycompare()
        {
            UnitsNet.SpecificEnergy L1 = new UnitsNet.SpecificEnergy(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
            EngineeringUnits.SpecificEnergy L2 = new EngineeringUnits.SpecificEnergy(10, EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram);



            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 1.9E-12);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 0);
        }



        [TestMethod]
        public void SpecificEnergycompare2()
        {
            UnitsNet.SpecificEnergy L1 = new UnitsNet.SpecificEnergy(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
            EngineeringUnits.SpecificEnergy L2 = new EngineeringUnits.SpecificEnergy(1, EngineeringUnits.SpecificEnergyUnit.BtuPerPound);



            //UnitNets and EngineeringUnits does not agree on the exact conversing between JoulePerKilogram -> BtuPerPound
            //That what gives the 'large' different

            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.1);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-5);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.1E-05);
        }



        //[TestMethod]
        //public void SpecificEnergyCompareAutoTest()
        //{
        //    UnitsNet.SpecificEnergy A1 = new UnitsNet.SpecificEnergy(1, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
        //    EngineeringUnits.SpecificEnergy A2 = new EngineeringUnits.SpecificEnergy(1, EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram);

        //    var EU11 = EngineeringUnits.SpecificEnergyUnit.List();
        //    var UN11 = UnitsNet.SpecificEnergy.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.SpecificEnergy.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Energy.Units[i] == UnitsNet.Units.EnergyUnit.UsSurveySquareFoot)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.SpecificEnergyUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.SpecificEnergy.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-8);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a").Replace("min", "m").Replace("btu", "BTU").Replace("ST", "t (short)"));

        //    }
        //}

        [TestMethod]
        public void SpecificEnergyAutoTest()
        {
            var A1 = new UnitsNet.SpecificEnergy(65.743, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
            var A2 = new EngineeringUnits.SpecificEnergy(65.743, EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<SpecificEnergyUnit>())
            {


                double Error = 1E-5;
                double RelError = 4E-4;

                var UNList = UnitsNet.SpecificEnergy.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.SpecificEnergyUnit.BtuPerPound) Error = .0003898557813860592;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("btu", "BTU")
                                    .Replace("ST", "t (short)")

                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(25, WorkingCompares);

        }




        [TestMethod]
        public void SpecificHeatCapacitycompare()
        {

            //BtuPerPoundFahrenheit should have been named BtuPerPoundRankine
            //Rankine to Fahrenheit, is what Kelvin is to DegreeCelsius



            UnitsNet.SpecificEntropy L1 = new UnitsNet.SpecificEntropy(1, UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin);
            EngineeringUnits.SpecificEntropy L2 = new EngineeringUnits.SpecificEntropy(1, EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin);


            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEntropyUnit.BtuPerPoundRankine) - L1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit), 9.4E-10);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin) - L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin), 0);

        }


        [TestMethod]
        public void SpecificHeatCapacitycompare2()
        {

            //BtuPerPoundFahrenheit should have been named BtuPerPoundRankine
            //Rankine to Fahrenheit, is what Kelvin is to DegreeCelsius



            UnitsNet.SpecificEntropy L1 = new UnitsNet.SpecificEntropy(1, UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit);
            EngineeringUnits.SpecificEntropy L2 = new EngineeringUnits.SpecificEntropy(1, EngineeringUnits.SpecificEntropyUnit.BtuPerPoundRankine);

            //Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)}");
            //Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin)}");


            //UnitsNet: 4186,8
            //EngineeringUnits: 4186,816458133984


            //UnitsNet dont not use a high precision for this conversion


            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEntropyUnit.BtuPerPoundRankine) - L1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin) - L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin), 0.02);


            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin), L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)) , 0.0004);

            
        }



        [TestMethod]
        public void MassFlowcompare()
        {

            UnitsNet.MassFlow L1 = new UnitsNet.MassFlow(45442, UnitsNet.Units.MassFlowUnit.PoundPerMinute);
            EngineeringUnits.MassFlow L2 = new EngineeringUnits.MassFlow(45442, EngineeringUnits.MassFlowUnit.PoundPerMinute);


            Assert.AreEqual(0, L2.As(EngineeringUnits.MassFlowUnit.KilogramPerHour) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerHour), 4);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassFlowUnit.KilogramPerMinute) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerMinute), 0.06);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassFlowUnit.KilogramPerSecond) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerSecond), 0.00093);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassFlowUnit.PoundPerHour) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerHour), 7);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassFlowUnit.PoundPerMinute) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerMinute), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassFlowUnit.PoundPerSecond) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerSecond), 0.0021);
        }

    

        [TestMethod]
        public void MassFlowAutoTest()
        {
            var A1 = new UnitsNet.MassFlow(65.743, UnitsNet.Units.MassFlowUnit.KilogramPerHour);
            var A2 = new EngineeringUnits.MassFlow(65.743, EngineeringUnits.MassFlowUnit.KilogramPerHour);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<MassFlowUnit>())
            {


                double Error = 7E-4;
                double RelError = 3E-4;

                var UNList = UnitsNet.MassFlow.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.MassFlowUnit.NanogramPerDay) Error = 0.25;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("min", "m")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(33, WorkingCompares);

        }

        [TestMethod]
        public void Powercompare()
        {
            EngineeringUnits.Power L2 = new EngineeringUnits.Power(1, EngineeringUnits.PowerUnit.Watt);
            UnitsNet.Power L1 = new UnitsNet.Power(1, UnitsNet.Units.PowerUnit.Watt);



            Assert.AreEqual(0, L2.As(EngineeringUnits.PowerUnit.Watt) - L1.As(UnitsNet.Units.PowerUnit.Watt), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.PowerUnit.Kilowatt) - L1.As(UnitsNet.Units.PowerUnit.Kilowatt), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.PowerUnit.BritishThermalUnitPerHour) - L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 1.5E-05);


            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.PowerUnit.Watt),
                                                    L1.As(UnitsNet.Units.PowerUnit.Watt)), 0);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.PowerUnit.Kilowatt),
                                        L1.As(UnitsNet.Units.PowerUnit.Kilowatt)), 0);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.PowerUnit.BritishThermalUnitPerHour),
                            L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour)), 0.00042);



        }

        [TestMethod]
        public void Powercompare2()
        {
            EngineeringUnits.Power L2 = new EngineeringUnits.Power(1, EngineeringUnits.PowerUnit.BritishThermalUnitPerHour);
            UnitsNet.Power L1 = new UnitsNet.Power(1, UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour);



            Assert.AreEqual(0, L2.As(EngineeringUnits.PowerUnit.Watt) - L1.As(UnitsNet.Units.PowerUnit.Watt), 1.3E-06);
            Assert.AreEqual(0, L2.As(EngineeringUnits.PowerUnit.Kilowatt) - L1.As(UnitsNet.Units.PowerUnit.Kilowatt), 1.3E-09);
            Assert.AreEqual(0, L2.As(EngineeringUnits.PowerUnit.BritishThermalUnitPerHour) - L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 0);


            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.PowerUnit.Watt),
                                                    L1.As(UnitsNet.Units.PowerUnit.Watt)), 0.00042);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.PowerUnit.Kilowatt),
                                        L1.As(UnitsNet.Units.PowerUnit.Kilowatt)), 0.00042);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.PowerUnit.BritishThermalUnitPerHour),
                            L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour)), 0);



        }

        //[TestMethod]
        //public void PowerCompareAutoTest()
        //{
        //    UnitsNet.Power A1 = new UnitsNet.Power(65.743m, UnitsNet.Units.PowerUnit.KilobritishThermalUnitPerHour);
        //    EngineeringUnits.Power A2 = new EngineeringUnits.Power(65.743m, EngineeringUnits.PowerUnit.KilobritishThermalUnitPerHour);

        //    var EU11 = EngineeringUnits.PowerUnit.List();
        //    var UN11 = UnitsNet.Power.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.Power.Units.Length; i++)
        //    {

        //        //if (UnitsNet.MassFlow.Units[i] == UnitsNet.Units.MassFlowUnit.UsSurveySquareFoot)

        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.PowerUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.Power.Units[i];

        //        //All units absolute difference
        //        //Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        if (A1.ToUnit(UN).ToString("a") != "short tn/h")
        //        {
        //            Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                            A1.ToUnit(UN).ToString("a").Replace("min", "m").Replace("Btu","BTU"));

        //        }

        //    }
        //}

        [TestMethod]
        public void PowerAutoTest()
        {
            var A1 = new UnitsNet.Power(65.743m, UnitsNet.Units.PowerUnit.KilobritishThermalUnitPerHour);
            var A2 = new EngineeringUnits.Power(65.743, EngineeringUnits.PowerUnit.KilobritishThermalUnitPerHour);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<PowerUnit>())
            {


                double Error = 80352555552768;
                double RelError = 5E-4;

                var UNList = UnitsNet.Power.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.PowerUnit.Femtowatt) Error = 80352555552768;
                    if (UN == UnitsNet.Units.PowerUnit.Picowatt) Error = 80352555556;
                    if (UN == UnitsNet.Units.PowerUnit.Nanowatt) Error = 80352555.5546875;
                    if (UN == UnitsNet.Units.PowerUnit.Microwatt) Error = 80352.55555725098;
                    if (UN == UnitsNet.Units.PowerUnit.Milliwatt) Error = 80.35255555808544;
                    if (UN == UnitsNet.Units.PowerUnit.Deciwatt) Error = 0.8035255555587355;
                    if (UN == UnitsNet.Units.PowerUnit.Watt) Error = 0.08035255555660115;
                    if (UN == UnitsNet.Units.PowerUnit.MillijoulePerHour) Error = 289269.19999694824;

                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("Btu", "BTU")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(25, WorkingCompares);

        }


        [TestMethod]
        public void AreaCompareAutoTest()
        {
            var A1 = new UnitsNet.Area(65.743, UnitsNet.Units.AreaUnit.SquareFoot);
            var A2 = new EngineeringUnits.Area(65.743, EngineeringUnits.AreaUnit.SquareFoot);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<AreaUnit>())
            {


                double Error = 5E-2;
                double RelError = 1E-3;

                var UNList = UnitsNet.Area.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.AreaUnit.SquareMicrometer) Error = 2629720.0009765625;
                    if (UN == UnitsNet.Units.AreaUnit.SquareMillimeter) Error = 2.629720000550151;

                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(13, WorkingCompares);

        }

       [TestMethod]
        public void EnergyAutoTest()
        {
            var A1 = new UnitsNet.Energy(65.743, UnitsNet.Units.EnergyUnit.Joule);
            var A2 = new EngineeringUnits.Energy(65.743, EngineeringUnits.EnergyUnit.Joule);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<EnergyUnit>())
            {


                double Error = 7E-5;
                double RelError = 4E-4;

                var UNList = UnitsNet.Energy.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.EnergyUnit.ElectronVolt) Error = 65536;
                    if (UN == UnitsNet.Units.EnergyUnit.KiloelectronVolt) Error = 64;
                    if (UN == UnitsNet.Units.EnergyUnit.MegaelectronVolt) Error = 0.0625;

                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(36, WorkingCompares);

        }


        //[TestMethod]
        //public void SpecificEntropyCompareAutoTest()
        //{
        //    UnitsNet.SpecificEntropy A1 = new UnitsNet.SpecificEntropy(1, UnitsNet.Units.SpecificEntropyUnit.KilocaloriePerGramKelvin);
        //    EngineeringUnits.SpecificEntropy A2 = new EngineeringUnits.SpecificEntropy(1, EngineeringUnits.SpecificEntropyUnit.KilocaloriePerGramKelvin);

        //    var EU11 = EngineeringUnits.SpecificEntropyUnit.List();
        //    var UN11 = UnitsNet.SpecificEntropy.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.SpecificEntropy.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Energy.Units[i] == UnitsNet.Units.EnergyUnit.UsSurveySquareFoot)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.SpecificEntropyUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.SpecificEntropy.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1024);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a")
        //                        .Replace("°F", "°R").
        //                        Replace("C", "K").
        //                        Replace("·", "*").
        //                        //Replace("K", "k").
        //                        Replace(".", "*"));

        //}
        //}

        [TestMethod]
        public void SpecificEntropyAutoTest()
        {
            var A1 = new UnitsNet.SpecificEntropy(65.743, UnitsNet.Units.SpecificEntropyUnit.KilocaloriePerGramKelvin);
            var A2 = new EngineeringUnits.SpecificEntropy(65.743, EngineeringUnits.SpecificEntropyUnit.KilocaloriePerGramKelvin);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<SpecificEntropyUnit>())
            {


                double Error = 1E-5;
                double RelError = 4E-4;

                var UNList = UnitsNet.SpecificEntropy.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit) Error = 0.25825910954154097;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace(".", "*")
                                    .Replace("C", "K")
                                    .Replace("°F", "°R")
                                    .Replace("·", "*")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(9, WorkingCompares);

        }


        //[TestMethod]
        //public void SpeedCompareAutoTest()
        //{
        //    UnitsNet.Speed A1 = new UnitsNet.Speed(1, UnitsNet.Units.SpeedUnit.FootPerHour);
        //    EngineeringUnits.Speed A2 = new EngineeringUnits.Speed(1, EngineeringUnits.SpeedUnit.FootPerHour);

        //    var EU11 = EngineeringUnits.SpeedUnit.List();
        //    var UN11 = UnitsNet.Speed.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.Speed.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Energy.Units[i] == UnitsNet.Units.EnergyUnit.UsSurveySquareFoot)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.SpeedUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.Speed.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1024);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a").Replace("/min", "/m"));

        //    }
        //}

        [TestMethod]
        public void SpeedAutoTest()
        {
            var A1 = new UnitsNet.Speed(65.743, UnitsNet.Units.SpeedUnit.FootPerHour);
            var A2 = new EngineeringUnits.Speed(65.743, EngineeringUnits.SpeedUnit.FootPerHour);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<SpeedUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-4;

                var UNList = UnitsNet.Speed.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.SpeedUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("/min", "/m")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(32, WorkingCompares);

        }

        [TestMethod]
        public void PressureAutoTest()
        {
            var A1 = new UnitsNet.Pressure(65.743, UnitsNet.Units.PressureUnit.Bar);
            var A2 = new EngineeringUnits.Pressure(65.743, EngineeringUnits.PressureUnit.Bar);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<PressureUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.Pressure.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.PressureUnit.Micropascal) Error = 0.0009765625;
                    if (UN == UnitsNet.Units.PressureUnit.KilogramForcePerSquareMeter) Error = 0.013645294005982578;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(42, WorkingCompares);

        }

        [TestMethod]
        public void ForceAutoTest()
        {
            var A1 = new UnitsNet.Force(65.743, UnitsNet.Units.ForceUnit.Kilonewton);
            var A2 = new EngineeringUnits.Force(65.743, EngineeringUnits.ForceUnit.Kilonewton);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<ForceUnit>())
            {


                double Error = 2E-5;
                double RelError = 6E-5;

                var UNList = UnitsNet.Force.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.ForceUnit.Poundal) Error = 0.2531900921021588;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(15, WorkingCompares);

        }

        //[TestMethod]
        //public void AccelerationCompareAutoTest()
        //{
        //    UnitsNet.Acceleration A1 = new UnitsNet.Acceleration(1, UnitsNet.Units.AccelerationUnit.MeterPerSecondSquared);
        //    EngineeringUnits.Acceleration A2 = new EngineeringUnits.Acceleration(1, EngineeringUnits.AccelerationUnit.MeterPerSecondSquared);

        //    var EU11 = EngineeringUnits.AccelerationUnit.List();
        //    var UN11 = UnitsNet.Acceleration.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.Acceleration.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
        //        //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.AccelerationUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.Acceleration.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-5);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a").Replace("min","m"));

        //    }
        //}

        [TestMethod]
        public void AccelerationAutoTest()
        {
            var A1 = new UnitsNet.Acceleration(65.743, UnitsNet.Units.AccelerationUnit.MeterPerSecondSquared);
            var A2 = new EngineeringUnits.Acceleration(65.743, EngineeringUnits.AccelerationUnit.MeterPerSecondSquared);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<AccelerationUnit>())
            {


                double Error = 2E-4;
                double RelError = 1E-5;

                var UNList = UnitsNet.Acceleration.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.AccelerationUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("min", "m")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(14, WorkingCompares);

        }

       [TestMethod]
        public void VolumeAutoTest()
        {
            var A1 = new UnitsNet.Volume(65.743, UnitsNet.Units.VolumeUnit.Liter);
            var A2 = new EngineeringUnits.Volume(65.743, EngineeringUnits.VolumeUnit.Liter);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<VolumeUnit>())
            {


                double Error = 1E-4;
                double RelError = 4E-4;

                var UNList = UnitsNet.Volume.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.VolumeUnit.CubicMicrometer) Error = 8;
                    if (UN == UnitsNet.Units.VolumeUnit.CubicInch) Error = 0.015668552908209676;
                    if (UN == UnitsNet.Units.VolumeUnit.CubicMicrometer) Error = 8;
                    if (UN == UnitsNet.Units.VolumeUnit.CubicMicrometer) Error = 8;
                    if (UN == UnitsNet.Units.VolumeUnit.CubicMicrometer) Error = 8;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(51, WorkingCompares);

        }

        //[TestMethod]
        //public void DensityCompareAutoTest()
        //{
        //    UnitsNet.Density A1 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.DecigramPerDeciliter);
        //    EngineeringUnits.Density A2 = new EngineeringUnits.Density(1, EngineeringUnits.DensityUnit.DecigramPerDeciliter);

        //    var EU11 = EngineeringUnits.DensityUnit.List();
        //    var UN11 = UnitsNet.Density.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.Density.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
        //        //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.DensityUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.Density.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a").Replace("/L","/l").Replace("kip", "klb"));

        //    }

        //}

        [TestMethod]
        public void DensityAutoTest()
        {
            var A1 = new UnitsNet.Density(65.743, UnitsNet.Units.DensityUnit.DecigramPerDeciliter);
            var A2 = new EngineeringUnits.Density(65.743, EngineeringUnits.DensityUnit.DecigramPerDeciliter);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<DensityUnit>())
            {


                double Error = 1E-5;
                double RelError = 2E-4;

                var UNList = UnitsNet.Density.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.DensityUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("/L", "/l")
                                    .Replace("kip", "klb")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(40, WorkingCompares);

        }

        //[TestMethod]
        //public void DynamicViscosityCompareAutoTest()
        //{
        //    UnitsNet.DynamicViscosity A1 = new UnitsNet.DynamicViscosity(1, UnitsNet.Units.DynamicViscosityUnit.PascalSecond);
        //    EngineeringUnits.DynamicViscosity A2 = new EngineeringUnits.DynamicViscosity(1, EngineeringUnits.DynamicViscosityUnit.PascalSecond);

        //    var EU11 = EngineeringUnits.DynamicViscosityUnit.List();
        //    var UN11 = UnitsNet.DynamicViscosity.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.DynamicViscosity.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
        //        //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.DynamicViscosityUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.DynamicViscosity.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a").Replace("Ns", "N·s"));

        //    }

        //}

        [TestMethod]
        public void DynamicViscosityAutoTest()
        {
            var A1 = new UnitsNet.DynamicViscosity(65.743, UnitsNet.Units.DynamicViscosityUnit.PascalSecond);
            var A2 = new EngineeringUnits.DynamicViscosity(65.743, EngineeringUnits.DynamicViscosityUnit.PascalSecond);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<DynamicViscosityUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.DynamicViscosity.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.DynamicViscosityUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("Ns", "N·s")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(10, WorkingCompares);

        }

        [TestMethod]
        public void ThermalConductivityAutoTest()
        {
            var A1 = new UnitsNet.ThermalConductivity(65.743, UnitsNet.Units.ThermalConductivityUnit.WattPerMeterKelvin);
            var A2 = new EngineeringUnits.ThermalConductivity(65.743, EngineeringUnits.ThermalConductivityUnit.WattPerMeterKelvin);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<ThermalConductivityUnit>())
            {


                double Error = 2E-4;
                double RelError = 4E-4;

                var UNList = UnitsNet.ThermalConductivity.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.ThermalConductivityUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(2, WorkingCompares);

        }

        [TestMethod]
        public void ForcePerLengthAutoTest()
        {
            var A1 = new UnitsNet.ForcePerLength(65.743, UnitsNet.Units.ForcePerLengthUnit.DecanewtonPerCentimeter);
            var A2 = new EngineeringUnits.ForcePerLength(65.743, EngineeringUnits.ForcePerLengthUnit.DecanewtonPerCentimeter);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<ForcePerLengthUnit>())
            {


                double Error = 2E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.ForcePerLength.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.ForcePerLengthUnit.NanonewtonPerCentimeter) Error = 0.0001220703125;
                    if (UN == UnitsNet.Units.ForcePerLengthUnit.NanonewtonPerMeter) Error = 0.0078125;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(38, WorkingCompares);

        }

        //[TestMethod]
        //public void VolumeFlowCompareAutoTest()
        //{
        //    UnitsNet.VolumeFlow A1 = new UnitsNet.VolumeFlow(1, UnitsNet.Units.VolumeFlowUnit.CubicFootPerHour);
        //    EngineeringUnits.VolumeFlow A2 = new EngineeringUnits.VolumeFlow(1, EngineeringUnits.VolumeFlowUnit.CubicFootPerHour);

        //    var EU11 = EngineeringUnits.VolumeFlowUnit.List();
        //    var UN11 = UnitsNet.VolumeFlow.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.VolumeFlow.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
        //        //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.VolumeFlowUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.VolumeFlow.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-2);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a")
        //                        .Replace("day", "d")
        //                        .Replace("min", "m")
        //                        //.Replace("cL", "cl")
        //                        //.Replace("dL", "dl")
        //                        .Replace("cy", "yd³")
        //                        //.Replace("kL", "kl")
        //                        .Replace("L", "l")
        //                        .Replace("hr", "h")
        //                        );

        //    }

        //}

        [TestMethod]
        public void VolumeFlowAutoTest()
        {
            var A1 = new UnitsNet.VolumeFlow(65.743, UnitsNet.Units.VolumeFlowUnit.CubicFootPerHour);
            var A2 = new EngineeringUnits.VolumeFlow(65.743, EngineeringUnits.VolumeFlowUnit.CubicFootPerHour);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<VolumeFlowUnit>())
            {


                double Error = 9E-4;
                double RelError = 4E-4;

                var UNList = UnitsNet.VolumeFlow.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.VolumeFlowUnit.NanoliterPerDay) Error = 0.5234375;
                    if (UN == UnitsNet.Units.VolumeFlowUnit.UkGallonPerDay) Error = 0.020195131377477082;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("day", "d")
                                    .Replace("min", "m")
                                    .Replace("L", "l")
                                    .Replace("cy", "yd³")
                                    .Replace("hr", "h")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(56, WorkingCompares);

        }

        [TestMethod]
        public void MolarMassAutoTest()
        {
            var A1 = new UnitsNet.MolarMass(65.743, UnitsNet.Units.MolarMassUnit.KilopoundPerMole);
            var A2 = new EngineeringUnits.MolarMass(65.743, EngineeringUnits.MolarMassUnit.KilopoundPerMole);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<MolarMassUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.MolarMass.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.MolarMassUnit.NanogramPerMole) Error = 4;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(12, WorkingCompares);

        }

        //[TestMethod]
        //public void EntropyCompareAutoTest()
        //{
        //    UnitsNet.Entropy A1 = new UnitsNet.Entropy(1, UnitsNet.Units.EntropyUnit.JoulePerKelvin);
        //    EngineeringUnits.Entropy A2 = new EngineeringUnits.Entropy(1, EngineeringUnits.EntropyUnit.JoulePerKelvin);

        //    var EU11 = EngineeringUnits.EntropyUnit.List();
        //    var UN11 = UnitsNet.Entropy.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.Entropy.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
        //        //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.EntropyUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.Entropy.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-5);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a")
        //                        .Replace("J/C", "J/K")
        //                        //.Replace("K","k")
        //                        );

        //    }

        //}

        [TestMethod]
        public void EntropyAutoTest()
        {
            var A1 = new UnitsNet.Entropy(65.743, UnitsNet.Units.EntropyUnit.JoulePerKelvin);
            var A2 = new EngineeringUnits.Entropy(65.743, EngineeringUnits.EntropyUnit.JoulePerKelvin);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<EntropyUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.Entropy.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.EntropyUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("J/C", "J/K")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(7, WorkingCompares);

        }

        [TestMethod]
        public void ThermalResistanceAutoTest()
        {
            var A1 = new UnitsNet.ThermalResistance(65.743, UnitsNet.Units.ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
            var A2 = new EngineeringUnits.ThermalResistance(65.743, EngineeringUnits.ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<ThermalResistanceUnit>())
            {


                double Error = 3E-4;
                double RelError = 1E-1;

                var UNList = UnitsNet.ThermalResistance.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie) Error = 0.0542845837316861;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(5, WorkingCompares);

        }

        [TestMethod]
        public void HeatTransferCoefficientAutoTest()
        {
            var A1 = new UnitsNet.HeatTransferCoefficient(65.743, UnitsNet.Units.HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);
            var A2 = new EngineeringUnits.HeatTransferCoefficient(65.743, EngineeringUnits.HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<HeatTransferCoefficientUnit>())
            {


                double Error = 1E-5;
                double RelError = 4E-4;

                var UNList = UnitsNet.HeatTransferCoefficient.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.HeatTransferCoefficientUnit.WattPerSquareMeterKelvin) Error = 0.0014674503834157804;
                    if (UN == UnitsNet.Units.HeatTransferCoefficientUnit.WattPerSquareMeterCelsius) Error = 0.0014674503834157804;

                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(3, WorkingCompares);

        }

        //[TestMethod]
        //public void ElectricPotentialCompareAutoTest()
        //{
        //    UnitsNet.ElectricPotential A1 = new UnitsNet.ElectricPotential(1, UnitsNet.Units.ElectricPotentialUnit.Megavolt);
        //    EngineeringUnits.ElectricPotential A2 = new EngineeringUnits.ElectricPotential(1, EngineeringUnits.ElectricPotentialUnit.Megavolt);

        //    var EU11 = EngineeringUnits.ElectricPotentialUnit.List();
        //    var UN11 = UnitsNet.ElectricPotential.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.ElectricPotential.Units.Length; i++)
        //    {

        //        //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
        //        //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
        //        //{
        //        //    DiffCount++;
        //        //    continue;
        //        //}



        //        //Getting Units
        //        var EU = EngineeringUnits.ElectricPotentialUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.ElectricPotential.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                        A1.ToUnit(UN).ToString("a")
        //                        .Replace("K", "k")
        //                        );

        //    }

        //}

        [TestMethod]
        public void ElectricPotentialAutoTest()
        {
            var A1 = new UnitsNet.ElectricPotential(65.743, UnitsNet.Units.ElectricPotentialUnit.Megavolt);
            var A2 = new EngineeringUnits.ElectricPotential(65.743, EngineeringUnits.ElectricPotentialUnit.Megavolt);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<ElectricPotentialUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.ElectricPotential.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.ElectricPotentialUnit.Microvolt) Error = 0.0078125;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(5, WorkingCompares);

        }

        [TestMethod]
        public void FrequencyAutoTest()
        {
            var A1 = new UnitsNet.Frequency(65.743, UnitsNet.Units.FrequencyUnit.Hertz);
            var A2 = new EngineeringUnits.Frequency(65.743, EngineeringUnits.FrequencyUnit.Hertz);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<FrequencyUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.Frequency.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.FrequencyUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(10, WorkingCompares);

        }

        [TestMethod]
        public void TorqueAutoTest()
        {
            var A1 = new UnitsNet.Torque(65.743, UnitsNet.Units.TorqueUnit.KilonewtonMeter);
            var A2 = new EngineeringUnits.Torque(65.743, EngineeringUnits.TorqueUnit.KilonewtonMeter);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<TorqueUnit>())
            {


                double Error = 2E-4;
                double RelError = 1E-5;

                var UNList = UnitsNet.Torque.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.TorqueUnit.KilogramForceCentimeter) Error = 0.013645293889567256;
                    if (UN == UnitsNet.Units.TorqueUnit.KilogramForceMillimeter) Error = 0.13645293843001127;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(22, WorkingCompares);

        }


        [TestMethod]
        public void KinematicViscosityAutoTest()
        {
            var A1 = new UnitsNet.KinematicViscosity(65.743, UnitsNet.Units.KinematicViscosityUnit.Kilostokes);
            var A2 = new EngineeringUnits.KinematicViscosity(65.743, EngineeringUnits.KinematicViscosityUnit.Kilostokes);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<KinematicViscosityUnit>())
            {


                double Error = 2E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.KinematicViscosity.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.KinematicViscosityUnit.Nanostokes) Error = 0.015625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a"));

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(8, WorkingCompares);

        }
    }
}