using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DB91F8949B2B33E, NameHash = 0x6CE18BA2B414C4ED)]
    public class GcRewardSetInteractionMissionState : NMSTemplate
    {
        /* 0x0 */ public GcInteractionMissionState MissionState;
        /* 0x4 */ public bool SetForThisInteraction;
        /* 0x8 */ public GcInteractionType SetForInteractionClassInMyBuilding;
    }
}