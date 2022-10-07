namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B4FA8D64E615DCE, NameHash = 0xE1F35851383555E2)]
    public class GcSentinelCoverComponentData : NMSTemplate
    {
        /* 0x00 */ public float HealthPercLostPerSecMin;
        /* 0x04 */ public float HealthPercLostPerSecMax;
        /* 0x08 */ public NMSString0x10 SpawnEffectId;
        /* 0x18 */ public NMSString0x10 DestroyEffectId;
        /* 0x28 */ public NMSString0x20 EffectLocator;
        // size: 0x4
        public enum CoverStateAnimsEnum {
            Deploying,
            Deployed,
            ShuttingDown,
            ShutDown
        }
        [NMS(Size = 0x4, EnumType = typeof(CoverStateAnimsEnum))]
        /* 0x48 */ public NMSString0x10[] CoverStateAnims;
    }
}
