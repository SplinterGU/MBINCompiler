using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8437C9918C475F50, NameHash = 0x4B1DBAB6A4BE391D)]
    public class GcMissionSequenceAudioEvent : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x4 */ public NMSString0x80 DebugText;
    }
}
