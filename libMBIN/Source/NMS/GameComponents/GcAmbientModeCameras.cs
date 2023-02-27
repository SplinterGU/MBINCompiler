using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33FA353B288C9430, NameHash = 0xAF2F2B2DB8C8446A)]
    public class GcAmbientModeCameras : NMSTemplate
    {
        /* 0x00 */ public List<GcCameraAmbientBuildingData> BuildingCameraAnimations;
        /* 0x10 */ public List<GcCameraAmbientSpaceData> SpaceCameraAnimations;
        /* 0x20 */ public List<GcCameraAmbientSpecialData> SpecialCameraAnimations;
    }
}
