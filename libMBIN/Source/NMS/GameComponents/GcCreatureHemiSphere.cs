namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA787ADE434116CC9, NameHash = 0x1BE056BC4F556CAA)]
    public class GcCreatureHemiSphere : NMSTemplate
    {
        // size: 0x3
        public enum CreatureHemiSphereEnum {
            Any,
            Northern,
            Southern
        }
        /* 0x0 */ public CreatureHemiSphereEnum CreatureHemiSphere;
    }
}
