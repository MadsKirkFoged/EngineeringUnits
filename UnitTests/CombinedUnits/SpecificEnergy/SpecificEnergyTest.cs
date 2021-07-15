using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Diagnostics;
using UnitsNet;

namespace UnitTests
{
    [TestClass]
    public class SpecificEnergyTest
    {


        [TestMethod]
        public void SpecificEnergyAdd()
        {
            UnitsNet.SpecificEnergy UnitNet1 = new UnitsNet.SpecificEnergy(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
            UnitsNet.SpecificEnergy UnitNet2 = new UnitsNet.SpecificEnergy(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);

            EngineeringUnits.SpecificEnergy EngineeringUnits1 = new EngineeringUnits.SpecificEnergy(1, SpecificEnergyUnit.BtuPerPound);
            EngineeringUnits.SpecificEnergy EngineeringUnits2 = new EngineeringUnits.SpecificEnergy(10, SpecificEnergyUnit.JoulePerKilogram);


            UnitsNet.SpecificEnergy UnitNet3 = UnitNet1 + UnitNet2;
            EngineeringUnits.SpecificEnergy EngineeringUnits3 = EngineeringUnits1 + EngineeringUnits2;

            //Difference in procent
            Assert.AreEqual(0, HelperClass.Percent(EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound),
                                                    UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound)), 0.00042);

            Assert.AreEqual(0, HelperClass.Percent(EngineeringUnits3.As(SpecificEnergyUnit.JoulePerKilogram),
                                        UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram)), 0.00042);

            Assert.AreEqual(0, HelperClass.Percent(EngineeringUnits3.As(SpecificEnergyUnit.CaloriePerGram),
                                        UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram)), 0.00042);
            Assert.AreEqual(0, HelperClass.Percent(EngineeringUnits3.As(SpecificEnergyUnit.KilojoulePerKilogram),
                                        UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram)), 0.00042);


            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 1.7E-08);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.JoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.01);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.CaloriePerGram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-06);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.KilojoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.07E-06);
        }

        [TestMethod]
        public void SpecificEnergysub()
        {
            UnitsNet.SpecificEnergy UnitNet1 = new UnitsNet.SpecificEnergy(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
            UnitsNet.SpecificEnergy UnitNet2 = new UnitsNet.SpecificEnergy(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);

            EngineeringUnits.SpecificEnergy EngineeringUnits1 = new EngineeringUnits.SpecificEnergy(1, SpecificEnergyUnit.BtuPerPound);
            EngineeringUnits.SpecificEnergy EngineeringUnits2 = new EngineeringUnits.SpecificEnergy(10, SpecificEnergyUnit.JoulePerKilogram);


            UnitsNet.SpecificEnergy UnitNet3 = UnitNet1 - UnitNet2;
            EngineeringUnits.SpecificEnergy EngineeringUnits3 = EngineeringUnits1 - EngineeringUnits2;



            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 1.7E-08);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.JoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.01);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.CaloriePerGram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-06);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.KilojoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.07E-06);
        }

        [TestMethod]
        public void SpecificEnergysubSJON()
        {
            UnitsNet.SpecificEnergy UnitNet1 = new UnitsNet.SpecificEnergy(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
            UnitsNet.SpecificEnergy UnitNet2 = new UnitsNet.SpecificEnergy(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);

            EngineeringUnits.SpecificEnergy EngineeringUnits1 = new EngineeringUnits.SpecificEnergy(1, SpecificEnergyUnit.BtuPerPound);
            EngineeringUnits.SpecificEnergy EngineeringUnits2 = new EngineeringUnits.SpecificEnergy(10, SpecificEnergyUnit.JoulePerKilogram);

            string jsonstring = JsonConvert.SerializeObject(EngineeringUnits2);
            EngineeringUnits.SpecificEnergy JSON = JsonConvert.DeserializeObject<EngineeringUnits.SpecificEnergy>(jsonstring);


            UnitsNet.SpecificEnergy UnitNet3 = UnitNet1 - UnitNet2;
            EngineeringUnits.SpecificEnergy EngineeringUnits3 = EngineeringUnits1 - JSON;



            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 1.7E-08);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.JoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.01);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.CaloriePerGram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-06);
            Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.KilojoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.07E-06);
        }


    }
}
