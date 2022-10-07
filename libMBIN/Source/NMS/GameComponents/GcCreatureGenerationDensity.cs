namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC51196B224527DC7, NameHash = 0x2CD4E62B393F6930)]
    public class GcCreatureGenerationDensity : NMSTemplate
    {
        // size: 0x4
        public enum DensityEnum {
            Sparse,
            Normal,
            Dense,
            VeryDense
        }
        /* 0x0 */ public DensityEnum Density;
    }
}
