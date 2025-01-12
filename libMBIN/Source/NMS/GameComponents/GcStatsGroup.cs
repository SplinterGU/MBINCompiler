using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA9FAA5058379C78, NameHash = 0xEB5E59FB895AFF06)]
    public class GcStatsGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkTextureResource Icon;
        /* 0x98 */ public List<GcStatsEntry> StatIds;
    }
}
