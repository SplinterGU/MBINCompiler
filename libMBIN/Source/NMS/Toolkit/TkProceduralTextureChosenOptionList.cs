using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA8840D6378C5B612, NameHash = 0x2E2EA6E03BFB1DF8)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        /* 0x0 */ public List<TkProceduralTextureChosenOptionSampler> Samplers;
    }
}
