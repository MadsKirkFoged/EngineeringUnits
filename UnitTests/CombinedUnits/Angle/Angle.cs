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
    public class AngleTest
    {

        [TestMethod]
        public void AngleAutoTest()
        {
            var A1 = new UnitsNet.Angle(1, UnitsNet.Units.AngleUnit.Degree);
            var A2 = new EngineeringUnits.Angle(1, AngleUnit.Degree);

            int WorkingCompares = 0;


            foreach (var EU in UnitTypebase.ListOf<AngleUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.Angle.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.AngleUnit.SquareMicrometer) Error = 2629720.0009765625;


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
            Assert.AreEqual(14, WorkingCompares);

        }

        [TestMethod]
        public void AngleCanBeZero()
        {
            EngineeringUnits.Angle angle = 0;
            Assert.AreEqual(0, angle);
        }

        [TestMethod]
        public void FromAngle1()
        {
            EngineeringUnits.Angle a1 = EngineeringUnits.Angle.From(1, AngleUnit.Gradian);
            Assert.AreEqual(0.9, a1.Degree);

            EngineeringUnits.Angle a2 = EngineeringUnits.Angle.From(0.9, AngleUnit.Degree);
            Assert.AreEqual(a1, a2);
        }
        [TestMethod]
        public void FromAngle2()
        {
            double? value = null;

            EngineeringUnits.Angle a = EngineeringUnits.Angle.From(value, null);
            Assert.IsNull(a);


        }
        [TestMethod]
        public void FromAngle3()
        {
            double? value = 100;
            EngineeringUnits.Angle a = EngineeringUnits.Angle.From(value, AngleUnit.Degree);
            EngineeringUnits.Angle a2 = EngineeringUnits.Angle.From(value, null);
            Assert.IsNotNull(a);
            Assert.IsNull(a2);

        }

        [TestMethod]
        public void AsLength()
        {
            EngineeringUnits.Angle a = EngineeringUnits.Angle.FromDegree(0.9);
            var m = a.As(AngleUnit.Gradian);
            Assert.AreEqual(1, m);

        }


    }
}