using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;

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



        [TestMethod]
        public void SpecificEnergyCompareAutoTest()
        {
            UnitsNet.SpecificEnergy A1 = new UnitsNet.SpecificEnergy(1, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
            EngineeringUnits.SpecificEnergy A2 = new EngineeringUnits.SpecificEnergy(1, EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram);

            var EU11 = EngineeringUnits.SpecificEnergyUnit.List();
            var UN11 = UnitsNet.SpecificEnergy.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.SpecificEnergy.Units.Length; i++)
            {

                //if (UnitsNet.Energy.Units[i] == UnitsNet.Units.EnergyUnit.UsSurveySquareFoot)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.SpecificEnergyUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.SpecificEnergy.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-8);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a").Replace("min", "m").Replace("btu", "BTU").Replace("ST", "t (short)"));

            }
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
        public void MassFlowCompareAutoTest()
        {
            UnitsNet.MassFlow A1 = new UnitsNet.MassFlow(65.743, UnitsNet.Units.MassFlowUnit.KilogramPerHour);
            EngineeringUnits.MassFlow A2 = new EngineeringUnits.MassFlow(65.743, EngineeringUnits.MassFlowUnit.KilogramPerHour);

            var EU11 = EngineeringUnits.MassFlowUnit.List();
            var UN11 = UnitsNet.MassFlow.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.MassFlow.Units.Length; i++)
            {

                //if (UnitsNet.MassFlow.Units[i] == UnitsNet.Units.MassFlowUnit.UsSurveySquareFoot)

                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.MassFlowUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.MassFlow.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                if (A1.ToUnit(UN).ToString("a") != "short tn/h")
                {
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a").Replace("min","m"));

                }

            }
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

        [TestMethod]
        public void PowerCompareAutoTest()
        {
            UnitsNet.Power A1 = new UnitsNet.Power(65.743m, UnitsNet.Units.PowerUnit.KilobritishThermalUnitPerHour);
            EngineeringUnits.Power A2 = new EngineeringUnits.Power(65.743m, EngineeringUnits.PowerUnit.KilobritishThermalUnitPerHour);

            var EU11 = EngineeringUnits.PowerUnit.List();
            var UN11 = UnitsNet.Power.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Power.Units.Length; i++)
            {

                //if (UnitsNet.MassFlow.Units[i] == UnitsNet.Units.MassFlowUnit.UsSurveySquareFoot)

                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.PowerUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Power.Units[i];

                //All units absolute difference
                //Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                if (A1.ToUnit(UN).ToString("a") != "short tn/h")
                {
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a").Replace("min", "m").Replace("Btu","BTU"));

                }

            }
        }

        [TestMethod]
        public void AreaCompareAutoTest()
        {
            UnitsNet.Area A1 = new UnitsNet.Area(65.743, UnitsNet.Units.AreaUnit.SquareFoot);
            EngineeringUnits.Area A2 = new EngineeringUnits.Area(65.743, EngineeringUnits.AreaUnit.SquareFoot);

            var EU11 = EngineeringUnits.AreaUnit.List();
            var UN11 = UnitsNet.Area.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Area.Units.Length; i++)
            {

                if (UnitsNet.Area.Units[i] == UnitsNet.Units.AreaUnit.UsSurveySquareFoot)

                {
                    DiffCount++;
                    continue;
                }



                //Getting Units
                var EU = EngineeringUnits.AreaUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Area.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 2729720);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }

        [TestMethod]
        public void EnergyCompareAutoTest()
        {
            UnitsNet.Energy A1 = new UnitsNet.Energy(1, UnitsNet.Units.EnergyUnit.Joule);
            EngineeringUnits.Energy A2 = new EngineeringUnits.Energy(1, EngineeringUnits.EnergyUnit.Joule);

            var EU11 = EngineeringUnits.EnergyUnit.List();
            var UN11 = UnitsNet.Energy.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Energy.Units.Length; i++)
            {

                //if (UnitsNet.Energy.Units[i] == UnitsNet.Units.EnergyUnit.UsSurveySquareFoot)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.EnergyUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Energy.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1024);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }


        [TestMethod]
        public void SpecificEntropyCompareAutoTest()
        {
            UnitsNet.SpecificEntropy A1 = new UnitsNet.SpecificEntropy(1, UnitsNet.Units.SpecificEntropyUnit.KilocaloriePerGramKelvin);
            EngineeringUnits.SpecificEntropy A2 = new EngineeringUnits.SpecificEntropy(1, EngineeringUnits.SpecificEntropyUnit.KilocaloriePerGramKelvin);

            var EU11 = EngineeringUnits.SpecificEntropyUnit.List();
            var UN11 = UnitsNet.SpecificEntropy.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.SpecificEntropy.Units.Length; i++)
            {

                //if (UnitsNet.Energy.Units[i] == UnitsNet.Units.EnergyUnit.UsSurveySquareFoot)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.SpecificEntropyUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.SpecificEntropy.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1024);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a").Replace("°F", "°R").Replace("C", "K").Replace("·", "*").Replace(".", "*").Replace("K", "k"));

            }
        }

        [TestMethod]
        public void SpeedCompareAutoTest()
        {
            UnitsNet.Speed A1 = new UnitsNet.Speed(1, UnitsNet.Units.SpeedUnit.FootPerHour);
            EngineeringUnits.Speed A2 = new EngineeringUnits.Speed(1, EngineeringUnits.SpeedUnit.FootPerHour);

            var EU11 = EngineeringUnits.SpeedUnit.List();
            var UN11 = UnitsNet.Speed.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Speed.Units.Length; i++)
            {

                //if (UnitsNet.Energy.Units[i] == UnitsNet.Units.EnergyUnit.UsSurveySquareFoot)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.SpeedUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Speed.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1024);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a").Replace("/min", "/m"));

            }
        }

        [TestMethod]
        public void PressureCompareAutoTest()
        {
            UnitsNet.Pressure A1 = new UnitsNet.Pressure(1, UnitsNet.Units.PressureUnit.Bar);
            EngineeringUnits.Pressure A2 = new EngineeringUnits.Pressure(1, EngineeringUnits.PressureUnit.Bar);

            var EU11 = EngineeringUnits.PressureUnit.List();
            var UN11 = UnitsNet.Pressure.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Pressure.Units.Length; i++)
            {

                if (UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                {
                    DiffCount++;
                    continue;
                }



                //Getting Units
                var EU = EngineeringUnits.PressureUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Pressure.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-3);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-5);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }

        [TestMethod]
        public void ForceCompareAutoTest()
        {
            UnitsNet.Force A1 = new UnitsNet.Force(1, UnitsNet.Units.ForceUnit.Kilonewton);
            EngineeringUnits.Force A2 = new EngineeringUnits.Force(1, EngineeringUnits.ForceUnit.Kilonewton);

            var EU11 = EngineeringUnits.ForceUnit.List();
            var UN11 = UnitsNet.Force.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Force.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.ForceUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Force.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-2);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-4);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }

        [TestMethod]
        public void AccelerationCompareAutoTest()
        {
            UnitsNet.Acceleration A1 = new UnitsNet.Acceleration(1, UnitsNet.Units.AccelerationUnit.MeterPerSecondSquared);
            EngineeringUnits.Acceleration A2 = new EngineeringUnits.Acceleration(1, EngineeringUnits.AccelerationUnit.MeterPerSecondSquared);

            var EU11 = EngineeringUnits.AccelerationUnit.List();
            var UN11 = UnitsNet.Acceleration.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Acceleration.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.AccelerationUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Acceleration.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-5);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a").Replace("min","m"));

            }
        }

        [TestMethod]
        public void VolumeCompareAutoTest()
        {
            UnitsNet.Volume A1 = new UnitsNet.Volume(1, UnitsNet.Units.VolumeUnit.Liter);
            EngineeringUnits.Volume A2 = new EngineeringUnits.Volume(1, EngineeringUnits.VolumeUnit.Liter);

            var EU11 = EngineeringUnits.VolumeUnit.List();
            var UN11 = UnitsNet.Volume.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Volume.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.VolumeUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Volume.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-1);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }

        }

        [TestMethod]
        public void DensityCompareAutoTest()
        {
            UnitsNet.Density A1 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.DecigramPerDeciliter);
            EngineeringUnits.Density A2 = new EngineeringUnits.Density(1, EngineeringUnits.DensityUnit.DecigramPerDeciliter);

            var EU11 = EngineeringUnits.DensityUnit.List();
            var UN11 = UnitsNet.Density.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Density.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.DensityUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Density.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a").Replace("/L","/l").Replace("kip", "klb"));

            }

        }

        [TestMethod]
        public void DynamicViscosityCompareAutoTest()
        {
            UnitsNet.DynamicViscosity A1 = new UnitsNet.DynamicViscosity(1, UnitsNet.Units.DynamicViscosityUnit.PascalSecond);
            EngineeringUnits.DynamicViscosity A2 = new EngineeringUnits.DynamicViscosity(1, EngineeringUnits.DynamicViscosityUnit.PascalSecond);

            var EU11 = EngineeringUnits.DynamicViscosityUnit.List();
            var UN11 = UnitsNet.DynamicViscosity.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.DynamicViscosity.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.DynamicViscosityUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.DynamicViscosity.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a").Replace("Ns", "N·s"));

            }

        }

        [TestMethod]
        public void ThermalConductivityCompareAutoTest()
        {
            UnitsNet.ThermalConductivity A1 = new UnitsNet.ThermalConductivity(1, UnitsNet.Units.ThermalConductivityUnit.WattPerMeterKelvin);
            EngineeringUnits.ThermalConductivity A2 = new EngineeringUnits.ThermalConductivity(1, EngineeringUnits.ThermalConductivityUnit.WattPerMeterKelvin);

            var EU11 = EngineeringUnits.ThermalConductivityUnit.List();
            var UN11 = UnitsNet.ThermalConductivity.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.ThermalConductivity.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.ThermalConductivityUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.ThermalConductivity.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a").Replace("K","k"));

            }

        }

        [TestMethod]
        public void ForcePerLengthCompareAutoTest()
        {
            UnitsNet.ForcePerLength A1 = new UnitsNet.ForcePerLength(1, UnitsNet.Units.ForcePerLengthUnit.DecanewtonPerMeter);
            EngineeringUnits.ForcePerLength A2 = new EngineeringUnits.ForcePerLength(1, EngineeringUnits.ForcePerLengthUnit.DecanewtonPerMeter);

            var EU11 = EngineeringUnits.ForcePerLengthUnit.List();
            var UN11 = UnitsNet.ForcePerLength.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.ForcePerLength.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.ForcePerLengthUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.ForcePerLength.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-5);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }

        }

        [TestMethod]
        public void VolumeFlowCompareAutoTest()
        {
            UnitsNet.VolumeFlow A1 = new UnitsNet.VolumeFlow(1, UnitsNet.Units.VolumeFlowUnit.CubicFootPerHour);
            EngineeringUnits.VolumeFlow A2 = new EngineeringUnits.VolumeFlow(1, EngineeringUnits.VolumeFlowUnit.CubicFootPerHour);

            var EU11 = EngineeringUnits.VolumeFlowUnit.List();
            var UN11 = UnitsNet.VolumeFlow.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.VolumeFlow.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.VolumeFlowUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.VolumeFlow.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-2);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a")
                                .Replace("day", "d")
                                .Replace("min", "m")
                                //.Replace("cL", "cl")
                                //.Replace("dL", "dl")
                                .Replace("cy", "yd³")
                                //.Replace("kL", "kl")
                                .Replace("L", "l")
                                .Replace("hr", "h")
                                );

            }

        }

        [TestMethod]
        public void MolarMassCompareAutoTest()
        {
            UnitsNet.MolarMass A1 = new UnitsNet.MolarMass(1, UnitsNet.Units.MolarMassUnit.KilopoundPerMole);
            EngineeringUnits.MolarMass A2 = new EngineeringUnits.MolarMass(1, EngineeringUnits.MolarMassUnit.KilopoundPerMole);

            var EU11 = EngineeringUnits.MolarMassUnit.List();
            var UN11 = UnitsNet.MolarMass.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.MolarMass.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.MolarMassUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.MolarMass.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-1);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-5);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a")
                                
                                );

            }

        }

        [TestMethod]
        public void EntropyCompareAutoTest()
        {
            UnitsNet.Entropy A1 = new UnitsNet.Entropy(1, UnitsNet.Units.EntropyUnit.JoulePerKelvin);
            EngineeringUnits.Entropy A2 = new EngineeringUnits.Entropy(1, EngineeringUnits.EntropyUnit.JoulePerKelvin);

            var EU11 = EngineeringUnits.EntropyUnit.List();
            var UN11 = UnitsNet.Entropy.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Entropy.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.EntropyUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Entropy.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-5);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a")
                                .Replace("K","k")
                                .Replace("J/C", "J/k")
                                );

            }

        }

        [TestMethod]
        public void ThermalResistanceCompareAutoTest()
        {
            UnitsNet.ThermalResistance A1 = new UnitsNet.ThermalResistance(1, UnitsNet.Units.ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
            EngineeringUnits.ThermalResistance A2 = new EngineeringUnits.ThermalResistance(1, EngineeringUnits.ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);

            var EU11 = EngineeringUnits.ThermalResistanceUnit.List();
            var UN11 = UnitsNet.ThermalResistance.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.ThermalResistance.Units.Length; i++)
            {

                //if (UnitsNet.Force.Units[i] == UnitsNet.Units.PressureUnit.FootOfElevation ||
                //    UnitsNet.Pressure.Units[i] == UnitsNet.Units.PressureUnit.MeterOfElevation)
                //{
                //    DiffCount++;
                //    continue;
                //}



                //Getting Units
                var EU = EngineeringUnits.ThermalResistanceUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.ThermalResistance.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-3);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-1);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a")
                                .Replace("K","k")
                                );

            }

        }
    }
}