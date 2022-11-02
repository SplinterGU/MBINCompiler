using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA859ACFDC9E7A77D, NameHash = 0x701157823082E732)]
    public class GcWeightedResource : NMSTemplate
    {
        /* 0x0 */ public float RelativeProbability;
        /* 0x4 */ public TkModelResource Geometry;
    }
}
