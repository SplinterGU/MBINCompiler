namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2EA92F3027D31030, NameHash = 0x8A4027FC041677F0)]
    public class GcScannerIconTypes : NMSTemplate
    {
        // size: 0x40
        public enum ScanIconTypeEnum : uint {
            None,
            Health,
            Shield,
            Hazard,
            LifeSupport,
            Tech,
            BluePlant,
            CaveSubstance,
            LaunchCrystals,
            Power,
            Carbon,
            CarbonPlus,
            Oxygen,
            Mineral,
            Sodium,
            SodiumPlus,
            Crate,
            Artifact,
            Plant,
            HazardPlant,
            ArtifactCrate,
            BuriedTech,
            BuriedRare,
            Drone,
            CustomMarker,
            SignalBooster,
            Refiner,
            Grave,
            Rare1,
            Rare2,
            Rare3,
            Pearl,
            RareEgg,
            HazardEgg,
            FishFiend,
            Clam,
            CaveStone,
            StormCrystal,
            BiomeTrophy,
            PowerHotspot,
            MineralHotspot,
            GasHotspot,
            HarvestPlant,
            Cooker,
            CreaturePoop,
            FreighterTeleporter,
            FreighterDoor,
            FreighterTerminal,
            FreighterHeater,
            FreighterDataPad,
            LandedPilot,
            PetEgg,
            Sandworm,
            FriendlyDrone,
            CorruptedCrystal,
            CorruptedMachine,
            RobotHead,
            HiddenCrystal,
            SpaceDestrutibleSmall,
            SpaceDestrutibleLarge,
            ShieldGenerator,
            FreighterEngine,
            FreighterWeakPoint,
            FreighterTrenchEntrance,
        }
        /* 0x0 */ public ScanIconTypeEnum ScanIconType;
    }
}
