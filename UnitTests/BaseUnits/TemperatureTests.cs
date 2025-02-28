using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.BaseUnits;

[TestClass]
public class TemperatureTests
{

    [TestMethod]
    public void Compare()
    {
        UnitsNet.Temperature L1 = new(657.4, UnitsNet.Units.TemperatureUnit.Kelvin);
        EngineeringUnits.Temperature L2 = new(657.4, TemperatureUnit.Kelvin);

        var jsonString = JsonConvert.SerializeObject(L2);
        EngineeringUnits.Temperature? JSON = JsonConvert.DeserializeObject<EngineeringUnits.Temperature>(jsonString);

        //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
        Assert.IsNotNull(JSON);
        Assert.AreEqual(0, JSON.As(TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 0);
        Assert.AreEqual(0, JSON.As(TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 1.2E-13);
        Assert.AreEqual(0, JSON.As(TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
        Assert.AreEqual(0, JSON.As(TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 0);

        //Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);

    }

    [TestMethod]
    public void Compare2()
    {
        UnitsNet.Temperature L1 = new(657.4, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
        EngineeringUnits.Temperature L2 = new(657.4, TemperatureUnit.DegreeCelsius);

        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 0);
        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 0);
        Assert.AreEqual(0, L2.As(TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 0.000001);

    }

    [TestMethod]
    public void Compare3()
    {
        UnitsNet.Temperature L1 = new(657.4, UnitsNet.Units.TemperatureUnit.DegreeFahrenheit);
        EngineeringUnits.Temperature L2 = new(657.4, TemperatureUnit.DegreeFahrenheit);

        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 5.7E-14);
        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 0);
        Assert.AreEqual(0, L2.As(TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 2.3E-13);

    }

    [TestMethod]
    public void Compare4()
    {
        UnitsNet.Temperature L1 = new(657.4, UnitsNet.Units.TemperatureUnit.DegreeRankine);
        EngineeringUnits.Temperature L2 = new(657.4, TemperatureUnit.DegreeRankine);

        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 5.7E-14);
        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 5.7E-14);
        Assert.AreEqual(0, L2.As(TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
        Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 2.3E-13);

    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Temperature(65.743, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
        var A2 = new EngineeringUnits.Temperature(65.743, TemperatureUnit.DegreeCelsius);

        var WorkingCompares = 0;

        foreach (TemperatureUnit EU in UnitTypebase.ListOf<TemperatureUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.TemperatureUnit> UNList = UnitsNet.Temperature.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.TemperatureUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.TemperatureUnit.SquareMicrometer) Error = 2629720.0009765625;

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
                //Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                //               A1.ToUnit(UN).ToString("a"));

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(4, WorkingCompares);

    }

    [TestMethod]
    public void CelsiusDivideFahrenheit()
    {
        //Arrange
        Temperature T1 = new(100, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        UnknownUnit T3 = T2 / T1;
        var K3 = T2.As(TemperatureUnit.SI) / T1.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "0.8914");
        Assert.AreEqual(K3, 0.89136455411224458);
    }

    [TestMethod]
    public void FahrenheitDivideCelsius()
    {
        //Arrange
        Temperature T1 = new(100, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        UnknownUnit T3 = T1 / T2;
        var K3 = T1.As(TemperatureUnit.SI) / T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "1.122");
        Assert.AreEqual(K3, 1.12187543849099);
    }

    [TestMethod]
    public void CelsiusDivideCelsius()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        UnknownUnit T3 = T1 / T2;
        var K3 = T1.As(TemperatureUnit.SI) / T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "1.083");
        Assert.AreEqual(K3, 1.0829875518672198);
    }

    [TestMethod]
    public void FahrenheitDivideFahrenheit()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeFahrenheit);

        //Act
        UnknownUnit T3 = T1 / T2;
        var K3 = T1.As(TemperatureUnit.SI) / T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "1.05");
        Assert.AreEqual(K3, 1.0496042443979554);
    }

    [TestMethod]
    public void KelvinDivideKelvin()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.Kelvin);
        Temperature T2 = new(4, TemperatureUnit.Kelvin);

        //Act
        UnknownUnit T3 = T1 / T2;
        var K3 = T1.As(TemperatureUnit.SI) / T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "6.75");
        Assert.AreEqual(K3, 6.75);
    }

    /// <summary>
    /// 
    /// </summary>

    [TestMethod]
    public void CelsiusTimesFahrenheit()
    {
        //Arrange
        Temperature T1 = new(100, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        UnknownUnit T3 = T2 * T1;
        var K3 = T2.As(TemperatureUnit.SI) * T1.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "8.617e+04 K²");
        Assert.AreEqual(K3, 86173.633611111116);
    }

    [TestMethod]
    public void FahrenheitTimesCelsius()
    {
        //Arrange
        Temperature T1 = new(100, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        UnknownUnit T3 = T1 * T2;
        var K3 = T1.As(TemperatureUnit.SI) * T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "8.617e+04 K²");
        Assert.AreEqual(K3, 86173.633611111116);
    }

    [TestMethod]
    public void CelsiusTimesCelsius()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        UnknownUnit T3 = T1 * T2;
        var K3 = T1.As(TemperatureUnit.SI) * T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "8.319e+04 K²");
        Assert.AreEqual(K3, 83186.57249999998);
    }

    [TestMethod]
    public void FahrenheitTimesFahrenheit()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeFahrenheit);

        //Act
        UnknownUnit T3 = T1 * T2;
        var K3 = T1.As(TemperatureUnit.SI) * T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "6.965e+04 K²");
        Assert.AreEqual(K3, 69646.3823765432);
    }

    [TestMethod]
    public void KelvinTimesKelvin()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.Kelvin);
        Temperature T2 = new(4, TemperatureUnit.Kelvin);

        //Act
        UnknownUnit T3 = T1 * T2;
        var K3 = T1.As(TemperatureUnit.SI) * T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "108 K²");
        Assert.AreEqual(K3, 108);

    }

    /// <summary>
    /// 
    /// </summary>

    [TestMethod]
    public void CelsiusAddFahrenheit()
    {
        //Arrange
        Temperature T1 = new(100, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        Temperature T3 = T2 + T1;
        var K3 = T2.As(TemperatureUnit.SI) + T1.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "588.1 K");
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeFahrenheit), 598.87);
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeCelsius), 314.92777777777775);
        Assert.AreEqual(T3.As(TemperatureUnit.Kelvin), 588.0777777777778);
        Assert.AreEqual(K3, 588.0777777777778);
    }

    [TestMethod]
    public void FahrenheitAddCelsius()
    {
        //Arrange
        Temperature T1 = new(100, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        Temperature T3 = T1 + T2;
        var K3 = T1.As(TemperatureUnit.SI) + T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "1059 °R");
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeFahrenheit), 598.87);
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeCelsius), 314.92777777777775);
        Assert.AreEqual(T3.As(TemperatureUnit.Kelvin), 588.0777777777778);
        Assert.AreEqual(K3, 588.0777777777778);
    }

    [TestMethod]
    public void CelsiusAddCelsius()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        Temperature T3 = T1 + T2;
        var K3 = T1.As(TemperatureUnit.SI) + T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "577.3 K");
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeCelsius), 304.15);
        Assert.AreEqual(T3.As(TemperatureUnit.Kelvin), 577.3);
        Assert.AreEqual(K3, 577.3);
    }

    [TestMethod]
    public void FahrenheitAddFahrenheit()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeFahrenheit);

        //Act
        Temperature T3 = T1 + T2;
        var K3 = T1.As(TemperatureUnit.SI) + T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "950.3 °R");
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeFahrenheit), 490.67);
        Assert.AreEqual(T3.As(TemperatureUnit.Kelvin), 527.9666666666667);
        Assert.AreEqual(K3, 527.9666666666667);
    }

    [TestMethod]
    public void KelvinAddKelvin()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.Kelvin);
        Temperature T2 = new(4, TemperatureUnit.Kelvin);

        //Act
        Temperature T3 = T1 + T2;
        var K3 = T1.As(TemperatureUnit.SI) + T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3, new(31, TemperatureUnit.Kelvin));
        Assert.AreEqual(T3.ToString(), "31 K");
        Assert.AreEqual(K3, 31);

    }

    [TestMethod]
    public void CelsiusMinusFahrenheit()
    {
        //Arrange
        Temperature T1 = new(100, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        Temperature T3 = T2 - T1;
        var K3 = T2.As(TemperatureUnit.SI) - T1.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "-33.78 K");
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeFahrenheit), -520.46999999999991);
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeCelsius), -306.92777777777775);
        Assert.AreEqual(T3.As(TemperatureUnit.Kelvin), -33.777777777777779);
        Assert.AreEqual(K3, -33.777777777777828);
    }

    [TestMethod]
    public void FahrenheitMinusCelsius()
    {
        //Arrange
        Temperature T1 = new(100, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        Temperature T3 = T1 - T2;
        var K3 = T1.As(TemperatureUnit.SI) - T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "60.8 °R");
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeFahrenheit), -398.87);
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeCelsius), -239.37222222222223);
        Assert.AreEqual(T3.As(TemperatureUnit.Kelvin), 33.777777777777779);
        Assert.AreEqual(K3, 33.777777777777828);
    }

    [TestMethod]
    public void CelsiusMinusCelsius()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(4, TemperatureUnit.DegreeCelsius);

        //Act
        Temperature T3 = T1 - T2;
        var K3 = T1.As(TemperatureUnit.SI) - T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "23 K");
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeCelsius), -250.15);
        Assert.AreEqual(T3.As(TemperatureUnit.Kelvin), 23);
        Assert.AreEqual(K3, 23);
    }

    [TestMethod]
    public void FahrenheitMinusFahrenheit()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.DegreeFahrenheit);
        Temperature T2 = new(4, TemperatureUnit.DegreeFahrenheit);

        //Act
        Temperature T3 = T1 - T2;
        var K3 = T1.As(TemperatureUnit.SI) - T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "23 °R");
        Assert.AreEqual(T3.As(TemperatureUnit.DegreeFahrenheit), -436.67);
        Assert.AreEqual(T3.As(TemperatureUnit.Kelvin), 12.777777777777779);
        Assert.AreEqual(K3, 12.777777777777779, 0.000000001);
    }

    [TestMethod]
    public void KelvinMinusKelvin()
    {
        //Arrange
        Temperature T1 = new(27, TemperatureUnit.Kelvin);
        Temperature T2 = new(4, TemperatureUnit.Kelvin);

        //Act
        Temperature T3 = T1 - T2;
        var K3 = T1.As(TemperatureUnit.SI) - T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3, new(23, TemperatureUnit.Kelvin));
        Assert.AreEqual(T3.ToString(), "23 K");
        Assert.AreEqual(K3, 23);

    }

    [TestMethod]
    public void CelsiusMinusKelvin()
    {
        //Arrange
        Temperature T1 = new(50, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(322, TemperatureUnit.Kelvin);

        //Act
        Temperature T3 = T1 - T2;
        var K3 = T1.As(TemperatureUnit.SI) - T2.As(TemperatureUnit.SI);

        //Assert
        Assert.AreEqual(T3.ToString(), "1.15 K");
        Assert.AreEqual(K3, 1.15, 0.0000001);

    }

    [TestMethod]
    public void TemperatureEqual()
    {
        Temperature T1 = new(20, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(20, TemperatureUnit.DegreeCelsius);

        Assert.AreEqual(T1, T2);

    }

    [TestMethod]
    public void TemperatureNotEqual()
    {
        Temperature T1 = new(20, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(21, TemperatureUnit.DegreeCelsius);

        Assert.AreNotEqual(T1, T2);

    }

    [TestMethod]
    public void TemperatureCelsiusDivideDouble()
    {
        Temperature T1 = new(20, TemperatureUnit.DegreeCelsius);

        T1 /= 10;

        Assert.AreEqual(-243.835, T1.As(TemperatureUnit.DegreeCelsius));
        Assert.AreEqual(29.315, T1.As(TemperatureUnit.Kelvin));

    }

    [TestMethod]
    public void TemperatureCelsiusTimesDouble()
    {
        Temperature T1 = new(20, TemperatureUnit.DegreeCelsius);

        T1 *= 10;

        Assert.AreEqual(2658.35, T1.As(TemperatureUnit.DegreeCelsius));
        Assert.AreEqual(2931.5, T1.As(TemperatureUnit.Kelvin));

    }

    [TestMethod]
    public void TemperatureKelvinTimesDouble()
    {
        Temperature T1 = new(20, TemperatureUnit.Kelvin);

        T1 *= 10;

        Assert.AreEqual(200, T1.As(TemperatureUnit.Kelvin));

    }

    [TestMethod]
    public void TemperatureConvertsFromKelvin()
    {
        Temperature T1 = new(20, TemperatureUnit.Kelvin);

        Assert.AreEqual(-423.67, (double)T1.As(TemperatureUnit.DegreeFahrenheit), 0.00000001);
        Assert.AreEqual(20, T1.As(TemperatureUnit.Kelvin));
        Assert.AreEqual(-253.15, T1.As(TemperatureUnit.DegreeCelsius));
    }

    [TestMethod]
    public void TemperatureConvertsFromCelsius()
    {
        Temperature T1 = new(20, TemperatureUnit.DegreeCelsius);

        Debug.Print($"{T1}");

        Assert.AreEqual(293.15, T1.As(TemperatureUnit.Kelvin));
        Assert.AreEqual(20, T1.As(TemperatureUnit.DegreeCelsius));
        Assert.AreEqual(68, (double)T1.As(TemperatureUnit.DegreeFahrenheit), 0.000001);
    }

    [TestMethod]
    public void TemperatureConvertsFromCelsiusJSON()
    {
        Temperature T1 = new(20, TemperatureUnit.DegreeCelsius);

        var jsonstring = JsonConvert.SerializeObject(T1);
        Temperature? JSON = JsonConvert.DeserializeObject<Temperature>(jsonstring);

        Assert.IsNotNull(JSON);
        Assert.AreEqual(293.15, JSON.As(TemperatureUnit.Kelvin));
        Assert.AreEqual(20, JSON.As(TemperatureUnit.DegreeCelsius));
        Assert.AreEqual(68, (double)JSON.As(TemperatureUnit.DegreeFahrenheit), 0.000001);
    }

    [TestMethod]
    public void TemperatureConvertsFromFahrenheit()
    {
        Temperature T1 = new(20, TemperatureUnit.DegreeFahrenheit);

        Assert.AreEqual(266.48333333333335, (double)T1.As(TemperatureUnit.Kelvin), 0.0000001);
        Assert.AreEqual(-6.666667, (double)T1.As(TemperatureUnit.DegreeCelsius), 0.00001);
        Assert.AreEqual(20, T1.As(TemperatureUnit.DegreeFahrenheit));
    }

    [TestMethod]
    public void TemperatureAdd()
    {

        Temperature T1 = new(20, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(293.15, TemperatureUnit.Kelvin);
        Temperature T3 = new(68, TemperatureUnit.DegreeFahrenheit);

        //Debug.WriteLine($"{T1}");
        Temperature T4 = T1 + T1;
        Temperature T5 = T2 + T2;
        Temperature T6 = T3 + T3;

        Assert.AreEqual(586.3, (double)T4.As(TemperatureUnit.Kelvin), 0.0000001);
        Assert.AreEqual(313.15, (double)T5.As(TemperatureUnit.DegreeCelsius), 0.00001);
        Assert.AreEqual(595.67, (double)T6.As(TemperatureUnit.DegreeFahrenheit));
    }

    [TestMethod]
    public void TemperatureAdd2()
    {

        Temperature T1 = new(0, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(0, TemperatureUnit.Kelvin);
        Temperature T3 = new(0, TemperatureUnit.DegreeFahrenheit);

        //Debug.WriteLine($"{T1}");
        Temperature T4 = T1 + T1;
        Temperature T5 = T2 + T2;
        Temperature T6 = T3 + T3;

        Assert.AreEqual(546.3, (double)T4.As(TemperatureUnit.Kelvin), 0.0000001);
        Assert.AreEqual(0, (double)T5.As(TemperatureUnit.Kelvin), 0.00001);
        Assert.AreEqual(510.7444444444444, (double)T6.As(TemperatureUnit.Kelvin));
    }

    [TestMethod]
    public void TemperatureMultiply()
    {

        Temperature T1 = new(0, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(0, TemperatureUnit.Kelvin);
        Temperature T3 = new(0, TemperatureUnit.DegreeFahrenheit);

        UnknownUnit T4 = T1 * T1;
        _ = T4.ToString();

        UnknownUnit T5 = T2 * T2;
        UnknownUnit T6 = T3 * T3;

        Assert.AreEqual("0 K²", T5.ToString());
        Assert.AreEqual("74610.92 K²", $"{T4:G7}");
        Assert.AreEqual("65214.97 K²", $"{T6:G7}");
    }

    [TestMethod]
    public void TemperatureDivideTemperature()
    {
        Temperature T1 = new(20, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(293.15, TemperatureUnit.Kelvin);
        Temperature T3 = new(68, TemperatureUnit.DegreeFahrenheit);

        //Debug.WriteLine($"{T1}");
        var T4 = (double)(T1 / T1);
        var T5 = (double)(T2 / T2);
        var T6 = (double)(T3 / T3);

        var T7 = (double)(T2 / T1);
        var T8 = (double)(T3 / T2);
        var T9 = (double)(T1 / T3);

        Assert.AreEqual(1, T4, 0);
        Assert.AreEqual(1, T5, 0);
        Assert.AreEqual(1, T6, 0);

        Assert.AreEqual(1, T7, 0);
        Assert.AreEqual(1, T8, 0);
        Assert.AreEqual(1, T9, 0);

    }

    [TestMethod]
    public void TemperatureDivideTemperature2()
    {
        Temperature T1 = new(10, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(10, TemperatureUnit.Kelvin);
        Temperature T3 = new(10, TemperatureUnit.DegreeFahrenheit);

        var T7 = (double)(T2 / T1);
        var T8 = (double)(T3 / T2);
        var T9 = (double)(T1 / T3);
        var T10 = (double)(T3 / T1);

        Assert.AreEqual(0.035316969803990815, T7);
        Assert.AreEqual(26.092777777777776, T8);
        Assert.AreEqual(1.0851661805097197, T9);
        Assert.AreEqual(0.9215178448800204, T10);

    }

    [TestMethod]
    public void TemperatureDisplay()
    {
        var value = 10.75458;

        Temperature T1 = new(value, TemperatureUnit.DegreeCelsius);
        Temperature T2 = new(value, TemperatureUnit.Kelvin);
        Temperature T3 = new(value, TemperatureUnit.DegreeFahrenheit);
        Temperature T4 = T2.ToUnit(TemperatureUnit.DegreeCelsius);
        Temperature T5 = T1.ToUnit(TemperatureUnit.Kelvin);

        Assert.AreEqual("10.75 °C", T1.ToString());
        Assert.AreEqual("10.75 K", T2.ToString());
        Assert.AreEqual("10.75 °F", T3.ToString());
        Assert.AreEqual("-262.4 °C", T4.ToString());
        Assert.AreEqual("283.9 K", T5.ToString());

        Assert.AreEqual("°C", $"{T1:UnitOnly}");
        Assert.AreEqual("K", $"{T2:UnitOnly}");
        Assert.AreEqual("°F", $"{T3:UnitOnly}");
        Assert.AreEqual("°C", $"{T4:UnitOnly}");
        Assert.AreEqual("K", $"{T5:UnitOnly}");

        Assert.AreEqual("11", $"{T1:V2}");
        Assert.AreEqual("10.75", $"{T2:V4}");
        Assert.AreEqual("10.75458", $"{T3:V10}");
        Assert.AreEqual("-262.4", $"{T4:V4}");
        Assert.AreEqual("283.9", $"{T5:V4}");
        Assert.AreEqual("283.9", $"{T5:V5}");

        Assert.AreEqual("11 °C", $"{T1:0.}");
        Assert.AreEqual("11 K", $"{T2:0.}");
        Assert.AreEqual("11 °F", $"{T3:0.}");
        Assert.AreEqual("-262 °C", $"{T4:0.}");
        Assert.AreEqual("284 K", $"{T5:0.}");

        Assert.AreEqual("10.8 °C", $"{T1:0.#}");
        Assert.AreEqual("10.8 K", $"{T2:0.#}");
        Assert.AreEqual("10.8 °F", $"{T3:0.#}");
        Assert.AreEqual("-262.4 °C", $"{T4:0.#}");
        Assert.AreEqual("283.9 K", $"{T5:0.#}");

        Assert.AreEqual("10.75 °C", $"{T1:0.##}");
        Assert.AreEqual("10.75 K", $"{T2:0.##}");
        Assert.AreEqual("10.75 °F", $"{T3:0.##}");
        Assert.AreEqual("-262.4 °C", $"{T4:0.##}");
        Assert.AreEqual("283.9 K", $"{T5:0.##}");

        Assert.AreEqual("10.755 °C", $"{T1:0.###}");
        Assert.AreEqual("10.755 K", $"{T2:0.###}");
        Assert.AreEqual("10.755 °F", $"{T3:0.###}");
        Assert.AreEqual("-262.395 °C", $"{T4:0.###}");
        Assert.AreEqual("283.905 K", $"{T5:0.###}");

        Assert.AreEqual("10.7546 °C", $"{T1:0.####}");
        Assert.AreEqual("10.7546 K", $"{T2:0.####}");
        Assert.AreEqual("10.7546 °F", $"{T3:0.####}");
        Assert.AreEqual("-262.3954 °C", $"{T4:0.####}");
        Assert.AreEqual("283.9046 K", $"{T5:0.####}");

        Assert.AreEqual("10.75458 °C", $"{T1:0.#####}");
        Assert.AreEqual("10.75458 K", $"{T2:0.#####}");
        Assert.AreEqual("10.75458 °F", $"{T3:0.#####}");
        Assert.AreEqual("-262.39542 °C", $"{T4:0.#####}");
        Assert.AreEqual("283.90458 K", $"{T5:0.#####}");

        Assert.AreEqual("10.75458 °C", $"{T1:0.######}");
        Assert.AreEqual("10.75458 K", $"{T2:0.######}");
        Assert.AreEqual("10.75458 °F", $"{T3:0.######}");
        Assert.AreEqual("-262.39542 °C", $"{T4:0.######}");
        Assert.AreEqual("283.90458 K", $"{T5:0.######}");

    }
}
