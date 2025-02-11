using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.BaseUnits;

[TestClass]
public class LenghtTests
{

    [TestMethod]
    public void Compare()
    {
        UnitsNet.Length L1 = new(1, UnitsNet.Units.LengthUnit.Mile);
        EngineeringUnits.Length L2 = new(1d, LengthUnit.Mile);

        //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
        Assert.AreEqual(0, L2.As(LengthUnit.Kilometer) - L1.As(UnitsNet.Units.LengthUnit.Kilometer), 4.000000000115023E-06);
        Assert.AreEqual(0, L2.As(LengthUnit.Hectometer) - L1.As(UnitsNet.Units.LengthUnit.Hectometer), 4.0000000002038405E-05);
        Assert.AreEqual(0, L2.As(LengthUnit.Meter) - L1.As(UnitsNet.Units.LengthUnit.Meter), 0.0041);
        Assert.AreEqual(0, L2.As(LengthUnit.Decimeter) - L1.As(UnitsNet.Units.LengthUnit.Decimeter), 0.041);
        Assert.AreEqual(0, L2.As(LengthUnit.Centimeter) - L1.As(UnitsNet.Units.LengthUnit.Centimeter), 0.4);
        Assert.AreEqual(0, L2.As(LengthUnit.Millimeter) - L1.As(UnitsNet.Units.LengthUnit.Millimeter), 4);
        Assert.AreEqual(0, L2.As(LengthUnit.Micrometer) - L1.As(UnitsNet.Units.LengthUnit.Micrometer), 4000);
        Assert.AreEqual(0, L2.As(LengthUnit.Nanometer) - L1.As(UnitsNet.Units.LengthUnit.Nanometer), 4000001);
        Assert.AreEqual(0, L2.As(LengthUnit.Inch) - L1.As(UnitsNet.Units.LengthUnit.Inch), 0.16);
        Assert.AreEqual(0, L2.As(LengthUnit.Hand) - L1.As(UnitsNet.Units.LengthUnit.Hand), 0.04);
        Assert.AreEqual(0, L2.As(LengthUnit.Foot) - L1.As(UnitsNet.Units.LengthUnit.Foot), 0.014);
        Assert.AreEqual(0, L2.As(LengthUnit.Yard) - L1.As(UnitsNet.Units.LengthUnit.Yard), 0.0044);
        Assert.AreEqual(0, L2.As(LengthUnit.Chain) - L1.As(UnitsNet.Units.LengthUnit.Chain), 0.0002);
        Assert.AreEqual(0, L2.As(LengthUnit.Mile) - L1.As(UnitsNet.Units.LengthUnit.Mile), 0);
        Assert.AreEqual(0, L2.As(LengthUnit.NauticalMile) - L1.As(UnitsNet.Units.LengthUnit.NauticalMile), 2.2E-06);
        Assert.AreEqual(0, L2.As(LengthUnit.LightYear) - L1.As(UnitsNet.Units.LengthUnit.LightYear), 4.3E-19);
        Assert.AreEqual(0, L2.As(LengthUnit.AstronomicalUnit) - L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit), 2.74E-14);
        Assert.AreEqual(0, L2.As(LengthUnit.Parsec) - L1.As(UnitsNet.Units.LengthUnit.Parsec), 1.3E-19);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(LengthUnit.AstronomicalUnit),
                                    L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit)), 0.0003);
        Assert.AreEqual(0, HelperClass.Percent(L2.As(LengthUnit.Centimeter),
                        L1.As(UnitsNet.Units.LengthUnit.Centimeter)), 0.0003);
        Assert.AreEqual(0, HelperClass.Percent(L2.As(LengthUnit.Centimeter),
            L1.As(UnitsNet.Units.LengthUnit.Centimeter)), 0.0003);

        Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometer(435).Meter, 0);
        Assert.AreEqual(0, UnitsNet.Length.FromFeet(4356).Meters - EngineeringUnits.Length.FromFoot(4356).Meter, 0);
        Assert.AreEqual(0, UnitsNet.Length.FromYards(95.65).Miles - EngineeringUnits.Length.FromYard(95.65).Mile, 1.4E-07);
        Assert.AreEqual(0, UnitsNet.Length.FromInches(95.6322325).Feet - EngineeringUnits.Length.FromInch(95.6322325).Foot, 0);
        Assert.AreEqual(0, UnitsNet.Length.FromMeters(4454678.945678).Feet - EngineeringUnits.Length.FromMeter(4454678.945678).Foot, 0);

    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Length(65.743, UnitsNet.Units.LengthUnit.Inch);
        var A2 = new EngineeringUnits.Length(65.743, LengthUnit.Inch);

        var WorkingCompares = 0;

        foreach (LengthUnit EU in UnitTypebase.ListOf<LengthUnit>())
        {

            var Error = 1E-5;
            var RelError = 3E-4;

            IEnumerable<UnitsNet.Units.LengthUnit> UNList = UnitsNet.Length.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.LengthUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.LengthUnit.SquareMicrometer) Error = 2629720.0009765625;

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
        Assert.AreEqual(31, WorkingCompares);

    }

    [TestMethod]
    public void LengthTimesDouble()
    {
        Length L1 = new(65.948443434, LengthUnit.Meter);

        L1 *= 10;

        Assert.AreEqual(65948.443434, L1.As(LengthUnit.Centimeter));
        Assert.AreEqual(659484.43434, L1.As(LengthUnit.Millimeter));
        Assert.AreEqual(659.48443434, L1.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void LengthTimesDouble2()
    {
        Length L1 = new(65.948443434, LengthUnit.Yard);

        L1 *= 10;

        Assert.AreEqual(659.48443434, L1.As(LengthUnit.Yard));
        Assert.AreEqual(603.032566760496, L1.As(LengthUnit.Meter));
        Assert.AreEqual(23741.43963624, L1.As(LengthUnit.Inch));
        Assert.AreEqual(1978.45330302, L1.As(LengthUnit.Foot));
    }

    [TestMethod]
    public void LengthTimesDouble3()
    {
        Length L1 = new(65.948443434, LengthUnit.Yard);

        L1 = 10 * L1;

        Assert.AreEqual(659.48443434, L1.As(LengthUnit.Yard));
        Assert.AreEqual(603.032566760496, L1.As(LengthUnit.Meter));
        Assert.AreEqual(23741.43963624, L1.As(LengthUnit.Inch));
        Assert.AreEqual(1978.45330302, L1.As(LengthUnit.Foot));
    }

    [TestMethod]
    public void LengthDivideDouble()
    {
        Length L1 = new(65.948443434, LengthUnit.Meter);

        L1 /= 10;

        Assert.AreEqual(659.48443434, L1.As(LengthUnit.Centimeter));
        Assert.AreEqual(6594.8443434, L1.As(LengthUnit.Millimeter));
        Assert.AreEqual(6.5948443434, L1.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void LengthSI2SI()
    {
        Length L1 = new(65.948443434, LengthUnit.Meter);

        Assert.AreEqual(6594.8443434, L1.As(LengthUnit.Centimeter));
        Assert.AreEqual(65948.443434, L1.As(LengthUnit.Millimeter));
        Assert.AreEqual(65.948443434, L1.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void LengthSI2SI2()
    {
        Length L1 = new(659484434, LengthUnit.Kilometer);

        Assert.AreEqual(65948443400000, L1.As(LengthUnit.Centimeter));
        Assert.AreEqual(659484434000000, L1.As(LengthUnit.Millimeter));
        Assert.AreEqual(659484434000, L1.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void LengthIP2IP()
    {
        Length L1 = new(1, LengthUnit.Mile);

        Assert.AreEqual(1, L1.As(LengthUnit.Mile));
        Assert.AreEqual(1760, L1.As(LengthUnit.Yard));
        Assert.AreEqual(5280, L1.As(LengthUnit.Foot));
        Assert.AreEqual(63360, L1.As(LengthUnit.Inch));
    }

    [TestMethod]
    public void LengthIP2SI()
    {
        Length L1 = new(1, LengthUnit.Mile);

        Assert.AreEqual(160934.4, L1.As(LengthUnit.Centimeter));
        Assert.AreEqual(1609344, L1.As(LengthUnit.Millimeter));
        Assert.AreEqual(1609.344, L1.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void LengthAddDifferent()
    {
        Length L1 = new(3.87, LengthUnit.Inch);
        Length L2 = new(2.78, LengthUnit.Meter);

        Length L3 = L1 + L2;
        Length L4 = L2 + L1;

        Assert.AreEqual(287.8298, L3.As(LengthUnit.Centimeter), 0.0000001);
        Assert.AreEqual(113.31881889763779527559055118, L3.As(LengthUnit.Inch));
        Assert.AreEqual(287.8298, L4.As(LengthUnit.Centimeter));
        Assert.AreEqual(113.31881889763779527559055118, L4.As(LengthUnit.Inch));

    }

    [TestMethod]
    public void LengthAddToExactNumber()
    {
        Length L1 = new(1000, LengthUnit.Inch);
        Length L2 = new(10000, LengthUnit.Yard);

        Length L3 = L1 + L2;
        Length L4 = L2 + L1;
        Length L5 = L1 + L1;
        Length L6 = L2 + L2;

        Assert.AreEqual(361000, L3.As(LengthUnit.Inch));
        Assert.AreEqual(361000, L4.As(LengthUnit.Inch));
        Assert.AreEqual(2000, L5.As(LengthUnit.Inch));
        Assert.AreEqual(720000, L6.As(LengthUnit.Inch));

    }

    [TestMethod]
    public void LengthSub()
    {
        Length L1 = new(3.87, LengthUnit.Inch);
        Length L2 = new(2.78, LengthUnit.Meter);

        Length L3 = L2 - L1;

        Assert.AreEqual(268.1702, L3.As(LengthUnit.Centimeter));
        Assert.AreEqual(105.57881889763779, L3.As(LengthUnit.Inch));

    }

    [TestMethod]
    public void LengthDivide()
    {
        Length L1 = new(3.87, LengthUnit.Inch);
        Length L2 = new(2.78, LengthUnit.Meter);

        Length L3 = new(9, LengthUnit.Meter);
        Length L4 = new(3, LengthUnit.Meter);

        Length L5 = new(80, LengthUnit.Inch);
        Length L6 = new(20, LengthUnit.Inch);

        Assert.AreEqual(0.0353589928057554, (double)(L1 / L2));
        Assert.AreEqual(28.281348552361187, (double)(L2 / L1));

        Assert.AreEqual(1, (double)(L1 / L1));
        Assert.AreEqual(1, (double)(L2 / L2));

        Assert.AreEqual(3, (double)(L3 / L4));
        Assert.AreEqual(4, (double)(L5 / L6));
    }

    [TestMethod]
    public void LengthDivide2()
    {

        Length L1 = new(200, LengthUnit.Centimeter);
        Length L2 = new(3, LengthUnit.Foot);

        UnknownUnit A1 = L1 * L1 * L1 / (L2 * L2);

        Debug.Print($"{A1}");

        //Assert.AreEqual(1, A1.));
        //Assert.AreEqual(1, (double)(L2 / L2));

        //Assert.AreEqual(0.035358992805755406, (double)(L1 / L2), 0.000000001);
        //Assert.AreEqual(28.281348552361187, (double)(L2 / L1), 0.000000001);

        //Assert.AreEqual(3, (double)(L3 / L4));
        //Assert.AreEqual(4, (double)(L5 / L6));
    }

    [TestMethod]
    public void LengthMultiply2()
    {
        Length L1 = new(3, LengthUnit.Inch);
        Length L2 = new(2, LengthUnit.Meter);
        _ = L1 * 10 / L1;
        UnknownUnit test14 = L1 * 10;
        _ = test14/ L1;

        //Make a crazy series
        _ = L1 * L1;
        _ = L1 * L1;
        _ = L1 * L1 * L1;
        _ = L1 * L1 * L1 * L1;
        _ = L1 * L1 * L1 * L1 * L1;
        _ = L1 * L1 * L1 * L1 * L1 * 50;
        _ = L1 * L1 * L1 * L1 * L1 / 100;
        _ = L1 / 100;
        _ = 100 / L1;
        _ = 100 * L1;
        _ = L1 * 100;
        _ = L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 / (L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1 * L1);
        _ = L1 * L1;
        _ = L2 * L2;
        _ = L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1 - L1 + (L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1);
        //var test12 = (((L1 * 10) / L1) * 10 * L1 / 10 / 10 / 10 / L1 * 10 * L1 - L1 - L1 - L1 - L1 - L1) + (L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1 + L1);

        //Assert.AreEqual(1, A1.To(LengthUnits.Centimeter));
        //Assert.AreEqual(1, L2 / L2);

    }

    [TestMethod]
    public void LengthOperators()
    {
        Length L1 = new(5, LengthUnit.Meter);
        Length L2 = new(2, LengthUnit.Inch);
        Length L4 = new(2, LengthUnit.Inch);

        Length L3 = L1;

        Assert.IsTrue(L1 == L3);
        Assert.IsTrue(L3 == L1);

        Assert.IsFalse(L1 == L2);
        Assert.IsTrue(L1 != L2);

        Assert.IsFalse(L1 != L3);
        Assert.IsFalse(L3 != L1);

        Assert.IsTrue(L1 != L2);
        Assert.IsTrue(L2 != L1);

        Assert.IsTrue(L1 > L2);
        Assert.IsFalse(L1 > L3);
        Assert.IsFalse(L1 < L3);

        Assert.IsTrue(L1 >= L2);
        Assert.IsTrue(L2 >= L4);

        Assert.IsFalse(L1 <  L2);
        Assert.IsFalse(L1 <= L2);

        Assert.IsFalse(L2 > L1);
        Assert.IsFalse(L2 >= L1);

        Assert.IsTrue(L2 < L1);
        Assert.IsTrue(L2 <= L1);
        Assert.IsTrue(L2 <= L4);

        Assert.IsTrue(L1 * L1 == L3 * L3);
        Assert.IsTrue(L3 * L3 == L1 * L1);

        Assert.IsTrue(L1 * L1 > L2 * L2);
        Assert.IsTrue(L1 * L1 >= L2 * L2);
        Assert.IsFalse(L1 * L1 < L2 * L2);
        Assert.IsFalse(L1 * L1 <= L2 * L2);

        Assert.IsFalse(L2 * L2 > L1 * L1);
        Assert.IsFalse(L2 * L2 >= L1 * L1);
        Assert.IsTrue(L2 * L2 < L1 * L1);
        Assert.IsTrue(L2 * L2 <= L1 * L1);
        UnknownUnit add = L1 + L3;
        Assert.IsTrue(L1 + L1 == add);
        UnknownUnit subtract = L1 - L3;
        Assert.IsTrue(subtract == L1 - L1);
        Assert.IsFalse(add < subtract);

        Assert.IsTrue(L1.Equals(L3));
        object test = L3;
        Assert.IsTrue(L1.Equals(test));

        object? nullObj = null;
        Assert.IsFalse(L1.Equals(nullObj));
    }

    [TestMethod]
    public void UnknownOperators()
    {
        var L1 = new Length(5, LengthUnit.Meter).ToUnknownUnit();
        var L2 = new Length(2, LengthUnit.Inch).ToUnknownUnit();
        var L4 = new Length(2, LengthUnit.Inch).ToUnknownUnit();

        UnknownUnit L3 = L1;

        Assert.IsTrue(L1 == L3);
        Assert.IsTrue(L3 == L1);

        Assert.IsFalse(L1 == L2);
        Assert.IsTrue(L1 != L2);

        Assert.IsFalse(L1 != L3);
        Assert.IsFalse(L3 != L1);

        Assert.IsTrue(L1 != L2);
        Assert.IsTrue(L2 != L1);

        Assert.IsTrue(L1 > L2);
        Assert.IsFalse(L1 > L3);
        Assert.IsFalse(L1 < L3);

        Assert.IsTrue(L1 >= L2);
        Assert.IsTrue(L2 >= L4);

        Assert.IsFalse(L1 < L2);
        Assert.IsFalse(L1 <= L2);

        Assert.IsFalse(L2 > L1);
        Assert.IsFalse(L2 >= L1);

        Assert.IsTrue(L2 < L1);
        Assert.IsTrue(L2 <= L1);
        Assert.IsTrue(L2 <= L4);

        Assert.IsTrue(L1 * L1 == L3 * L3);
        Assert.IsTrue(L3 * L3 == L1 * L1);

        Assert.IsTrue(L1 * L1 > L2 * L2);
        Assert.IsTrue(L1 * L1 >= L2 * L2);
        Assert.IsFalse(L1 * L1 < L2 * L2);
        Assert.IsFalse(L1 * L1 <= L2 * L2);

        Assert.IsFalse(L2 * L2 > L1 * L1);
        Assert.IsFalse(L2 * L2 >= L1 * L1);
        Assert.IsTrue(L2 * L2 < L1 * L1);
        Assert.IsTrue(L2 * L2 <= L1 * L1);
        UnknownUnit add = L1 + L3;
        Assert.IsTrue(L1 + L1 == add);
        UnknownUnit subtract = L1 - L3;
        Assert.IsTrue(subtract == L1 - L1);
        Assert.IsFalse(add < subtract);
    }

    [TestMethod]
    public void LengthJSON()
    {
        Length L1 = new(1, LengthUnit.Mile);

        var jsonstring = JsonConvert.SerializeObject(L1);

        Length? JSON = JsonConvert.DeserializeObject<Length>(jsonstring);

        Assert.IsNotNull(JSON);
        Assert.AreEqual(160934.4, JSON.As(LengthUnit.Centimeter));
        Assert.AreEqual(1609344, JSON.As(LengthUnit.Millimeter));
        Assert.AreEqual(1609.344, JSON.As(LengthUnit.Meter));

    }

    [TestMethod]
    public void FromLength1()
    {
        var l1 = Length.From(100, LengthUnit.Centimeter);
        Assert.AreEqual(1, l1.Meter);

        var l2 = Length.From(1, LengthUnit.Meter);
        Assert.AreEqual(l1, l2);
    }

    [TestMethod]
    public void FromLength2()
    {
        double? value = null;
        var l = Length.From(value, null);
        Assert.IsNull(l);

    }

    [TestMethod]
    public void FromLength3()
    {
        double? value = 100;
        var l = Length.From(value, LengthUnit.Centimeter);
        var l2 = Length.From(value, null);
        Assert.IsNotNull(l);
        Assert.IsNull(l2);

    }

    [TestMethod]
    public void AsLength()
    {
        var l = Length.FromFoot(6);
        var m = l.As(LengthUnit.Meter);
        Assert.AreEqual(1.8288, m);

    }

    [TestMethod]
    public void ConvertLengthTest()
    {
        var meter = Length.FromMeter(100);
        Assert.AreEqual(meter, Length.FromHectometer(1));
        Assert.AreEqual(meter, Length.FromDecimeter(1000));
        Assert.AreEqual(meter, Length.FromMillimeter(100000));
    }

    //add test for + operator for unknownunit and length
    [TestMethod]
    public void AddOperatorUnknownUnitAndLength()
    {

        Length length = new(1, LengthUnit.Meter);
        var unknownUnit = Length.FromMeter(2).ToUnknownUnit();

        UnknownUnit unknownUnit2 = unknownUnit + length;
        Length length2 = length + unknownUnit;

        Assert.IsTrue(unknownUnit2 == length2);

        Assert.IsTrue(Length.FromMeter(3) == unknownUnit2);
        Assert.IsTrue(Length.FromMeter(3) == length2);
    }

    //add test for - operator for unknownunit and length
    [TestMethod]
    public void MinusOperatorUnknownUnitAndLength()
    {

        Length length = new(1, LengthUnit.Meter);
        var unknownUnit = Length.FromMeter(2).ToUnknownUnit();

        UnknownUnit unknownUnit2 = unknownUnit - length;
        Length length2 = length - unknownUnit;

        Assert.IsFalse(unknownUnit2 == length2);

        Assert.IsTrue(Length.FromMeter(1) == unknownUnit2);
        Assert.IsTrue(Length.FromMeter(-1) == length2);
    }
}
