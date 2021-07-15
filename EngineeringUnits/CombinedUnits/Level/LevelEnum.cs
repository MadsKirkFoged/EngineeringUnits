using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class LevelUnit : Enumeration
    {

        public static readonly LevelUnit SI = new LevelUnit();
        public static readonly LevelUnit Decibel = new LevelUnit("dB");
        public static readonly LevelUnit Neper = new LevelUnit("Np", 1/0.115129254m);



        public LevelUnit(string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = new UnitSystem();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

       

    }




}