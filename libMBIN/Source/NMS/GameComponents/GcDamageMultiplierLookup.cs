using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x31B87E042D974AFE, NameHash = 0x792FD0F5EBBA55E9)]
    public class GcDamageMultiplierLookup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float Default;
        /* 0x18 */ public List<GcDamageMultiplier> Multipliers;
    }
}