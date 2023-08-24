using CodeGen;
using EngineeringUnits;
using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
//using UnitsNet;

namespace UnitNetcomparing
{
    public class Program
    {
        public static readonly Power P1 = Power.FromSI(10);
        public static readonly Length L1 = Length.FromSI(2);
        public static readonly Temperature T1 = Temperature.FromSI(4);

        private static async Task<MassFlow> TestFucntion()
        {



            

            MassFlow massFlow = new MassFlow(10, MassFlowUnit.KilogramPerSecond);
            MassFlow massFlow1 = massFlow * 0.1 + massFlow;

            Mass m1 = new Mass(1, MassUnit.Kilogram);
            Duration d1 = new Duration(12, DurationUnit.Second);


            MassFlow m3 = m1 / d1;

            massFlow1 += m3;

            await Task.Delay(0);

            return massFlow1;
        }


        public static async Task Main(string[] args)
        {

            SpecificEnergy converterror = new SpecificEnergy(10, SpecificEnergyUnit.SI);

            converterror = null;

            Enthalpy enthalpy = converterror;



            for (int i = 0; i < 10000000; i++)
            {
                var speedtest = P1 / (L1 * T1);
            }


            var MyList = new List<Mass>
            {
                Mass.FromKilogram(43),
                Mass.FromMegapound(2),
                Mass.FromMilligram(77644),
                Mass.FromPound(345)
            };

            Mass Min = MyList.Min();    //7.764e+04 mg
            Mass Max = MyList.Max();    //2 Mlb
            Mass Avg = MyList.Average(); //2.268e+05 kg
            Mass Sum = MyList.Sum();     //9.074e+05 kg
            Mass Mean = MyList.Mean();     //345 lb


            

            //Create new unit
            Length L11 = new(1d, LengthUnit.Meter);

            //Serialize it into JSON 
            string L1AsJSON = JsonConvert.SerializeObject(L11);

            //Deserialize from JSON
            Length BackFromJSON = JsonConvert.DeserializeObject<Length>(L1AsJSON);




            string PrintOut = $"";

            List<string> lllist = new List<string>();

            List<string> assembly = ListOfUnitsForDifferentGenerators.GetListOFAllUnits();

            //List<string> assembly = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass", "Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };

            assembly.Sort();

            foreach (string assemblyName in assembly)
            {
                var t = Type.GetType("EngineeringUnits.Units." + assemblyName + "Unit, EngineeringUnits");
                PrintOut += "\n"+assemblyName+":";
                foreach (var item in t.GetFields(BindingFlags.Static | BindingFlags.Public))
                {

                    PrintOut+=$"[{item.Name}], ";
                }
            }




            double? valueOfT = 10;
            string unit = "Meter";


            Length temp = valueOfT.AddUnit<LengthUnit>(unit);


            Length L111 = Length.FromMeter(10); //10m

            Length L22 = L111.Minimum(Length.FromMeter(5)); //10m
            Length L33 = L111.Minimum(Length.FromMeter(15)); //15m
            Length L44 = L111.Maximum(Length.FromMeter(5)); //5m
            Length L55 = L111.Maximum(Length.FromMeter(15)); //10m


            var PressureTest = new Pressure(1, PressureUnit.Bar, PressureReference.Absolute);
            var PressureTest2 = new Pressure(3, PressureUnit.Bar, PressureReference.Absolute);

            Pressure PressureTest3 = PressureTest2 - PressureTest;

            PressureTest = PressureTest.ToUnit(PressureReference.Gauge);

            string Bara1 = $"{PressureTest:V4}";

            string Bara2 = $"{PressureTest:UnitOnly}";

            //var PressureTest2 = PressureTest.ToUnit(PressureUnit.Pascal);


            var massflow = MassFlow.FromKilogramPerDay(1);

            var massflow2 = MassFlow.FromKilogramPerSecond(1) / 2;



            //var DataTasks = new List<Task<MassFlow>>();
            //for (int i = 0; i < 1000000000; i++)
            //{

            //    DataTasks.Add(TestFucntion());
            //}


            //var returntest = await Task.WhenAll(DataTasks);

            double? nulltest = null;

            UnknownUnit UnknownUnittest = nulltest;


            MassFlow massFlow3 = null;

            //UnknownUnit nulltest = massFlow3;






            MassFlow massFlow = new MassFlow(-10, MassFlowUnit.KilogramPerSecond).Abs();
            MassFlow massFlow2 = new MassFlow(19, MassFlowUnit.KilogramPerSecond);
            var booltest = massFlow == massFlow2;



            MassFlow massFlow1 = massFlow * 0.1;

            massFlow1 = massFlow * 0.1;


            Temperature temperature2 = null;



            if (temperature2 == null)
            {
                
            }

            if (temperature2 is null)
            {

            }

            if (temperature2 is not null)
            {

            }



            List<Power> Mylist = new List<Power>();


            var nullcheck = Mylist.Max();
            var nullcheck2 = nullcheck?.ToUnit(PowerUnit.Watt);

            string nullcheck3 = $"{nullcheck2}";


            Volume Mole = new Volume(10, VolumeUnit.SI);
            Mass Time = new Mass(5, MassUnit.SI);

            SpecificVolume MF = Mole / Time;

            MassFlow testmf = new MassFlow(10, MassFlowUnit.KilogramPerSecond);


            string Text = PressureUnit.DynePerSquareCentimeter.ToString();



            //finding similar units with different naming
            List<string> mylist = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass", "Temperature", "Acceleration", "Angle", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance", "ApparentPower", "Enthalpy", "SpecificHeatCapacity" };
            List<string> list2 = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass", "Temperature", "Acceleration", "Angle", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance", "ApparentPower", "Enthalpy", "SpecificHeatCapacity" };

          
            List<string> re = new List<string>();
            UnitSystem alias1;
            UnitSystem alias2;
            foreach (var item in mylist)
            {
                var t = Type.GetType("EngineeringUnits.Units." + item + "Unit, EngineeringUnits");
                var u = t.GetFields().FirstOrDefault();
                string s="";

                alias1 = ((UnitTypebase)u.GetValue(u)).Unit;
                foreach (var i in list2)
                {
                    var t1 = Type.GetType("EngineeringUnits.Units." + i + "Unit, EngineeringUnits");
                    var u1 = t1.GetFields().FirstOrDefault();

                    alias2 = ((UnitTypebase)u1.GetValue(u1)).Unit;
                    if ((alias2 == alias1) && (item != i))
                    {
                        if (!re.Exists(e => e.EndsWith($"={i},")))
                         
                            re.Add($"{i}={item},"); 
                      
                        
                    }
                }
            }
            // 22 units in the output
           foreach(var i in re)
            {
                Console.WriteLine(i);

            Power P1 = Power.FromKilowatt(10);
            Length L1 = Length.FromChain(2);
            Temperature T1 = Temperature.FromDegreesCelsius(4);

            ThermalConductivity Th = ThermalConductivity.FromBtuPerHourFootFahrenheit(10);


            //for (int k = 0; k < 100000000; k++)
            //{
            //    var test22 = (P1 / (L1 * T1)) + Th;

            //}




            Power p1 = new Power(5,PowerUnit.SI);
            Power p2 = new Power(10, PowerUnit.SI);
            Power p3 = new Power(15, PowerUnit.SI);

  
            UVector v1 = new UVector(p1, p2);
            UVector v2 = v1 + v1;
            Power PDot = UVector.DotProduct(v1, v1);


            UVector v3 = new UVector(p1, p2, p3);
            UVector v4 = new UVector(p2, p2, p2);
            UVector PCross = UVector.CrossProduct(v3, v4);


            //Creating a unit that is not yet cast to a specific unit
            UnknownUnit unknown = Energy.FromSI(10) / Duration.FromSI(10);
            // {1 W}

            //You could cast it to BaseUnit but you lose the nice looking symbols
            BaseUnit baseunit = (BaseUnit)unknown;
            // {1 kgm²/s³}

            //Casting it to a specifig unit. It runs the check and will throw an error if the user set it to a wrong unit
            Power power = unknown;
            //{1 W}

            //Trying to cast to a wrong unit
            //Energy energy = unknown;
            //WrongUnitException

            var Ptest = new Pressure(10m, PressureUnit.Bar);
            var Ptest2 = Ptest.ToUnit(PressureReference.Gauge);
            var Ptest3 = Ptest.ToUnit(PressureReference.Absolute);

            var teststring2 = Ptest2.ToString();
            var teststring4 = Ptest3.ToString();


            Acceleration test121 = new Acceleration(0, AccelerationUnit.SI);

            

            //foreach (var item in AngleUnit.ListOf<AngleUnit>())
            //{

            //    PrintOut += $"[{item}], ";
            //}

            //List<string> lllist = new List<string>();

            //List<string> assembly = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass","Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };
          
            //foreach (string assemblyName in assembly)
            //{
            //    var t = Type.GetType("EngineeringUnits.Units." + assemblyName + "Unit, EngineeringUnits");
            //    PrintOut += "\n"+assemblyName+":";
            //    foreach (var item in t.GetFields()) { 
              
            //    PrintOut+=$"[{item.GetValue(item)}], ";}
            //}
            

            


            //string PrintOut = $"Acceleration: [{AccelerationUnit.SI}]";



            SpecificEntropy S1 = new SpecificEntropy(10, SpecificEntropyUnit.JoulePerKilogramKelvin);
            SpecificHeatCapacity S2 = new SpecificEntropy(10, SpecificEntropyUnit.JoulePerKilogramKelvin);
           // SpecificHeatCapacity S3 = new SpecificHeatCapacity(10, SpecificEntropyUnit.JoulePerKilogramKelvin);
            SpecificHeatCapacity S4 = S1;


            Temperature ResultEvapTemperature = new Temperature(10,TemperatureUnit.DegreeCelsius);

            string jsonString1 = JsonConvert.SerializeObject(ResultEvapTemperature);
            Temperature JSON = JsonConvert.DeserializeObject<Temperature>(jsonString1);



            var teststring = $"{JSON}";





            var area = new Area(10, AreaUnit.SquareMeter).Sqrt();





            Pressure Check = new Pressure(0, PressureUnit.Pascal);
            Pressure Check2 = Pressure.Zero;
            Pressure Check3 = 0;
            Pressure Check4 = new Pressure();

            Debug.Print((Check == Pressure.Zero).ToString());
            Debug.Print((Check != Pressure.Zero).ToString());

            Debug.Print((Check2 == Pressure.Zero).ToString());
            Debug.Print((Check2 != Pressure.Zero).ToString());

            Debug.Print((Check3 == Pressure.Zero).ToString());
            Debug.Print((Check3 != Pressure.Zero).ToString());

            Debug.Print((Check4 == Pressure.Zero).ToString());
            Debug.Print((Check4 != Pressure.Zero).ToString());



            //Temperature T1 = new Temperature(10.572455, TemperatureUnit.DegreeCelsius);

            //This will as standard use 4 significant digits
            string Output1 = T1.ToString(); // 10.57 °C

            //This will as use 5 significant digits
            string Output2 = T1.ToString("S5"); // 10.572 °C

            //Same as ToString but looks better
            string Output3 = $"{T1:S5}"; // 10.572 °C

            //Same as "S4" but without the unit
            string Output4 = $"{T1:V4}"; // 10.57

            //Display the unit without value
            string Output5 = $"{T1:UnitOnly}"; // °C

            //All the normal options can still be used
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            //The build-in "General"
            string Output6 = $"{T1:G1}"; // 1E+01 °C
            string Output7 = $"{T1:G4}"; // 10.57 °C


            int Decimals = 2;
            decimal value = (-0.001111546987m);

            var test = value.DisplaySignificantDigits(Decimals);
            var test2 = value.ToString("S"+Decimals.ToString());



            double inputVal = 300.6544;
            var temperature = new Temperature(inputVal, TemperatureUnit.Kelvin);
            var temperatureConvert = temperature.ToUnit(TemperatureUnit.DegreeCelsius);

            Console.WriteLine($"{inputVal} K is {temperature:##.} or {temperatureConvert:0.#####}");



            //double test = 10;

            //int test2 = (int)10.4545;

            Speed test3 = Length.FromMeter(10) / Duration.FromSecond(1);




            List<double> list = new List<double> { 1, 1.2, 0.2, 1.8, 0.5 };
            Debug.Print(mylist.Min().ToString());
            double lenght = 50; //cm
            double time = 4; //seconds
            double speed = lenght / time; // m/s
            double speed2 = time / lenght; // m/s

            
            
            
            Length lenght2 = Length.FromCentimeter(50);
            Duration time2 = Duration.FromSecond(4);

            Speed speed3 = lenght2 / time2;
            //Speed speed4 = time2 / lenght2;


            Debug.Print($"{speed3}");
            Debug.Print($"{speed3.As(SpeedUnit.MeterPerSecond)}");
            Debug.Print($"{speed3.As(SpeedUnit.MeterPerMinute)}");


            var watch = System.Diagnostics.Stopwatch.StartNew();




            Area SqrtTest = Area.FromSI(9);
            Length L2 = Length.FromSI(-2);
            Length L5 = Length.FromFoot(5);
            Length L6 = Length.FromFoot(-10);
            Length L7 = Length.FromFoot(10);

            List<Length> listofl = new List<Length>() { L2, L5 , L6, L7 };

            var test111 = listofl.Abs();

            foreach (var item in test111)
            {
                Debug.Print($"{item}");
            }



            Debug.Print(L2.Unit.GetHashCode().ToString());
            Debug.Print(L5.Unit.GetHashCode().ToString());
            Debug.Print(L6.Unit.GetHashCode().ToString());
            Debug.Print(L7.Unit.GetHashCode().ToString());


            Area Lmix = L2 * L5;


            Length SqrtTest2 = Lmix.Sqrt();


            var local = Lmix.Unit.ReduceUnits();
            var local2 = Lmix.Unit.ReduceUnitsHard();


            Length L10 = Length.FromSI(10);


            //List<Length> listOfL = new List<Length>();

            //listOfL.Add(L2);
            //listOfL.Add(L5);
            //listOfL.Add(L10);

            //var local = listOfL.RoundDownToNearest(Length.FromSI(1));

            //var test122 = new Density(1, DensityUnit.GramPerCubicCentimeter);


            //Debug.Print(test122.Unit.GetHashCode().ToString());

            Power P2 = Power.FromSI(10);
            //Length L2 = Length.FromSI(2);
            Temperature T2 = Temperature.FromSI(4);

            double ThermalConductivityAsSI = 0;
            double PowerAsSI = P2.SI;
            double LengthAsSI = L2.SI;
            double TemperatureAsSI = T2.SI;

            //Solver or function where calculation speed is critical!
            for (int n = 0; n < 1000000000; n++)
            {
                ThermalConductivityAsSI = PowerAsSI / (LengthAsSI * TemperatureAsSI);
            }

            ThermalConductivity Result = ThermalConductivity.FromSI(ThermalConductivityAsSI);


            //ThermalConductivity test = 0;
           // var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int j = 0; j < 10000000; j++)
            {
                ThermalConductivity TC = P2 / (L2 * T2);
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(elapsedMs.ToString());
            Console.ReadLine();

            }

        }

       


    }
}
