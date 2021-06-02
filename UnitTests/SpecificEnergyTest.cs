using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            EngineeringUnits.SpecificEnergy EngineeringUnits1 = new EngineeringUnits.SpecificEnergy(1, EngineeringUnits.SpecificEnergyUnit.BtuPerPound);
            EngineeringUnits.SpecificEnergy EngineeringUnits2 = new EngineeringUnits.SpecificEnergy(10, EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram);


            UnitsNet.SpecificEnergy UnitNet3 = UnitNet1 + UnitNet2;
            EngineeringUnits.SpecificEnergy EngineeringUnits3 = EngineeringUnits1 + EngineeringUnits2;



            Assert.AreEqual(0, EngineeringUnits3.As(EngineeringUnits.SpecificEnergyUnit.BtuPerPound) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 1.7E-08);
            Assert.AreEqual(0, EngineeringUnits3.As(EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.01);
            Assert.AreEqual(0, EngineeringUnits3.As(EngineeringUnits.SpecificEnergyUnit.CaloriePerGram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-06);
            Assert.AreEqual(0, EngineeringUnits3.As(EngineeringUnits.SpecificEnergyUnit.KilojoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.07E-06);
        }

        [TestMethod]
        public void SpecificEnergysub()
        {
            UnitsNet.SpecificEnergy UnitNet1 = new UnitsNet.SpecificEnergy(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
            UnitsNet.SpecificEnergy UnitNet2 = new UnitsNet.SpecificEnergy(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);

            EngineeringUnits.SpecificEnergy EngineeringUnits1 = new EngineeringUnits.SpecificEnergy(1, EngineeringUnits.SpecificEnergyUnit.BtuPerPound);
            EngineeringUnits.SpecificEnergy EngineeringUnits2 = new EngineeringUnits.SpecificEnergy(10, EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram);


            UnitsNet.SpecificEnergy UnitNet3 = UnitNet1 - UnitNet2;
            EngineeringUnits.SpecificEnergy EngineeringUnits3 = EngineeringUnits1 - EngineeringUnits2;



            Assert.AreEqual(0, EngineeringUnits3.As(EngineeringUnits.SpecificEnergyUnit.BtuPerPound) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 1.7E-08);
            Assert.AreEqual(0, EngineeringUnits3.As(EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.01);
            Assert.AreEqual(0, EngineeringUnits3.As(EngineeringUnits.SpecificEnergyUnit.CaloriePerGram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-06);
            Assert.AreEqual(0, EngineeringUnits3.As(EngineeringUnits.SpecificEnergyUnit.KilojoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.07E-06);
        }



    }
}
