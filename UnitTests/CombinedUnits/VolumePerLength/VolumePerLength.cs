using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class VolumePerLengthTest
    {



        [TestMethod]
        public void VolumePerLengthAutoTest()
        {
            var A1 = new UnitsNet.VolumePerLength(1, UnitsNet.Units.VolumePerLengthUnit.CubicMeterPerMeter);
            var A2 = new EngineeringUnits.VolumePerLength(1, EngineeringUnits.VolumePerLengthUnit.CubicMeterPerMeter);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<VolumePerLengthUnit>())
            {


                double Error = 1E-5;
                double RelError = 2E-5;

                var UNList = UnitsNet.VolumePerLength.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.VolumePerLengthUnit.PicowattPerCubicFoot) Error = 0.0625;


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


                                );


                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(7, WorkingCompares);

        }
    }
}