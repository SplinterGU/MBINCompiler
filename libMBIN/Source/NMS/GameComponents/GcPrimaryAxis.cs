namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1003ACDA0DB7C653, NameHash = 0x839577D6883299CA)]
    public class GcPrimaryAxis : NMSTemplate
    {
        // size: 0x6
        public enum PrimaryAxisEnum {
            Z,
            ZNeg,
            X,
            XNeg,
            Y,
            YNeg
        }
        /* 0x0 */ public PrimaryAxisEnum PrimaryAxis;
    }
}
