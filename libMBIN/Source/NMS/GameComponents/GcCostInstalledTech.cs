namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3686C90657DD079F, NameHash = 0xF6CA47F9F51F553F)]
    public class GcCostInstalledTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0x6
        public enum InventoryToCheckEnum : uint {
            All,
            Suit,
            Ship,
            Weapon,
            Freighter,
            Buggy,
        }
        /* 0x10 */ public InventoryToCheckEnum InventoryToCheck;
    }
}
