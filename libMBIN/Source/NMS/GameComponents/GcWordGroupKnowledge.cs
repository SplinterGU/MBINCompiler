using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x981184D008478281, NameHash = 0xB64408EDDD99E644)]
    public class GcWordGroupKnowledge : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Group;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x20 */ public bool[] Races;
    }
}
