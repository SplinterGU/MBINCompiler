namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA1A08C2974D9E1, NameHash = 0xEDA5BCF252E3B6EF)]
    public class GcRewardSignalScan : NMSTemplate
    {
        // size: 0x8
        public enum SignalScanTypeEnum {
            None,
            DropPod,
            Shelter,
            Search,
            Relic,
            Industrial,
            Alien,
            CrashedFreighter
        }
        /* 0x0 */ public SignalScanTypeEnum SignalScanType;
    }
}
