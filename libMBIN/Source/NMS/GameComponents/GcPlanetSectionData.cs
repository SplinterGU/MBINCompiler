namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF9B2EE21C846E8CC, NameHash = 0x408CCAADC93DEEFE)]
    public class GcPlanetSectionData : NMSTemplate
    {
        /* 0x0 */ public ulong DiscovererUID;
        [NMS(Size = 0x2)]
        /* 0x8 */ public byte[] DiscovererPlatform;
        /* 0xA */ public bool DiscoveredState;
    }
}
