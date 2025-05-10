namespace MB.Domain.LevelAggregate;

public class LevelDefinition : AuditableEntity
{
    public int LevelNumber { get; private set; }
    public int MinExperience { get; private set; }
    public int? MaxExperience { get; private set; }

    private LevelDefinition() { }
    public LevelDefinition(int levelNumber, int minExp, int? maxExp = null)
    {
        LevelNumber = levelNumber;
        MinExperience = minExp;
        MaxExperience = maxExp;
    }
}