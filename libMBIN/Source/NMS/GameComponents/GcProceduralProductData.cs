using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96CA6F8639C9CC2A, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x028 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        /* 0x038 */ public int NameGeneratorLegacyRolls;
        /* 0x040 */ public GcProductData Product;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x450 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x828 */ public GcBiomeList PerBiomeDropWeights;
        /* 0x8A8 */ public NMSString0x20 DeployableProductID;
        /* 0x8C8 */ public bool RecordsStat;
    }
}
