using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB807E0A43E0D5F25, NameHash = 0xE2FBC00AA319096D)]
    public class GcMissionSequenceSetGlobalMission : NMSTemplate
    {
        /* 0x0 */ public GcRewardChangeGlobalMission Type;
        /* 0x4 */ public NMSString0x80 DebugText;
    }
}
