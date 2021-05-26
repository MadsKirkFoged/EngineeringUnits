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
        public ElectriccurrentUnit Electriccurrent { get; set; }
        public TemperatureUnit Temperature { get; set; }
        public AmountOfSubstanceUnit Amount { get; set; }
        public LuminousIntensityUnit LuminousIntensity { get; set; }


        
        public UnitSystem()
        {
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


            if (a.Length is object && b.Length is object)
            {
                if (a.Length.Count != b.Length.Count)
                {
                    return false;
                } 
            }
            else if (a.Length is object)
            {
                if (a.Length.Count != 0)
                {
                    return false;
                }
            }
            else if (b.Length is object)
            {
                if (b.Length.Count != 0)
                {
                    return false;
                }
            }





            if (a.Mass is object && b.Mass is object)
            {
                if (a.Mass.Count != b.Mass.Count)
                {
                    return false;
                }
            }
            else if (a.Mass is object)
            {
                if (a.Mass.Count != 0)
                {
                    return false;
                }
            }
            else if (b.Mass is object)
            {
                if (b.Mass.Count != 0)
                {
                    return false;
                }
            }






            if (a.Duration is object && b.Duration is object)
            {
                if (a.Duration.Count != b.Duration.Count)
                {
                    return false;
                }
            }
            else if (a.Duration is object)
            {
                if (a.Duration.Count != 0)
                {
                    return false;
                }
            }
            else if (b.Duration is object)
            {
                if (b.Duration.Count != 0)
                {
                    return false;
                }
            }



            if (a.Electriccurrent is object && b.Electriccurrent is object)
            {
                if (a.Electriccurrent.Count != b.Electriccurrent.Count)
                {
                    return false;
                }
            }
            else if (a.Electriccurrent is object)
            {
                if (a.Electriccurrent.Count != 0)
                {
                    return false;
                }
            }
            else if (b.Electriccurrent is object)
            {
                if (b.Electriccurrent.Count != 0)
                {
                    return false;
                }
            }




            if (a.Temperature is object && b.Temperature is object)
            {
                if (a.Temperature.Count != b.Temperature.Count)
                {
                    return false;
                }
            }
            else if (a.Temperature is object)
            {
                if (a.Temperature.Count != 0)
                {
                    return false;
                }
            }
            else if (b.Temperature is object)
            {
                if (b.Temperature.Count != 0)
                {
                    return false;
                }
            }





            if (a.Amount is object && b.Amount is object)
            {
                if (a.Amount.Count != b.Amount.Count)
                {
                    return false;
                }
            }
            else if (a.Amount is object)
            {
                if (a.Amount.Count != 0)
                {
                    return false;
                }
            }
            else if (b.Amount is object)
            {
                if (b.Amount.Count != 0)
                {
                    return false;
                }
            }




            if (a.LuminousIntensity is object && b.LuminousIntensity is object)
            {
                if (a.LuminousIntensity.Count != b.LuminousIntensity.Count)
                {
                    return false;
                }
            }
            else if (a.LuminousIntensity is object)
            {
                if (a.LuminousIntensity.Count != 0)
                {
                    return false;
                }
            }
            else if (b.LuminousIntensity is object)
            {
                if (b.LuminousIntensity.Count != 0)
                {
                    return false;
                }
            }



            return true;


   
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
                local.Electriccurrent = (ElectriccurrentUnit)a.Electriccurrent.Copy();
            else if (b.Electriccurrent is object)
                local.Electriccurrent = (ElectriccurrentUnit)b.Electriccurrent.Copy();


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
                local.Electriccurrent = (ElectriccurrentUnit)a.Electriccurrent.Copy();
                local.Electriccurrent.Count += b.Electriccurrent.Count;
            }
            else if (a.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectriccurrentUnit)a.Electriccurrent.Copy();
            }
            else if (b.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectriccurrentUnit)b.Electriccurrent.Copy();
            }



            if (a.Temperature is object && b.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
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



  

            return local;

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            UnitSystem local = new UnitSystem();//  Merge(a, b);



            if (a.Length is object && b.Length is object)
            {
                local.Length = (LengthUnit)a.Length.Copy();
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





            if (a.Mass is object && b.Mass is object)
            {
                local.Mass = (MassUnit)a.Mass.Copy();
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



            if (a.Duration is object && b.Duration is object)
            {
                local.Duration = (DurationUnit)a.Duration.Copy();
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




            if (a.Electriccurrent is object && b.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectriccurrentUnit)a.Electriccurrent.Copy();
                local.Electriccurrent.Count -= b.Electriccurrent.Count;
            }
            else if (a.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectriccurrentUnit)a.Electriccurrent.Copy();
            }
            else if (b.Electriccurrent is object)
            {
                local.Electriccurrent = (ElectriccurrentUnit)b.Electriccurrent.Copy();
                local.Electriccurrent.Count *= -1;
            }



            if (a.Temperature is object && b.Temperature is object)
            {
                local.Temperature = (TemperatureUnit)a.Temperature.Copy();
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





            if (a.Amount is object && b.Amount is object)
            {
                local.Amount = (AmountOfSubstanceUnit)a.Amount.Copy();
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




            if (a.LuminousIntensity is object && b.LuminousIntensity is object)
            {
                local.LuminousIntensity = (LuminousIntensityUnit)a.LuminousIntensity.Copy();
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




            return local;

        }


        public static UnitSystem operator +(UnitSystem left, UnitSystem right) => Add(left, right);
        public static UnitSystem operator -(UnitSystem left, UnitSystem right) => Subtract(left, right);

        public static UnitSystem operator *(UnitSystem left, UnitSystem right) => Multiply(left, right);
        public static UnitSystem operator /(UnitSystem left, UnitSystem right) => Divide(left, right);


        public Fraction GetAFactorGlobal()
        {

            Fraction a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    //a *= (decimal)Math.Pow((double)item.A2, item.Count);
                    //a *= Pow(item.A2, item.Count);
                    a *= Fraction.Pow((Fraction)item.A2, item.Count);
                }
                
            }


            return a;
        }



        public Fraction SumOfA1ConstantsWithPow()
        {
            Fraction a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    //a *= (decimal)Math.Pow((double)item.A1, item.Count);
                    //a *= Pow(item.A1, item.Count);
                    a *= Fraction.Pow((Fraction)item.A1, item.Count);
                }
            }


            return a;

        }


        public Fraction SumOfA2ConstantsWithPow()
        {
            Fraction a = 1;

            foreach (var item in UnitList())
            {
                if (item is object)
                {
                    //a *= (decimal)Math.Pow((double)item.A2, item.Count);
                    //a *= Pow(item.A2, item.Count);
                    a *= Fraction.Pow((Fraction)item.A2, item.Count);
                }
            }


            return a;

        }

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
