using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DC6800722F998DB, NameHash = 0x891585A60DC0D014)]
    public class GcInventoryCostData : NMSTemplate
    {
        // size: 0x9
        public enum InventoryCostDataEnum {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail
        }
        [NMS(Size = 0x9, EnumType = typeof(InventoryCostDataEnum))]
        /* 0x0 */ public GcInventoryCostDataEntry[] InventoryCostData;
    }
}
