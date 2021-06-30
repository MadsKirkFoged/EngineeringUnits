using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class CalcSpeedTest
    {
        [TestMethod]
        public void CreateNewDurationUnit()
        {
            Stopwatch stopwatchUN = new Stopwatch();
            Stopwatch stopwatchEN = new Stopwatch();

            stopwatchUN.Start();
            UnitsNet.Duration A1 = new UnitsNet.Duration(6544444.743, UnitsNet.Units.DurationUnit.Minute);
            stopwatchUN.Stop();

            stopwatchEN.Start();
            EngineeringUnits.Duration A2 = new EngineeringUnits.Duration(6544444.743, EngineeringUnits.DurationUnit.Minute);
            stopwatchEN.Stop();


            Debug.Print($" UnitNets:         { stopwatchUN.ElapsedMilliseconds.ToString()}");
            Debug.Print($" EngineeringUnits: { stopwatchEN.ElapsedMilliseconds.ToString()}");


            Assert.IsTrue( stopwatchUN.ElapsedMilliseconds > stopwatchEN.ElapsedMilliseconds);


        }

        [TestMethod]
        public void CreateNewForcePerLengthUnit()
        {
            Stopwatch stopwatchUN = new Stopwatch();
            Stopwatch stopwatchEN = new Stopwatch();            
            


            stopwatchUN.Start();
            var A1 = new UnitsNet.ForcePerLength(65.743, UnitsNet.Units.ForcePerLengthUnit.DecanewtonPerCentimeter);
            stopwatchUN.Stop();

            stopwatchEN.Start();
            var A2 = new EngineeringUnits.ForcePerLength(65.743, EngineeringUnits.ForcePerLengthUnit.DecanewtonPerCentimeter);
            stopwatchEN.Stop();


            Debug.Print($" UnitNets:         { stopwatchUN.ElapsedMilliseconds.ToString()}");
            Debug.Print($" EngineeringUnits: { stopwatchEN.ElapsedMilliseconds.ToString()}");


            Assert.IsTrue(10 *stopwatchUN.ElapsedMilliseconds > stopwatchEN.ElapsedMilliseconds);


        }


        [TestMethod]
        public void DoCalculation()
        {
            Stopwatch stopwatchUN = new Stopwatch();
            Stopwatch stopwatchEN = new Stopwatch();



            stopwatchUN.Start();
            var M1 = new UnitsNet.Mass(65.743, UnitsNet.Units.MassUnit.Kilopound);
            var V1 = new UnitsNet.Volume(10.457, UnitsNet.Units.VolumeUnit.Liter);
            UnitsNet.Density D1 = M1 / V1;

            stopwatchUN.Stop();

            stopwatchEN.Start();
            var M2 = new EngineeringUnits.Mass(65.743, EngineeringUnits.MassUnit.Kilopound);
            var V2 = new EngineeringUnits.Volume(10.457, EngineeringUnits.VolumeUnit.Liter);
            EngineeringUnits.Density D2 = M2 / V2;

            stopwatchEN.Stop();


            Debug.Print($" UnitNets:         { stopwatchUN.ElapsedMilliseconds.ToString()}");
            Debug.Print($" EngineeringUnits: { stopwatchEN.ElapsedMilliseconds.ToString()}");


            Assert.IsTrue(10 * stopwatchUN.ElapsedMilliseconds > stopwatchEN.ElapsedMilliseconds);


        }

        [TestMethod]
        public void CreateManyPutToList()
        {
            Stopwatch stopwatchUN = new Stopwatch();
            Stopwatch stopwatchEN = new Stopwatch();



            stopwatchUN.Start();
            List<UnitsNet.Power> UNList = new List<UnitsNet.Power>();

            for (int i = 0; i < 100000; i++)
            {
                UNList.Add(new UnitsNet.Power(i, UnitsNet.Units.PowerUnit.Gigawatt));
            }

            stopwatchUN.Stop();



            stopwatchEN.Start();


            List<EngineeringUnits.Power> ENList = new List<EngineeringUnits.Power>();

            for (int i = 0; i < 100000; i++)
            {
                ENList.Add(new EngineeringUnits.Power(i, EngineeringUnits.PowerUnit.Gigawatt));
            }

            stopwatchEN.Stop();


            Debug.Print($" UnitNets:         { stopwatchUN.ElapsedMilliseconds.ToString()}");
            Debug.Print($" EngineeringUnits: { stopwatchEN.ElapsedMilliseconds.ToString()}");


            Assert.IsTrue(100 * stopwatchUN.ElapsedMilliseconds > stopwatchEN.ElapsedMilliseconds);


        }

        [TestMethod]
        public void Adding()
        {
            Stopwatch stopwatchUN = new Stopwatch();
            Stopwatch stopwatchEN = new Stopwatch();



            stopwatchUN.Start();
            var M1 = new UnitsNet.Mass(1, UnitsNet.Units.MassUnit.Kilopound);

            for (int i = 0; i < 20; i++)
            {
                M1 = M1 + M1;
            }


            stopwatchUN.Stop();



            stopwatchEN.Start();

            var M2 = new EngineeringUnits.Mass(1, EngineeringUnits.MassUnit.Kilopound);

            for (int i = 0; i < 20; i++)
            {
                M2 = M2 + M2;
            }

            stopwatchEN.Stop();


            Debug.Print($" UnitNets:         { stopwatchUN.ElapsedMilliseconds.ToString()}");
            Debug.Print($" EngineeringUnits: { stopwatchEN.ElapsedMilliseconds.ToString()}");


            Assert.IsTrue(10 * stopwatchUN.ElapsedMilliseconds > stopwatchEN.ElapsedMilliseconds);


        }




    }
}
