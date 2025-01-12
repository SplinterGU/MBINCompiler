namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B2FA4F6D327DF4, NameHash = 0x428DC2A675E89B6D)]
    public class GcAlienPuzzleCategory : NMSTemplate
    {
        // size: 0x3B
        public enum AlienPuzzleCategoryEnum : uint {
            Default,
            GuildTraderNone,
            GuildTraderLow,
            GuildTraderMed,
            GuildTraderHigh,
            GuildTraderBest,
            GuildWarriorNone,
            GuildWarriorLow,
            GuildWarriorMed,
            GuildWarriorHigh,
            GuildWarriorBest,
            GuildExplorerNone,
            GuildExplorerLow,
            GuildExplorerMed,
            GuildExplorerHigh,
            GuildExplorerBest,
            BiomeHot,
            BiomeCold,
            BiomeLush,
            BiomeDusty,
            BiomeTox,
            BiomeRad,
            BiomeWeird,
            LocationSpaceStation,
            LocationShop,
            LocationOutpost,
            LocationObservatory,
            Walking,
            ExtremeWeather,
            ExtremeSentinels,
            WaterPlanet,
            FreighterCrew,
            FreighterCrewOwned,
            ShipShop,
            SuitShop,
            WeapShop,
            VehicleShop,
            MoodVeryPositive,
            MoodPositive,
            MoodNeutral,
            MoodNegative,
            MoodVeryNegative,
            Proc,
            FirstAbandonedFreighter,
            StandardAbandonedFreighter,
            BiomeSwamp,
            BiomeLava,
            AbandonedSystem,
            InhabitedSystem,
            SettlementOwned,
            SettlementNotOwned,
            PirateStation,
            StandardPilot,
            Unlocked,
            AllUnlocked,
            NotUnlocked,
            SpiderA,
            SpiderB,
            SpiderRenewed,
        }
        /* 0x0 */ public AlienPuzzleCategoryEnum AlienPuzzleCategory;
    }
}
