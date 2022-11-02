using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64B20B6557979BB6, NameHash = 0xFF1B80B6AD49D2A3)]
    public class GcAntagonistEnemy : NMSTemplate
    {
        /* 0x0 */ public float HatredFactor;
        /* 0x4 */ public float GrudgeFactor;
        /* 0x8 */ public List<NMSString0x10> Perceptions;
    }
}
