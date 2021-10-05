using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using EngineeringUnits.Units;

namespace UnitTests
{
    [TestClass]
    public class Angle
    {


        [TestMethod]
        public void Energycompare()
        {
            UnitsNet.Energy L1 = new(56239676, UnitsNet.Units.EnergyUnit.Joule);
            EngineeringUnits.Energy L2 = new(56239676, EnergyUnit.Joule);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EnergyUnit.BritishThermalUnit) - L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit), 0.21);
            Assert.AreEqual(0, L2.As(EnergyUnit.Calorie) - L1.As(UnitsNet.Units.EnergyUnit.Calorie), 1.9E-09);
            Assert.AreEqual(0, L2.As(EnergyUnit.ElectronVolt) - L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt), 0);


            //The %-error is still very small
            Assert.AreEqual(0, L2.As(EnergyUnit.FootPound) - L1.As(UnitsNet.Units.EnergyUnit.FootPound), 550);


            Assert.AreEqual(0, L2.As(EnergyUnit.Joule) - L1.As(UnitsNet.Units.EnergyUnit.Joule), 0);
            Assert.AreEqual(0, L2.As(EnergyUnit.KilowattHour) - L1.As(UnitsNet.Units.EnergyUnit.KilowattHour), 0);
            Assert.AreEqual(0, L2.As(EnergyUnit.WattHour) - L1.As(UnitsNet.Units.EnergyUnit.WattHour), 0);

            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent( L2.As(EnergyUnit.Joule),
                                                    L1.As(UnitsNet.Units.EnergyUnit.Joule)), 0);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EnergyUnit.BritishThermalUnit),
                                                     L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EnergyUnit.Calorie),
                                                    L1.As(UnitsNet.Units.EnergyUnit.Calorie)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EnergyUnit.ElectronVolt),
                                                    L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt)), 0);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EnergyUnit.FootPound),
                                                    L1.As(UnitsNet.Units.EnergyUnit.FootPound)), 0.002);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EnergyUnit.KilowattHour),
                                                    L1.As(UnitsNet.Units.EnergyUnit.KilowattHour)), 0);

            Assert.AreEqual(0, HelperClass.Percent( L2.As(EnergyUnit.WattHour),
                                                    L1.As(UnitsNet.Units.EnergyUnit.WattHour)), 0);
        }

        [TestMethod]
        public void Energycompare2()
        {
            UnitsNet.Energy L1 = new(56239676, UnitsNet.Units.EnergyUnit.BritishThermalUnit);
            EngineeringUnits.Energy L2 = new(56239676, EnergyUnit.BritishThermalUnit);


      
            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.Joule),
                                                    L1.As(UnitsNet.Units.EnergyUnit.Joule)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.BritishThermalUnit),
                                                     L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.Calorie),
                                                    L1.As(UnitsNet.Units.EnergyUnit.Calorie)), 0.0004);

            //Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.ElectronVolt),
                                                   // L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt)), 0);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.FootPound),
                                                    L1.As(UnitsNet.Units.EnergyUnit.FootPound)), 0.002);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.KilowattHour),
                                                    L1.As(UnitsNet.Units.EnergyUnit.KilowattHour)), 0.0004);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.WattHour),
                                                    L1.As(UnitsNet.Units.EnergyUnit.WattHour)), 0.0004);
        }

        [TestMethod]
        public void Enthalpycompare()
        {

            //Enthalpy is an alias for SpecificEnergy

            UnitsNet.SpecificEnergy L1 = new(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
            EngineeringUnits.Enthalpy L2 = new(10, SpecificEnergyUnit.JoulePerKilogram);



            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 1.9E-12);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 0);
        }

        [TestMethod]
        public void SpecificEnergycompare()
        {
            UnitsNet.SpecificEnergy L1 = new(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
            EngineeringUnits.SpecificEnergy L2 = new(10, SpecificEnergyUnit.JoulePerKilogram);



            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 1.9E-12);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 0);
        }

        [TestMethod]
        public void SpecificEnergycompare2()
        {
            UnitsNet.SpecificEnergy L1 = new(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
            EngineeringUnits.SpecificEnergy L2 = new(1, SpecificEnergyUnit.BtuPerPound);



            //UnitNets and EngineeringUnits does not agree on the exact conversing between JoulePerKilogram -> BtuPerPound
            //That what gives the 'large' different

            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.1);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-5);
            Assert.AreEqual(0, L2.As(SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.1E-05);
        }

        [TestMethod]
        public void SpecificEnergyAutoTest()
        {
            var A1 = new UnitsNet.SpecificEnergy(65.743, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
            var A2 = new EngineeringUnits.SpecificEnergy(65.743, SpecificEnergyUnit.JoulePerKilogram);

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



            UnitsNet.SpecificEntropy L1 = new(1, UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin);
            EngineeringUnits.SpecificEntropy L2 = new(1, SpecificEntropyUnit.JoulePerKilogramKelvin);


            Assert.AreEqual(0, L2.As(SpecificEntropyUnit.BtuPerPoundRankine) - L1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit), 9.4E-10);
            Assert.AreEqual(0, L2.As(SpecificEntropyUnit.JoulePerKilogramKelvin) - L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin), 0);

        }

        [TestMethod]
        public void SpecificHeatCapacitycompare2()
        {

            //BtuPerPoundFahrenheit should have been named BtuPerPoundRankine
            //Rankine to Fahrenheit, is what Kelvin is to DegreeCelsius



            UnitsNet.SpecificEntropy L1 = new(1, UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit);
            EngineeringUnits.SpecificEntropy L2 = new(1, SpecificEntropyUnit.BtuPerPoundRankine);

            //Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)}");
            //Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.SpecificEntropyUnit.JoulePerKilogramKelvin)}");


            //UnitsNet: 4186,8
            //EngineeringUnits: 4186,816458133984


            //UnitsNet dont not use a high precision for this conversion


            Assert.AreEqual(0, L2.As(SpecificEntropyUnit.BtuPerPoundRankine) - L1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit), 0);
            Assert.AreEqual(0, L2.As(SpecificEntropyUnit.JoulePerKilogramKelvin) - L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin), 0.02);


            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(L2.As(SpecificEntropyUnit.JoulePerKilogramKelvin), L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)) , 0.0004);

            
        }

        [TestMethod]
        public void MassFlowcompare()
        {

            UnitsNet.MassFlow L1 = new(45442, UnitsNet.Units.MassFlowUnit.PoundPerMinute);
            EngineeringUnits.MassFlow L2 = new(45442, MassFlowUnit.PoundPerMinute);


            Assert.AreEqual(0, L2.As(MassFlowUnit.KilogramPerHour) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerHour), 4);
            Assert.AreEqual(0, L2.As(MassFlowUnit.KilogramPerMinute) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerMinute), 0.06);
            Assert.AreEqual(0, L2.As(MassFlowUnit.KilogramPerSecond) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerSecond), 0.00093);
            Assert.AreEqual(0, L2.As(MassFlowUnit.PoundPerHour) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerHour), 7);
            Assert.AreEqual(0, L2.As(MassFlowUnit.PoundPerMinute) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerMinute), 0);
            Assert.AreEqual(0, L2.As(MassFlowUnit.PoundPerSecond) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerSecond), 0.0021);
        }

        [TestMethod]
        public void MassFlowAutoTest()
        {
            var A1 = new UnitsNet.MassFlow(65.743, UnitsNet.Units.MassFlowUnit.KilogramPerHour);
            var A2 = new EngineeringUnits.MassFlow(65.743, MassFlowUnit.KilogramPerHour);

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
            EngineeringUnits.Power L2 = new(1, PowerUnit.Watt);
            UnitsNet.Power L1 = new(1, UnitsNet.Units.PowerUnit.Watt);



            Assert.AreEqual(0, L2.As(PowerUnit.Watt) - L1.As(UnitsNet.Units.PowerUnit.Watt), 0);
            Assert.AreEqual(0, L2.As(PowerUnit.Kilowatt) - L1.As(UnitsNet.Units.PowerUnit.Kilowatt), 0);
            Assert.AreEqual(0, L2.As(PowerUnit.BritishThermalUnitPerHour) - L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 1.5E-05);


            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.Watt),
                                                    L1.As(UnitsNet.Units.PowerUnit.Watt)), 0);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.Kilowatt),
                                        L1.As(UnitsNet.Units.PowerUnit.Kilowatt)), 0);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.BritishThermalUnitPerHour),
                            L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour)), 0.00042);



        }

        [TestMethod]
        public void Powercompare2()
        {
            EngineeringUnits.Power L2 = new(1, PowerUnit.BritishThermalUnitPerHour);
            UnitsNet.Power L1 = new(1, UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour);



            Assert.AreEqual(0, L2.As(PowerUnit.Watt) - L1.As(UnitsNet.Units.PowerUnit.Watt), 1.3E-06);
            Assert.AreEqual(0, L2.As(PowerUnit.Kilowatt) - L1.As(UnitsNet.Units.PowerUnit.Kilowatt), 1.3E-09);
            Assert.AreEqual(0, L2.As(PowerUnit.BritishThermalUnitPerHour) - L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 0);


            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.Watt),
                                                    L1.As(UnitsNet.Units.PowerUnit.Watt)), 0.00042);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.Kilowatt),
                                        L1.As(UnitsNet.Units.PowerUnit.Kilowatt)), 0.00042);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(PowerUnit.BritishThermalUnitPerHour),
                            L1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour)), 0);



        }

        [TestMethod]
        public void PowerAutoTest()
        {
            var A1 = new UnitsNet.Power(65.743m, UnitsNet.Units.PowerUnit.KilobritishThermalUnitPerHour);
            var A2 = new EngineeringUnits.Power(65.743, PowerUnit.KilobritishThermalUnitPerHour);

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
            var A2 = new EngineeringUnits.Area(65.743, AreaUnit.SquareFoot);

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
            var A2 = new EngineeringUnits.Energy(65.743, EnergyUnit.Joule);

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

        [TestMethod]
        public void SpecificEntropyAutoTest()
        {
            var A1 = new UnitsNet.SpecificEntropy(65.743, UnitsNet.Units.SpecificEntropyUnit.KilocaloriePerGramKelvin);
            var A2 = new EngineeringUnits.SpecificEntropy(65.743, SpecificEntropyUnit.KilocaloriePerGramKelvin);

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
   
        [TestMethod]
        public void SpeedAutoTest()
        {
            var A1 = new UnitsNet.Speed(65.743, UnitsNet.Units.SpeedUnit.FootPerHour);
            var A2 = new EngineeringUnits.Speed(65.743, SpeedUnit.FootPerHour);

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
            var A2 = new EngineeringUnits.Pressure(65.743, PressureUnit.Bar);

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
            var A2 = new EngineeringUnits.Force(65.743, ForceUnit.Kilonewton);

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

        [TestMethod]
        public void AccelerationAutoTest()
        {
            var A1 = new UnitsNet.Acceleration(65.743, UnitsNet.Units.AccelerationUnit.MeterPerSecondSquared);
            var A2 = new EngineeringUnits.Acceleration(65.743, AccelerationUnit.MeterPerSecondSquared);

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
            var A2 = new EngineeringUnits.Volume(65.743, VolumeUnit.Liter);

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

        [TestMethod]
        public void DensityAutoTest()
        {
            var A1 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.KilogramPerCubicMeter);
            var A2 = new EngineeringUnits.Density(1, DensityUnit.KilogramPerCubicMeter);

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
                                    //.Replace("kip", "klb")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(40, WorkingCompares);

        }

        [TestMethod]
        public void DynamicViscosityAutoTest()
        {
            var A1 = new UnitsNet.DynamicViscosity(65.743, UnitsNet.Units.DynamicViscosityUnit.PascalSecond);
            var A2 = new EngineeringUnits.DynamicViscosity(65.743, DynamicViscosityUnit.PascalSecond);

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
            var A2 = new EngineeringUnits.ThermalConductivity(65.743, ThermalConductivityUnit.WattPerMeterKelvin);

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
            var A2 = new EngineeringUnits.ForcePerLength(65.743, ForcePerLengthUnit.DecanewtonPerCentimeter);

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

        [TestMethod]
        public void VolumeFlowAutoTest()
        {
            var A1 = new UnitsNet.VolumeFlow(65.743, UnitsNet.Units.VolumeFlowUnit.CubicFootPerHour);
            var A2 = new EngineeringUnits.VolumeFlow(65.743, VolumeFlowUnit.CubicFootPerHour);

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
            var A2 = new EngineeringUnits.MolarMass(65.743, MolarMassUnit.KilopoundPerMole);

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
                                    A1.ToUnit(UN).ToString("a")
                                    
                                    .Replace("klb", "kip")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(12, WorkingCompares);

        }

        [TestMethod]
        public void EntropyAutoTest()
        {
            var A1 = new UnitsNet.Entropy(65.743, UnitsNet.Units.EntropyUnit.JoulePerKelvin);
            var A2 = new EngineeringUnits.Entropy(65.743, EntropyUnit.JoulePerKelvin);

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
            var A2 = new EngineeringUnits.ThermalResistance(65.743, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);

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
            var A2 = new EngineeringUnits.HeatTransferCoefficient(65.743, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);

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

        [TestMethod]
        public void ElectricPotentialAutoTest()
        {
            var A1 = new UnitsNet.ElectricPotential(65.743, UnitsNet.Units.ElectricPotentialUnit.Megavolt);
            var A2 = new EngineeringUnits.ElectricPotential(65.743, ElectricPotentialUnit.Megavolt);

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
            var A2 = new EngineeringUnits.Frequency(65.743, FrequencyUnit.Hertz);

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
            var A2 = new EngineeringUnits.Torque(65.743, TorqueUnit.KilonewtonMeter);

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
            var A2 = new EngineeringUnits.KinematicViscosity(65.743, KinematicViscosityUnit.Kilostokes);

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