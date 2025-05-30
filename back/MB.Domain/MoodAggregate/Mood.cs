namespace MB.Domain.MoodAggregate;

public class Mood : AuditableEntity
{
    public int Type { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Score { get; set; } = 0;
    public int Position { get; private set; } = 0;
    public bool IsApproved { get; private set; }
    public string Extension { get; set; } = string.Empty;

    public ICollection<RelationMoodArtist>? MoodArtists { get; set; }
    public ICollection<RelationMoodModel>? MoodModels { get; set; }
    public ICollection<RelationMoodFranchise>? MoodFranchises { get; set; }
    public ICollection<RelationMoodTag>? MoodTags { get; set; }

    public void Approve()
    {
        if (IsApproved)
            return;

        IsApproved = true;
    }

    public void UpdatePosition(int position)
    {
        Position += position;
    }
}