namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC660D01265903B43, NameHash = 0xACDE6E8DA19EC2E2)]
    public class GcStatsEnum : NMSTemplate
    {
        // size: 0x14
        public enum StatEnumEnum : uint {
            None,
            DEPOTS_BROKEN,
            FPODS_BROKEN,
            PLANTS_PLANTED,
            SALVAGE_LOOTED,
            TREASURE_FOUND,
            QUADS_KILLED,
            WALKERS_KILLED,
            FLORA_KILLED,
            PLANTS_GATHERED,
            BONES_FOUND,
            C_SENT_KILLS,
            STORM_CRYSTALS,
            BURIED_PROPS,
            MINIWORM_KILL,
            POOP_COLLECTED,
            GRAVBALLS,
            EGG_PODS,
            CORRUPT_PILLAR,
            DRONE_SHARDS,
        }
        /* 0x0 */ public StatEnumEnum StatEnum;
    }
}
