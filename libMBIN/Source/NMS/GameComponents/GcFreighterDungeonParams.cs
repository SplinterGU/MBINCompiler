using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x181429458781FD95, NameHash = 0x1186D86C82D48E4E)]
    public class GcFreighterDungeonParams : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public GcDungeonGenerationParams DungeonParams;
    }
}
