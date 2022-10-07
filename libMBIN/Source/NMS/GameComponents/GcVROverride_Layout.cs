namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66CAE7AA203660F7, NameHash = 0xE16B8EC5F09E6041)]
    public class GcVROverride_Layout : NMSTemplate
    {
        // size: 0x5
        public enum VROverride_LayoutEnum {
            PosX,
            PosY,
            LayerWidth,
            LayerHeight,
            MaxWidth
        }
        /* 0x0 */ public VROverride_LayoutEnum VROverride_Layout;
        /* 0x4 */ public float FloatValue;
    }
}
