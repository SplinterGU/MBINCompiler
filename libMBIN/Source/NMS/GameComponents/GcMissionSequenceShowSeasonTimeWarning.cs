namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90B47FC5D232EA60, NameHash = 0x232C5143BAE4E2F9)]
    public class GcMissionSequenceShowSeasonTimeWarning : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public float TimeToShow;
        /* 0x84 */ public NMSString0x80 DebugText;
    }
}
