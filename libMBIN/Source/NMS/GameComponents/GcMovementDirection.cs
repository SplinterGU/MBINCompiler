namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60EFB41575ED04BC, NameHash = 0x59A54DA2535D6C79)]
    public class GcMovementDirection : NMSTemplate
    {
        // size: 0x4
        public enum MovementDirectionEnum {
            WorldRelative,
            BodyRelative,
            HeadRelative,
            NotSet
        }
        /* 0x0 */ public MovementDirectionEnum MovementDirection;
    }
}
