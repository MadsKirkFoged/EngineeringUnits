using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class EnthalpyTests
{

    [TestMethod]
    public void Compare()
    {

        //Enthalpy is an alias for SpecificEnergy

        UnitsNet.SpecificEnergy L1 = new(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
        EngineeringUnits.Enthalpy L2 = new(10, EnthalpyUnit.JoulePerKilogram);

        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 1.9E-12);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 0);
    }
}
