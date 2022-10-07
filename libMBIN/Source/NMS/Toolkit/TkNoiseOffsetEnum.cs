namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x63660285B883E92D, NameHash = 0xFCAC758E3056BFEF)]
    public class TkNoiseOffsetEnum : NMSTemplate
    {
        // size: 0x4
        public enum OffsetTypeEnum {
            Zero,
            Base,
            All,
            SeaLevel
        }
        /* 0x0 */ public OffsetTypeEnum OffsetType;
    }
}
