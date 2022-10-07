namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x953D6F5550ED77E2, NameHash = 0xA2280C1D273E7644)]
    public class GcDiscoveryRewardLookup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 Secondary;
        // size: 0x10
        public enum BiomeSpecificEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(BiomeSpecificEnum))]
        /* 0x20 */ public NMSString0x10[] BiomeSpecific;
    }
}
