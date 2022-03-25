using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace UnitTests
{
    [TestClass]
    public class ComparToUnitNet
    {


       

        [TestMethod]
        public void AmountCompare()
        {

            UnitsNet.AmountOfSubstance A1 = new(65.743, UnitsNet.Units.AmountOfSubstanceUnit.Mole);
            AmountOfSubstance A2 = new(65.743, AmountOfSubstanceUnit.Mole);



            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Centimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Centimole), 1E-10);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.CentipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Decimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Decimole), 0);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.DecipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Kilomole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole), 0);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.KilopoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Megamole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Megamole), 0);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.MicropoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Micromole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Micromole), 0);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Millimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Millimole), 1E-10);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.MillipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Mole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Mole), 0);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Nanomole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole), 7.7E-06);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.NanopoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole), 1E-7);
            Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.PoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole), 1E-10);



            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromCentimoles(435).Centimoles - AmountOfSubstance.FromCentimole(435).Centimole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromCentipoundMoles(435).CentipoundMoles - AmountOfSubstance.FromCentipoundMole(435).CentipoundMole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromDecimoles(435).Decimoles - AmountOfSubstance.FromDecimole(435).Decimole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromDecipoundMoles(435).DecipoundMoles - AmountOfSubstance.FromDecipoundMole(435).DecipoundMole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromKilomoles(435).Kilomoles - AmountOfSubstance.FromKilomole(435).Kilomole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromKilopoundMoles(435).KilopoundMoles - AmountOfSubstance.FromKilopoundMole(435).KilopoundMole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMegamoles(435).Megamoles - AmountOfSubstance.FromMegamole(435).Megamole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMicromoles(435).Micromoles - AmountOfSubstance.FromMicromole(435).Micromole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMicropoundMoles(435).MicropoundMoles - AmountOfSubstance.FromMicropoundMole(435).MicropoundMole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMillimoles(435).Millimoles - AmountOfSubstance.FromMillimole(435).Millimole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMillipoundMoles(435).MillipoundMoles - AmountOfSubstance.FromMillipoundMole(435).MillipoundMole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMoles(435).Moles - AmountOfSubstance.FromMole(435).Mole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromNanomoles(435).Nanomoles - AmountOfSubstance.FromNanomole(435).Nanomole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromNanopoundMoles(435).NanopoundMoles - AmountOfSubstance.FromNanopoundMole(435).NanopoundMole, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromPoundMoles(435).PoundMoles - AmountOfSubstance.FromPoundMole(435).PoundMole, 0);


            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.Centimole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Centimole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.CentipoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.Decimole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Decimole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.DecipoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.Kilomole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.KilopoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.Megamole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Megamole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.Micromole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Micromole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.MicropoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.Millimole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Millimole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.MillipoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.Mole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Mole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.Nanomole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.NanopoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(AmountOfSubstanceUnit.PoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole)), 1E-10);


     
            
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Centimole).DisplaySymbol(), 
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Centimole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.CentipoundMole).DisplaySymbol(), 
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Decimole).DisplaySymbol(), 
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Decimole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.DecipoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Kilomole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.KilopoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Megamole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Megamole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Micromole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Micromole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.MicropoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Millimole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Millimole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.MillipoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Mole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Mole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Nanomole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.NanopoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.PoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole).ToString("a"));
           




        }

        [TestMethod]
        public void AmountAutoTest()
        {
            var A1 = new UnitsNet.AmountOfSubstance(65.743, UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole);
            var A2 = new EngineeringUnits.AmountOfSubstance(65.743, AmountOfSubstanceUnit.KilopoundMole);

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<AmountOfSubstanceUnit>())
            {


                double Error = 8E-3;
                double RelError = 1E-5;

                var UNList = UnitsNet.AmountOfSubstance.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.AmountOfSubstanceUnit.Nanomole) Error = 4;
                    //if (UN == UnitsNet.Units.AreaUnit.SquareMillimeter) Error = 2.629720000550151;

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
            Assert.AreEqual(15, WorkingCompares);

        }



        [TestMethod]
        public void DurationCompare()
        {

            UnitsNet.Duration A1 = new(6544444.743, UnitsNet.Units.DurationUnit.Minute);
            EngineeringUnits.Duration A2 = new(6544444.743, DurationUnit.Minute);

            string jsonString = JsonConvert.SerializeObject(A2);
            EngineeringUnits.Duration JSON = JsonConvert.DeserializeObject<EngineeringUnits.Duration>(jsonString);



            Assert.AreEqual(0, JSON.As(DurationUnit.Day) - A1.As(UnitsNet.Units.DurationUnit.Day), 0);
            Assert.AreEqual(0, JSON.As(DurationUnit.Hour) - A1.As(UnitsNet.Units.DurationUnit.Hour), 0);
            Assert.AreEqual(0, JSON.As(DurationUnit.Microsecond) - A1.As(UnitsNet.Units.DurationUnit.Microsecond), 0);
            Assert.AreEqual(0, JSON.As(DurationUnit.Millisecond) - A1.As(UnitsNet.Units.DurationUnit.Millisecond), 0);
            Assert.AreEqual(0, JSON.As(DurationUnit.Minute) - A1.As(UnitsNet.Units.DurationUnit.Minute), 0);
            Assert.AreEqual(0, JSON.As(DurationUnit.Nanosecond) - A1.As(UnitsNet.Units.DurationUnit.Nanosecond), 65);
            Assert.AreEqual(0, JSON.As(DurationUnit.Second) - A1.As(UnitsNet.Units.DurationUnit.Second), 0);
            Assert.AreEqual(0, JSON.As(DurationUnit.Week) - A1.As(UnitsNet.Units.DurationUnit.Week), 0);
            Assert.AreEqual(0, JSON.As(DurationUnit.Month30) - A1.As(UnitsNet.Units.DurationUnit.Month30), 0);
            Assert.AreEqual(0, JSON.As(DurationUnit.Year365) - A1.As(UnitsNet.Units.DurationUnit.Year365), 0);


            Assert.AreEqual(0, UnitsNet.Duration.FromDays(435).Days - EngineeringUnits.Duration.FromDay(435).Day, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromHours(435).Hours - EngineeringUnits.Duration.FromHour(435).Hour, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromMicroseconds(435).Microseconds - EngineeringUnits.Duration.FromMicrosecond(435).Microsecond, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromMilliseconds(435).Milliseconds - EngineeringUnits.Duration.FromMillisecond(435).Millisecond, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromMinutes(435).Minutes - EngineeringUnits.Duration.FromMinute(435).Minute, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromMonths30(435).Months30 - EngineeringUnits.Duration.FromMonth30(435).Month30, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromNanoseconds(435).Nanoseconds - EngineeringUnits.Duration.FromNanosecond(435).Nanosecond, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromSeconds(435).Seconds - EngineeringUnits.Duration.FromSecond(435).Second, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromWeeks(435).Weeks - EngineeringUnits.Duration.FromWeek(435).Week, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromYears365(435).Years365 - EngineeringUnits.Duration.FromYear365(435).Year365, 0);



            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Day),
                                                    A1.As(UnitsNet.Units.DurationUnit.Day)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Hour),
                                                    A1.As(UnitsNet.Units.DurationUnit.Hour)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Microsecond),
                                                    A1.As(UnitsNet.Units.DurationUnit.Microsecond)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Millisecond),
                                                    A1.As(UnitsNet.Units.DurationUnit.Millisecond)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Minute),
                                                    A1.As(UnitsNet.Units.DurationUnit.Minute)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Month30),
                                                    A1.As(UnitsNet.Units.DurationUnit.Month30)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Nanosecond),
                                                    A1.As(UnitsNet.Units.DurationUnit.Nanosecond)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Second),
                                                    A1.As(UnitsNet.Units.DurationUnit.Second)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Week),
                                                    A1.As(UnitsNet.Units.DurationUnit.Week)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(DurationUnit.Year365),
                                                    A1.As(UnitsNet.Units.DurationUnit.Year365)), 1E-10);



            //Assert.AreEqual(JSON.ToUnit(DurationUnit.Day).DisplaySymbol(),
            //                A1.ToUnit(UnitsNet.Units.DurationUnit.Day).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(DurationUnit.Hour).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Hour).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(DurationUnit.Microsecond).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Microsecond).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(DurationUnit.Millisecond).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Millisecond).ToString("a"));
            //Assert.AreEqual(JSON.ToUnit(DurationUnit.Minute).DisplaySymbol(),
            //                A1.ToUnit(UnitsNet.Units.DurationUnit.Minute).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(DurationUnit.Month30).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Month30).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(DurationUnit.Nanosecond).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Nanosecond).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(DurationUnit.Second).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Second).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(DurationUnit.Week).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Week).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(DurationUnit.Year365).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Year365).ToString("a"));

        }


        [TestMethod]
        public void DurationAutoTest()
        {
            var A1 = new UnitsNet.Duration(65.743, UnitsNet.Units.DurationUnit.Hour);
            var A2 = new EngineeringUnits.Duration(65.743, DurationUnit.Hour);

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<DurationUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.Duration.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.DurationUnit.Nanosecond) Error = 0.03125;


                    //Debug.Print($"");
                    //Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    //Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    //Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    //Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol()
                                    .Replace("min", "m")
                                    .Replace("day", "d")
                                    ,

                                    A1.ToUnit(UN).ToString("a")
                                    

                                );
                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(10, WorkingCompares);

        }




        [TestMethod]
        public void ElectriccurrentCompare()
        {

            UnitsNet.ElectricCurrent A1 = new(0.0000546, UnitsNet.Units.ElectricCurrentUnit.Ampere);
            EngineeringUnits.ElectricCurrent A2 = new(0.0000546, ElectricCurrentUnit.Ampere);


     
            Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Ampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Ampere), 0);
            Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Centiampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Centiampere), 0);
            Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Kiloampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Kiloampere), 0);
            Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Megaampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Megaampere), 0);
            Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Microampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Microampere), 0);
            Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Milliampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Milliampere), 7E-18);
            Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Nanoampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Nanoampere), 7.3E-12);
            Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Picoampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Picoampere), 0);



            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromAmperes(435).Amperes - EngineeringUnits.ElectricCurrent.FromAmpere(435).Ampere, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromCentiamperes(435).Centiamperes - EngineeringUnits.ElectricCurrent.FromCentiampere(435).Centiampere, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromKiloamperes(435).Kiloamperes - EngineeringUnits.ElectricCurrent.FromKiloampere(435).Kiloampere, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMegaamperes(435).Megaamperes - EngineeringUnits.ElectricCurrent.FromMegaampere(435).Megaampere, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMicroamperes(435).Microamperes - EngineeringUnits.ElectricCurrent.FromMicroampere(435).Microampere, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMilliamperes(435).Milliamperes - EngineeringUnits.ElectricCurrent.FromMilliampere(435).Milliampere, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromNanoamperes(435).Nanoamperes - EngineeringUnits.ElectricCurrent.FromNanoampere(435).Nanoampere, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromPicoamperes(435).Picoamperes - EngineeringUnits.ElectricCurrent.FromPicoampere(435).Picoampere, 0);


            Assert.AreEqual(0, HelperClass.Percent( A2.As(ElectricCurrentUnit.Ampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Ampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(ElectricCurrentUnit.Centiampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Centiampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(ElectricCurrentUnit.Kiloampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Kiloampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(ElectricCurrentUnit.Megaampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Megaampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(ElectricCurrentUnit.Microampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Microampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(ElectricCurrentUnit.Milliampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Milliampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(ElectricCurrentUnit.Nanoampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Nanoampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(ElectricCurrentUnit.Picoampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Picoampere)), 1E-10);

            Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Ampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Ampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Centiampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Centiampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Kiloampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Kiloampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Megaampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Megaampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Microampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Microampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Milliampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Milliampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Nanoampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Nanoampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Picoampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Picoampere).ToString("a"));
           


        }


        [TestMethod]
        public void ElectricCurrentAutoTest()
        {
            var A1 = new UnitsNet.ElectricCurrent(65.743, UnitsNet.Units.ElectricCurrentUnit.Kiloampere);
            var A2 = new EngineeringUnits.ElectricCurrent(65.743, ElectricCurrentUnit.Kiloampere);

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<ElectricCurrentUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.ElectricCurrent.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.ElectricCurrentUnit.Nanoampere) Error = 0.0078125;


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
            Assert.AreEqual(8, WorkingCompares);

        }



        [TestMethod]
        public void Lenghtcompare()
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
        public void LengthAutoTest()
        {
            var A1 = new UnitsNet.Length(65.743, UnitsNet.Units.LengthUnit.Inch);
            var A2 = new EngineeringUnits.Length(65.743, LengthUnit.Inch);

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<LengthUnit>())
            {


                double Error = 1E-5;
                double RelError = 3E-4;

                var UNList = UnitsNet.Length.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

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
        public void Masscompare()
        {
            UnitsNet.Mass L1 = new(5674.889, UnitsNet.Units.MassUnit.Kilogram);
            EngineeringUnits.Mass L2 = new(5674.889, MassUnit.Kilogram);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(MassUnit.Centigram) - L1.As(UnitsNet.Units.MassUnit.Centigram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Decigram) - L1.As(UnitsNet.Units.MassUnit.Decigram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Decagram) - L1.As(UnitsNet.Units.MassUnit.Decagram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.EarthMass) - L1.As(UnitsNet.Units.MassUnit.EarthMass), 9.5E-20);
            Assert.AreEqual(0, L2.As(MassUnit.Grain) - L1.As(UnitsNet.Units.MassUnit.Grain), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Gram) - L1.As(UnitsNet.Units.MassUnit.Gram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Hectogram) - L1.As(UnitsNet.Units.MassUnit.Hectogram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Kilogram) - L1.As(UnitsNet.Units.MassUnit.Kilogram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Microgram) - L1.As(UnitsNet.Units.MassUnit.Microgram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Milligram) - L1.As(UnitsNet.Units.MassUnit.Milligram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Nanogram) - L1.As(UnitsNet.Units.MassUnit.Nanogram), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Ounce) - L1.As(UnitsNet.Units.MassUnit.Ounce), 0.0003);
            Assert.AreEqual(0, L2.As(MassUnit.Pound) - L1.As(UnitsNet.Units.MassUnit.Pound), 1.9E-12);
            Assert.AreEqual(0, L2.As(MassUnit.ShortTon) - L1.As(UnitsNet.Units.MassUnit.ShortTon), 0);
            Assert.AreEqual(0, L2.As(MassUnit.Stone) - L1.As(UnitsNet.Units.MassUnit.Stone), 0.0008);
            Assert.AreEqual(0, L2.As(MassUnit.Tonne) - L1.As(UnitsNet.Units.MassUnit.Tonne), 0);

            //Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);



        }

        [TestMethod]
        public void MassAutoTest()
        {
            var A1 = new UnitsNet.Mass(65.743, UnitsNet.Units.MassUnit.Pound);
            var A2 = new EngineeringUnits.Mass(65.743, MassUnit.Pound);

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<MassUnit>())
            {


                double Error = 1E-5;
                double RelError = 5E-4;

                var UNList = UnitsNet.Mass.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    if (UN == UnitsNet.Units.MassUnit.Nanogram) Error = 0.00390625;


                    //Debug.Print($"");
                    //Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    //Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    //Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    //Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    .Replace("klb", "kip")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(24, WorkingCompares);

        }

        [TestMethod]
        public void Temperaturecompare()
        {
            UnitsNet.Temperature L1 = new(657.4, UnitsNet.Units.TemperatureUnit.Kelvin);
            EngineeringUnits.Temperature L2 = new(657.4, TemperatureUnit.Kelvin);

            string jsonString = JsonConvert.SerializeObject(L2);
            EngineeringUnits.Temperature JSON = JsonConvert.DeserializeObject<EngineeringUnits.Temperature>(jsonString);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, JSON.As(TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 0);
            Assert.AreEqual(0, JSON.As(TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 1.2E-13);
            Assert.AreEqual(0, JSON.As(TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, JSON.As(TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 0);


            //Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);



        }

        [TestMethod]
        public void Temperaturecompare2()
        {
            UnitsNet.Temperature L1 = new(657.4, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
            EngineeringUnits.Temperature L2 = new(657.4, TemperatureUnit.DegreeCelsius);



            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 0);
            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 0);
            Assert.AreEqual(0, L2.As(TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 0);





        }

        [TestMethod]
        public void Temperaturecompare3()
        {
            UnitsNet.Temperature L1 = new(657.4, UnitsNet.Units.TemperatureUnit.DegreeFahrenheit);
            EngineeringUnits.Temperature L2 = new(657.4, TemperatureUnit.DegreeFahrenheit);



            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 5.7E-14);
            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 0);
            Assert.AreEqual(0, L2.As(TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 2.3E-13);





        }

        [TestMethod]
        public void Temperaturecompare4()
        {
            UnitsNet.Temperature L1 = new(657.4, UnitsNet.Units.TemperatureUnit.DegreeRankine);
            EngineeringUnits.Temperature L2 = new(657.4, TemperatureUnit.DegreeRankine);

            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 5.7E-14);
            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 5.7E-14);
            Assert.AreEqual(0, L2.As(TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 2.3E-13);


        }


        [TestMethod]
        public void TemperatureAutoTest()
        {
            var A1 = new UnitsNet.Temperature(65.743, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
            var A2 = new EngineeringUnits.Temperature(65.743, TemperatureUnit.DegreeCelsius);

            int WorkingCompares = 0;


            foreach (var EU in UnitEnumbase.ListOf<TemperatureUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.Temperature.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

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


    }
}
