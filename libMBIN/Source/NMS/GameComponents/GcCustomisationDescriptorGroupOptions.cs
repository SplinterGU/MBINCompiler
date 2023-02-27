using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E6EE8A3313E1086, NameHash = 0x57CBFDF164E923E9)]
    public class GcCustomisationDescriptorGroupOptions : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A GroupTitle;
        /* 0x20 */ public bool FirstOptionIsEmpty;
        /* 0x28 */ public List<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions;
        /* 0x38 */ public List<NMSString0x10> PrerequisiteGroup;
    }
}
