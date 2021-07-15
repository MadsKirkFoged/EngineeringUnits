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
    public class MathDensity
    {

        [TestMethod]
        public void DensityAdding()
        {
            var U0 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.DecigramPerLiter);
            var U1 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.GramPerMilliliter);
            var U2 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.SlugPerCubicFoot);
            var U3 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.GramPerCubicMeter);
            var U4 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.KilogramPerCubicMeter);
            var U5 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.KilopoundPerCubicInch);
            var U6 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.PoundPerCubicInch);
            var U7 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.TonnePerCubicMeter);
            var U8 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.KilopoundPerCubicInch);
            var U9 = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.PoundPerCubicInch);


            var E0 = new EngineeringUnits.Density(1, DensityUnit.DecigramPerLiter);
            var E1 = new EngineeringUnits.Density(1, DensityUnit.GramPerMilliliter);
            var E2 = new EngineeringUnits.Density(1, DensityUnit.SlugPerCubicFoot);
            var E3 = new EngineeringUnits.Density(1, DensityUnit.GramPerCubicMeter);
            var E4 = new EngineeringUnits.Density(1, DensityUnit.KilogramPerCubicMeter);
            var E5 = new EngineeringUnits.Density(1, DensityUnit.KilopoundPerCubicInch);
            var E6 = new EngineeringUnits.Density(1, DensityUnit.PoundPerCubicInch);
            var E7 = new EngineeringUnits.Density(1, DensityUnit.TonnePerCubicMeter);
            var E8 = new EngineeringUnits.Density(1, DensityUnit.KilopoundPerCubicInch);
            var E9 = new EngineeringUnits.Density(1, DensityUnit.PoundPerCubicInch);


            UnitsNet.Density Result1 = U0 - U1 + U2 - U3 + U4 - U5 + U6 - U7 + U8 - U9 + U0 - U1 + U2 - U3 + U4 - U5 + U6 - U7 + U8 - U9 + U0 - U1 + U2 - U3 + U4 - U5 + U6 - U7 + U8 - U9;
            EngineeringUnits.Density Result2 = E0 - E1 + E2 - E3 + E4 - E5 + E6 - E7 + E8 - E9 + E0 - E1 + E2 - E3 + E4 - E5 + E6 - E7 + E8 - E9 + E0 - E1 + E2 - E3 + E4 - E5 + E6 - E7 + E8 - E9; ;

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<DensityUnit>())
            {



                double RelError = 3E-4;

                var UNList = UnitsNet.Density.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();



                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(Result2.As(EU),
                                                            Result1.As(UN)),
                                                            RelError);
                  

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(40, WorkingCompares);

        }

        [TestMethod]
        public void DensityMultiply()
        {
            var massU = new UnitsNet.Mass(1, UnitsNet.Units.MassUnit.Pound);
            var lengthU = new UnitsNet.Length(1, UnitsNet.Units.LengthUnit.Inch);
            var areaU = new UnitsNet.Area(1, UnitsNet.Units.AreaUnit.SquareFoot);
            var volumeU = new UnitsNet.Volume(1, UnitsNet.Units.VolumeUnit.Liter);
            var densityU = new UnitsNet.Density(1, UnitsNet.Units.DensityUnit.KilogramPerCubicMeter);

            var massE = new EngineeringUnits.Mass(1, EngineeringUnits.Units.MassUnit.Pound);
            var lengthE = new EngineeringUnits.Length(1, EngineeringUnits.Units.LengthUnit.Inch);
            var areaE = new EngineeringUnits.Area(1, EngineeringUnits.Units.AreaUnit.SquareFoot);
            var volumeE = new EngineeringUnits.Volume(1, EngineeringUnits.Units.VolumeUnit.Liter);
            var densityE = new EngineeringUnits.Density(1, EngineeringUnits.Units.DensityUnit.KilogramPerCubicMeter);


            UnitsNet.Density ResultU1 = UnitsNet.Density.FromKilogramsPerCubicMeter(massU.Kilograms / (lengthU.Meters * lengthU.Meters * lengthU.Meters));
            UnitsNet.Density ResultU2 = UnitsNet.Density.FromKilogramsPerCubicMeter(massU.Kilograms / (areaU.SquareMeters * lengthU.Meters));
            UnitsNet.Density ResultU3 = UnitsNet.Density.FromKilogramsPerCubicMeter(massU.Kilograms / (volumeU.CubicMeters));
            UnitsNet.Density Result1 = UnitsNet.Density.FromKilogramsPerCubicMeter((ResultU1.KilogramsPerCubicMeter / ResultU2.KilogramsPerCubicMeter) * ResultU3.KilogramsPerCubicMeter);

            EngineeringUnits.Density ResultE1 = massE / (lengthE * lengthE * lengthE);
            EngineeringUnits.Density ResultE2 = massE / (areaE * lengthE);
            EngineeringUnits.Density ResultE3 = massE / (volumeE);


            EngineeringUnits.Density Result2 = (ResultE1 / ResultE2) * ResultE3;

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<DensityUnit>())
            {



                double RelError = 2E-3;

                var UNList = UnitsNet.Density.Units.Where(x => x.ToString() == EU.QuantityName);


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                
                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(Result2.As(EU),
                                                            Result1.As(UN)),
                                                            RelError);


                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(40, WorkingCompares);

        }
    }
}