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
    public class MathAcceleration
    {

        [TestMethod]
        public void AccelerationAdding()
        {
            var A1 = new UnitsNet.Acceleration(1, UnitsNet.Units.AccelerationUnit.FootPerSecondSquared);
            var A2 = new UnitsNet.Acceleration(1, UnitsNet.Units.AccelerationUnit.MicrometerPerSecondSquared);
            var A3 = new EngineeringUnits.Acceleration(1, AccelerationUnit.FootPerSecondSquared);
            var A4 = new EngineeringUnits.Acceleration(1, AccelerationUnit.MicrometerPerSecondSquared);


            var Result1 = A1 + A2;
            EngineeringUnits.Acceleration Result2 = A3 + A4;

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<AccelerationUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.Acceleration.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.AngleUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {Result1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {Result2.As(EU)}");
                    Debug.Print($"ABS:    {Result2.As(EU) - Result1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(Result2.As(EU), Result1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, Result2.As(EU) - Result1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(Result2.As(EU),
                                                            Result1.As(UN)),
                                                            RelError);
                  

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(14, WorkingCompares);

        }

        [TestMethod]
        public void AccelerationMultiply()
        {
            var A1 = new UnitsNet.Length(10, UnitsNet.Units.LengthUnit.Kilometer);
            var A2 = new UnitsNet.Duration(1, UnitsNet.Units.DurationUnit.Minute);
            var A3 = new UnitsNet.Duration(1, UnitsNet.Units.DurationUnit.Hour);


            var A4 = new EngineeringUnits.Length(10, LengthUnit.Kilometer);
            var A5 = new EngineeringUnits.Duration(1, DurationUnit.Minute);
            var A6 = new EngineeringUnits.Duration(1, DurationUnit.Hour);


            UnitsNet.Acceleration Result1 = UnitsNet.Acceleration.FromMetersPerSecondSquared( A1.Meters / (A2.Seconds * A3.Seconds));
            EngineeringUnits.Acceleration Result2 = A4 / (A5 * A6);

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<AccelerationUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.Acceleration.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.AngleUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {Result1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {Result2.As(EU)}");
                    Debug.Print($"ABS:    {Result2.As(EU) - Result1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(Result2.As(EU), Result1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, Result2.As(EU) - Result1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(Result2.As(EU),
                                                            Result1.As(UN)),
                                                            RelError);


                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(14, WorkingCompares);
           

           

        }
    }
}