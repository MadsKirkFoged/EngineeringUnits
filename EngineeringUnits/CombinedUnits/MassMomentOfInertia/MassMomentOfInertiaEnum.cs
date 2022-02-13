using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MassMomentOfInertiaUnit : Enumeration
    {

        public static readonly MassMomentOfInertiaUnit SI = new(MassUnit.SI, AreaUnit.SI);
        public static readonly MassMomentOfInertiaUnit KilogramSquareMeter = new(MassUnit.Kilogram, AreaUnit.SquareMeter);


        public static readonly MassMomentOfInertiaUnit GramSquareCentimeter = new(MassUnit.Gram, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit GramSquareDecimeter = new(MassUnit.Gram, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit GramSquareMeter = new(MassUnit.Gram, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit GramSquareMillimeter = new(MassUnit.Gram, AreaUnit.SquareMillimeter);
        public static readonly MassMomentOfInertiaUnit KilogramSquareCentimeter = new(MassUnit.Kilogram, AreaUnit.SquareCentimeter);

        public static readonly MassMomentOfInertiaUnit KilogramSquareDecimeter = new(MassUnit.Kilogram, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit KilogramSquareMillimeter = new(MassUnit.Kilogram, AreaUnit.SquareMillimeter);


        public static readonly MassMomentOfInertiaUnit KilotonneSquareCentimeter = new(MassUnit.Kilotonne, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit KilotonneSquareDecimeter = new(MassUnit.Kilotonne, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit KilotonneSquareMeter = new(MassUnit.Kilotonne, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit KilotonneSquareMilimeter = new(MassUnit.Kilotonne, AreaUnit.SquareMillimeter);
        public static readonly MassMomentOfInertiaUnit MegatonneSquareCentimeter = new(MassUnit.Megatonne, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit MegatonneSquareDecimeter = new(MassUnit.Megatonne, AreaUnit.SquareDecimeter);

        public static readonly MassMomentOfInertiaUnit MegatonneSquareMeter = new(MassUnit.Megatonne, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit MegatonneSquareMilimeter = new(MassUnit.Megatonne, AreaUnit.SquareMillimeter);
        public static readonly MassMomentOfInertiaUnit MilligramSquareCentimeter = new(MassUnit.Milligram, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit MilligramSquareDecimeter = new(MassUnit.Milligram, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit MilligramSquareMeter = new(MassUnit.Milligram, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit MilligramSquareMillimeter = new(MassUnit.Milligram, AreaUnit.SquareMillimeter);
        public static readonly MassMomentOfInertiaUnit PoundSquareFoot = new(MassUnit.Pound, AreaUnit.SquareFoot);
        public static readonly MassMomentOfInertiaUnit PoundSquareInch = new(MassUnit.Pound, AreaUnit.SquareInch);

        public static readonly MassMomentOfInertiaUnit SlugSquareFoot = new(MassUnit.Slug, AreaUnit.SquareFoot);
        public static readonly MassMomentOfInertiaUnit SlugSquareInch = new(MassUnit.Slug, AreaUnit.SquareInch);

        public static readonly MassMomentOfInertiaUnit TonneSquareCentimeter = new(MassUnit.Tonne, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit TonneSquareDecimeter = new(MassUnit.Tonne, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit TonneSquareMeter = new(MassUnit.Tonne, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit TonneSquareMilimeter = new(MassUnit.Tonne, AreaUnit.SquareMillimeter);

       


        public MassMomentOfInertiaUnit(MassUnit mass, AreaUnit area, string NewSymbol = "Empty")
        {
            Unit = mass * area;
            SetNewSymbol(NewSymbol);
        }
     

    }




}