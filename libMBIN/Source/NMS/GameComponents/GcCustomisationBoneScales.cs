using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69DC41E07A33259, NameHash = 0x79EA3335C4095B8E)]
    public class GcCustomisationBoneScales : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GroupTitle;
        /* 0x20 */ public NMSString0x10 ScaleBoneName;
        /* 0x30 */ public List<float> Positions;
    }
}
