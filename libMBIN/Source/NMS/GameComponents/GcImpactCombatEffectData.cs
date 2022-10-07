using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39E03F7CE8F8A08, NameHash = 0x3213D59A0301372C)]
    public class GcImpactCombatEffectData : NMSTemplate
    {
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        /* 0x4 */ public float TotalDuration;
        /* 0x8 */ public float DamagePerSeccond;
        /* 0xC */ public float CurrentDuration;
    }
}
