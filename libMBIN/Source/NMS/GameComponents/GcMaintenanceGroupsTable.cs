using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x347E8C07887F9E14, NameHash = 0x4819F209285AD45B)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcMaintenanceElementGroups.MaintenanceGroupEnum))]
        /* 0x0 */ public GcMaintenanceGroup[] Groups;
    }
}
