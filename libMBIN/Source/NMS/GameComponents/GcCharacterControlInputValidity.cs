namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9755EFA88663FD0B, NameHash = 0x1A9351C5A8C07BA4)]
    public class GcCharacterControlInputValidity : NMSTemplate
    {
        // size: 0x3
        public enum CharacterControlInputValidityEnum {
            Always,
            PadOnly,
            KeyboardAnMouseOnly
        }
        /* 0x0 */ public CharacterControlInputValidityEnum CharacterControlInputValidity;
    }
}
