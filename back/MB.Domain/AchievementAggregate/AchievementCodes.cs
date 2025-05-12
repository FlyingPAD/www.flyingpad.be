namespace MB.Domain.AchievementAggregate;

public static class AchievementCodes
{
    // — Standard achievements —
    public const string OfficialMember = "OfficialMember";
    public const string EmailVerified = "EmailVerified";
    public const string ProfileCompleted = "ProfileCompleted";

    // — Note-master achievements —
    public const string NoviceBass = "NoviceBass";
    public const string IntermediateBass = "IntermediateBass";
    public const string AdvancedBass = "AdvancedBass";
    public const string ExpertBass = "ExpertBass";
    public const string MasterBass = "MasterBass";

    public const string NoviceAlto = "NoviceAlto";
    public const string IntermediateAlto = "IntermediateAlto";
    public const string AdvancedAlto = "AdvancedAlto";
    public const string ExpertAlto = "ExpertAlto";
    public const string MasterAlto = "MasterAlto";

    public const string NoviceTreble = "NoviceTreble";
    public const string IntermediateTreble = "IntermediateTreble";
    public const string AdvancedTreble = "AdvancedTreble";
    public const string ExpertTreble = "ExpertTreble";
    public const string MasterTreble = "MasterTreble";

    // — Level achievements (constantes) —
    public const string Level2Achieved = "Level2Achieved";
    public const string Level3Achieved = "Level3Achieved";
    public const string Level4Achieved = "Level4Achieved";
    public const string Level5Achieved = "Level5Achieved";
    public const string Level6Achieved = "Level6Achieved";
    public const string Level7Achieved = "Level7Achieved";
    public const string Level8Achieved = "Level8Achieved";
    public const string Level9Achieved = "Level9Achieved";
    public const string Level10Achieved = "Level10Achieved";
    public const string Level11Achieved = "Level11Achieved";
    public const string Level12Achieved = "Level12Achieved";
    public const string Level13Achieved = "Level13Achieved";
    public const string Level14Achieved = "Level14Achieved";
    public const string Level15Achieved = "Level15Achieved";

    // … ou, pour générer dynamiquement le code :
    public static string LevelReached(int level) => $"Level{level}Achieved";

    // — League achievements —
    public const string WoodLeague = "WoodLeague";
    public const string StoneLeague = "StoneLeague";
    public const string BronzeLeague = "BronzeLeague";
    public const string SilverLeague = "SilverLeague";
    public const string CrystalLeague = "CrystalLeague";
    public const string EliteLeague = "EliteLeague";
    public const string ChampionLeague = "ChampionLeague";
    public const string LegendLeague = "LegendLeague";
}