using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MassMomentOfInertiaUnit : Enumeration
    {

        public static readonly MassMomentOfInertiaUnit SI = new MassMomentOfInertiaUnit(MassUnit.Kilogram, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit KilogramSquareMeter = new MassMomentOfInertiaUnit(MassUnit.Kilogram, AreaUnit.SquareMeter);


        public static readonly MassMomentOfInertiaUnit GramSquareCentimeter = new MassMomentOfInertiaUnit(MassUnit.Gram, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit GramSquareDecimeter = new MassMomentOfInertiaUnit(MassUnit.Gram, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit GramSquareMeter = new MassMomentOfInertiaUnit(MassUnit.Gram, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit GramSquareMillimeter = new MassMomentOfInertiaUnit(MassUnit.Gram, AreaUnit.SquareMillimeter);
        public static readonly MassMomentOfInertiaUnit KilogramSquareCentimeter = new MassMomentOfInertiaUnit(MassUnit.Kilogram, AreaUnit.SquareCentimeter);

        public static readonly MassMomentOfInertiaUnit KilogramSquareDecimeter = new MassMomentOfInertiaUnit(MassUnit.Kilogram, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit KilogramSquareMillimeter = new MassMomentOfInertiaUnit(MassUnit.Kilogram, AreaUnit.SquareMillimeter);


        public static readonly MassMomentOfInertiaUnit KilotonneSquareCentimeter = new MassMomentOfInertiaUnit(MassUnit.Kilotonne, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit KilotonneSquareDecimeter = new MassMomentOfInertiaUnit(MassUnit.Kilotonne, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit KilotonneSquareMeter = new MassMomentOfInertiaUnit(MassUnit.Kilotonne, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit KilotonneSquareMilimeter = new MassMomentOfInertiaUnit(MassUnit.Kilotonne, AreaUnit.SquareMillimeter);
        public static readonly MassMomentOfInertiaUnit MegatonneSquareCentimeter = new MassMomentOfInertiaUnit(MassUnit.Megatonne, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit MegatonneSquareDecimeter = new MassMomentOfInertiaUnit(MassUnit.Megatonne, AreaUnit.SquareDecimeter);

        public static readonly MassMomentOfInertiaUnit MegatonneSquareMeter = new MassMomentOfInertiaUnit(MassUnit.Megatonne, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit MegatonneSquareMilimeter = new MassMomentOfInertiaUnit(MassUnit.Megatonne, AreaUnit.SquareMillimeter);
        public static readonly MassMomentOfInertiaUnit MilligramSquareCentimeter = new MassMomentOfInertiaUnit(MassUnit.Milligram, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit MilligramSquareDecimeter = new MassMomentOfInertiaUnit(MassUnit.Milligram, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit MilligramSquareMeter = new MassMomentOfInertiaUnit(MassUnit.Milligram, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit MilligramSquareMillimeter = new MassMomentOfInertiaUnit(MassUnit.Milligram, AreaUnit.SquareMillimeter);
        public static readonly MassMomentOfInertiaUnit PoundSquareFoot = new MassMomentOfInertiaUnit(MassUnit.Pound, AreaUnit.SquareFoot);
        public static readonly MassMomentOfInertiaUnit PoundSquareInch = new MassMomentOfInertiaUnit(MassUnit.Pound, AreaUnit.SquareInch);

        public static readonly MassMomentOfInertiaUnit SlugSquareFoot = new MassMomentOfInertiaUnit(MassUnit.Slug, AreaUnit.SquareFoot);
        public static readonly MassMomentOfInertiaUnit SlugSquareInch = new MassMomentOfInertiaUnit(MassUnit.Slug, AreaUnit.SquareInch);

        public static readonly MassMomentOfInertiaUnit TonneSquareCentimeter = new MassMomentOfInertiaUnit(MassUnit.Tonne, AreaUnit.SquareCentimeter);
        public static readonly MassMomentOfInertiaUnit TonneSquareDecimeter = new MassMomentOfInertiaUnit(MassUnit.Tonne, AreaUnit.SquareDecimeter);
        public static readonly MassMomentOfInertiaUnit TonneSquareMeter = new MassMomentOfInertiaUnit(MassUnit.Tonne, AreaUnit.SquareMeter);
        public static readonly MassMomentOfInertiaUnit TonneSquareMilimeter = new MassMomentOfInertiaUnit(MassUnit.Tonne, AreaUnit.SquareMillimeter);

       


        public MassMomentOfInertiaUnit(MassUnit mass, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass.Unit * area.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }
     

    }




}