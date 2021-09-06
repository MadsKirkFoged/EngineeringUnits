using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System;
//using System.Text.Json.Serialization;

namespace EngineeringUnits
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UnitSystem
    {

        [JsonProperty]
        public string Symbol { get; set; }

        //Just have a list of units?
        //public List<Enumeration> UnitListBeta = new List<Enumeration>();

        public LengthUnit L { get; set; } //Length
        public MassUnit M { get; set; } //Mass
        public DurationUnit D { get; set; } //Duration
        public ElectricCurrentUnit E { get; set; } //Electriccurrent
        public TemperatureUnit T { get; set; } //Temperature
        public AmountOfSubstanceUnit A { get; set; } //Amount
        public LuminousIntensityUnit LI { get; set; } //LuminousIntensity
        public CombinedUnit C { get; set; } //Combined


        public UnitSystem()
        {
        }

        public UnitSystem(string symbol)
        {
            Symbol = symbol;
        }


        public static bool operator ==(UnitSystem a, UnitSystem b)
        {


            if (!Compareunits(a.L, b.L) ||
                !Compareunits(a.M, b.M) ||
                !Compareunits(a.D, b.D) ||
                !Compareunits(a.E, b.E) ||
                !Compareunits(a.T, b.T) ||
                !Compareunits(a.A, b.A) ||
                !Compareunits(a.LI, b.LI))
            { 
                return false;            
            }


            return true;


            //Local function
            bool Compareunits(Enumeration a1, Enumeration b1)
            {

                if (a1 is object && b1 is object)
                {
                    if (a1.Ct != b1.Ct)                    
                        return false;                    
                }
                else if (a1 is object)
                {
                    if (a1.Ct != 0)                    
                        return false;                    
                }
                else if (b1 is object)
                {
                    if (b1.Ct != 0)                    
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
            return a;
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


            if (a.L is object && b.L is object)
            {
                local.L = (LengthUnit)a.L.Clone();
                local.L.Ct += b.L.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.L.LC;
                CombinedFraction *= (Fraction)a.L.GC;

                CombinedFraction /= (Fraction)b.L.LC;
                CombinedFraction /= (Fraction)b.L.GC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.L.Ct);
                local.L.AC *= CombinedFraction * b.L.AC;
            }
            else if (a.L is object)
            {
                //local.L = (LengthUnit)a.L.Clone();
                local.L = (LengthUnit)a.L;
            }
            else if (b.L is object)
            {
                //local.L = (LengthUnit)b.L.Clone();
                local.L = (LengthUnit)b.L;
            }


            if (a.M is object && b.M is object)
            {
                local.M = (MassUnit)a.M.Clone();
                local.M.Ct += b.M.Ct;


                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.M.LC;
                CombinedFraction *= (Fraction)a.M.GC;

                CombinedFraction /= (Fraction)b.M.LC;
                CombinedFraction /= (Fraction)b.M.GC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.M.Ct);
                local.M.AC *= CombinedFraction * b.M.AC;



            }
            else if (a.M is object)
            {
                local.M = (MassUnit)a.M.Clone();
            }
            else if (b.M is object)
            {
                local.M = (MassUnit)b.M.Clone();
            }



            if (a.D is object && b.D is object)
            {
                local.D = (DurationUnit)a.D.Clone();
                local.D.Ct += b.D.Ct;

                Fraction CombinedFraction = 1;

                CombinedFraction *= (Fraction)a.D.LC;
                CombinedFraction *= (Fraction)a.D.GC;

                CombinedFraction /= (Fraction)b.D.LC;
                CombinedFraction /= (Fraction)b.D.GC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.D.Ct);
                local.D.AC *= CombinedFraction * b.D.AC;
            }
            else if (a.D is object)
            {
                local.D = (DurationUnit)a.D.Clone();
            }
            else if (b.D is object)
            {
                local.D = (DurationUnit)b.D.Clone();
            }




            if (a.E is object && b.E is object)
            {
                local.E = (ElectricCurrentUnit)a.E.Clone();
                local.E.Ct += b.E.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.E.LC;
                CombinedFraction *= (Fraction)a.E.GC;

                CombinedFraction /= (Fraction)b.E.LC;
                CombinedFraction /= (Fraction)b.E.GC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.E.Ct);
                local.E.AC *= CombinedFraction * b.E.AC;
            }
            else if (a.E is object)
            {
                local.E = (ElectricCurrentUnit)a.E.Clone();
            }
            else if (b.E is object)
            {
                local.E = (ElectricCurrentUnit)b.E.Clone();
            }



            if (a.T is object && b.T is object)
            {
                local.T = (TemperatureUnit)a.T.Clone();
                local.T.Ct += b.T.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.T.LC;
                CombinedFraction *= (Fraction)a.T.GC;

                CombinedFraction /= (Fraction)b.T.LC;
                CombinedFraction /= (Fraction)b.T.GC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.T.Ct);
                local.T.AC *= CombinedFraction * b.T.AC;
            }
            else if (a.T is object)
            {
                local.T = (TemperatureUnit)a.T.Clone();
            }
            else if (b.T is object)
            {
                local.T = (TemperatureUnit)b.T.Clone();
            }





            if (a.A is object && b.A is object)
            {
                local.A = (AmountOfSubstanceUnit)a.A.Clone();
                local.A.Ct += b.A.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.A.LC;
                CombinedFraction *= (Fraction)a.A.GC;

                CombinedFraction /= (Fraction)b.A.LC;
                CombinedFraction /= (Fraction)b.A.GC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.A.Ct);
                local.A.AC *= CombinedFraction * b.A.AC;
            }
            else if (a.A is object)
            {
                local.A = (AmountOfSubstanceUnit)a.A.Clone();
            }
            else if (b.A is object)
            {
                local.A = (AmountOfSubstanceUnit)b.A.Clone();
            }




            if (a.LI is object && b.LI is object)
            {
                local.LI = (LuminousIntensityUnit)a.LI.Clone();
                local.LI.Ct += b.LI.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= (Fraction)a.LI.LC;
                CombinedFraction *= (Fraction)a.LI.GC;

                CombinedFraction /= (Fraction)b.LI.LC;
                CombinedFraction /= (Fraction)b.LI.GC;

                CombinedFraction = Fraction.Pow(CombinedFraction, b.LI.Ct);
                local.LI.AC *= CombinedFraction * b.LI.AC;
            }
            else if (a.LI is object)
            {
                local.LI = (LuminousIntensityUnit)a.LI.Clone();
            }
            else if (b.LI is object)
            {
                local.LI = (LuminousIntensityUnit)b.LI.Clone();
            }



            if (a.C is object && b.C is object)
            {
                local.C = (CombinedUnit)a.C.Clone();
                local.C.SetNewGlobalC(local.C.GC * b.C.GC);
                local.C.Ct += b.C.Ct;
            }
            else if (a.C is object)
            {
                local.C = (CombinedUnit)a.C.Clone();
            }
            else if (b.C is object)
            {
                local.C = (CombinedUnit)b.C.Clone();
            }


            return local;

        }
        public static UnitSystem Divide(UnitSystem a, UnitSystem b)
        {
            UnitSystem local = new UnitSystem();


            //LENGTH

            if (a.L is object && b.L is object)
            {
                local.L = (LengthUnit)a.L.Clone();             
                local.L.Ct -= b.L.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.L.LC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.L.GC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.L.LC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.L.GC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.L.Ct);
                local.L.AC *= (1 / CombinedFraction) * b.L.AC;
            }
            else if (a.L is object)
            {
                local.L = (LengthUnit)a.L.Clone();
            }
            else if (b.L is object)
            {
                local.L = (LengthUnit)b.L.Clone();
                local.L.AC = 1 / local.L.AC;
                local.L.Ct *= -1;
            }


            //MASS
            if (a.M is object && b.M is object)
            {
                local.M = (MassUnit)a.M.Clone();               
                local.M.Ct -= b.M.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.M.LC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.M.GC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.M.LC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.M.GC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.M.Ct);
                local.M.AC *= (1 / CombinedFraction) * b.M.AC;
            }
            else if (a.M is object)
            {
                local.M = (MassUnit)a.M.Clone();
            }
            else if (b.M is object)
            {
                local.M = (MassUnit)b.M.Clone();
                local.M.AC = 1 / local.M.AC;
                local.M.Ct *= -1;
            }



            //DURATION
            if (a.D is object && b.D is object)
            {
                local.D = (DurationUnit)a.D.Clone();             
                local.D.Ct -= b.D.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.D.LC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.D.GC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.D.LC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.D.GC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.D.Ct);
                local.D.AC *= (1 / CombinedFraction) * b.D.AC;
            }
            else if (a.D is object)
            {
                local.D = (DurationUnit)a.D.Clone();
            }
            else if (b.D is object)
            {
                local.D = (DurationUnit)b.D.Clone();
                local.D.AC = 1 / local.D.AC;
                local.D.Ct *= -1;
            }



            //ELECTRICCURRENT
            if (a.E is object && b.E is object)
            {
                local.E = (ElectricCurrentUnit)a.E.Clone();
                local.E.Ct -= b.E.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.E.LC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.E.GC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.E.LC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.E.GC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.E.Ct);
                local.E.AC *= (1 / CombinedFraction) * b.E.AC;
            }
            else if (a.E is object)
            {
                local.E = (ElectricCurrentUnit)a.E.Clone();
            }
            else if (b.E is object)
            {
                local.E = (ElectricCurrentUnit)b.E.Clone();
                local.E.AC = 1 / local.E.AC;
                local.E.Ct *= -1;
            }



            //TEMPERATURE

            if (a.T is object && b.T is object)
            {
                local.T = (TemperatureUnit)a.T.Clone();
                local.T.Ct -= b.T.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.T.LC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.T.GC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.T.LC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.T.GC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.T.Ct);
                local.T.AC *= (1 / CombinedFraction) * b.T.AC;
            }
            else if (a.T is object)
            {
                local.T = (TemperatureUnit)a.T.Clone();
            }
            else if (b.T is object)
            {
                local.T = (TemperatureUnit)b.T.Clone();
                local.T.AC = 1 / local.T.AC;
                local.T.Ct *= -1;
            }



            //AMOUNT

            if (a.A is object && b.A is object)
            {
                local.A = (AmountOfSubstanceUnit)a.A.Clone();
                local.A.Ct -= b.A.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.A.LC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.A.GC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.A.LC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.A.GC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.A.Ct);
                local.A.AC *= (1 / CombinedFraction) * b.A.AC;
            }
            else if (a.A is object)
            {
                local.A = (AmountOfSubstanceUnit)a.A.Clone();
            }
            else if (b.A is object)
            {
                local.A = (AmountOfSubstanceUnit)b.A.Clone();
                local.A.AC = 1 / local.A.AC;
                local.A.Ct *= -1;
            }




            //LUMINOUSINTERSITY

            if (a.LI is object && b.LI is object)
            {
                local.LI = (LuminousIntensityUnit)a.LI.Clone();
                local.LI.Ct -= b.LI.Ct;

                Fraction CombinedFraction = 1;
                CombinedFraction *= Fraction.Pow((Fraction)a.LI.LC, 1);
                CombinedFraction *= Fraction.Pow((Fraction)a.LI.GC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.LI.LC, 1);
                CombinedFraction /= Fraction.Pow((Fraction)b.LI.GC, 1);
                CombinedFraction = Fraction.Pow(CombinedFraction, b.LI.Ct);
                local.LI.AC *= (1 / CombinedFraction) * b.LI.AC;
            }
            else if (a.LI is object)
            {
                local.LI = (LuminousIntensityUnit)a.LI.Clone();
            }
            else if (b.LI is object)
            {
                local.LI = (LuminousIntensityUnit)b.LI.Clone();
                local.LI.AC = 1 / local.LI.AC;
                local.LI.Ct *= -1;
            }


            //COMBINED
            if (a.C is object && b.C is object)
            {
                local.C = (CombinedUnit)a.C.Clone();

                local.C.SetNewGlobalC(local.C.GC / b.C.GC);
                local.C.Ct -= b.C.Ct;
            }
            else if (a.C is object)
            {
                local.C = (CombinedUnit)a.C.Clone();
            }
            else if (b.C is object)
            {
                local.C = (CombinedUnit)b.C.Clone();
                local.C.SetNewGlobalC(1 / b.C.GC);
                local.C.Ct *= -1;
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

                        if (ToUnit.GetType() == FromUnit.GetType()  && ToUnit.GetType() != typeof(CombinedUnit))
                        {
                            Fraction CombinedFraction = 1;

                            CombinedFraction *= (Fraction)FromUnit.LC;
                            CombinedFraction *= (Fraction)FromUnit.GC;

                            CombinedFraction /= (Fraction)ToUnit.LC;
                            CombinedFraction /= (Fraction)ToUnit.GC;

                            CombinedFraction = Fraction.Pow(CombinedFraction, FromUnit.Ct);

                            CombinedFraction2 *= CombinedFraction;

                        }
                    }
                }
            }


            foreach (var FromUnit in From.UnitList())
            {
                CombinedFraction2 /= (Fraction)FromUnit.AC;                
            }

            foreach (var ToUnit in To.UnitList())
            {
                CombinedFraction2 *= (Fraction)ToUnit.AC;
            }


            foreach (var FromUnit in From.UnitList())
            {

                if (FromUnit.GetType() == typeof(CombinedUnit))
                {
                    Fraction CombinedFraction = 1;
                    CombinedFraction *= (Fraction)FromUnit.LC;
                    CombinedFraction *= (Fraction)FromUnit.GC;
                    CombinedFraction2 *= CombinedFraction;
                }
            }

            foreach (var ToUnit in To.UnitList())
            {

                if (ToUnit.GetType() == typeof(CombinedUnit))
                {
                    Fraction CombinedFraction = 1;
                    CombinedFraction /= (Fraction)ToUnit.LC;
                    CombinedFraction /= (Fraction)ToUnit.GC;
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
                if (Unit.GetType() == typeof(CombinedUnit))                
                    CombinedFraction *= (Fraction)Unit.GC;                
            }

            return CombinedFraction;
        }

        //public Fraction GetFactorGlobal()
        //{
        //    Fraction a = 1;          

        //    foreach (var item in UnitList())
        //    {
        //        if (item is object)
        //        {
        //            a *= Fraction.Pow((Fraction)item.GlobalC, item.Count);
        //        }
                
        //    }

        //    return a;
        //}

        //public Fraction GetFactorLocal()
        //{
        //    Fraction a = 1;

        //    foreach (var item in UnitList())
        //    {
        //        if (item is object)                
        //            a *= Fraction.Pow((Fraction)item.LocalC, item.Count);                
        //    }

        //    return a;
        //}

        public Fraction GetActualC()
        {
            Fraction a = 1;

            foreach (var item in UnitList())            
                if (item is object)                
                    a *= item.AC;
                
            


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

                if (unit is object && unit.Ct > 0)
                {

                    if (unit is object)                    
                        local += unit.S;
                    



                    if (unit.Ct > 1)
                        local += $"{ToSuperScript(unit.Ct)}";

                }


            }




            //If any negative values
            if (UnitList().Any(x => x.Ct < 0))            
                local += "/";




            foreach (var unit in UnitList())
            {

                if (unit is object && unit.Ct < 0)
                {
                    local += unit.S;

                    if (unit.Ct < -1)
                        local += $"{ToSuperScript(unit.Ct * -1)}";

                }


            }

            

            //if (Symbol is object)
            //{
            //    return Symbol;
            //}
            //else
            //{
                return local;
            //}

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

            if (L is object)
                local.Add(L);

            if (M is object)
                local.Add(M);

            if (D is object)
                local.Add(D);

            if (E is object)
                local.Add(E);

            if (T is object)
                local.Add(T);

            if (A is object)
                local.Add(A);

            if (LI is object)
                local.Add(LI);

            if (C is object)
                local.Add(C);



            return local;
        }

        public UnitSystem Copy()
        {

            UnitSystem local = new UnitSystem();

            if (Symbol is object)
                local.Symbol = Symbol;

            if (L is object)
                local.L = (LengthUnit)L.Clone();

            if (M is object)
                local.M = (MassUnit)M.Clone();

            if (D is object)
                local.D = (DurationUnit)D.Clone();

            if (E is object)
                local.E = (ElectricCurrentUnit)E.Clone();

            if (T is object)
                local.T = (TemperatureUnit)T.Clone();

            if (A is object)
                local.A = (AmountOfSubstanceUnit)A.Clone();

            if (LI is object)
                local.LI = (LuminousIntensityUnit)LI.Clone();

            if (C is object)
                local.C = (CombinedUnit)C.Clone();


            return local;
        }


        public UnitSystem BaseUnitSystem()
        {

            UnitSystem local = Copy();


            //Remove combi and acutalC
            local.C = new CombinedUnit("",1,1);

            foreach (var item in local.UnitList())
            {
                item.AC = 1;
            }

            return local;
        }

        public UnitSystem Pow(int toPower)
        {

            if (toPower == 1)
                return this;

            UnitSystem local = new UnitSystem();

            if (toPower == 0)
                return local;


            if (toPower > 1)
                for (int i = 0; i < toPower; i++)
                    local *= this;


            if (toPower < 0)
                for (int i = 0; i > toPower; i--)
                    local /= this;



            return local;
        }


    }




}
