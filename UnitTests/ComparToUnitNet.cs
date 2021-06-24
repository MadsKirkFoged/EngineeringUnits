using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnitsNet;

namespace UnitTests
{
    [TestClass]
    public class ComparToUnitNet
    {


       

        [TestMethod]
        public void AmountCompare()
        {

            UnitsNet.AmountOfSubstance A1 = new UnitsNet.AmountOfSubstance(65.743, UnitsNet.Units.AmountOfSubstanceUnit.Mole);
            EngineeringUnits.AmountOfSubstance A2 = new EngineeringUnits.AmountOfSubstance(65.743, EngineeringUnits.AmountOfSubstanceUnit.Mole);



            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Centimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Centimole), 1E-10);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.CentipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Decimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Decimole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.DecipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Kilomole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.KilopoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Megamole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Megamole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.MicropoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Micromole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Micromole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Millimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Millimole), 1E-10);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.MillipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole), 1E-10);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Mole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Mole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Nanomole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole), 7.7E-06);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.NanopoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole), 1E-7);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.PoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole), 1E-10);



            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromCentimoles(435).Centimoles - EngineeringUnits.AmountOfSubstance.FromCentimoles(435).Centimoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromCentipoundMoles(435).CentipoundMoles - EngineeringUnits.AmountOfSubstance.FromCentipoundMoles(435).CentipoundMoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromDecimoles(435).Decimoles - EngineeringUnits.AmountOfSubstance.FromDecimoles(435).Decimoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromDecipoundMoles(435).DecipoundMoles - EngineeringUnits.AmountOfSubstance.FromDecipoundMoles(435).DecipoundMoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromKilomoles(435).Kilomoles - EngineeringUnits.AmountOfSubstance.FromKilomoles(435).Kilomoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromKilopoundMoles(435).KilopoundMoles - EngineeringUnits.AmountOfSubstance.FromKilopoundMoles(435).KilopoundMoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMegamoles(435).Megamoles - EngineeringUnits.AmountOfSubstance.FromMegamoles(435).Megamoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMicromoles(435).Micromoles - EngineeringUnits.AmountOfSubstance.FromMicromoles(435).Micromoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMicropoundMoles(435).MicropoundMoles - EngineeringUnits.AmountOfSubstance.FromMicropoundMoles(435).MicropoundMoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMillimoles(435).Millimoles - EngineeringUnits.AmountOfSubstance.FromMillimoles(435).Millimoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMillipoundMoles(435).MillipoundMoles - EngineeringUnits.AmountOfSubstance.FromMillipoundMoles(435).MillipoundMoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMoles(435).Moles - EngineeringUnits.AmountOfSubstance.FromMoles(435).Moles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromNanomoles(435).Nanomoles - EngineeringUnits.AmountOfSubstance.FromNanomoles(435).Nanomoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromNanopoundMoles(435).NanopoundMoles - EngineeringUnits.AmountOfSubstance.FromNanopoundMoles(435).NanopoundMoles, 0);
            Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromPoundMoles(435).PoundMoles - EngineeringUnits.AmountOfSubstance.FromPoundMoles(435).PoundMoles, 0);


            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.Centimole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Centimole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.CentipoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.Decimole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Decimole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.DecipoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.Kilomole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.KilopoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.Megamole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Megamole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.Micromole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Micromole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.MicropoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.Millimole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Millimole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.MillipoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.Mole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Mole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.Nanomole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.NanopoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.AmountOfSubstanceUnit.PoundMole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole)), 1E-10);


     
            
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.Centimole).DisplaySymbol(), 
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Centimole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.CentipoundMole).DisplaySymbol(), 
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.Decimole).DisplaySymbol(), 
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Decimole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.DecipoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.Kilomole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.KilopoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.Megamole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Megamole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.Micromole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Micromole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.MicropoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.Millimole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Millimole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.MillipoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.Mole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Mole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.Nanomole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.NanopoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.AmountOfSubstanceUnit.PoundMole).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole).ToString("a"));
           




        }

        [TestMethod]
        public void AmountCompareAutoTest()
        {

            UnitsNet.AmountOfSubstance A1 = new UnitsNet.AmountOfSubstance(65.743, UnitsNet.Units.AmountOfSubstanceUnit.Mole);
            EngineeringUnits.AmountOfSubstance A2 = new EngineeringUnits.AmountOfSubstance(65.743, EngineeringUnits.AmountOfSubstanceUnit.Mole);

            string jsonString = JsonConvert.SerializeObject(A2);
            EngineeringUnits.AmountOfSubstance JSON = JsonConvert.DeserializeObject<EngineeringUnits.AmountOfSubstance>(jsonString);



            for (int i = 0; i < UnitsNet.AmountOfSubstance.Units.Length; i++)
            {

                //Getting Units
                var EU = EngineeringUnits.AmountOfSubstanceUnit.List().ToList()[i];
                var UN = UnitsNet.AmountOfSubstance.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, JSON.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(JSON.As(EU),
                                                        A1.As(UN)), 
                                                        1E-10);
                //All units symbol compare
                Assert.AreEqual(JSON.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }



            [TestMethod]
        public void DurationCompare()
        {

            UnitsNet.Duration A1 = new UnitsNet.Duration(6544444.743, UnitsNet.Units.DurationUnit.Minute);
            EngineeringUnits.Duration A2 = new EngineeringUnits.Duration(6544444.743, EngineeringUnits.DurationUnit.Minute);

            string jsonString = JsonConvert.SerializeObject(A2);
            EngineeringUnits.Duration JSON = JsonConvert.DeserializeObject<EngineeringUnits.Duration>(jsonString);



            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Day) - A1.As(UnitsNet.Units.DurationUnit.Day), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Hour) - A1.As(UnitsNet.Units.DurationUnit.Hour), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Microsecond) - A1.As(UnitsNet.Units.DurationUnit.Microsecond), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Millisecond) - A1.As(UnitsNet.Units.DurationUnit.Millisecond), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Minute) - A1.As(UnitsNet.Units.DurationUnit.Minute), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Nanosecond) - A1.As(UnitsNet.Units.DurationUnit.Nanosecond), 65);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Second) - A1.As(UnitsNet.Units.DurationUnit.Second), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Week) - A1.As(UnitsNet.Units.DurationUnit.Week), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Month30) - A1.As(UnitsNet.Units.DurationUnit.Month30), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.DurationUnit.Year365) - A1.As(UnitsNet.Units.DurationUnit.Year365), 0);


            Assert.AreEqual(0, UnitsNet.Duration.FromDays(435).Days - EngineeringUnits.Duration.FromDays(435).Days, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromHours(435).Hours - EngineeringUnits.Duration.FromHours(435).Hours, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromMicroseconds(435).Microseconds - EngineeringUnits.Duration.FromMicroseconds(435).Microseconds, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromMilliseconds(435).Milliseconds - EngineeringUnits.Duration.FromMilliseconds(435).Milliseconds, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromMinutes(435).Minutes - EngineeringUnits.Duration.FromMinutes(435).Minutes, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromMonths30(435).Months30 - EngineeringUnits.Duration.FromMonths30(435).Months30, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromNanoseconds(435).Nanoseconds - EngineeringUnits.Duration.FromNanoseconds(435).Nanoseconds, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromSeconds(435).Seconds - EngineeringUnits.Duration.FromSeconds(435).Seconds, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromWeeks(435).Weeks - EngineeringUnits.Duration.FromWeeks(435).Weeks, 0);
            Assert.AreEqual(0, UnitsNet.Duration.FromYears365(435).Years365 - EngineeringUnits.Duration.FromYears365(435).Years365, 0);



            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Day),
                                                    A1.As(UnitsNet.Units.DurationUnit.Day)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Hour),
                                                    A1.As(UnitsNet.Units.DurationUnit.Hour)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Microsecond),
                                                    A1.As(UnitsNet.Units.DurationUnit.Microsecond)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Millisecond),
                                                    A1.As(UnitsNet.Units.DurationUnit.Millisecond)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Minute),
                                                    A1.As(UnitsNet.Units.DurationUnit.Minute)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Month30),
                                                    A1.As(UnitsNet.Units.DurationUnit.Month30)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Nanosecond),
                                                    A1.As(UnitsNet.Units.DurationUnit.Nanosecond)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Second),
                                                    A1.As(UnitsNet.Units.DurationUnit.Second)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Week),
                                                    A1.As(UnitsNet.Units.DurationUnit.Week)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent(JSON.As(EngineeringUnits.DurationUnit.Year365),
                                                    A1.As(UnitsNet.Units.DurationUnit.Year365)), 1E-10);



            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Day).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Day).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Hour).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Hour).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Microsecond).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Microsecond).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Millisecond).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Millisecond).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Minute).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Minute).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Month30).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Month30).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Nanosecond).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Nanosecond).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Second).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Second).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Week).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Week).ToString("a"));
            Assert.AreEqual(JSON.ToUnit(EngineeringUnits.DurationUnit.Year365).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.DurationUnit.Year365).ToString("a"));

        }


        [TestMethod]
        public void DurationCompareAutoTest()
        {

            UnitsNet.Duration A1 = new UnitsNet.Duration(65.743, UnitsNet.Units.DurationUnit.Hour);
            EngineeringUnits.Duration A2 = new EngineeringUnits.Duration(65.743, EngineeringUnits.DurationUnit.Hour);

            for (int i = 0; i < UnitsNet.Duration.Units.Length; i++)
            {

                //Getting Units
                var EU = EngineeringUnits.DurationUnit.List().ToList()[i];
                var UN = UnitsNet.Duration.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN),0.04);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-10);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }




        [TestMethod]
        public void ElectriccurrentCompare()
        {

            UnitsNet.ElectricCurrent A1 = new UnitsNet.ElectricCurrent(0.0000546, UnitsNet.Units.ElectricCurrentUnit.Ampere);
            EngineeringUnits.ElectricCurrent A2 = new EngineeringUnits.ElectricCurrent(0.0000546, EngineeringUnits.ElectricCurrentUnit.Ampere);


     
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Ampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Ampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Centiampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Centiampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Kiloampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Kiloampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Megaampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Megaampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Microampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Microampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Milliampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Milliampere), 7E-18);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Nanoampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Nanoampere), 7.3E-12);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Picoampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Picoampere), 0);



            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromAmperes(435).Amperes - EngineeringUnits.ElectricCurrent.FromAmperes(435).Amperes, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromCentiamperes(435).Centiamperes - EngineeringUnits.ElectricCurrent.FromCentiamperes(435).Centiamperes, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromKiloamperes(435).Kiloamperes - EngineeringUnits.ElectricCurrent.FromKiloamperes(435).Kiloamperes, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMegaamperes(435).Megaamperes - EngineeringUnits.ElectricCurrent.FromMegaamperes(435).Megaamperes, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMicroamperes(435).Microamperes - EngineeringUnits.ElectricCurrent.FromMicroamperes(435).Microamperes, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMilliamperes(435).Milliamperes - EngineeringUnits.ElectricCurrent.FromMilliamperes(435).Milliamperes, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromNanoamperes(435).Nanoamperes - EngineeringUnits.ElectricCurrent.FromNanoamperes(435).Nanoamperes, 0);
            Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromPicoamperes(435).Picoamperes - EngineeringUnits.ElectricCurrent.FromPicoamperes(435).Picoamperes, 0);


            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.ElectricCurrentUnit.Ampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Ampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.ElectricCurrentUnit.Centiampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Centiampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.ElectricCurrentUnit.Kiloampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Kiloampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.ElectricCurrentUnit.Megaampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Megaampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.ElectricCurrentUnit.Microampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Microampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.ElectricCurrentUnit.Milliampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Milliampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.ElectricCurrentUnit.Nanoampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Nanoampere)), 1E-10);
            Assert.AreEqual(0, HelperClass.Percent( A2.As(EngineeringUnits.ElectricCurrentUnit.Picoampere),
                                                    A1.As(UnitsNet.Units.ElectricCurrentUnit.Picoampere)), 1E-10);

            Assert.AreEqual(A2.ToUnit(EngineeringUnits.ElectricCurrentUnit.Ampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Ampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.ElectricCurrentUnit.Centiampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Centiampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.ElectricCurrentUnit.Kiloampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Kiloampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.ElectricCurrentUnit.Megaampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Megaampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.ElectricCurrentUnit.Microampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Microampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.ElectricCurrentUnit.Milliampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Milliampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.ElectricCurrentUnit.Nanoampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Nanoampere).ToString("a"));
            Assert.AreEqual(A2.ToUnit(EngineeringUnits.ElectricCurrentUnit.Picoampere).DisplaySymbol(),
                            A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Picoampere).ToString("a"));
           


        }


        [TestMethod]
        public void ElectriccurrentCompareAutoTest()
        {

            UnitsNet.ElectricCurrent A1 = new UnitsNet.ElectricCurrent(65.743, UnitsNet.Units.ElectricCurrentUnit.Ampere);
            EngineeringUnits.ElectricCurrent A2 = new EngineeringUnits.ElectricCurrent(65.743, EngineeringUnits.ElectricCurrentUnit.Ampere);

            for (int i = 0; i < UnitsNet.ElectricCurrent.Units.Length; i++)
            {

                //Getting Units
                var EU = EngineeringUnits.ElectricCurrentUnit.List().ToList()[i];
                var UN = UnitsNet.ElectricCurrent.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-10);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }



        [TestMethod]
        public void Lenghtcompare()
        {
            UnitsNet.Length L1 = new UnitsNet.Length(1, UnitsNet.Units.LengthUnit.Mile);
            EngineeringUnits.Length L2 = new EngineeringUnits.Length(1d, EngineeringUnits.LengthUnit.Mile);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Kilometer) - L1.As(UnitsNet.Units.LengthUnit.Kilometer), 4.000000000115023E-06);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Hectometer) - L1.As(UnitsNet.Units.LengthUnit.Hectometer), 4.0000000002038405E-05);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Meter) - L1.As(UnitsNet.Units.LengthUnit.Meter), 0.0041);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Decimeter) - L1.As(UnitsNet.Units.LengthUnit.Decimeter), 0.041);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Centimeter) - L1.As(UnitsNet.Units.LengthUnit.Centimeter), 0.4);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Millimeter) - L1.As(UnitsNet.Units.LengthUnit.Millimeter), 4);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Micrometer) - L1.As(UnitsNet.Units.LengthUnit.Micrometer), 4000);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Nanometer) - L1.As(UnitsNet.Units.LengthUnit.Nanometer), 4000001);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Inch) - L1.As(UnitsNet.Units.LengthUnit.Inch), 0.16);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Hand) - L1.As(UnitsNet.Units.LengthUnit.Hand), 0.04);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Foot) - L1.As(UnitsNet.Units.LengthUnit.Foot), 0.014);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Yard) - L1.As(UnitsNet.Units.LengthUnit.Yard), 0.0044);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Chain) - L1.As(UnitsNet.Units.LengthUnit.Chain), 0.0002);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Mile) - L1.As(UnitsNet.Units.LengthUnit.Mile), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.NauticalMile) - L1.As(UnitsNet.Units.LengthUnit.NauticalMile), 2.2E-06);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.LightYear) - L1.As(UnitsNet.Units.LengthUnit.LightYear), 4.3E-19);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit) - L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit), 2.74E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Parsec) - L1.As(UnitsNet.Units.LengthUnit.Parsec), 1.3E-19);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit),
                                        L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit)), 0.0003);
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.LengthUnit.Centimeter),
                            L1.As(UnitsNet.Units.LengthUnit.Centimeter)), 0.0003);
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.LengthUnit.Centimeter),
                L1.As(UnitsNet.Units.LengthUnit.Centimeter)), 0.0003);



            Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromFeet(4356).Meters - EngineeringUnits.Length.FromFeet(4356).Meters, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromYards(95.65).Miles - EngineeringUnits.Length.FromYards(95.65).Miles, 1.4E-07);
            Assert.AreEqual(0, UnitsNet.Length.FromInches(95.6322325).Feet - EngineeringUnits.Length.FromInches(95.6322325).Feet, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromMeters(4454678.945678).Feet - EngineeringUnits.Length.FromMeters(4454678.945678).Feet, 0);


        }


        [TestMethod]
        public void LengthCompareAutoTest()
        {

            UnitsNet.Length A1 = new UnitsNet.Length(65.743, UnitsNet.Units.LengthUnit.Inch);
            EngineeringUnits.Length A2 = new EngineeringUnits.Length(65.743, EngineeringUnits.LengthUnit.Inch);

            var EU11 = EngineeringUnits.LengthUnit.List();
            var UN11 = UnitsNet.Length.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Length.Units.Length; i++)
            {

                if (UnitsNet.Length.Units[i] == UnitsNet.Units.LengthUnit.PrinterPica ||
                    UnitsNet.Length.Units[i] == UnitsNet.Units.LengthUnit.PrinterPoint)
                {
                    DiffCount++;
                    continue;
                }



                //Getting Units
                var EU = EngineeringUnits.LengthUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Length.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 1E-5);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a").Replace("NM", "nmi"));

            }
        }


        [TestMethod]
        public void Masscompare()
        {
            UnitsNet.Mass L1 = new UnitsNet.Mass(5674.889, UnitsNet.Units.MassUnit.Kilogram);
            EngineeringUnits.Mass L2 = new EngineeringUnits.Mass(5674.889, EngineeringUnits.MassUnit.Kilogram);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Centigram) - L1.As(UnitsNet.Units.MassUnit.Centigram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Decigram) - L1.As(UnitsNet.Units.MassUnit.Decigram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Decagram) - L1.As(UnitsNet.Units.MassUnit.Decagram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.EarthMass) - L1.As(UnitsNet.Units.MassUnit.EarthMass), 9.5E-20);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Grain) - L1.As(UnitsNet.Units.MassUnit.Grain), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Gram) - L1.As(UnitsNet.Units.MassUnit.Gram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Hectogram) - L1.As(UnitsNet.Units.MassUnit.Hectogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Kilogram) - L1.As(UnitsNet.Units.MassUnit.Kilogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Microgram) - L1.As(UnitsNet.Units.MassUnit.Microgram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Milligram) - L1.As(UnitsNet.Units.MassUnit.Milligram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Nanogram) - L1.As(UnitsNet.Units.MassUnit.Nanogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Ounce) - L1.As(UnitsNet.Units.MassUnit.Ounce), 0.0003);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Pound) - L1.As(UnitsNet.Units.MassUnit.Pound), 1.9E-12);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.ShortTon) - L1.As(UnitsNet.Units.MassUnit.ShortTon), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Stone) - L1.As(UnitsNet.Units.MassUnit.Stone), 0.0008);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Tonne) - L1.As(UnitsNet.Units.MassUnit.Tonne), 0);

            //Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);



        }

        [TestMethod]
        public void MassCompareAutoTest()
        {
            UnitsNet.Mass A1 = new UnitsNet.Mass(65.743, UnitsNet.Units.MassUnit.Kilogram);
            EngineeringUnits.Mass A2 = new EngineeringUnits.Mass(65.743, EngineeringUnits.MassUnit.Kilogram);

            var EU11 = EngineeringUnits.MassUnit.List();
            var UN11 = UnitsNet.Mass.Units;


            int DiffCount = 0;

            for (int i = 0; i < UnitsNet.Mass.Units.Length; i++)
            {

                if (UnitsNet.Mass.Units[i] == UnitsNet.Units.MassUnit.SolarMass)
                    
                {
                    DiffCount++;
                    continue;
                }



                //Getting Units
                var EU = EngineeringUnits.MassUnit.List().ToList()[i - DiffCount];
                var UN = UnitsNet.Mass.Units[i];

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 0.008);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        1E-3);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

            }
        }

        [TestMethod]
        public void Temperaturecompare()
        {
            UnitsNet.Temperature L1 = new UnitsNet.Temperature(657.4, UnitsNet.Units.TemperatureUnit.Kelvin);
            EngineeringUnits.Temperature L2 = new EngineeringUnits.Temperature(657.4, EngineeringUnits.TemperatureUnit.Kelvin);

            string jsonString = JsonConvert.SerializeObject(L2);
            EngineeringUnits.Temperature JSON = JsonConvert.DeserializeObject<EngineeringUnits.Temperature>(jsonString);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, JSON.As(EngineeringUnits.TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 1.2E-13);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, JSON.As(EngineeringUnits.TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 0);


            //Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);



        }

        [TestMethod]
        public void Temperaturecompare2()
        {
            UnitsNet.Temperature L1 = new UnitsNet.Temperature(657.4, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
            EngineeringUnits.Temperature L2 = new EngineeringUnits.Temperature(657.4, EngineeringUnits.TemperatureUnit.DegreeCelsius);



            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 0);





        }

        [TestMethod]
        public void Temperaturecompare3()
        {
            UnitsNet.Temperature L1 = new UnitsNet.Temperature(657.4, UnitsNet.Units.TemperatureUnit.DegreeFahrenheit);
            EngineeringUnits.Temperature L2 = new EngineeringUnits.Temperature(657.4, EngineeringUnits.TemperatureUnit.DegreeFahrenheit);



            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 5.7E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 2.3E-13);





        }

        [TestMethod]
        public void Temperaturecompare4()
        {
            UnitsNet.Temperature L1 = new UnitsNet.Temperature(657.4, UnitsNet.Units.TemperatureUnit.DegreeRankine);
            EngineeringUnits.Temperature L2 = new EngineeringUnits.Temperature(657.4, EngineeringUnits.TemperatureUnit.DegreeRankine);

            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 5.7E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 5.7E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 2.3E-13);


        }

        //[TestMethod]
        //public void TemperatureCompareAutoTest()
        //{
        //    UnitsNet.Temperature A1 = new UnitsNet.Temperature(65.743, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
        //    EngineeringUnits.Temperature A2 = new EngineeringUnits.Temperature(65.743, EngineeringUnits.TemperatureUnit.DegreeCelsius);

        //    var EU11 = EngineeringUnits.TemperatureUnit.List();
        //    var UN11 = UnitsNet.Temperature.Units;


        //    int DiffCount = 0;

        //    for (int i = 0; i < UnitsNet.Temperature.Units.Length; i++)
        //    {

        //        if (UnitsNet.Temperature.Units[i] == UnitsNet.Units.TemperatureUnit.DegreeDelisle ||
        //            UnitsNet.Temperature.Units[i] == UnitsNet.Units.TemperatureUnit.DegreeReaumur ||
        //            UnitsNet.Temperature.Units[i] == UnitsNet.Units.TemperatureUnit.DegreeRoemer ||
        //            UnitsNet.Temperature.Units[i] == UnitsNet.Units.TemperatureUnit.MillidegreeCelsius ||
        //            UnitsNet.Temperature.Units[i] == UnitsNet.Units.TemperatureUnit.SolarTemperature)
        //        {
        //            DiffCount++;
        //            continue;
        //        }



        //        //Getting Units
        //        var EU = EngineeringUnits.TemperatureUnit.List().ToList()[i - DiffCount];
        //        var UN = UnitsNet.Temperature.Units[i];

        //        //All units absolute difference
        //        Assert.AreEqual(0, A2.As(EU) - A1.As(UN), 0.008);

        //        //All units relative difference
        //        Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
        //                                                A1.As(UN)),
        //                                                1E-3);
        //        //All units symbol compare
        //        //Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
        //                       // A1.ToUnit(UN).ToString("a"));

        //    }
        //}



    }
}
