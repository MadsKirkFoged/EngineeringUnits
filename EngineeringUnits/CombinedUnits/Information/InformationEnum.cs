using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class InformationUnit : Enumeration
    {

        public static readonly InformationUnit SI = new InformationUnit("");
        public static readonly InformationUnit Byte = new InformationUnit("B", 8m);
        public static readonly InformationUnit Bit = new InformationUnit("b");



        public static readonly InformationUnit Kibibit = new InformationUnit(Bit, "Kib", (1024m));
        public static readonly InformationUnit Mebibit = new InformationUnit(Bit, "Mib", (1024m * 1024));
        public static readonly InformationUnit Gibibit = new InformationUnit(Bit, "Gib", (1024m * 1024 * 1024));
        public static readonly InformationUnit Tebibit = new InformationUnit(Bit, "Tib", (1024m * 1024 * 1024 * 1024));
        public static readonly InformationUnit Pebibit = new InformationUnit(Bit, "Pib", (1024m * 1024 * 1024 * 1024 * 1024));
        public static readonly InformationUnit Exbibit = new InformationUnit(Bit, "Eib", (1024m * 1024 * 1024 * 1024 * 1024 * 1024));


        public static readonly InformationUnit Kibibyte = new InformationUnit(Byte, "KiB", (1024m));
        public static readonly InformationUnit Mebibyte = new InformationUnit(Byte, "MiB", (1024m * 1024));
        public static readonly InformationUnit Gibibyte = new InformationUnit(Byte, "GiB", (1024m * 1024 * 1024));
        public static readonly InformationUnit Tebibyte = new InformationUnit(Byte, "TiB", (1024m * 1024 * 1024 * 1024));
        public static readonly InformationUnit Pebibyte = new InformationUnit(Byte, "PiB", (1024m * 1024 * 1024 * 1024 * 1024));
        public static readonly InformationUnit Exbibyte = new InformationUnit(Byte, "EiB", (1024m * 1024 * 1024 * 1024 * 1024 * 1024));


        public static readonly InformationUnit Kilobyte = new InformationUnit(PreFix.kilo, Byte);
        public static readonly InformationUnit Megabyte = new InformationUnit(PreFix.mega, Byte);
        public static readonly InformationUnit Gigabyte = new InformationUnit(PreFix.giga, Byte);
        public static readonly InformationUnit Terabyte = new InformationUnit(PreFix.tera, Byte);
        public static readonly InformationUnit Petabyte = new InformationUnit(PreFix.peta, Byte);
        public static readonly InformationUnit Exabyte = new InformationUnit(PreFix.exa, Byte);



        public static readonly InformationUnit Kilobit = new InformationUnit(PreFix.kilo, Bit);
        public static readonly InformationUnit Megabit = new InformationUnit(PreFix.mega, Bit);
        public static readonly InformationUnit Gigabit = new InformationUnit(PreFix.giga, Bit);
        public static readonly InformationUnit Terabit = new InformationUnit(PreFix.tera, Bit);
        public static readonly InformationUnit Petabit = new InformationUnit(PreFix.peta, Bit);
        public static readonly InformationUnit Exabit = new InformationUnit(PreFix.exa, Bit);






        public InformationUnit(string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = new UnitSystem();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public InformationUnit(PreFix SI, InformationUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public InformationUnit(InformationUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}