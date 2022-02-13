using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class InformationUnit : Enumeration
    {

        public static readonly InformationUnit SI = new("");
        public static readonly InformationUnit Byte = new("B", 8m);
        public static readonly InformationUnit Bit = new("b");



        public static readonly InformationUnit Kibibit = new(Bit, "Kib", (1024m));
        public static readonly InformationUnit Mebibit = new(Bit, "Mib", (1024m * 1024));
        public static readonly InformationUnit Gibibit = new(Bit, "Gib", (1024m * 1024 * 1024));
        public static readonly InformationUnit Tebibit = new(Bit, "Tib", (1024m * 1024 * 1024 * 1024));
        public static readonly InformationUnit Pebibit = new(Bit, "Pib", (1024m * 1024 * 1024 * 1024 * 1024));
        public static readonly InformationUnit Exbibit = new(Bit, "Eib", (1024m * 1024 * 1024 * 1024 * 1024 * 1024));


        public static readonly InformationUnit Kibibyte = new(Byte, "KiB", (1024m));
        public static readonly InformationUnit Mebibyte = new(Byte, "MiB", (1024m * 1024));
        public static readonly InformationUnit Gibibyte = new(Byte, "GiB", (1024m * 1024 * 1024));
        public static readonly InformationUnit Tebibyte = new(Byte, "TiB", (1024m * 1024 * 1024 * 1024));
        public static readonly InformationUnit Pebibyte = new(Byte, "PiB", (1024m * 1024 * 1024 * 1024 * 1024));
        public static readonly InformationUnit Exbibyte = new(Byte, "EiB", (1024m * 1024 * 1024 * 1024 * 1024 * 1024));


        public static readonly InformationUnit Kilobyte = new(PreFix.kilo, Byte);
        public static readonly InformationUnit Megabyte = new(PreFix.mega, Byte);
        public static readonly InformationUnit Gigabyte = new(PreFix.giga, Byte);
        public static readonly InformationUnit Terabyte = new(PreFix.tera, Byte);
        public static readonly InformationUnit Petabyte = new(PreFix.peta, Byte);
        public static readonly InformationUnit Exabyte = new(PreFix.exa, Byte);



        public static readonly InformationUnit Kilobit = new(PreFix.kilo, Bit);
        public static readonly InformationUnit Megabit = new(PreFix.mega, Bit);
        public static readonly InformationUnit Gigabit = new(PreFix.giga, Bit);
        public static readonly InformationUnit Terabit = new(PreFix.tera, Bit);
        public static readonly InformationUnit Petabit = new(PreFix.peta, Bit);
        public static readonly InformationUnit Exabit = new(PreFix.exa, Bit);






        public InformationUnit(string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = new UnitSystem(correction, NewSymbol);
        }

        public InformationUnit(PreFix SI, InformationUnit unit) : base(SI, unit) {}

        public InformationUnit(InformationUnit unit, string NewSymbol = "Empty", decimal correction = 1) : base(unit, NewSymbol, correction) {}

    }




}