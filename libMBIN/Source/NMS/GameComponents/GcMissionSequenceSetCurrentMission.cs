namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA39B8B61E2532C5, NameHash = 0x48508806BFEC4731)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public bool Silent;
        /* 0x11 */ public NMSString0x80 DebugText;
    }
}
