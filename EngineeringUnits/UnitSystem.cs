using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EngineeringUnits
{
    public class UnitSystem
    {

        public string Symbol { get; set; }

        public LengthUnit Length { get; set; }
        public MassUnit Mass { get; set; }
        public DurationUnit Duration { get; set; }
        public ElectricCurrentUnit Electriccurrent { get; set; }
        public TemperatureUnit Temperature { get; set; }
        public AmountOfSubstanceUnit Amount { get; set; }
        public LuminousIntensityUnit LuminousIntensity { get; set; }
        public CombinedUnit Combined { get; set; }

        //public decimal EkstraCorrection { get; set; }



        public UnitSystem()
        {
            //EkstraCorrection = 1;

            //Length = new BaseUnitClass(BaseUnits.length);
            //Mass = new BaseUnitClass(BaseUnits.mass);
            //Duration = new BaseUnitClass(BaseUnits.time);
            //Electriccurrent = new BaseUnitClass(BaseUnits.electricCurrent);
            //Temperature = new BaseUnitClass(BaseUnits.temperature);
            //Amount = new BaseUnitClass(BaseUnits.amountOfSubstance);
            //LuminousIntensity = new BaseUnitClass(BaseUnits.luminousIntensity);            
        }


        public static bool operator ==(UnitSystem a, UnitSystem b)
        {


            if (!Compareunits(a.Length, b.Length) ||
                !Compareunits(a.Mass, b.Mass) ||
                !Compareunits(a.Duration, b.Duration) ||
                !Compareunits(a.Electriccurrent, b.Electriccurrent) ||
                !Compareunits(a.Temperature, b.Temperature) ||
                !Compareunits(a.Amount, b.Amount) ||
                !Compareunits(a.LuminousIntensity, b.LuminousIntensity)) // ||
                //!Compareunits(a.Combined, b.Combined))
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
                throw new InvalidOperationException($"Trying to add two UnitSystem that are not the same!");
            }


            UnitSystem local = new UnitSystem();

            if (a.Length is object)
                local.Length = (LengthUnit)a.Length.Copy();
            else if (b.Length is object)
                local.Length = (LengthUnit)b.Length.Copy();

            if (a.Mass is object)
                local.Mass = (MassUnit)a.Mass.Copy();
            else if (b.Mass is object)
                local.Mass = (MassUnit)b.Mass.Copy();


            if (a.Duration is object)
                local.Duration = (DurationUnit)a.Duration.Copy();
            else if (b.Duration is object)
                local.Duration = (DurationUnit)b.Duration.Copy();



            if (a.Electriccurrent is object)
                local.Electriccurrent = (ElectricCurrentUnit)a.Electriccurrent.Copy();
            else if (b.Electriccurrent is object)
                local.Electriccurrent = (ElectricCurrentUnit)b.Electriccurrent.Copy();


            if (a.Temperature is object)
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
            else if (b.Temperature is object)
                local.Temperature = (TemperatureUnit)b.Temperature.Copy();


            if (a.Amount is object)
                local.Amount = (AmountOfSubstanceUnit)a.Amount.Copy();
            else if (b.Amount is object)
                local.Amount = (AmountOfSubstanceUnit)b.Amount.Copy();


            if (a.LuminousIntensity is object)
                local.LuminousIntensity = (LuminousIntensityUnit)a.LuminousIntensity.Copy();
            else if (b.LuminousIntensity is object)
                local.LuminousIntensity = (LuminousIntensityUnit)b.LuminousIntensity.Copy();



            if (a.Combined is object)
                local.Combined = (CombinedUnit)a.Combined.Copy();
            else if (b.Combined is object)
                local.Combined = (CombinedUnit)b.Combined.Copy();




            return local;

        }
        public static UnitSystem Subtract(UnitSystem a, UnitSystem b)
        {
            //Subtract does the same to a unit as add
            return Add(a, b);

        }
        public static UnitSystem Multiply(UnitSystem a, UnitSystem b)
        {

            UnitSystem local = new UnitSystem();//  Merge(a, b);



            if (a.Length is object && b.Length is object)
            {
                local.Length = (LengthUnit)a.Length.Copy();





                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Length.LocalC, a.Length.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Length.GlobalC, a.Length.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Length.LocalC, b.Length.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Length.GlobalC, b.Length.Count);

                //If combined units are set using different like Kg vs pound
                local.Length.ActualC = (decimal)CombinedFraction * a.Length.ActualC * b.Length.ActualC;





                local.Length.Count += b.Length.Count;
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


                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Mass.LocalC, a.Mass.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Mass.GlobalC, a.Mass.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Mass.LocalC, b.Mass.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Mass.GlobalC, b.Mass.Count);

                //If combined units are set using different like Kg vs pound
                local.Mass.ActualC = (decimal)CombinedFraction * a.Mass.ActualC * b.Mass.ActualC;




                local.Mass.Count += b.Mass.Count;
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

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Duration.LocalC, a.Duration.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Duration.GlobalC, a.Duration.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Duration.LocalC, b.Duration.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Duration.GlobalC, b.Duration.Count);

                //If combined units are set using different like Kg vs pound
                local.Duration.ActualC = (decimal)CombinedFraction * a.Duration.ActualC * b.Duration.ActualC;



                local.Duration.Count += b.Duration.Count;
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


                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Electriccurrent.LocalC, a.Electriccurrent.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Electriccurrent.GlobalC, a.Electriccurrent.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Electriccurrent.LocalC, b.Electriccurrent.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Electriccurrent.GlobalC, b.Electriccurrent.Count);

                //If combined units are set using different like Kg vs pound
                local.Electriccurrent.ActualC = (decimal)CombinedFraction * a.Electriccurrent.ActualC * b.Electriccurrent.ActualC;



                local.Electriccurrent.Count += b.Electriccurrent.Count;
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

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Temperature.LocalC, a.Temperature.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Temperature.GlobalC, a.Temperature.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Temperature.LocalC, b.Temperature.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Temperature.GlobalC, b.Temperature.Count);

                //If combined units are set using different like Kg vs pound
                local.Temperature.ActualC = (decimal)CombinedFraction * a.Temperature.ActualC * b.Temperature.ActualC;



                local.Temperature.Count += b.Temperature.Count;
            }
            else if (a.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
            }
            else if (b.Electriccurrent is object)
            {
                local.Temperature = (TemperatureUnit)b.Temperature.Copy();
            }





            if (a.Amount is object && b.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)a.Amount.Copy();

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Amount.LocalC, a.Amount.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Amount.GlobalC, a.Amount.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Amount.LocalC, b.Amount.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.Amount.GlobalC, b.Amount.Count);

                //If combined units are set using different like Kg vs pound
                local.Amount.ActualC = (decimal)CombinedFraction * a.Amount.ActualC * b.Amount.ActualC;

                local.Amount.Count += b.Amount.Count;
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

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.LuminousIntensity.LocalC, a.LuminousIntensity.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.LuminousIntensity.GlobalC, a.LuminousIntensity.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.LuminousIntensity.LocalC, b.LuminousIntensity.Count);
                CombinedFraction *= Fraction.Pow((Fraction)b.LuminousIntensity.GlobalC, b.LuminousIntensity.Count);

                //If combined units are set using different like Kg vs pound
                local.LuminousIntensity.ActualC = (decimal)CombinedFraction * a.LuminousIntensity.ActualC * b.LuminousIntensity.ActualC;



                local.LuminousIntensity.Count += b.LuminousIntensity.Count;
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
                local.Combined = (CombinedUnit)a.Combined.Copy();
                local.Combined.Count += b.Combined.Count;
            }
            else if (a.Combined is object)
            {
                local.Combined = (CombinedUnit)a.Combined.Copy();
            }
            else if (b.Combined is object)
            {
                local.Combined = (CombinedUnit)b.Combined.Copy();
            }




            return local;

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            UnitSystem local = new UnitSystem();//  Merge(a, b);

            //LENGTH

            if (a.Length is object && b.Length is object)
            {
                local.Length = (LengthUnit)a.Length.Copy();





                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Length.LocalC, a.Length.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Length.GlobalC, a.Length.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Length.LocalC, b.Length.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Length.GlobalC, b.Length.Count);

                //If combined units are set using different like Kg vs pound
                local.Length.ActualC = (decimal)CombinedFraction * a.Length.ActualC * b.Length.ActualC;




                local.Length.Count -= b.Length.Count;
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


                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Mass.LocalC, a.Mass.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Mass.GlobalC, a.Mass.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Mass.LocalC, b.Mass.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Mass.GlobalC, b.Mass.Count);

                //If combined units are set using different like Kg vs pound
                local.Mass.ActualC = (decimal)CombinedFraction * a.Mass.ActualC * b.Mass.ActualC;




                local.Mass.Count -= b.Mass.Count;
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


                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Duration.LocalC, a.Duration.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Duration.GlobalC, a.Duration.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Duration.LocalC, b.Duration.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Duration.GlobalC, b.Duration.Count);


                //If combined units are set using different like Kg vs pound
                local.Duration.ActualC = (decimal)CombinedFraction * a.Duration.ActualC * b.Duration.ActualC;







                local.Duration.Count -= b.Duration.Count;
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


                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Electriccurrent.LocalC, a.Electriccurrent.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Electriccurrent.GlobalC, a.Electriccurrent.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Electriccurrent.LocalC, b.Electriccurrent.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Electriccurrent.GlobalC, b.Electriccurrent.Count);


                //If combined units are set using different like Kg vs pound
                local.Electriccurrent.ActualC = (decimal)CombinedFraction * a.Electriccurrent.ActualC * b.Electriccurrent.ActualC;





                local.Electriccurrent.Count -= b.Electriccurrent.Count;
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



                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Temperature.LocalC, a.Temperature.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Temperature.GlobalC, a.Temperature.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Temperature.LocalC, b.Temperature.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Temperature.GlobalC, b.Temperature.Count);


                //If combined units are set using different like Kg vs pound
                local.Temperature.ActualC = (decimal)CombinedFraction * a.Temperature.ActualC * b.Temperature.ActualC;






                local.Temperature.Count -= b.Temperature.Count;
            }
            else if (a.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
            }
            else if (b.Electriccurrent is object)
            {
                local.Temperature = (TemperatureUnit)b.Temperature.Copy();
                local.Temperature.Count *= -1;
            }







            //AMOUNT

            if (a.Amount is object && b.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)a.Amount.Copy();


                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.Amount.LocalC, a.Amount.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.Amount.GlobalC, a.Amount.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Amount.LocalC, b.Amount.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.Amount.GlobalC, b.Amount.Count);


                //If combined units are set using different like Kg vs pound
                local.Amount.ActualC = (decimal)CombinedFraction * a.Amount.ActualC * b.Amount.ActualC;


                local.Amount.Count -= b.Amount.Count;
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


                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.LuminousIntensity.LocalC, a.LuminousIntensity.Count);
                CombinedFraction *= Fraction.Pow((Fraction)a.LuminousIntensity.GlobalC, a.LuminousIntensity.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.LuminousIntensity.LocalC, b.LuminousIntensity.Count);
                CombinedFraction /= Fraction.Pow((Fraction)b.LuminousIntensity.GlobalC, b.LuminousIntensity.Count);


                //If combined units are set using different like Kg vs pound
                local.LuminousIntensity.ActualC = (decimal)CombinedFraction * a.LuminousIntensity.ActualC * b.LuminousIntensity.ActualC;




                local.LuminousIntensity.Count -= b.LuminousIntensity.Count;
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






            Fraction CombinedFraction2 = 1;


            ////Vi skal kun have forskellen mellem Combined?





            if (a.Combined is object)
            {
                CombinedFraction2 *= Fraction.Pow((Fraction)a.Combined.LocalC, a.Combined.Count);
                CombinedFraction2 *= Fraction.Pow((Fraction)a.Combined.GlobalC, a.Combined.Count);
            }


            if (b.Combined is object)
            {
                CombinedFraction2 /= Fraction.Pow((Fraction)b.Combined.LocalC, b.Combined.Count);
                CombinedFraction2 /= Fraction.Pow((Fraction)b.Combined.GlobalC, b.Combined.Count);
            }


            //
            if (local.Combined is null)
            {
                local.Combined = new CombinedUnit("", (decimal)(CombinedFraction2), 1);
            }
            else
            {
                local.Combined = new CombinedUnit("", (decimal)(CombinedFraction2) * local.Combined.LocalC, 1);
            }








            //if (a.Combined is object && b.Combined is object)
            //{
            //    local.Combined = (CombinedUnit)a.Combined.Copy();
            //    local.Combined.Count -= b.Combined.Count;
            //}
            //else if (a.Combined is object)
            //{
            //    local.Combined = (CombinedUnit)a.Combined.Copy();
            //}
            //else if (b.Combined is object)
            //{
            //    local.Combined = (CombinedUnit)b.Combined.Copy();
            //    local.Combined.Count *= -1;
            //}





            return local;

        }


        public static UnitSystem operator +(UnitSystem left, UnitSystem right) => Add(left, right);
        public static UnitSystem operator -(UnitSystem left, UnitSystem right) => Subtract(left, right);

        public static UnitSystem operator *(UnitSystem left, UnitSystem right) => Multiply(left, right);
        public static UnitSystem operator /(UnitSystem left, UnitSystem right) => Divide(left, right);


        public Fraction GetFactorGlobal()
        {

            Fraction a = 1;

            //a *= (Fraction)EkstraCorrection;

            

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
                    a *= (Fraction)item.ActualC;
                }
            }


            return a;

        }

        //public static Fraction GetFactor(UnitSystem left, UnitSystem right)
        //{

        //    //Toal Factor

        //    //Samle konstanter
        //    Fraction leftA1 = left.GetFactorLocal();
        //    Fraction leftA2 = left.GetFactorGlobal();
        //    Fraction rightA1 = right.GetFactorLocal();
        //    Fraction rightA2 = right.GetFactorGlobal();




        //    Fraction y2 = 1;




        //    //Trying to avoid small numeric error
        //    if (rightA1 >= leftA1)
        //        y2 /= (rightA1 / leftA1);
        //    else
        //        y2 *= (leftA1 / rightA1);


        //    if (rightA2 >= leftA2)
        //        y2 /= (rightA2 / leftA2);
        //    else
        //        y2 *= (leftA2 / rightA2);



        //    return y2;


        //}



        public Fraction SumOfBConstants()
        {
            Fraction b = 0;

            foreach (var item in UnitList())
            {
                if (item is object)
                    b += (Fraction)item.B;

            }
            return b;
        }


        public string ChangingUnitSymbols()
        {

            SpecificEnergyUnit test = SpecificEnergyUnit.JoulePerKilogram;


            if (this == (SpecificEnergyUnit.JoulePerKilogram).Unit)
            {
                Debug.Print("HER!");

                
                //Construct J

                //Construct Mass




                return (SpecificEnergyUnit.JoulePerKilogram).ToString();
                
            }

            return "";


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


        public decimal Pow(decimal x, int y)
        {

            if (x == 1 || y == 1)
            {
                return x;
            }
            else if (y == 0)
            {
                return 1;
            }

            int count;
            decimal local = 1;

            if (y > 0)
                count = y;
            else            
                count = -y;



            for (int i = 0; i < count; i++)
                local *= x;
            

            if (local == 0)
                return 0;            




            if (y > 0)
                return local;
            else
                return 1/local;





        }





    }




}
