using Fractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace EngineeringUnits
{
    public class UnitSystem
    {

        [JsonProperty]
        public string Symbol { get; set; }

        public LengthUnit Length { get; set; }
        public MassUnit Mass { get; set; }
        public DurationUnit Duration { get; set; }
        public ElectricCurrentUnit Electriccurrent { get; set; }
        public TemperatureUnit Temperature { get; set; }
        public AmountOfSubstanceUnit Amount { get; set; }
        public LuminousIntensityUnit LuminousIntensity { get; set; }
        public CombinedUnit Combined { get; set; }


        public UnitSystem()
        {
         
        }

        public UnitSystem(string symbol)
        {
            Symbol = symbol;
        }


        public static bool operator ==(UnitSystem a, UnitSystem b)
        {


            if (!Compareunits(a.Length, b.Length) ||
                !Compareunits(a.Mass, b.Mass) ||
                !Compareunits(a.Duration, b.Duration) ||
                !Compareunits(a.Electriccurrent, b.Electriccurrent) ||
                !Compareunits(a.Temperature, b.Temperature) ||
                !Compareunits(a.Amount, b.Amount) ||
                !Compareunits(a.LuminousIntensity, b.LuminousIntensity))
            { 
                return false;            
            }


            return true;


            //Local function
            bool Compareunits(Enumeration a, Enumeration b)
            {

                if (a is object && b is object)
                {
                    if (a.Count != b.Count)                    
                        return false;                    
                }
                else if (a is object)
                {
                    if (a.Count != 0)                    
                        return false;                    
                }
                else if (b is object)
                {
                    if (b.Count != 0)                    
                        return false;                    
                }

                return true;

            }
        }
        public static bool operator !=(UnitSystem a, UnitSystem b)
        {
            return !(a == b);
        }



        public static UnitSystem Add(UnitSystem a, UnitSystem b)
        {

            if (a != b)
            {
                throw new InvalidOperationException($"Failed to do: {a} + {b}. Expected both units to be the same!");
            }

            //Using a unitsystem as the final system
            return a.Copy();
        }

        public static UnitSystem Subtract(UnitSystem a, UnitSystem b)
        {
            if (a != b)
            {
                throw new InvalidOperationException($"Failed to do: {a} - {b}. Expected both units to be the same!");
            }

            //Subtract does the same to a unit as add
            return Add(a, b);

        }
        public static UnitSystem Multiply(UnitSystem a, UnitSystem b)
        {

            UnitSystem local = new UnitSystem();


            if (a.Length is object && b.Length is object)
            {
                local.Length = (LengthUnit)a.Length.Copy();
                local.Length.Count += b.Length.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.Length.LocalC;
                CombinedFraction *= (Fraction)a.Length.GlobalC;

                CombinedFraction /= (Fraction)b.Length.LocalC;
                CombinedFraction /= (Fraction)b.Length.GlobalC;

                //CombinedFraction /= (Fraction)a.Length.LocalC;
                //CombinedFraction /= (Fraction)a.Length.GlobalC;

                //CombinedFraction *= (Fraction)b.Length.LocalC;
                //CombinedFraction *= (Fraction)b.Length.GlobalC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.Length.Count);
                local.Length.ActualC = CombinedFraction;
            }
            else if (a.Length is object)
            {
                local.Length = (LengthUnit)a.Length.Copy();
            }
            else if (b.Length is object)
            {
                local.Length = (LengthUnit)b.Length.Copy();
            }


            if (a.Mass is object && b.Mass is object)
            {
                local.Mass = (MassUnit)a.Mass.Copy();
                local.Mass.Count += b.Mass.Count;


                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.Mass.LocalC;
                CombinedFraction *= (Fraction)a.Mass.GlobalC;

                CombinedFraction /= (Fraction)b.Mass.LocalC;
                CombinedFraction /= (Fraction)b.Mass.GlobalC;

                //CombinedFraction /= (Fraction)a.Mass.LocalC;
                //CombinedFraction /= (Fraction)a.Mass.GlobalC;

                //CombinedFraction *= (Fraction)b.Mass.LocalC;
                //CombinedFraction *= (Fraction)b.Mass.GlobalC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.Mass.Count);
                local.Mass.ActualC = CombinedFraction;



            }
            else if (a.Mass is object)
            {
                local.Mass = (MassUnit)a.Mass.Copy();
            }
            else if (b.Mass is object)
            {
                local.Mass = (MassUnit)b.Mass.Copy();
            }



            if (a.Duration is object && b.Duration is object)
            {
                local.Duration = (DurationUnit)a.Duration.Copy();
                local.Duration.Count += b.Duration.Count;

                Fraction CombinedFraction = 1;
                //CombinedFraction /= (Fraction)a.Duration.LocalC;
                //CombinedFraction /= (Fraction)a.Duration.GlobalC;

                //CombinedFraction *= (Fraction)b.Duration.LocalC;
                //CombinedFraction *= (Fraction)b.Duration.GlobalC;


                CombinedFraction *= (Fraction)a.Duration.LocalC;
                CombinedFraction *= (Fraction)a.Duration.GlobalC;

                CombinedFraction /= (Fraction)b.Duration.LocalC;
                CombinedFraction /= (Fraction)b.Duration.GlobalC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.Duration.Count);
                local.Duration.ActualC = CombinedFraction;
            }
            else if (a.Duration is object)
            {
                local.Duration = (DurationUnit)a.Duration.Copy();
            }
            else if (b.Duration is object)
            {
                local.Duration = (DurationUnit)b.Duration.Copy();
            }




            if (a.Electriccurrent is object && b.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectricCurrentUnit)a.Electriccurrent.Copy();
                local.Electriccurrent.Count += b.Electriccurrent.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.Electriccurrent.LocalC;
                CombinedFraction *= (Fraction)a.Electriccurrent.GlobalC;

                CombinedFraction /= (Fraction)b.Electriccurrent.LocalC;
                CombinedFraction /= (Fraction)b.Electriccurrent.GlobalC;

                //CombinedFraction /= (Fraction)a.Electriccurrent.LocalC;
                //CombinedFraction /= (Fraction)a.Electriccurrent.GlobalC;

                //CombinedFraction *= (Fraction)b.Electriccurrent.LocalC;
                //CombinedFraction *= (Fraction)b.Electriccurrent.GlobalC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.Electriccurrent.Count);
                local.Electriccurrent.ActualC = CombinedFraction;
            }
            else if (a.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectricCurrentUnit)a.Electriccurrent.Copy();
            }
            else if (b.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectricCurrentUnit)b.Electriccurrent.Copy();
            }



            if (a.Temperature is object && b.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
                local.Temperature.Count += b.Temperature.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.Temperature.LocalC;
                CombinedFraction *= (Fraction)a.Temperature.GlobalC;

                CombinedFraction /= (Fraction)b.Temperature.LocalC;
                CombinedFraction /= (Fraction)b.Temperature.GlobalC;

                //CombinedFraction /= (Fraction)a.Temperature.LocalC;
                //CombinedFraction /= (Fraction)a.Temperature.GlobalC;

                //CombinedFraction *= (Fraction)b.Temperature.LocalC;
                //CombinedFraction *= (Fraction)b.Temperature.GlobalC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.Temperature.Count);
                local.Temperature.ActualC = CombinedFraction;
            }
            else if (a.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
            }
            else if (b.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)b.Temperature.Copy();
            }





            if (a.Amount is object && b.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)a.Amount.Copy();
                local.Amount.Count += b.Amount.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.Amount.LocalC;
                CombinedFraction *= (Fraction)a.Amount.GlobalC;

                CombinedFraction /= (Fraction)b.Amount.LocalC;
                CombinedFraction /= (Fraction)b.Amount.GlobalC;

                //CombinedFraction /= (Fraction)a.Amount.LocalC;
                //CombinedFraction /= (Fraction)a.Amount.GlobalC;

                //CombinedFraction *= (Fraction)b.Amount.LocalC;
                //CombinedFraction *= (Fraction)b.Amount.GlobalC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.Amount.Count);
                local.Amount.ActualC = CombinedFraction;
            }
            else if (a.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)a.Amount.Copy();
            }
            else if (b.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)b.Amount.Copy();
            }




            if (a.LuminousIntensity is object && b.LuminousIntensity is object)
            {
                local.LuminousIntensity = (LuminousIntensityUnit)a.LuminousIntensity.Copy();
                local.LuminousIntensity.Count += b.LuminousIntensity.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.LuminousIntensity.LocalC;
                CombinedFraction *= (Fraction)a.LuminousIntensity.GlobalC;

                CombinedFraction /= (Fraction)b.LuminousIntensity.LocalC;
                CombinedFraction /= (Fraction)b.LuminousIntensity.GlobalC;

                //CombinedFraction /= (Fraction)a.LuminousIntensity.LocalC;
                //CombinedFraction /= (Fraction)a.LuminousIntensity.GlobalC;

                //CombinedFraction *= (Fraction)b.LuminousIntensity.LocalC;
                //CombinedFraction *= (Fraction)b.LuminousIntensity.GlobalC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.LuminousIntensity.Count);
                local.LuminousIntensity.ActualC = CombinedFraction;
            }
            else if (a.LuminousIntensity is object)
            {
                local.LuminousIntensity = (LuminousIntensityUnit)a.LuminousIntensity.Copy();
            }
            else if (b.LuminousIntensity is object)
            {
                local.LuminousIntensity = (LuminousIntensityUnit)b.LuminousIntensity.Copy();
            }



            if (a.Combined is object && b.Combined is object)
            {
                local.Combined = a.Combined.Copy();
                local.Combined.Count += b.Combined.Count;
            }
            else if (a.Combined is object)
            {
                local.Combined = a.Combined.Copy();
            }
            else if (b.Combined is object)
            {
                local.Combined = b.Combined.Copy();
            }


            return local;

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            UnitSystem local = new UnitSystem();


            //LENGTH

            if (a.Length is object && b.Length is object)
            {
                local.Length = (LengthUnit)a.Length.Copy();             
                local.Length.Count -= b.Length.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Length.LocalC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.Length.GlobalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Length.LocalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Length.GlobalC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.Length.Count);
                local.Length.ActualC = (1 / CombinedFraction);
            }
            else if (a.Length is object)
            {
                local.Length = (LengthUnit)a.Length.Copy();
            }
            else if (b.Length is object)
            {
                local.Length = (LengthUnit)b.Length.Copy();
                local.Length.Count *= -1;
            }


            //MASS
            if (a.Mass is object && b.Mass is object)
            {
                local.Mass = (MassUnit)a.Mass.Copy();               
                local.Mass.Count -= b.Mass.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Mass.LocalC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.Mass.GlobalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Mass.LocalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Mass.GlobalC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.Mass.Count);
                local.Mass.ActualC = (1 / CombinedFraction);
            }
            else if (a.Mass is object)
            {
                local.Mass = (MassUnit)a.Mass.Copy();
            }
            else if (b.Mass is object)
            {
                local.Mass = (MassUnit)b.Mass.Copy();
                local.Mass.Count *= -1;
            }



            //DURATION
            if (a.Duration is object && b.Duration is object)
            {
                local.Duration = (DurationUnit)a.Duration.Copy();             
                local.Duration.Count -= b.Duration.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Duration.LocalC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.Duration.GlobalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Duration.LocalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Duration.GlobalC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.Duration.Count);
                local.Duration.ActualC = (1 / CombinedFraction);
            }
            else if (a.Duration is object)
            {
                local.Duration = (DurationUnit)a.Duration.Copy();
            }
            else if (b.Duration is object)
            {
                local.Duration = (DurationUnit)b.Duration.Copy();
                local.Duration.Count *= -1;
            }



            //ELECTRICCURRENT
            if (a.Electriccurrent is object && b.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectricCurrentUnit)a.Electriccurrent.Copy();
                local.Electriccurrent.Count -= b.Electriccurrent.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Electriccurrent.LocalC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.Electriccurrent.GlobalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Electriccurrent.LocalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Electriccurrent.GlobalC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.Electriccurrent.Count);
                local.Electriccurrent.ActualC = (1 / CombinedFraction);
            }
            else if (a.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectricCurrentUnit)a.Electriccurrent.Copy();
            }
            else if (b.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectricCurrentUnit)b.Electriccurrent.Copy();
                local.Electriccurrent.Count *= -1;
            }



            //TEMPERATURE

            if (a.Temperature is object && b.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
                local.Temperature.Count -= b.Temperature.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Temperature.LocalC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.Temperature.GlobalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Temperature.LocalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Temperature.GlobalC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.Temperature.Count);
                local.Temperature.ActualC = (1 / CombinedFraction);
            }
            else if (a.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
            }
            else if (b.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)b.Temperature.Copy();
                local.Temperature.Count *= -1;
            }



            //AMOUNT

            if (a.Amount is object && b.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)a.Amount.Copy();
                local.Amount.Count -= b.Amount.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Amount.LocalC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.Amount.GlobalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Amount.LocalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.Amount.GlobalC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.Amount.Count);
                local.Amount.ActualC = (1 / CombinedFraction);
            }
            else if (a.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)a.Amount.Copy();
            }
            else if (b.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)b.Amount.Copy();
                local.Amount.Count *= -1;
            }




            //LUMINOUSINTERSITY

            if (a.LuminousIntensity is object && b.LuminousIntensity is object)
            {
                local.LuminousIntensity = (LuminousIntensityUnit)a.LuminousIntensity.Copy();
                local.LuminousIntensity.Count -= b.LuminousIntensity.Count;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.LuminousIntensity.LocalC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.LuminousIntensity.GlobalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.LuminousIntensity.LocalC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.LuminousIntensity.GlobalC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.LuminousIntensity.Count);
                local.LuminousIntensity.ActualC = (1 / CombinedFraction);
            }
            else if (a.LuminousIntensity is object)
            {
                local.LuminousIntensity = (LuminousIntensityUnit)a.LuminousIntensity.Copy();
            }
            else if (b.LuminousIntensity is object)
            {
                local.LuminousIntensity = (LuminousIntensityUnit)b.LuminousIntensity.Copy();
                local.LuminousIntensity.Count *= -1;
            }


            //COMBINED
            if (a.Combined is object && b.Combined is object)
            {
                local.Combined = a.Combined.Copy();
                local.Combined.Count -= b.Combined.Count;
            }
            else if (a.Combined is object)
            {
                local.Combined = a.Combined.Copy();
            }
            else if (b.Combined is object)
            {
                local.Combined = b.Combined.Copy();
                local.Combined.Count *= -1;
            }


            return local;




        }

        public static Fraction Convert(UnitSystem From, UnitSystem To)
        {

            Fraction CombinedFraction2 = 1;


            foreach (var ToUnit in To.UnitList())
            {
                foreach (var FromUnit in From.UnitList())
                {
                    if (ToUnit is object && FromUnit is object)
                    {
                        if (ToUnit.Name == FromUnit.Name && ToUnit.Name != "Combined")
                        {
                            Fraction CombinedFraction = 1;

                            CombinedFraction *= (Fraction)FromUnit.LocalC;
                            CombinedFraction *= (Fraction)FromUnit.GlobalC;

                            CombinedFraction /= (Fraction)ToUnit.LocalC;
                            CombinedFraction /= (Fraction)ToUnit.GlobalC;


                            CombinedFraction = Fraction.Pow(CombinedFraction, FromUnit.Count);

                            CombinedFraction2 *= CombinedFraction;

                        }
                    }
                }
            }


            foreach (var FromUnit in From.UnitList())
            {

                if (FromUnit.Name == "Combined")
                {
                    Fraction CombinedFraction = 1;
                    CombinedFraction *= (Fraction)FromUnit.LocalC;
                    CombinedFraction *= (Fraction)FromUnit.GlobalC;
                    CombinedFraction2 *= CombinedFraction;
                }
            }

            return CombinedFraction2;
        }


        public static UnitSystem operator +(UnitSystem left, UnitSystem right) => Add(left, right);
        public static UnitSystem operator -(UnitSystem left, UnitSystem right) => Subtract(left, right);

        public static UnitSystem operator *(UnitSystem left, UnitSystem right) => Multiply(left, right);
        public static UnitSystem operator /(UnitSystem left, UnitSystem right) => Divide(left, right);


        public Fraction GetCombi()
        {
            Fraction CombinedFraction = 1;

            foreach (var Unit in UnitList())
            {

                if (Unit.Name == "Combined")
                {
                    //CombinedFraction /= (Fraction)ToUnit.LocalC;
                    //CombinedFraction /= (Fraction)ToUnit.GlobalC;
                    CombinedFraction *= (Fraction)Unit.GlobalC;
                }
            }

            return CombinedFraction;
        }

        public Fraction GetFactorGlobal()
        {
            Fraction a = 1;          

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    a *= Fraction.Pow((Fraction)item.GlobalC, item.Count);
                }
                
            }

            return a;
        }

        public Fraction GetFactorLocal()
        {
            Fraction a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    a *= Fraction.Pow((Fraction)item.LocalC, item.Count);
                }
            }


            return a;

        }

        public Fraction GetActualC()
        {
            Fraction a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    a *= item.ActualC;
                    //a *= Fraction.Pow((Fraction)item.ActualC, item.Count);
                }
            }


            return a;

        }

        public Fraction GetTotalFactor()
        {
            Fraction a = 1;

            a *= GetFactorGlobal();
            a *= GetFactorLocal();
            a *= GetActualC();

            return a;

        }

        public Fraction SumOfBConstants()
        {
            Fraction b = 0;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    b += (Fraction)item.B;
                    //b += Fraction.Pow((Fraction)item.B, item.Count);
                }

            }
            return b;
        }


        public override string ToString()
        {

             string local = "";

            

            foreach (var unit in UnitList())
            {

                if (unit is object && unit.Count > 0)
                {

                    if (unit is object)                    
                        local += unit.Symbol;
                    



                    if (unit.Count > 1)
                        local += $"{ToSuperScript(unit.Count)}";

                }


            }




            //If any negative values
            if (UnitList().Any(x => x.Count < 0))            
                local += "/";




            foreach (var unit in UnitList())
            {

                if (unit is object && unit.Count < 0)
                {
                    local += unit.Symbol;

                    if (unit.Count < -1)
                        local += $"{ToSuperScript(unit.Count * -1)}";

                }


            }

            

            if (Symbol is object)
            {
                return Symbol;
            }
            else
            {
                return local;
            }

        }

        private string ToSuperScript(int number)
        {
            const string SuperscriptDigits =
                "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

            string superscript = new string(number.ToString().Select(x => SuperscriptDigits[x - '0'])
                                    .ToArray());

            return superscript;

        }


        public IEnumerable<Enumeration> UnitList()
        {
            var local = new List<Enumeration>();

            if (Length is object)
                local.Add(Length);

            if (Mass is object)
                local.Add(Mass);

            if (Duration is object)
                local.Add(Duration);

            if (Electriccurrent is object)
                local.Add(Electriccurrent);

            if (Temperature is object)
                local.Add(Temperature);

            if (Amount is object)
                local.Add(Amount);

            if (LuminousIntensity is object)
                local.Add(LuminousIntensity);

            if (Combined is object)
                local.Add(Combined);



            return local;
        }

        public UnitSystem Copy()
        {

            UnitSystem local = new UnitSystem();

            if (Symbol is object)
                local.Symbol = Symbol;

            if (Length is object)
                local.Length = Length.Copy();

            if (Mass is object)
                local.Mass = Mass.Copy();

            if (Duration is object)
                local.Duration = Duration.Copy();

            if (Electriccurrent is object)
                local.Electriccurrent = Electriccurrent.Copy();

            if (Temperature is object)
                local.Temperature = Temperature.Copy();

            if (Amount is object)
                local.Amount = Amount.Copy();

            if (LuminousIntensity is object)
                local.LuminousIntensity = LuminousIntensity.Copy();

            if (Combined is object)
                local.Combined = Combined.Copy();

            return local;
        }



    }




}
