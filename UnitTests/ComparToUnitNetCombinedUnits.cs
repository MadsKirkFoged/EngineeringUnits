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
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-3);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }
    }
}
