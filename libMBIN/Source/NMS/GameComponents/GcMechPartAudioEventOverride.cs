using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DA6FFB0566CCFF6, NameHash = 0x8713A8C7BE9925C6)]
    public class GcMechPartAudioEventOverride : NMSTemplate
    {
        /* 0x0 */ public GcMechMeshPart MeshPart;
        /* 0x4 */ public GcMechMeshType MeshType;
        /* 0x8 */ public GcAudioWwiseEvents OverrideEvent;
    }
}
