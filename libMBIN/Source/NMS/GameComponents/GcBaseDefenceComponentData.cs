using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD80E4BC0FC4AC75E, NameHash = 0x2D868A2A5696416C)]
    public class GcBaseDefenceComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcBaseDefenceTrigger> Triggers;
        /* 0x10 */ public float LostUncertaintyThreshold;
        /* 0x14 */ public float SearchTime;
        /* 0x18 */ public bool PrioritiseThreats;
        /* 0x1C */ public float LaserRangeAnimateTime;
    }
}
