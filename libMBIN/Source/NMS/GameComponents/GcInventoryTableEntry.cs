using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65D93A0D6A50384A, NameHash = 0xBA68F4D576FCF49E)]
    public class GcInventoryTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int MinSize;
        /* 0x14 */ public int MaxSize;
        /* 0x18 */ public GcInventoryLayoutSizeType LayoutSizeType;
    }
}
