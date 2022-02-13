using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class LevelUnit : Enumeration
    {

        public static readonly LevelUnit SI = new();
        public static readonly LevelUnit Decibel = new("dB");
        public static readonly LevelUnit Neper = new("Np", 1/0.115129254m);



        public LevelUnit(string NewSymbol = null, decimal correction = 1)
        {
            Unit = new UnitSystem(correction, NewSymbol);
        }

       

    }




}