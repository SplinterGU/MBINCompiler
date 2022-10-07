using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3AEA123B35FF91D2, NameHash = 0x37F732EF5C0B44F6)]
    public class TkInOutCurve : NMSTemplate
    {
        /* 0x0 */ public float Midpoint;
        /* 0x4 */ public TkCurveType InCurve;
        /* 0x8 */ public TkCurveType OutCurve;
    }
}
