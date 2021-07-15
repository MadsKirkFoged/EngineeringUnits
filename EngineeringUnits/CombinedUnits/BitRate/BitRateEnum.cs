using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class BitRateUnit : Enumeration
    {

        public static readonly BitRateUnit SI = new BitRateUnit("");
        public static readonly BitRateUnit BytePerSecond = new BitRateUnit("B/s", 8m);
        public static readonly BitRateUnit BitPerSecond = new BitRateUnit("bit/s");



        public static readonly BitRateUnit KibibitPerSecond = new BitRateUnit(BitPerSecond, "Kibit/s", (1024m));
        public static readonly BitRateUnit MebibitPerSecond = new BitRateUnit(BitPerSecond, "Mibit/s", (1024m * 1024));
        public static readonly BitRateUnit GibibitPerSecond = new BitRateUnit(BitPerSecond, "Gibit/s", (1024m * 1024 * 1024));
        public static readonly BitRateUnit TebibitPerSecond = new BitRateUnit(BitPerSecond, "Tibit/s", (1024m * 1024 * 1024 * 1024));
        public static readonly BitRateUnit PebibitPerSecond = new BitRateUnit(BitPerSecond, "Pibit/s", (1024m * 1024 * 1024 * 1024 * 1024));
        public static readonly BitRateUnit ExbibitPerSecond = new BitRateUnit(BitPerSecond, "Eibit/s", (1024m * 1024 * 1024 * 1024 * 1024 * 1024));


        public static readonly BitRateUnit KibibytePerSecond = new BitRateUnit(BytePerSecond, "KiB/s", (1024m));
        public static readonly BitRateUnit MebibytePerSecond = new BitRateUnit(BytePerSecond, "MiB/s", (1024m * 1024));
        public static readonly BitRateUnit GibibytePerSecond = new BitRateUnit(BytePerSecond, "GiB/s", (1024m * 1024 * 1024));
        public static readonly BitRateUnit TebibytePerSecond = new BitRateUnit(BytePerSecond, "TiB/s", (1024m * 1024 * 1024 * 1024));
        public static readonly BitRateUnit PebibytePerSecond = new BitRateUnit(BytePerSecond, "PiB/s", (1024m * 1024 * 1024 * 1024 * 1024));
        public static readonly BitRateUnit ExbibytePerSecond = new BitRateUnit(BytePerSecond, "EiB/s", (1024m * 1024 * 1024 * 1024 * 1024 * 1024));


        public static readonly BitRateUnit KilobytePerSecond = new BitRateUnit(PreFix.kilo, BytePerSecond);
        public static readonly BitRateUnit MegabytePerSecond = new BitRateUnit(PreFix.mega, BytePerSecond);
        public static readonly BitRateUnit GigabytePerSecond = new BitRateUnit(PreFix.giga, BytePerSecond);
        public static readonly BitRateUnit TerabytePerSecond = new BitRateUnit(PreFix.tera, BytePerSecond);
        public static readonly BitRateUnit PetabytePerSecond = new BitRateUnit(PreFix.peta, BytePerSecond);
        public static readonly BitRateUnit ExabytePerSecond = new BitRateUnit(PreFix.exa, BytePerSecond);



        public static readonly BitRateUnit KilobitPerSecond = new BitRateUnit(PreFix.kilo, BitPerSecond);
        public static readonly BitRateUnit MegabitPerSecond = new BitRateUnit(PreFix.mega, BitPerSecond);
        public static readonly BitRateUnit GigabitPerSecond = new BitRateUnit(PreFix.giga, BitPerSecond);
        public static readonly BitRateUnit TerabitPerSecond = new BitRateUnit(PreFix.tera, BitPerSecond);
        public static readonly BitRateUnit PetabitPerSecond = new BitRateUnit(PreFix.peta, BitPerSecond);
        public static readonly BitRateUnit ExabitPerSecond = new BitRateUnit(PreFix.exa, BitPerSecond);





        public BitRateUnit(string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = new UnitSystem();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public BitRateUnit(PreFix SI, BitRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public BitRateUnit(BitRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}